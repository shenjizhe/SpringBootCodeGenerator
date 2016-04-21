using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SpringBootCodeFactory.code.common
{
    [Serializable]
    public class Param
    {
        [XmlAttribute]
        public bool IsList { get; set; }
        [XmlAttribute]
        public String Type { get; set; }
        [XmlAttribute]
        public String Name { get; set; }
        [XmlAttribute]
        public String Description { get; set; }
        [XmlAttribute]
        public Modify Modify { get; set; }// null 代表不需要标注

        public static List<Param> CreateParam(string text)
        {
            List<Param> paramList = new List<Param>();

            string[] param_list = text.Split(',');

            if (param_list != null)
            {
                foreach (string p in param_list)
                {
                    string[] keyvalue = p.Split(' ');
                    Param pp = new Param(keyvalue[1], keyvalue[0], keyvalue[2], false, Modify.NULL);
                    paramList.Add(pp);
                }
            }

            return paramList;
        }

        public Param()
        {

        }

        public Param(string name, string type, string description, bool isList, Modify modify)
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.IsList = isList;
            this.Modify = modify;
        }
    }
}
