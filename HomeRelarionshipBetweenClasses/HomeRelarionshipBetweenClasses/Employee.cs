using System;
using System.Collections.Generic;
using System.Collections;

namespace HomeRelarionshipBetweenClasses 
{
    public class Employee : Man, IEnumerable
    {
        string position;
        IdCard iCard; //бинарная ассоциация
        private Departament departament;
        HashSet<Room> room = new HashSet<Room>(); // int - Set     
        HashSet<PastPosition> pastPositions = new HashSet<PastPosition>();
        public Employee(string n, string s, string p)
        {
            name = n;
            surname = s;
            position = p;
        }
        public string Position
        {
            get { return this.position; }
            set
            {
                if (value == null)
                {
                    throw new AccessViolationException("value");
                }
                this.position = value;
            }
        }
        public IdCard GetIdCard//
        {
            get { return this.iCard; }
        }
        public void setIdCard(IdCard c)
        {
            iCard = c;
        }
        

        public void setRoom(Room newRoom)
        {
            room.Add(newRoom);
        }

        public void deleteRoom(Room r)
        {
            room.Remove(r);
        }
        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Может находиться в помещениях:");
            foreach (Room i in room)
            {
                yield return i.Number;
            }
          
        }
        public void setPosition(string newProfession)
        {
            position = newProfession;
        }
        public String getPosition()
        {
            return position;
        }

        public void setDepartment(Departament d)
        {
            departament = d;
        }
        public Departament getDepartment
        {
            get { return this.departament; }
        }

        public void SetPastPosition(PastPosition p)
        {
            pastPositions.Add(p);
        }
  
        public IEnumerator GetPastPosition()
        {
            Console.WriteLine("В прошлом работал как:");
            foreach (PastPosition i in pastPositions)
            {
                yield return i.getName();
            }
        }
        public void deletePastPosition(PastPosition p)
        {
            pastPositions.Remove(p);
        }

        public void Mpost(Employee sysEngineer)
        {
            Console.WriteLine(sysEngineer.Name + " Работает в должности " + sysEngineer.Position);
        }      
        public void Certificate(Employee sysEngineer)
        {
            Console.WriteLine("Удостоверение действует до " + sysEngineer.GetIdCard.DateExpire);
        }
        public void DepartamentName(Employee sysEngineer)
        {
            Console.WriteLine("относится к отделу: " + sysEngineer.getDepartment.Name);
        }
        public void Iterator(Employee sysEngineer)
        {
            IEnumerator enumerator = sysEngineer.GetPastPosition();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void iter(Employee sysEngineer)
        {
            IEnumerator en = sysEngineer.GetEnumerator();
            while (en.MoveNext())
            {
                Console.Write(en.Current + " ");
            }
            Console.WriteLine();
        }
    }




}
