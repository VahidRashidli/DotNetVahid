﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC
{
    public class AboutController:Controller
    {
        public string Index()
        {
            return "Bizim Haqqimizda";
        }
    }
}
