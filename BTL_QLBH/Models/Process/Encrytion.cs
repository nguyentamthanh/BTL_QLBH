﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace BTL_QLBH.Models
{
    public class Encrytion
    {
        public string PassWordEncrytion(string pass)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(),"MD5");
        }

    }
}