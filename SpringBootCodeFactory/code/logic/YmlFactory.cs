using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    public class YmlFactory : IFactory<Service>
    {
        public string Create(Service service)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("server:\n");
            builder.Append("    port: " + service.Port + "\n");
            builder.Append("#    contextPath: /group\n");

            builder.Append("spring:\n");
            builder.Append("  redis:\n");
            builder.Append("    host: 123.59.84.71\n");
            builder.Append("    port: 6379\n");
            builder.Append("    password: 9hcom.com\n");
            builder.Append("  http:\n");
            builder.Append("    converters:\n");
            builder.Append("      preferred-json-mapper=gson\n");

            builder.Append("notification:\n");
            builder.Append("  ios:\n");
            builder.Append("    appkey: 55d681b567e58e3881000623\n");
            builder.Append("    appMasterSecret: dvibebrqrobjlzpiruniw8l30zzljnnb\n");
            builder.Append("    productionMode: false\n");
            builder.Append("  android:\n");
            builder.Append("    appkey: 55d681b567e58e3881000623\n");
            builder.Append("    appMasterSecret: dvibebrqrobjlzpiruniw8l30zzljnnb\n");
            builder.Append("    productionMode: false\n");

            builder.Append("# DATASOURCE\n");
            foreach (DataSource proj in service.DataSourceList)
            {
                builder.Append("# " + proj.Description + "\n");
                builder.Append(proj.JDBCName + ":\n");
                builder.Append("    DriverClass: com.mysql.jdbc.Driver\n");
                string port = "";
                if (proj.Port != null && proj.Port != "")
                {
                    port = ":" + proj.Port;
                }
                builder.Append("    JdbcUrl: jdbc:mysql://" + proj.DBUrl + port + "/" + proj.DBName + "?useunicode=true&characterencoding=utf8&autoreconnect=true&rewritebatchedstatements=true&zerodatetimebehavior=converttonull\n");
                builder.Append("    User: " + proj.UserName + "\n");
                builder.Append("    Password: " + proj.Pass + "\n");
            }

            builder.Append("mybatis:\n");
            builder.Append("    typeAliasesPackage: com.ninehcom." + service.Name + "\n");
            builder.Append("    mapperLocations: classpath:/sqlxml/*.xml\n");
            builder.Append("    configLocation: classpath:/mybatis-config.xml\n");

            builder.Append("sensitive:\n");
            builder.Append("    checkUrl: http://123.59.84.71:8083/check\n");

            return builder.ToString();
        }
    }
}