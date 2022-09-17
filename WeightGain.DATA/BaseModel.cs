using System;

namespace WeightGain.DATA
{
    public class BaseModel
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public bool Gender { get; set; }
        public UserTypeEnum UserType { get; set; }

        public string FullName => $"{FirstName} {LastName}";

    }
}
