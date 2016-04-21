using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    public class SqlMapFactory : IFactory<Service>
    {

        public string Create(Service service)
        {
            StringBuilder builder = new StringBuilder();


            builder.Append("package com.ninehcom." + service.Name + ".service;\n");
            builder.Append("\n");
            builder.Append("import java.util.HashMap;\n");
            builder.Append("import java.util.Map;\n");
            builder.Append("import javax.annotation.PostConstruct;\n");
            builder.Append("import org.apache.ibatis.session.SqlSession;\n");
            builder.Append("import org.springframework.beans.factory.annotation.Autowired;\n");
            builder.Append("import org.springframework.beans.factory.annotation.Qualifier;\n");
            builder.Append("import org.springframework.stereotype.Component;\n");
            builder.Append("\n");
            builder.Append("/**\n");
            builder.Append(" *\n");
            builder.Append(" * @author Shenjizhe\n");
            builder.Append(" */\n");
            builder.Append("@Component(\"sqlMap\")\n");
            builder.Append("public class SqlMap {\n");
            builder.Append("\n");
            builder.Append("    private Map<String, SqlSession> sqlMap;\n");
            foreach (DataSource ds in service.DataSourceList)
            {
                builder.Append("    @Autowired\n");
                builder.Append("    @Qualifier(\"" + ds.JDBCName + "_template\")\n");
                builder.Append("    SqlSession " + ds.JDBCName + "Session;\n\n");
            }


            builder.Append("    @PostConstruct\n");
            builder.Append("    private void init() {\n");
            builder.Append("        sqlMap = new HashMap();\n");

            foreach (DataSource ds in service.DataSourceList)
            {
                builder.Append("        sqlMap.put(\"" + ds.JDBCName + "\", " + ds.JDBCName + "Session);\n");
            }

            builder.Append("\n    }\n");
            builder.Append("\n");
            builder.Append("    /**\n");
            builder.Append("     * @return the sqlMap\n");
            builder.Append("     */\n");
            builder.Append("    public Map<String, SqlSession> getSqlMap() {\n");
            builder.Append("        return sqlMap;\n");
            builder.Append("    }\n");
            builder.Append("\n");
            builder.Append("    public void put(String dsName, SqlSession session) {\n");
            builder.Append("        sqlMap.put(dsName, session);\n");
            builder.Append("    }\n");
            builder.Append("\n");
            builder.Append("    public SqlSession getSession(String dsName) {\n");
            builder.Append("        if (!sqlMap.containsKey(dsName)) {\n");
            builder.Append("            return null;\n");
            builder.Append("        } else {\n");
            builder.Append("            return sqlMap.get(dsName);\n");
            builder.Append("        }\n");
            builder.Append("    }\n");
            builder.Append("}\n");


            return builder.ToString();
        }
    }
}
