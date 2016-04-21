using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;
using SpringBootCodeFactory.code.common;

namespace SpringBootCodeFactory.code.logic
{
    public class ServiceFactory : IFactory<Entity>
    {
        public string Create(Entity entity)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("package com.ninehcom." + ProjectConfig.Service.Name + ".service;\n\n");
            builder.Append("import com.ninehcom." + ProjectConfig.Service.Name + ".entity." + fs.f1(entity.Name) + ";\n");
            builder.Append("import com.ninehcom." + ProjectConfig.Service.Name + ".mapper." + fs.f1(entity.Name) + "Mapper;\n");
            builder.Append("import com.ninehcom.common.entity.PageParam;\n");
            builder.Append("import com.ninehcom.common.util.Result;\n");
            builder.Append("import java.util.ArrayList;\n");
            builder.Append("import java.util.List;\n");
            builder.Append("import org.springframework.beans.factory.annotation.Autowired;\n");
            builder.Append("import org.springframework.stereotype.Service;\n\n");

            builder.Append("/**\n");
            builder.Append(" * " + fs.f1(entity.Name) + "的Service\n");
            builder.Append(" * @author shenjizhe\n");
            builder.Append(" * @version 1.0.0\n");
            builder.Append(" */\n");


            builder.Append("@Service\n");
            builder.Append("public class " + fs.f1(entity.Name) + "Service {\n\n");


            builder.Append(Config.Table1_Text + "@Autowired\n");
            builder.Append(Config.Table1_Text + "private  " + fs.f1(entity.Name) + "Mapper  " + fs.f2(entity.Name) + "Mapper;\n");
            foreach (Method m in entity.MethodList)
            {
                builder.Append(Config.Table1_Text + "public Result " + fs.f2(m.Name) + "(");

                for (int i = 0; i < m.ParamList.Count; i++)
                {
                    Param p = m.ParamList[i];
                    builder.Append(p.Type + " " + p.Name);
                    if (i < m.ParamList.Count - 1)
                    {
                        builder.Append(", ");
                    }
                }

                //int newsType, PageParam pageParam


                builder.Append(") {\n");
                builder.Append(Config.Table2_Text);
                // method code
                string liststart = "";
                string listend = "";
                if (m.Return.IsList)
                {
                    liststart = "List<";
                    listend = ">";
                }
                builder.Append(liststart + m.Return.Type + listend);
                builder.Append(" " + m.Return.Name);
                builder.Append(" = " + fs.f2(entity.Name) + "Mapper." + fs.f2(m.Name) + "(");

                for (int i = 0; i < m.ParamList.Count; i++)
                {
                    Param p = m.ParamList[i];
                    builder.Append(p.Name);
                    if (i < m.ParamList.Count - 1)
                    {
                        builder.Append(", ");
                    }
                }
                builder.Append(");\n");
                string type = "";
                if (m.Return.IsList)
                {
                    type = "(ArrayList)";
                }
                builder.Append(Config.Table2_Text + "return Result.Success(" + type + m.Return.Name + ");\n");

                builder.Append(Config.Table1_Text + "}\n");
            }

            builder.Append("}");

            return builder.ToString();
        }
    }
}
