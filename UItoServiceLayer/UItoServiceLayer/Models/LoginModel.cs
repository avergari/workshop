﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UItoServiceLayer.Models
{
    public class LoginModel
    {

        public virtual string CompanyDB { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }

    }
}
