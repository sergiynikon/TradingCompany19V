using System.Collections.Generic;
using DAL.Interfaces;
using Database;
using DTO;
using AutoMapper;
using System.Linq;

namespace DAL
{
    public class UserDAL : TradingCompany19Entities, IUserDAL
    {
        readonly IMapper _mapper;
        public UserDAL()
        {
            var config = new MapperConfiguration(c => c.AddProfiles(typeof(UserDAL)));
            _mapper = config.CreateMapper();
        }

        public int AddUser(UserDTO user)
        {
            UserDAL db = new UserDAL();

            var newuser = _mapper.Map<UserDTO>(db.tblUsers.Add(_mapper.Map<tblUser>(user)));
            db.SaveChanges();

            return newuser.ID;
        }

        public UserDTO ValidateLogin(string login, string password)
        {
            using (var db = new UserDAL())
            {
                var user = db.tblUsers.Where(u => u.Login == login).FirstOrDefault(u => u.IsOrderManager == true);
                if (user != null && user.Password == password)
                {
                    return _mapper.Map<UserDTO>(user);
                }
                return null;
            }
        }
    }
}
