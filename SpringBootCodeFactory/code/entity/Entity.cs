using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using SpringBootCodeFactory.code.common;

namespace SpringBootCodeFactory.code.entity
{
    [Serializable]
    public class Entity
    {
        [XmlAttribute]
        public string Name;
        [XmlAttribute]
        public string Comment;
        [XmlArrayItem(typeof(Property))]
        public List<Property> PropertyList;
        [XmlArrayItem(typeof(Method))]
        public List<Method> MethodList;

        public Entity()
        {
            PropertyList = new List<Property>();
            MethodList = new List<Method>();
        }

        public Entity(string name, string Comment)
            : this()
        {
            this.Name = name;
            this.Comment = Comment;
        }

        public Entity(string name, string Comment, List<List<string>> items)
            : this(name, Comment)
        {
            for (int i = 0; i < items.Count; i++)
            {
                PropertyList.Add(new Property(items[i]));

            }
        }

        public Method SelectIDText
        {
            get
            {
                Method method = new Method();
                method.Name = "select_" + fs.f4(this.Name) + "_by_id";
                method.RequestMethod = RequestMethod.GET;
                method.DBAction = DBAction.select;
                method.Description = "获取";
                method.Return = new Param(fs.f2(this.Name), fs.f1(this.Name), fs.f1(this.Comment), false, Modify.NULL);
                method.ParamList.Add(new Param("Id", "int", fs.f1(this.Comment) + "唯一标识", false, Modify.PathVariable));
                method.Sql = "\tSELECT\n\t*\n\tFROM\n\t" + fs.f4(this.Name) + "\n\tWHERE\n\tID=#{0}";

                return method;
            }
        }

        public Method SelectAllText
        {
            get
            {
                Method method = new Method();
                method.Name = "select_all_" + fs.f4(this.Name);
                method.NameForURL = this.Name;
                method.RequestMethod = RequestMethod.GET;
                method.Description = "获取所有";
                method.DBAction = DBAction.select;
                method.Return = new Param("list", fs.f1(this.Name), fs.f1(this.Comment) + "列表", true, Modify.NULL);
                method.Sql = "\tSELECT\n\t*\n\tFROM\n\t" + fs.f4(this.Name);

                return method;
            }
        }

        public Method InsertText
        {
            get
            {
                Method method = new Method();
                method.Name = "insert_" + fs.f4(this.Name);
                method.RequestMethod = RequestMethod.POST;
                method.DBAction = DBAction.insert;
                method.Description = "添加";
                method.Return = new Param("count", "int", fs.f1(this.Comment) + "数量", false, Modify.NULL);

                method.ParamList.Add(new Param(fs.f2(this.Name), fs.f1(this.Name), fs.f1(this.Comment), false, Modify.RequestBody));

                method.Sql = "\tINSERT INTO\n\t" + fs.f4(this.Name) + "\n" +
                "\t(\n\t";
                for (int i = 0; i < this.PropertyList.Count; i++)
                {
                    Property prop = this.PropertyList[i];
                    if (prop.enable)
                    {
                        method.Sql += fs.f4(this.Name) + "." + prop.Name;
                        method.Sql += " , ";
                    }
                }
                method.Sql = method.Sql.TrimEnd(", ".ToArray());

                method.Sql += "\n\t)\n" +
                "\tVALUES\n" +
                "\t(\n\t";
                for (int i = 0; i < this.PropertyList.Count; i++)
                {
                    Property prop = this.PropertyList[i];
                    if (prop.enable)
                    {
                        method.Sql += "#{ ";
                        method.Sql += this.PropertyList[i].Name;
                        method.Sql += " }";
                        method.Sql += " , ";
                    }
                }
                method.Sql = method.Sql.TrimEnd(", ".ToArray());
                method.Sql += "\n\t)";

                return method;
            }
        }

        public Method DeleteText
        {
            get
            {
                Method method = new Method();
                method.Name = "delete_" + fs.f4(this.Name) + "_by_id";
                method.RequestMethod = RequestMethod.DELETE;
                method.Description = "删除";
                method.DBAction = DBAction.delete;
                method.Return = new Param("count", "int", fs.f1(this.Comment) + "数量", false, Modify.NULL);

                method.ParamList.Add(new Param("Id", "int", fs.f1(this.Comment) + "唯一标识", false, Modify.PathVariable));

                method.Sql = "\tDELETE FROM\n\t" + fs.f4(this.Name) + "\n\tWHERE\n\tid=#{0}";
                return method;
            }
        }

        public Method UpdateText
        {
            get
            {
                Method method = new Method();
                method.Name = "update_" + fs.f4(this.Name);
                method.RequestMethod = RequestMethod.PUT;
                method.Description = "修改";
                method.DBAction = DBAction.update;
                method.Return = new Param("count", "int", fs.f1(this.Comment) + "数量", false, Modify.NULL);

                method.ParamList.Add(new Param(fs.f2(this.Name), fs.f1(this.Name), fs.f1(this.Comment), false, Modify.RequestBody));

                method.Sql = "\tUPDATE\n\t" + fs.f4(this.Name) + "\n\tSET\n";
                for (int i = 1; i < this.PropertyList.Count; i++)
                {
                    Property prop = this.PropertyList[i];
                    if (prop.enable)
                    {
                        string propertyName = fs.f1(prop.Name);
                        method.Sql += "\t<if test=\"" + propertyName + " != null\">\n";

                        method.Sql += "\t" + fs.f4(this.Name) + "." + propertyName;
                        method.Sql += " = #{ ";
                        method.Sql += propertyName;
                        method.Sql += " }";
                        method.Sql += ",\n\t</if>";
                    }
                }

                method.Sql = method.Sql.TrimEnd(",\n\t</if>".ToArray()) + "\n\t</if>";
                method.Sql += "\n\tWHERE\n";
                method.Sql += "\tid= #{id}";
                return method;
            }
        }
    }
}
