using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SpringBootCodeFactory.code.entity
{
    [Serializable]
    public class Service
    {
        public const string FileSUFF = "jpsb";
        public const string FileFilter = "*." + Service.FileSUFF + "|*." + Service.FileSUFF + "|*.*|*.*";

        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public String Port { get; set; }
        [XmlAttribute]
        public String Version { get; set; }
        [XmlAttribute]
        public String DomainName { get; set; }


        [XmlArrayItem(typeof(DataSource))]
        public List<DataSource> DataSourceList { get; set; }

        public Service()
        {
            DataSourceList = new List<DataSource>();
        }

        public Service(string name,string port,string version,string domainName)
        {
            this.Name = name;
            this.Port = port;
            this.Version = version;
            this.DomainName = domainName;
        }
    }
}
