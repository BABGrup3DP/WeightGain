using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightGain.DATA
{
    public class Base
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public string email { get; set; }

        public string PhoneNumber { get; set; }

        public bool Gender { get; set; }

        public string Fullname { get { return FirstName + " " + LastName; } }

  


    }
}
