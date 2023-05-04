using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Helpers
{
    static class UserHelper
    {
        public statis ToString(this User user) 
        {
        
        }
        public statis ValidateCredentials(this User user)
        {
            if (user.Name == null && user.Password) 
            { 
                //error :)
            }
            ValidateUser();

        }
        public statis GetUser(this User user)
        {
            GetUser(user);  
        }
    }
}
