﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webgentle.BookStore.Controller
{
    public class HomeController:ControllerBase
    {
        public string Index()
        {
            return "Web Gentle";
        }
    }
}
