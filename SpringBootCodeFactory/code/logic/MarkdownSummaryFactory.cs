using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    public class MarkdownSummaryFactory : IFactory<Service>
    {
        public string Create(Service service)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < service.DataSourceList.Count; i++)
            {
                DataSource ds = service.DataSourceList[i];
                builder.Append("* [" + ds.Description + "]()\n");
                for (int j = 0; j < ds.EntityList.Count; j++)
                {
                    Entity entity = ds.EntityList[j];
                    builder.Append(" - [" + entity.Comment + "](" + ds.DBName + "/" + entity.Name + ".md)\n");
                }
            }

            return builder.ToString();
        }
    }
}
