using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace forecast.Controllers
{
    [Route("api/[controller]")]
    public class StaticFileController : Controller
    {
        [HttpGet("[action]")]
        public String[] List()
        {
            return Directory.GetDirectories(Directory.GetCurrentDirectory());
        }

        [HttpGet("js")]
        public String GetJs()
        {
            // Ok, where am I?
            var inDev = Directory.GetDirectories(Directory.GetCurrentDirectory()).Any(dir => dir.EndsWith("bin"));
            var clientAppDirName = Directory.GetDirectories(Directory.GetCurrentDirectory()).SingleOrDefault(dir => dir.Contains("ClientApp"));
            var clientAppDir = Directory.GetDirectories(clientAppDirName);
            var currentDirectory = Directory.GetCurrentDirectory();
            var fileName = currentDirectory + "/bin/";
            return "js";
        }
    }
}