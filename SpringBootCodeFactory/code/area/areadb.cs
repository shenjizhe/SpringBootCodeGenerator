using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpringBootCodeFactory.code.area
{
    public class Areadb
    {
        public static root create(List<region> regions)
        {
            root r = new root();
            List<region> temp = new List<region>(); ;

            //1. select pro
            for (int i = 0; i < regions.Count; i++)
            {
                if (regions[i].code.EndsWith("0000"))
                {
                    province pro = new province(regions[i].name, regions[i].code);
                    r.provinces.Add(pro);
                    temp.Add(regions[i]);
                }
            }
            for (int i = 0; i < temp.Count; i++)
            {
                regions.Remove(temp[i]);
            }
            temp.Clear();

            //2. select city
            for (int i = 0; i < r.provinces.Count; i++)
            {
                province pro = r.provinces[i];
                string head = pro.prcode.Substring(0,2);
                for (int j = 0; j < regions.Count; j++)
                {
                    if (regions[j].code.StartsWith(head) && regions[j].code.EndsWith("00"))
                    {
                        city ci = new city(regions[j].name, regions[j].code);
                        pro.citys.Add(ci);
                        temp.Add(regions[j]);
                    }
                }
            }

            for (int i = 0; i < temp.Count; i++)
            {
                regions.Remove(temp[i]);
            }
            temp.Clear();
            //3. select zip

            for (int i = 0; i < r.provinces.Count; i++)
            {
                province pro = r.provinces[i];
                for (int j = 0; j < pro.citys.Count; j++)
                {
                    city ci = pro.citys[j];
                    if (ci.name == "市辖区")
                    {
                        ci.name = pro.name;
                    }
                    for (int k = 0; k < regions.Count; k++)
                    {
                        string head = ci.ctcode.Substring(0, 4);
                        if (regions[k].code.StartsWith(head))
                        { 
                            district dis = new district(regions[k].name, regions[k].code);
                            if (dis.name != "市辖区")
                            {
                                ci.districts.Add(dis);
                            }
                        }
                    }
                    
                }
            }

            return r;
        }
    }
}
