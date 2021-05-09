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
            Contact obj3 = new Contact(100, "Mouhib", "Khemiri", "Jendouba", "khemiri.mouhib@gmail.com", "54431465468");
            Contact obj4 = new Contact(200, "Radhia", "", "jendouba", "", "99001122");

            Contact obj5 = new Contact();

            obj1.ShowProperties();
            obj2.ShowProperties();
            obj3.ShowProperties();
            obj4.ShowProperties();
            obj5.ShowProperties();

            Console.ReadKey();


        }
    }
}
