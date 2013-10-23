using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace AngularJsDateTimeTest.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index"];
            };

            Get["/stable"] = _ => {
                return View["stable"];
            };

            Get["/unstable"] = _ => {
                return View["unstable"];
            };

            Get["/now"] = _ => {
                var now = DateTime.Now;
                return Response.AsJson(new {time = now});
            };
        }
    }
}