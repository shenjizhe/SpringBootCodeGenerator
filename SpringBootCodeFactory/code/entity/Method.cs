using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.common;
using System.Xml.Serialization;

namespace SpringBootCodeFactory.code.entity
{
    [Serializable]
    public class Method
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string NameForURL { get; set; }
        [XmlArrayItem(typeof(Param))]
        public List<Param> ParamList { get; set; }
        [XmlElement]
        public Param Return { get; set; }
        [XmlAttribute]
        public RequestMethod RequestMethod { get; set; }
        [XmlAttribute]
        public DBAction DBAction { get; set; }
        [XmlAttribute]
        public string Description { get; set; }
        [XmlAttribute]
        public string Sql { get; set; }

        public Method()
        {
            ParamList = new List<Param>();
        }

        public Method(string name, RequestMethod method, DBAction action, string description, string sql, string nameForURL)
            : this()
        {
            this.Name = name;
            this.RequestMethod = method;
            this.DBAction = action;
            this.Description = description;
            this.Sql = sql;
            this.NameForURL = nameForURL;
        }

        public override string ToString()
        {
            //List<News> selectNewsByType(int newsType, PageParam pageParam);
            bool isList = Return.IsList;
            string listS = isList ? "List<" : "";
            string listE = isList ? ">" : "";

            string text = listS + Return.Name + listE + " " + Name + "(";

            for (int i = 0; i < this.ParamList.Count; i++)
            {
                Param p = this.ParamList[i];

                text += ((p.Modify == Modify.NULL) ? "" : "@" + p.Modify.ToString()) + p.Type + " " + p.Name;
                text += ",";
            }
            text += text.TrimEnd(',') + ")";

            return text;
        }

        public void FromString(string text)
        {

        }
    }
}
