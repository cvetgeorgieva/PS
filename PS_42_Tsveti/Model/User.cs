using PS_42_Tsveti.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_42_Tsveti.Model
{
    internal class User
    {
        private string _name;
        private string _pass;
        public UserRolesEnum Role;

        public string Name {
            get { return _name; }
            set { _name = value; } }
        public string Password {
            get { return _pass; }
            set { _pass = value; }
        } 
    }
}
