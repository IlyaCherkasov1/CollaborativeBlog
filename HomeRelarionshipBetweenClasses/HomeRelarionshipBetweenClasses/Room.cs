using System;

namespace HomeRelarionshipBetweenClasses //переместить каждый класс в отдельный файл
{//обобщение -наследование
    public class Room 
    {
        int number;
        public Room(int n) 
        {
            number =  n;
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
    }

    

   
}
