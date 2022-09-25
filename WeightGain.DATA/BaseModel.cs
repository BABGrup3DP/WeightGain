using System;

namespace WeightGain.DATA
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public UserTypeEnum UserType { get; set; }

    }
}
