using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var Empl = new Employee[5];
            Empl[0] = new Employee("Horold", "Smith", "Willimson", postEnum.Director, 20, 15000);
            Empl[1] = new Employee("Marlin", "Brown", "Wilson", postEnum.tester, 3, 8000);
            Empl[2] = new Employee("Luis", "Walke", "Adams", postEnum.Director, 10, 10000);
            Empl[3] = new Employee("Nicholas", "Brown", "Nuels", postEnum.programmer, 15, 13000);
            Empl[4] = new Employee("Horry", "Smith", "Dingles", postEnum.tester, 20, 1000);



            Console.WriteLine("1)Вывод на экран массива структур; ");
            Console.WriteLine("2)Вывести количество однофамильцев по каждой фамилии");
            Console.WriteLine("3)Вывести общую заработную плату по каждой должности");
            Console.WriteLine("4)Выход. ");


            while (true)

            {
                char item =Convert.ToChar(Console.ReadLine());
        
             //     var  item  = Console.ReadKey().KeyChar;
                switch (item)
                {
                    case '1':
                        foreach (Employee i in Empl)
                        {
                            i.DisplayInfo();
                        }
                        break;
                    case '2':
                        NameSake(Empl);

                        break;
                    case '3':
                        Wage(Empl);
                        Console.WriteLine();
                        break;
                    case '4':
                        Environment.Exit(0);

                        break;

                      
                    default:
                        Console.WriteLine("default");
                
                        break;
                }
            }
         
        }
        public static void NameSake(Employee[] Empl)

        {
            int count = 0;
            int i = 10;


            for (int k = 0; k < Empl.Length; k++)
            {


                for (int j = 0; j < Empl.Length; j++)
                {
                    if (Empl[k].surname == Empl[j].surname)
                    {
                        if (k > j)
                        {
                            i = j;

                            break;
                        }

                        count++;
                    }
                }
                if (k < i)
                    Console.WriteLine($"   {Empl[k].surname} = {count}");
                count = 0;
            }


        

    }
        
        public static void Wage(Employee[] Empl)
        {
            int average = 0;
            int SumSalary = 0;
            int  CountSpeciality = 0;
          
            var CheckContain = Enum.GetValues(typeof(postEnum)).Cast<postEnum>().ToList(); //create list without anouther enum
            CheckContain.Clear();
            for (int i=0; i<Empl.Length;i++ )
            {

                for (int j = 0; j < Empl.Length; j++)
                {
                    if(Empl[i].Post== Empl[j].Post)
                    {
                        SumSalary += Empl[j].salary;
                        CountSpeciality++;
                    }
       
                }
                average = SumSalary / CountSpeciality;
                if (!CheckContain.Contains(Empl[i].Post))
                {
                    Console.WriteLine($" Средняя зарплаты {Empl[i].Post} = {average}");
                }
                CheckContain.Add(Empl[i].Post);
                CountSpeciality = 0;
                average = 0;
                SumSalary = 0;
            }
        }
    }
}
