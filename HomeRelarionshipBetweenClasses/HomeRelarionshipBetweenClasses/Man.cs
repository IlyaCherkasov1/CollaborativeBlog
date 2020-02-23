using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRelarionshipBetweenClasses //переместить каждый класс в отдельный файл
{//обобщение -наследование
    public  class Man 
    {
        protected string name;
        protected string surname;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new AccessViolationException(
                        $"{nameof(value)} should not be zero");
                }
                this.name = value;
            }
        }
        public string Surname
        {
            get { return this.surname;}
            set
            {
                if (value == null)
                {
                    throw new AccessViolationException("value");
                }
                this.surname = value;
            }
        }

    }




}
