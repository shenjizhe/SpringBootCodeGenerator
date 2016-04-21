using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;
using SpringBootCodeFactory.code.common;

namespace SpringBootCodeFactory.code.logic
{
    public class MarkdownFactory : IFactory<Entity>
    {
        public string Create(Entity entity)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("### " + entity.Comment + " ###\n");
            builder.Append("<A NAME=\"" + fs.f1(entity.Name) + "\">" + fs.f1(entity.Name) + "</A>\n\n");


            builder.Append("名称|类型|描述\n");
            builder.Append("-|-|-\n");

            foreach (Property p in entity.PropertyList)
            {
                if (p.enable)
                {
                    builder.Append(String.Format("{0,-20}", fs.f2(p.Name)));
                    builder.Append("|");
                    builder.Append(String.Format("{0,-10}", p.JavaType));
                    builder.Append("|");
                    builder.Append(p.Description + "\n");
                }
            }

            builder.Append("\n");
            string domainName = ProjectConfig.Service.DomainName;

            for (int i = 0; i < entity.MethodList.Count; i++)
            {
                Method method = entity.MethodList[i];
                builder.Append("### " + (i + 1) + "." + method.Description + entity.Comment + "：（" + method.RequestMethod + "） ###\n");

                string text = fs.f5(entity.Name);
                for (int j = 0; j < method.ParamList.Count; j++)
                {
                    Param p = method.ParamList[j];
                    if (p.Modify == Modify.PathVariable)
                    {
                        text += "/{" + fs.f5(p.Name) + "}";
                    }
                }

                builder.Append("[" + domainName + text + "]" + "(" + domainName + text + ")\n\n");

                builder.Append("**input：**\n\n");
                builder.Append("参数名 		|描述	|示例\n");
                builder.Append(" --------- | ------|------\n");

                for (int k = 0; k < method.ParamList.Count; k++)
                {
                    Param p = method.ParamList[k];
                    builder.Append(p.Name + "| " + p.Description + " |   \n");

                }
                builder.Append("\n");


                builder.Append("**output：**<A HREF=\"#Code\">Code(返回码)</A>\n\n");
                builder.Append("参数名 		|描述	|示例\n");
                builder.Append(" --------- | ------|------\n");
                builder.Append("code 		|返回值	|0\n");
                builder.Append("msg			|返回消息|成功\n\n");
            }

            return builder.ToString();
        }
    }
}
