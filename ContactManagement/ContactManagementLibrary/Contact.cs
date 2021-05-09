using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementLibrary
{
    public class Contact
    {
        /// <summary>
        /// Contact ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Contact Tel.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Create a new object.
        /// </summary>
        /// <param name="id">Object ID.</param>
        /// <param name="firstName">First Name.</param>
        /// <param name="lastName">Last Name.</param>
        /// <param name="address">Address.</param>
        /// <param name="email">Email.</param>
        /// <param name="tel">Tel.</param>
        public Contact(int id, string firstName, string lastName, string address, string email, string tel)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            Tel = tel;

            if (id > 10)
            {
                ID = 0;
            }

            if (lastName == "")
            {
                LastName = "Anonym";
            }
        }

        public Contact()
        {

        }

        /// <summary>
        /// Shows all properties.
        /// </summary>
        public void ShowProperties()
        {
            Console.WriteLine("Contact Properties:");
            Console.WriteLine(ID);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Address);
            Console.WriteLine(Email);
            Console.WriteLine(Tel);
            Console.WriteLine();
        }

        /// <summary>
        /// Gets full name.
        /// </summary>
        public void GetFullName()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }
    }
}
