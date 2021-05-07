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
        /// Tel.
        /// </summary>
        public string Tel { get; set; }

    }
}
