using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SpringBootCodeFactory.code.entity
{
    [Serializable]
    public class Test : List<KeyValuePair<string, DataSource>>
    {

        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public String Port { get; set; }
        [XmlAttribute]
        public String Version { get; set; }

        [XmlArrayItem(typeof(KeyValuePair<string, DataSource>))]
        public List<KeyValuePair<string, DataSource>> DataSourceList { get; set; }

        public Test()
        {
            DataSourceList = new List<KeyValuePair<string, DataSource>>();
        }

 
    }
}
