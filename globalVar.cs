using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodMenuMaker
{

   
    public static class globalVar
    {
       public static  string xmlFilename = "MenuDataXML.xml";   //Default Name If not Changed

      
        public static string getName()
        {
            return xmlFilename;
        }
        
        public static void changeFileName(string name)
        {
            name = xmlFilename;
        }

    }


   
}
