using Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager um = new UserManager();
            um.RegisterUser(new Services.Models.RegisterModel() { Email = "tesst@da.bg", FirstName = "dd", LastName = "dd", Password = "Dd123dd!1", ConfirmPassword = "Dd123dd!1" });
        }
    }
}
