using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    internal class Kund
    {
        public Kund(string name, string adress, int personNumber, int phoneNumber, string email)
        {
            Name = name;
            Adress = adress;
            PersonNumber = personNumber;
            PhoneNumber = phoneNumber;
            this.email = email;
        }

        public string Name { get; set; }
        public string Adress { get; set; }
        public int PersonNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string email { get; set; }

    }
}
