 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryUP8
{
    /// <summary>
    /// structor for Employee
    /// </summary>
    public struct Employee
    {
        /// <summary>
        /// constructor Employee
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="service"></param>
        public Employee(string surname, string service)
        {
            Surname = surname;
            Service = service;
        }
        /// <summary>
        /// main property
        /// </summary>
        public string Surname { get ; set; }
        public string Service { get ; set; }
        /// <summary>
        /// display info employree
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"surname = {Surname} service = {Service}");
        }
    }
}
