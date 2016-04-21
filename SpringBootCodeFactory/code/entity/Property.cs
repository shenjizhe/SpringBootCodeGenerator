using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.common;
using System.Xml.Serialization;

namespace SpringBootCodeFactory.code.entity
{
    [Serializable]
    public class Property
    {
        private static Dictionary<string, string> map = new Dictionary<string, string>();

        [XmlAttribute]
        public string Name;
        [XmlAttribute]
        public string JavaType;
        [XmlAttribute]
        public string JdbcType;
        [XmlAttribute]
        public string Description;
        [XmlAttribute]
        public bool enable = true;

        static Property()
        {
            map.Add(JDBCTYPE.INT, JAVATYPE.INT);
            map.Add(JDBCTYPE.STRING, JAVATYPE.STRING);
            map.Add(JDBCTYPE.BOOLEAN, JAVATYPE.BOOLEAN);
            map.Add(JDBCTYPE.LONG, JAVATYPE.LONG);
            map.Add(JDBCTYPE.DATE, JAVATYPE.DATE);
            map.Add(JDBCTYPE.DATETIME, JAVATYPE.DATETIME);
            map.Add(JDBCTYPE.FLOAT, JAVATYPE.FLOAT);
            map.Add(JDBCTYPE.DOUBLE, JAVATYPE.DOUBLE);
            map.Add(JDBCTYPE.TEXT, JAVATYPE.STRING);
            map.Add(JDBCTYPE.TIMESTAMP, JAVATYPE.TIMESTAMP);
            map.Add(JDBCTYPE.TINYINT, JAVATYPE.INT);
            map.Add(JDBCTYPE.SMALLINT, JAVATYPE.INT);
            map.Add(JDBCTYPE.MEDIUMINT, JAVATYPE.INT);
            map.Add(JDBCTYPE.INTEGER, JAVATYPE.INT);
            map.Add(JDBCTYPE.DECIMAL, JAVATYPE.DECIMAL);
            map.Add(JDBCTYPE.REAL, JAVATYPE.DOUBLE);
            map.Add(JDBCTYPE.CHAR, JAVATYPE.STRING);
            map.Add(JDBCTYPE.ENUM, JAVATYPE.STRING);
            map.Add(JDBCTYPE.SET, JAVATYPE.STRING);
            map.Add(JDBCTYPE.TIME, JAVATYPE.STRING);
            map.Add(JDBCTYPE.YEAR, JAVATYPE.INT);
            map.Add(JDBCTYPE.BLOB, JAVATYPE.STRING);
            map.Add(JDBCTYPE.BINARY, JAVATYPE.STRING);
        }

        public Property()
        {

        }

        public Property(string name, string java, string jdbc, string description)
        {
            this.Name = name;
            this.JavaType = java;
            this.JdbcType = jdbc;
            this.Description = description;
        }

        public Property(List<string> texts)
        {
            this.Name = texts[0];
            string text = texts[1];
            string description = texts[8];
            int index = text.IndexOf("(");
            if (index > -1)
            {
                this.JdbcType = text.Substring(0, index);
            }
            else
            {
                this.JdbcType = text;
            }
            try
            {
                this.JavaType = map[this.JdbcType];
            }
            catch (Exception ex)
            {
                throw new ArgumentException("系统不知道数据库类型" + this.JdbcType, ex);
            }

            this.Description = description;
        }
    }
}
