using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store();
            st.OutputElement();
            //st.SupplyElement("samsung", 6);
         //   st.PurchaseElement("samsung",3);
            st.FindConsident("appleCompany", "5");


        }
    }
}
