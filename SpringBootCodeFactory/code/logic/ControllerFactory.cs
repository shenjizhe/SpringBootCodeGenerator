using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;
using SpringBootCodeFactory.code.common;

namespace SpringBootCodeFactory.code.logic
{
    public class ControllerFactory : IFactory<Entity>
    {
        public string Create(Entity entity)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("package com.ninehcom." + ProjectConfig.Service.Name + ".controller;\n\n");
            builder.Append("import java.util.List;\n");
            builder.Append("import org.springframework.beans.factory.annotation.Autowired;\n");
            builder.Append("import org.springframework.web.bind.annotation.RequestMapping;\n");
            builder.Append("import org.springframework.web.bind.annotation.RequestMethod;\n");
            builder.Append("import org.springframework.web.bind.annotation.RestController;\n");
            builder.Append("import org.springframework.web.bind.annotation.PathVariable;\n");
            builder.Append("import org.springframework.web.bind.annotation.ResponseBody;\n");
            builder.Append("import org.springframework.web.bind.annotation.RequestBody;\n");
            builder.Append("import com.wordnik.swagger.annotations.Api;\n");
            builder.Append("import com.wordnik.swagger.annotations.ApiOperation;\n");
            builder.Append("import com.wordnik.swagger.annotations.ApiParam;\n");

            builder.Append("import com.ninehcom." + ProjectConfig.Service.Name + ".entity." + fs.f1(entity.Name) + ";\n");
            builder.Append("import com.ninehcom." + ProjectConfig.Service.Name + ".service." + fs.f1(entity.Name) + "Service;\n");
            builder.Append("import com.ninehcom.common.util.Result;\n");
            builder.Append("//import com.ninehcom." + ProjectConfig.Service.Name + ".jpa.repository." + fs.f1(entity.Name) + "Repository;\n\n");

            builder.Append("/**\n");
            builder.Append(" * " + fs.f1(entity.Comment) + "的控制器\n");
            builder.Append(" * @author shenjizhe\n");
            builder.Append(" * @version 1.0.0\n");
            builder.Append(" */\n");

            builder.Append("@Api(basePath = \"/" + ProjectConfig.Service.Name + "\", value = \"" + entity.Comment + "\", description = \"" + entity.Comment + "\", produces = \"application/json\")\n");
            builder.Append("@RestController\n");
            builder.Append("@RequestMapping(value = \"/" + ProjectConfig.Service.Name + "\")\n");
            builder.Append("public class " + fs.f1(entity.Name) + "Controller {\n\n");
            builder.Append(Config.Table1_Text + "@Autowired\n");
            builder.Append(Config.Table1_Text + fs.f1(entity.Name) + "Service " + fs.f2(entity.Name) + "Service;\n");
            //builder.Append("//    @Autowired\n");
            //builder.Append("//    " + fs.f1(entity.Name) + "Repository " + fs.f2(entity.Name) + "Repository;\n");

            for (int i = 0; i < entity.MethodList.Count; i++)
            {
                // add path
                Method m = entity.MethodList[i];
                string text = Config.Table1_Text + "@ApiOperation(value = \"" + m.Description + entity.Comment + "\", notes = \"" + m.Description + entity.Comment + "\", position = " + (i + 1).ToString() + ")\n";
                text += Config.Table1_Text + "@RequestMapping(value = \"/" + fs.f5(entity.Name);
                for (int j = 0; j < m.ParamList.Count; j++)
                {
                    Param p = m.ParamList[j];
                    if (p.Modify == Modify.PathVariable)
                    {
                        text += "/{" + fs.f5(p.Name) + "}";
                    }
                }

                text += "\"";
                builder.Append(text);

                builder.Append(", method = RequestMethod." + m.RequestMethod + ")\n");
                builder.Append(Config.Table1_Text + "@ResponseBody\n");
                builder.Append(Config.Table1_Text + "public Result " + fs.f2(m.Name) + "(");
                text = "";
                for (int j = 0; j < m.ParamList.Count; j++)
                {
                    Param p = m.ParamList[j];

                    text += "\n" + Config.Table2_Text + "@ApiParam(value = \"" + p.Description + "\")\n";
                    if (p.Modify == Modify.PathVariable || p.Modify == Modify.PathValue)
                    {
                        text += Config.Table2_Text + "@PathVariable(\"" + fs.f5(p.Name) + "\") ";
                    }
                    else if (p.Modify == Modify.RequestParam)
                    {
                        text += Config.Table2_Text + "@RequestParam(value = \"" + fs.f1(p.Name) + "\", required = false, defaultValue =\"false\") ";
                    }
                    else if (p.Modify == Modify.RequestBody)
                    {
                        text += Config.Table2_Text + "@RequestBody ";
                    }
                    text += p.Type + " " + fs.f2(p.Name);
                    text += ",";
                }

                builder.Append(text.TrimEnd(','));
                builder.Append(") {\n");
                builder.Append(Config.Table2_Text + "return " + fs.f2(entity.Name) + "Service." + fs.f2(m.Name) + "(");
                // 调用服务函数传参数
                text = "";
                for (int j = 0; j < m.ParamList.Count; j++)
                {
                    Param p = m.ParamList[j];

                    text += fs.f2(p.Name);
                    text += ",";
                }

                builder.Append(text.TrimEnd(','));
                builder.Append(");\n");
                builder.Append(Config.Table1_Text + "}\n");
            }

            builder.Append("}");

            return builder.ToString();
        }
    }
}
