using System;

namespace HomeRelarionshipBetweenClasses //переместить каждый класс в отдельный файл
{//обобщение -наследование
    public  class IdCard
    {
        DateTime dateExpire;
        int number;
        public IdCard(int n)
        {
            number = n;
        }
        public int Number
        {
            get { return this.number; }
            set
            {
                if (value < 0)
                {
                    throw new AccessViolationException();
                }
                this.number = value;
            }
        }
        public DateTime DateExpire
        {
            get { return this.dateExpire; }
            set
            {
                if (value == null)
                {
                    throw new AccessViolationException();
                }
                this.dateExpire = value;
            }
        }
    }

    

   
}
