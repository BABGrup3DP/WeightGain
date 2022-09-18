using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class UserRepository
    {
        WeightGainContext dbcontext;
        public UserRepository()
        {
            dbcontext=new WeightGainContext();
        }

        //benzer üyelik var mı ve sonrasında ekleme
        public bool Insert(User newUser)
        {
            var findUser = dbcontext.Users.Any(x => x.Email == newUser.Email || x.PhoneNumber == newUser.PhoneNumber);
            if (findUser) return false;
            dbcontext.Users.Add(newUser);
            return dbcontext.SaveChanges() > 0;
        }


        //18-24 yas arasında olanların listesi
        public List<User> GetAllAge()
        {
            return dbcontext.Users.Where(x=>x.Age > 18 && x.Age<25).ToList();
        }
        //Kullanıcı ıd sine göre üyeleri getirme

        public User GetUserById(User ID)
        {
            return dbcontext.Users.Find(ID);
        }
        //kullanıcı giriş kontrol
        public  User CheckLogin(string email,string Phone)
        {
            User user = dbcontext.Users.Where(x => x.Email == email || x.PhoneNumber == Phone).SingleOrDefault();
            return null;
        }

        //Silme
        public bool Delete (User ID)
        {
            dbcontext.Users.Remove(ID);
            return dbcontext.SaveChanges()>0;
        }
        //Update
        public bool Update(User email)
        {
            return dbcontext.SaveChanges() > 0;
        }
        //vücut kitle endex'ine göre kontrol
        public  List<User> CheckEndex()
        {
            return dbcontext.Users.Where(x => x.Endex<18.5).ToList();
        }


    }
}
