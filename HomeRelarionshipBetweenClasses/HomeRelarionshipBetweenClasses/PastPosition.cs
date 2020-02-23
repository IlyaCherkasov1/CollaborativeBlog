using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRelarionshipBetweenClasses
{
   public  class PastPosition
    {
        private string name;
        private Departament departament;

        public PastPosition(string name, Departament departament)
        {
            this.name = name;
            this.departament = departament;
        }
        public void setName(String newName)
        {
            name = newName;
        }
        public String getName()
        {
            return name;
        }
        public void setDepartment(Departament d)
        {
            departament = d;
        }
        public Departament getDepartment()
        {
            return departament;
        }
    }
}
