using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19_Employees
{
    public class tulajdonsag
    {
        public int id;
        public string name;
        public int age;
        public int kereset;
        public tulajdonsag(string sor) 
        {
            string[]darab=sor.Split(';');
            this.id = int.Parse(darab[0]);
            this.name=darab[1];
            this.age = int.Parse(darab[2]);
            this.kereset = int.Parse(darab[3]);
        }
    }
}
