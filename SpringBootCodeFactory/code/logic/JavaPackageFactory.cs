using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.logic
{
    public class JavaPackageFactory
    {
        private Service service = null;
        public JavaPackageFactory(Service service)
        {
            this.service = service;
        }

        public string[] Format(string[] alllines,string replaceText)
        {
            if (alllines != null)
            {
                for (int i = 0; i < alllines.Length; i++)
                {
                    alllines[i] = alllines[i].Replace(replaceText, fs.f2(service.Name));
                }
            }

            return alllines;
        }
    }
}
