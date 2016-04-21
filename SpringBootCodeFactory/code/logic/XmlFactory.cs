using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    public class XmlFactory : IFactory<Entity>
    {
        public string Create(Entity entity)
        {
            StringBuilder builder = new StringBuilder();


            builder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\n");
            builder.Append("<!DOCTYPE mapper\n");
            builder.Append("  PUBLIC \"-//mybatis.org//DTD Mapper 3.0//EN\"\n");
            builder.Append("  \"http://mybatis.org/dtd/mybatis-3-mapper.dtd\">\n");
            builder.Append("<mapper namespace=\"com.ninehcom." + ProjectConfig.Service.Name + ".mapper." + fs.f1(entity.Name) + "Mapper\">\n");
            builder.Append("    <resultMap type=\"com.ninehcom." + ProjectConfig.Service.Name + ".entity." + fs.f1(entity.Name) + "\" id=\"" + fs.f2(entity.Name) + "Map\">\n");

            for (int i = 0; i < entity.PropertyList.Count; i++)
            {
                string text = i == 0 ? "id" : "result";
                Property p = entity.PropertyList[i];
                if (p.enable)
                {
                    builder.Append(Config.Table2_Text + "<" + text + " column=\"" + p.Name + "\" property=\"" + fs.f1(p.Name) + "\"/>\n");
                }
            }

            builder.Append(Config.Table1_Text + "</resultMap>\n");

            for (int i = 0; i < entity.MethodList.Count; i++)
            {
                Method m = entity.MethodList[i];

                string action = m.DBAction.ToString();

                if (m.DBAction == DBAction.select)
                {
                    builder.Append(Config.Table1_Text + "<" + action + " id=\"" + fs.f2(m.Name) + "\" resultType=\"" + fs.f1(entity.Name) + "\">\n");
                }
                else if (m.DBAction == DBAction.insert || m.DBAction == DBAction.update)
                {
                    builder.Append(Config.Table1_Text + "<" + action + " id=\"" + fs.f2(m.Name) + "\" parameterType=\"" + fs.f1(entity.Name) + "\">\n");
                }
                else
                {
                    builder.Append(Config.Table1_Text + "<" + action + " id=\"" + fs.f2(m.Name) + "\">\n");
                }

                builder.Append(Config.Table2_Text + m.Sql.Replace("\n", "\n" + Config.Table2_Text) + "\n");
                builder.Append(Config.Table1_Text + "</" + action + ">\n");
            }

            builder.Append("</mapper>\n");

            return builder.ToString();
        }
    }
}
