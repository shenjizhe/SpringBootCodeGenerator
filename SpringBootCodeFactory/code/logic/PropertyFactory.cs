using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    public class PropertyFactory : IFactory<Service>
    {
        public string Create(Service service)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("server.port =" + service.Port + "\n");
            builder.Append("# 数据库配置,多库配置\n");
            foreach (DataSource project in service.DataSourceList)
            {
                builder.Append("spring.datasource.url=jdbc:mysql://" + project.DBUrl + "/" + project.DBName +
                "?autoReconnect=true&useUnicode=true&characterEncoding=utf-8\n");
                builder.Append("spring.datasource.username=" + project.UserName + "\n");
                builder.Append("spring.datasource.password=" + project.Pass + "\n");

                builder.Append("spring.main.show-banner=false\n");
                builder.Append(service.Name + ".datasource.url=jdbc:mysql://" + project.DBUrl + "/" + project.DBName +
                    "?autoReconnect=true&useUnicode=true&characterEncoding=utf-8\n");
                builder.Append(service.Name + ".datasource.username=" + project.UserName + "\n");
                builder.Append(service.Name + ".datasource.password=" + project.Pass + "\n");
            }



            builder.Append("# 配置mybatis对应关系，JSonArray格式，里边字符串用,分割\n");

            string text = service.Name + ".datasource.mappers=[";
            text += "\"MysqlTestTaskMapper.xml\","; // 特殊为了自动连接数据库心跳

            foreach (DataSource project in service.DataSourceList)
            {
                for (int i = 0; i < project.EntityList.Count; i++)
                {
                    Entity entity = project.EntityList[i];
                    text += "\"" + fs.f1(entity.Name) + "Mapper.xml" + "\",";
                }
            }
            text = text.TrimEnd(',');
            text += "]\n";
            builder.Append(text);
            builder.Append(service.Name + ".datasource.path=sqlxml/\n");
            builder.Append(service.Name + ".datasource.version=" + service.Version);

            return builder.ToString();
        }
    }
}