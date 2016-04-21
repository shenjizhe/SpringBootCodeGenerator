using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SpringBootCodeFactory.code.area
{
    [Serializable]
    public class root
    {
        [XmlArray]
        public List<province> provinces;

        public root()
        {
            provinces = new List<province>();
        }

    }

    [Serializable]
    public class province
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public string prcode;
        [XmlArray]
        public List<city> citys;

        public province(string name, string prcode)
        {
            this.name = name;
            this.prcode = prcode;
            citys = new List<city>();
        }

        public province()
        {
            citys = new List<city>();
        }
    }

    [Serializable]
    public class city
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public string ctcode;
        [XmlArray]
        public List<district> districts;
        public city(string name, string ctcode)
        {
            this.name = name;
            this.ctcode = ctcode;
            districts = new List<district>();
        }

        public city()
        {
            districts = new List<district>();
        }
    }

    [Serializable]
    public class district
    {
        [XmlAttribute]
        public string name;
           [XmlAttribute]
        public string zipcode;

        public district(string name, string zipcode)
        {
            this.name = name;
            this.zipcode = zipcode;
        }

        public district()
        {

        }
    }
}
