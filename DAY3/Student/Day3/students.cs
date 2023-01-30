using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
   public  class students
   {
        public string name { get; set; }
        public string img { get; set; }

        public int id { get; set; }
        public int age{ get; set; }
        public int grade { get; set; }
        public override string ToString()
        {
            return name;
        }
    }

}
