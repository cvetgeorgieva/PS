using PS_42_Tsveti.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_42_Tsveti.View
{
    internal class UserView
    {
        private UserViewModel _viewModel;

        public UserView (UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display() {
            System.Console.WriteLine("Welcome");
            System.Console.WriteLine("User: " + _viewModel.Name);
            System.Console.WriteLine("Role: " + _viewModel.Role);
        }

        public void DisplayError()
        {
            throw new Exception("Error message");
        }
    }
}
