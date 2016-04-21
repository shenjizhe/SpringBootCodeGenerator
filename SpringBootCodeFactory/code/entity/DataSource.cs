using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SpringBootCodeFactory.code.entity
{
    [Serializable]
    public class DataSource
    {
        public const string Head = "jdbc_";
        [XmlAttribute]
        public String DBUrl { get; set; }
        [XmlAttribute]
        public String DBName { get; set; }
        [XmlAttribute]
        public String UserName { get; set; }
        [XmlAttribute]
        public String Pass { get; set; }
        [XmlAttribute]
        public String Port { get; set; }
        [XmlAttribute]
        public String Description { get; set; }

        [XmlArrayItem(typeof(Entity))]
        public List<Entity> EntityList { get; set; }

        [XmlIgnore]
        public string ID
        {
            get
            {
                return DBUrl + "/" + DBName;
            }
        }

        [XmlIgnore]
        public string JDBCName
        {
            get
            {
                return (Head + DBName).Replace("-", "_");
            }
        }

        public DataSource()
        {
            EntityList = new List<Entity>();
        }

        public DataSource(string dbUrl, string dbName, string userName, string pass, string port, string description)
            : this()
        {
            this.DBName = dbName;
            this.DBUrl = dbUrl;
            this.UserName = userName;
            this.Pass = pass;
            this.Port = port;
            this.Description = description;
        }
    }
}
