using Data;
using Models;
using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class UserManager : IUserManager
    {
        private StoreDbContext context;


        public string LoginUser(LoginModel loginModel)
        {
            return " ";
        }

        public string RegisterUser(RegisterModel model)
        {
            using (context = new StoreDbContext())
            {
               Person user= context.People.Where(x => x.Email == model.Email).FirstOrDefault();
                if (user==null)
                {
                    Person person = new Person()
                    {
                        Email = model.Email,
                        Password = model.Password, // PasswordHash
                        FirstName = model.FirstName,
                        LastName = model.LastName
                    };
                 

                    return "ghghghg";
                }

            }
            return "";
        }
    }
}
