﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Teste.Controllers
{
    public class TesteController:Controller
    {
        public string Ping() 
        {
            return "Pong";
        }

    }
}