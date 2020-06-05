using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    struct Shoes
    {
        public string article;
        public string name;
        public double value;
        public double kilk;
        public Shoes(string lineWithAllData)
        {
            string[] linesWiThDataAboutOneStudent = lineWithAllData.Split(' ');

            this.article = linesWiThDataAboutOneStudent[0];
            this.name = linesWiThDataAboutOneStudent[1];
            this.value = Convert.ToInt32(linesWiThDataAboutOneStudent[2]);
            this.kilk = Convert.ToInt32(linesWiThDataAboutOneStudent[3]);
        }
    }
}