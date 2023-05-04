using PS_42_Tsveti.Model;
using PS_42_Tsveti.Others;
using PS_42_Tsveti.View;
using PS_42_Tsveti.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_42_Tsveti
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            User user = new User();
            user.Name = "Test"; 
            user.Password = "test";
            user.Role = Others.UserRolesEnum.STUDENT;
            UserViewModel userViewModel = new UserViewModel(user);
            UserView userView = new UserView(userViewModel);
            userView.Display();
            */

            using (var context = new DatabaseContext()) 
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Name = "user",
                    Password = "password",
                    Expire = DateTime.Now,
                    Role = UserRolesEnum.STUDENT
                });
                context.SaveChanges();
                var users = context.Users.ToList();
                Console.ReadKey();

            }
        }
    }
}