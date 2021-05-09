using ContactManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact obj1 = new Contact(1, "Raslene", "Khemiri","Jendouba", "khemiri.raslene@gmail.com", "21572965");
            Contact obj2 = new Contact(2, "Iheb", "Khemiri", "Jendouba", "iheb.khemiri@gmail.com", "9901237650");

            obj1.ShowProperties();
            obj2.ShowProperties();

            //obj1.GetFullName();
            //obj2.GetFullName();
            
            Console.ReadKey();


        }
    }
}
