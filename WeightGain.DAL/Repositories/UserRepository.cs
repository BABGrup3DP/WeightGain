using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class UserRepository
    {
        protected readonly WeightGainContext DbContext;
        private readonly DbSet<User> _users;
        public UserRepository()
        {
            DbContext = new WeightGainContext();
            _users = DbContext.Set<User>();
        }

        //benzer üyelik var mı ve sonrasında ekleme
        public bool Insert(User newUser)
        {
            var findUser = _users.Any(x => x.Email == newUser.Email || x.PhoneNumber == newUser.PhoneNumber);
            if (findUser) return false;
            _users.Add(newUser);
            return DbContext.SaveChanges() > 0;
        }

        //18-24 yas arasında olanların listesi
        public List<User> GetAllAge()
        {
            return _users.Where(x => x.Age > 18 && x.Age < 25).ToList();
        }

        //Kullanıcı ıd sine göre üyeleri getirme
        public User GetUserById(User id)
        {
            return _users.Find(id);
        }

        //kullanıcı giriş kontrol
        public User CheckLogin(string emailOrPhone, string password)
        {
            var findUser = _users.FirstOrDefault(x => x.Email == emailOrPhone && x.Password == password);
            if (findUser != null)
            {
                return findUser;
            }
            findUser = _users.FirstOrDefault(x => x.PhoneNumber == emailOrPhone && x.Password == password);
            return findUser;
        }

        //Silme
        public bool Delete(User id)
        {
            _users.Remove(id);
            return DbContext.SaveChanges() > 0;
        }

        //Update
        public bool Update(User user)
        {
            var findUser = _users.Find(user.ID);
            if (findUser == null) return false;
            findUser.FirstName = user.FirstName;
            findUser.LastName = user.LastName;
            findUser.Email = user.Email;
            findUser.Password = user.Password;
            findUser.BirthDate = user.BirthDate;
            findUser.PhoneNumber = user.PhoneNumber;
            return DbContext.SaveChanges() > 0;
        }

        //vücut kitle endex'ine göre kontrol
        public List<User> CheckBmi()
        {
            return _users.Where(x => x.Bmi < 18.5).ToList();
        }


    }
}
