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
            try
            {
                var findUser = _users.Any(x => x.Email == newUser.Email || x.PhoneNumber == newUser.PhoneNumber);
                if (findUser) return false;
                _users.Add(newUser);
                return DbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //18-24 yas arasında olanların listesi
        public List<User> GetAllAge() => _users.Where(x => x.Age > 18 && x.Age < 25).ToList();

        //Kullanıcı ıd sine göre üyeleri getirme
        public User GetUserById(User id) => _users.Find(id);

        public List<User> GetAll() => _users.ToList();

        //kullanıcı giriş kontrol
        public User CheckLogin(string emailOrPhone, string password)
        {
            try
            {
                var findUser = _users.FirstOrDefault(x => x.Email == emailOrPhone && x.Password == password);
                if (findUser != null)
                {
                    return findUser;
                }
                findUser = _users.FirstOrDefault(x => x.PhoneNumber == emailOrPhone && x.Password == password);
                return findUser;
            }
            catch
            {
                return null;
            }
        }

        //Silme
        public bool Delete(User user)
        {
            try
            {
                _users.Remove(user);
                return DbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //Update
        public bool Update(User user)
        {
            try
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
            catch
            {
                return false;
            }
        }

        //vücut kitle endex'ine göre kontrol
        public List<User> CheckBmi() => _users.Where(x => x.Bmi < 18.5).ToList();

    }
}
