﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace StudentPortalWeb.Controllers
{
    public class HelloWorldController : Controller 
    {
        //GET: /Helloworld/
        public string Index()
        {
            return "This is my default action...";
        }
        

        // GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

    }
}
