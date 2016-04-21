using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    public class EntityFactory : IFactory<Entity>
    {
        public string Create(Entity entity)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("package com.ninehcom." + ProjectConfig.Service.Name + ".entity;\n\n");
            builder.Append("import java.util.Date;\n");
            builder.Append("import javax.persistence.Entity;\n");
            builder.Append("import java.io.Serializable;\n");
            builder.Append("import javax.persistence.Id;\n\n");


            builder.Append("/**\n");
            builder.Append("    名称:" + fs.f1(entity.Name) + "实体类\n");
            builder.Append("    描述:" + entity.Comment + "\n");

            builder.Append(" * @author shenjizhe\n");
            builder.Append(" * @version 1.0.0\n\n");

            builder.Append("### " + entity.Comment + " ###\n");
            builder.Append("<A NAME=\"" + fs.f1(entity.Name) + "\">" + fs.f1(entity.Name) + "</A>\n\n");


            builder.Append("名称|类型|描述\n");
            builder.Append("-|-|-\n");

            foreach (Property p in entity.PropertyList)
            {
                if (p.enable)
                {
                    builder.Append(String.Format("{0,-20}", p.Name));
                    builder.Append("|");
                    builder.Append(String.Format("{0,-10}", p.JavaType));
                    builder.Append("|");
                    builder.Append(p.Description + "\n");
                }
            }

            builder.Append(" */\n");
            builder.Append("@Entity\n");
            builder.Append("public class " + fs.f1(entity.Name) + " implements Serializable{\n\n");
            builder.Append("    @Id\n");

            foreach (Property p in entity.PropertyList)
            {
                if (p.enable)
                {
                    builder.Append("    private " + p.JavaType + " " + fs.f2(p.Name) + ";\n");
                    builder.Append("    public  " + p.JavaType + " get" + fs.f1(p.Name) + "() {\n");
                    builder.Append("        return " + fs.f2(p.Name) + ";\n");
                    builder.Append("    }\n");
                    builder.Append("    public void set" + fs.f1(p.Name) + "(" + p.JavaType + " " + fs.f2(p.Name) + ") {\n");
                    builder.Append("        this." + fs.f2(p.Name) + " = " + fs.f2(p.Name) + ";\n");
                    builder.Append("    }\n\n");
                }
            }
            builder.Append("}");

            return builder.ToString();
        }
    }
}
