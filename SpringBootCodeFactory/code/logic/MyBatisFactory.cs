using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    class MyBatisFactory : IFactory<Service>
    {
        public string Create(Service service)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("package com.ninehcom." + service.Name + ".conf;\n\n");
            builder.Append("import javax.sql.DataSource;\n");
            builder.Append("import org.apache.commons.logging.Log;\n");
            builder.Append("import org.apache.commons.logging.LogFactory;\n");
            builder.Append("import org.apache.ibatis.session.SqlSessionFactory;\n");
            builder.Append("import org.mybatis.spring.SqlSessionFactoryBean;\n");
            builder.Append("import org.mybatis.spring.SqlSessionTemplate;\n");
            builder.Append("import org.mybatis.spring.annotation.MapperScan;\n");
            builder.Append("import org.springframework.beans.factory.annotation.Autowired;\n");
            builder.Append("import org.springframework.beans.factory.annotation.Qualifier;\n");
            builder.Append("import org.springframework.boot.autoconfigure.AutoConfigureAfter;\n");
            builder.Append("import org.springframework.boot.autoconfigure.condition.ConditionalOnMissingBean;\n");
            builder.Append("import org.springframework.boot.bind.RelaxedPropertyResolver;\n");
            builder.Append("import org.springframework.context.EnvironmentAware;\n");
            builder.Append("import org.springframework.context.annotation.Bean;\n");
            builder.Append("import org.springframework.context.annotation.Configuration;\n");
            builder.Append("import org.springframework.context.annotation.Primary;\n");
            builder.Append("import org.springframework.core.env.Environment;\n");
            builder.Append("import org.springframework.core.io.DefaultResourceLoader;\n");
            builder.Append("import org.springframework.core.io.support.PathMatchingResourcePatternResolver;\n");
            builder.Append("import org.springframework.jdbc.datasource.DataSourceTransactionManager;\n");
            builder.Append("import org.springframework.transaction.annotation.EnableTransactionManagement;\n");

            builder.Append("@Configuration\n");
            builder.Append("@MapperScan(basePackages = {\"com.ninehcom." + service.Name + ".start.config\"})\n");
            builder.Append("@AutoConfigureAfter({DataBaseConfiguration.class})\n");
            builder.Append("@EnableTransactionManagement(proxyTargetClass = true)\n");
            builder.Append("public class MyBatisConfiguration implements EnvironmentAware {\n");
            builder.Append("\n");
            builder.Append(Config.Table1_Text +"private static Log logger = LogFactory.getLog(MyBatisConfiguration.class);\n");
            builder.Append(Config.Table1_Text + "private RelaxedPropertyResolver propertyResolver;\n");
            builder.Append("\n");
            builder.Append(Config.Table1_Text +"@Override\n");
            builder.Append(Config.Table1_Text + "public void setEnvironment(Environment environment) {\n");
            builder.Append(Config.Table2_Text + "this.propertyResolver = new RelaxedPropertyResolver(environment, \"mybatis.\");\n");
            builder.Append(Config.Table1_Text + "}\n");
            builder.Append(Config.Table1_Text + "\n");
            builder.Append(Config.Table1_Text + "private SqlSessionFactory sqlSessionFactory(DataSource ds) {\n");
            builder.Append(Config.Table2_Text + "try {\n");
            builder.Append(Config.Table2_Text + "SqlSessionFactoryBean factoryBean = new SqlSessionFactoryBean();\n");
            builder.Append(Config.Table2_Text + "factoryBean.setDataSource(ds);\n");
            builder.Append(Config.Table2_Text + "factoryBean.setTypeAliasesPackage(\n");
            builder.Append(Config.Table3_Text + "propertyResolver.getProperty(\"typeAliasesPackage\"));\n");
            builder.Append(Config.Table2_Text + "factoryBean.setMapperLocations(\n");
            builder.Append(Config.Table3_Text + "new PathMatchingResourcePatternResolver().getResources(\n");
            builder.Append(Config.Table3_Text + "propertyResolver.getProperty(\"mapperLocations\")));\n");
            builder.Append(Config.Table2_Text + "factoryBean.setConfigLocation(\n");
            builder.Append(Config.Table3_Text + "new DefaultResourceLoader().getResource(\n");
            builder.Append(Config.Table4_Text + "propertyResolver.getProperty(\"configLocation\")));\n");
            builder.Append("\n");
            builder.Append(Config.Table2_Text + "SqlSessionFactory sqlSessionFactory = null;\n");
            builder.Append(Config.Table2_Text + "try {\n");
            builder.Append(Config.Table3_Text + "sqlSessionFactory = factoryBean.getObject();\n");
            builder.Append(Config.Table2_Text + "} catch (Exception e) {\n");
            builder.Append(Config.Table3_Text + "e.printStackTrace();\n");
            builder.Append(Config.Table3_Text + "System.exit(0);\n");
            builder.Append(Config.Table2_Text + "}\n");
            builder.Append(Config.Table2_Text + "org.apache.ibatis.session.Configuration configuration\n");
            builder.Append(Config.Table4_Text + "= sqlSessionFactory.getConfiguration();\n");
            builder.Append(Config.Table3_Text + "configuration.setMapUnderscoreToCamelCase(true);\n");
            builder.Append(Config.Table3_Text + "return sqlSessionFactory;\n");
            builder.Append("\n");
            builder.Append(Config.Table2_Text + "} catch (Exception e) {\n");
            builder.Append(Config.Table2_Text + "logger.warn(\"Could not confiure mybatis session factory\");\n");
            builder.Append(Config.Table2_Text + "return null;\n");
            builder.Append(Config.Table2_Text + "}\n");
            builder.Append(Config.Table1_Text + "}\n");

            foreach (DataSource source in service.DataSourceList)
            {
                builder.Append(Config.Table1_Text + "@Autowired\n");
                builder.Append(Config.Table1_Text + "@Qualifier(\"" + source.JDBCName + "\")\n");
                builder.Append(Config.Table1_Text + "private DataSource " + source.JDBCName + ";\n");
                builder.Append("\n");
                builder.Append(Config.Table1_Text + "@Bean(name = \"" + source.JDBCName + "_template\")\n");
                builder.Append(Config.Table1_Text + "public SqlSessionTemplate " + source.JDBCName + "_template() {\n");
                builder.Append(Config.Table2_Text + "SqlSessionTemplate sessionTemplate = new SqlSessionTemplate(sqlSessionFactory(" + source.JDBCName + "));\n");
                builder.Append(Config.Table2_Text + "return sessionTemplate;\n");
                builder.Append(Config.Table1_Text + "}\n");
            }

            builder.Append("}\n");

            return builder.ToString();
        }
    }
}
