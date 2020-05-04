using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace laba27
{
   public class Sale
    {
        public Medecine Medecine { get; set; }
        public int Count { get; set; }
        public DateTime SaleDate { get; set; }
        public int Discount { get; set; }
        public int Id { get; set; }

        public Sale(Medecine medecine, int count, DateTime saleDate, int discount,int id)
        {
            Id = id;
            Medecine = medecine;
            Count = count;
            SaleDate = saleDate;
            Discount = discount;
        }
    }
}
