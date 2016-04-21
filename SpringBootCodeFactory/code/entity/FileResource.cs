using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpringBootCodeFactory.code.entity
{
    public class FileResource
    {
        public string Source { get; set; }
        public string Destnatation { get; set; }

        public FileResource()
        {

        }

        public FileResource(string source, string destnation)
        {
            this.Destnatation = destnation;
            this.Source = source;
        }
    }
}
