﻿using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserManager
    {
        string RegisterUser(RegisterModel model);
        string LoginUser(LoginModel loginModel);
    }
}