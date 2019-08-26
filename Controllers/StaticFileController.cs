using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using forecast.Models;

namespace forecast.Controllers
{
    [Route("api/mfe")]
    public class StaticFileController : Controller
    {
        [HttpGet("js")]
        public FilepathDTO GetJs()
        {
            var jsFiles = Directory.GetFiles("static/js");
            var jsFile = jsFiles.SingleOrDefault(dir => dir.EndsWith("js"));
            return new FilepathDTO(jsFile);
        }

        [HttpGet("css")]
        public FilepathDTO GetCss()
        {
            var jsFiles = Directory.GetFiles("static/css");
            var jsFile = jsFiles.SingleOrDefault(dir => dir.EndsWith("css"));
            return new FilepathDTO(jsFile);
        }
    }
}