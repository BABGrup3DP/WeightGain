using System;

namespace WeightGain.DATA
{
    public class BaseModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public UserTypeEnum UserType { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public byte Age => (byte)(DateTime.Now.Year - BirthDate.Year);

    }
}
