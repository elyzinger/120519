using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FileManager
{
    static class VirusScanner
    {
        
        public int MalwareSize
        {
            get
            {
                return malwareSize = Convert.ToInt32(ConfigurationManager.AppSettings["MalwareSize"]);
            }
        }
        //int malwareSize = Convert.ToInt32(ConfigurationManager.AppSettings["MalwareSize"]);

    }
}
