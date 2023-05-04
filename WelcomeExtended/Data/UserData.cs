using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        List<User> _user;
        int _nextId;

        public UserData() 
        {
            _user = new List<User>;
            _nextId = 0;    
        }

        public void AddUser(User user) 
        {
            user.Id = _nextId++;    
            _user.Add(user);    
        }

        public void DeleteUser(User user) 
        {
            _user.Remove(user); 
        }

        public void ValidateUser(string name, string password) 
        {
            foreach (var user in _user)
            {
                if (user.Name == name && user.Password == password) 
                {
                    return true;
                }
            }
            return false;   
        }

        public bool ValidateUserLambda(string name, string password) 
        {
            return _user.Where(x => x.Name == name && x.Password == password)
                .FirtsOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password) 
        {
            var ret = from user in _user
                      where user.Name == name && user.Password == password
                      select user.Id;
            return ret != null ? true : false; 
        }

        public User GetUser(string password) 
        {
            foreach (var user in _user)
            {
                if (user.Password == password)
                {
                    return user;
                }
            }
        }

        public void SetActive(string name)
        {
            foreach (var user in _user)
            {
                if (user.Password == password)
                {
                    return user;
                }
            }
        }

        public void AssignUserRole(string name, UserRolesEnum role)
        {
            foreach (var user in _user)
            {
                if (user.Name == name)
                {
                    user.Role = role;
                }
            }
        }

    }
}
