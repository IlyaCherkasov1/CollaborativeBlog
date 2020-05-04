using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba26_PlugLevel
{
    class Medicine
    {
        string name;
        string producer;
        string substance;

        public Medicine(string name, string producer, string substance1)
        {
            Name = name;
            Producer = producer;
            Substance1 = substance1;
        }

        //public Medicine(SqlDataReader sqlDataReader)
        //{
        //    Name = sqlDataReader.GetName(0);
        //    Producer = sqlDataReader.GetName(1);
        //    Substance1 = sqlDataReader.GetName(2);
        //}

        public string Name { get => name; set => name = value; }
        public string Producer { get => producer; set => producer = value; }
        public string Substance1 { get => substance; set => substance = value; }


    }
}
