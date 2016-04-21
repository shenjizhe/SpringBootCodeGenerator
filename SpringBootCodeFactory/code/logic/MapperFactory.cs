using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;
using SpringBootCodeFactory.code.common;

namespace SpringBootCodeFactory.code.logic
{
    public class MapperFactory : IFactory<DataSource, Entity>
    {
        public string Create(DataSource source, Entity entity)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("package com.ninehcom." + ProjectConfig.Service.Name + ".mapper;\n\n");
            builder.Append("import com.ninehcom." + ProjectConfig.Service.Name + ".entity." + fs.f1(entity.Name) + ";\n");
            builder.Append("import com.ninehcom.common.entity.PageParam;\n");
            builder.Append("import java.util.List;\n");
            builder.Append("import org.apache.ibatis.session.SqlSession;\n");
            builder.Append("import org.springframework.beans.factory.annotation.Autowired;\n");
            builder.Append("import org.springframework.beans.factory.annotation.Qualifier;\n");
            builder.Append("import org.springframework.stereotype.Component;\n");

            builder.Append("/**\n");
            builder.Append(" * " + fs.f1(entity.Name) + "的Mapper，用于Mybatis\n");
            builder.Append(" * @author shenjizhe\n");
            builder.Append(" * @version 1.0.0\n");
            builder.Append(" */\n");

            builder.Append("@Component\n");
            builder.Append("public class " + fs.f1(entity.Name) + "Mapper {\n\n");
            builder.Append(Config.Table1_Text + "@Autowired\n");
            builder.Append(Config.Table1_Text + "@Qualifier(\"" + source.JDBCName + "_template\")\n");
            builder.Append(Config.Table1_Text + "SqlSession sqlSession;\n");
            foreach (Method m in entity.MethodList)
            {
                string liststart = "";
                string listend = "";
                if (m.Return.IsList)
                {
                    liststart = "List<";
                    listend = ">";
                }
                builder.Append("\n" + Config.Table1_Text + "public " + liststart + m.Return.Type + listend + " " + fs.f2(m.Name) + "(");

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


                builder.Append("){\n");
                string sessionMethod = "selectList";
                if (m.DBAction == DBAction.select)
                {
                    if (m.ParamList.Count == 0)
                    {
                        sessionMethod = "selectList";
                    }
                    else
                    {
                        sessionMethod = "selectOne";
                    }
                }
                else if (m.DBAction == DBAction.insert)
                {
                    sessionMethod = "insert";
                }
                else if (m.DBAction == DBAction.update)
                {
                    sessionMethod = "update";
                }
                else if (m.DBAction == DBAction.delete)
                {
                    sessionMethod = "delete";
                }

                builder.Append("\treturn sqlSession." + sessionMethod + "(\"" + fs.f2(m.Name) + "\", ");
                if (m.ParamList.Count > 0)
                {
                    for (int i = 0; i < m.ParamList.Count; i++)
                    {
                        Param p = m.ParamList[i];
                        builder.Append(p.Name);
                        if (i < m.ParamList.Count - 1)
                        {
                            builder.Append(", ");
                        }
                    }
                }
                else
                {
                    builder.Append("null");
                }


                builder.Append(");");


                builder.Append("\n" + Config.Table1_Text + "}\n");
            }

            builder.Append("}");

            return builder.ToString();
        }
    }
}
