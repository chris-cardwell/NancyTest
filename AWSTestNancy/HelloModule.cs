using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace AWSTestNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}