using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    public class ConfigFactory : IFactory<Service>
    {
        public string Create(Service service)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("package com.ninehcom." + service.Name + ".conf;\n\n");

            builder.Append("import java.beans.PropertyVetoException;\n");
            builder.Append("import javax.sql.DataSource;\n");
            builder.Append("import org.springframework.boot.bind.RelaxedPropertyResolver;\n");
            builder.Append("import org.springframework.context.EnvironmentAware;\n");
            builder.Append("import org.springframework.context.annotation.Bean;\n");
            builder.Append("import org.springframework.context.annotation.Configuration;\n");
            builder.Append("import org.springframework.core.env.Environment;\n");
            builder.Append("import org.springframework.transaction.annotation.EnableTransactionManagement;\n");
            builder.Append("import com.mchange.v2.c3p0.ComboPooledDataSource;\n");
            builder.Append("import org.springframework.context.annotation.Primary;\n");
            builder.Append("import org.springframework.core.env.PropertyResolver;\n");

            builder.Append("@Configuration\n");
            builder.Append("@EnableTransactionManagement\n");
            builder.Append("public class DataBaseConfiguration implements EnvironmentAware {\n");

            foreach (DataSource source in service.DataSourceList)
            {
                builder.Append(Config.Table1_Text + "private RelaxedPropertyResolver " + source.JDBCName + "PR;\n");
            }
            builder.Append("\n");
            builder.Append(Config.Table1_Text + "@Override\n");
            builder.Append(Config.Table1_Text + "public void setEnvironment(Environment env) {\n");

            foreach (DataSource source in service.DataSourceList)
            {
                builder.Append(Config.Table2_Text + "this." + source.JDBCName + "PR = new RelaxedPropertyResolver(env, \"" + source.JDBCName + ".\");\n");
            }
            builder.Append(Config.Table1_Text + "}\n");
            builder.Append("\n");
            for (int i = 0; i < service.DataSourceList.Count; i++)
            {
                DataSource source = service.DataSourceList[i];
                builder.Append(Config.Table1_Text + "@Bean(name = \"" + source.JDBCName + "\")\n");
                if (i == 0)
                {
                    builder.Append(Config.Table1_Text + "@Primary\n");
                }
                builder.Append(Config.Table1_Text + "public DataSource " + source.JDBCName + "() throws PropertyVetoException {\n");
                builder.Append(Config.Table2_Text + "return getDataSource(" + source.JDBCName + "PR);\n");
                builder.Append(Config.Table1_Text + "}\n");
            }

            builder.Append("\n");
            builder.Append(Config.Table1_Text + "private DataSource getDataSource(PropertyResolver resolver) throws PropertyVetoException {\n");
            builder.Append(Config.Table2_Text + "ComboPooledDataSource dataSource = new ComboPooledDataSource();\n");
            builder.Append(Config.Table2_Text + "dataSource.setJdbcUrl(resolver.getProperty(\"JdbcUrl\"));\n");
            builder.Append(Config.Table2_Text + "dataSource.setDriverClass(resolver.getProperty(\"DriverClass\"));\n");
            builder.Append(Config.Table2_Text + "dataSource.setUser(resolver.getProperty(\"User\"));\n");
            builder.Append(Config.Table2_Text + "dataSource.setPassword(resolver.getProperty(\"Password\"));\n");
            builder.Append(Config.Table2_Text + "dataSource.setInitialPoolSize(5);\n");
            builder.Append(Config.Table2_Text + "dataSource.setMinPoolSize(2);\n");
            builder.Append(Config.Table2_Text + "dataSource.setMaxPoolSize(10);\n");
            builder.Append(Config.Table2_Text + "dataSource.setIdleConnectionTestPeriod(3000);\n");
            builder.Append(Config.Table2_Text + "return dataSource;\n");
            builder.Append(Config.Table1_Text + "}\n");
            builder.Append("}\n");

            return builder.ToString();
        }
    }
}
