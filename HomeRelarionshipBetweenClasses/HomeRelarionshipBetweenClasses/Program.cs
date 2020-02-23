using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRelarionshipBetweenClasses //отдел кадров
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Employee sysEngineer = new Employee("Александр" ,"Крылов", "Мэнеджер");    
            IdCard card = new IdCard(12);
            card.DateExpire = new DateTime(2020, 3, 1, 7, 0, 0); 
            sysEngineer.setIdCard(card); 
            Room room101 = new Room(123);
            Room room321 = new Room(321);
            sysEngineer.setRoom(room101);
            sysEngineer.setRoom(room321);
            sysEngineer.Mpost(sysEngineer);
            sysEngineer.Certificate(sysEngineer);
            sysEngineer.iter(sysEngineer);
            Departament programmerDepartament = new Departament("Программисты");
            programmerDepartament.addEmployee(sysEngineer);
            sysEngineer.setDepartment(programmerDepartament);
            PastPosition ps = new PastPosition("Сторож", programmerDepartament);
            sysEngineer.setPosition("инженер");
            sysEngineer.SetPastPosition(ps);
            sysEngineer.Iterator(sysEngineer);
            Employee director = new Employee("Вася", "Пупкин", "Директор");
            Menu menu = new Menu();
            Employee[] employees = new Employee[10];
            employees[0] = sysEngineer;
            employees[1] = director;
            Console.ReadKey();
            Menu.showEmployees(employees);
            Console.ReadKey();

        }
    }
}