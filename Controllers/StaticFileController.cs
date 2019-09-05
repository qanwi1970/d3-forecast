using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using forecast.DTO;

namespace forecast.Controllers
{
    [Route("api/mfe")]
    public class StaticFileController : Controller
    {
        [HttpGet("js")]
        public FilepathDTO GetJs()
        {
            var rootDir = Directory.GetCurrentDirectory();
            var fullPath = Path.Combine(rootDir, "ClientApp", "build", "static", "js");
            if (!Directory.Exists(fullPath))
            {
                return new FilepathDTO("/static/js/bundle.js");
            }
            var jsFiles = Directory.GetFiles(fullPath);
            var jsFile = jsFiles.SingleOrDefault(file => file.EndsWith("js"));
            var jsFileName = Path.GetFileName(jsFile);
            return new FilepathDTO("/static/js/" + jsFileName);
        }

        [HttpGet("css")]
        public FilepathDTO GetCss()
        {
            var rootDir = Directory.GetCurrentDirectory();
            var fullPath = Path.Combine(rootDir, "ClientApp", "build", "static", "css");
            if (!Directory.Exists(fullPath))
            {
                return new FilepathDTO();
            }
            var jsFiles = Directory.GetFiles(fullPath);
            var jsFile = jsFiles.SingleOrDefault(file => file.EndsWith("css"));
            var jsFileName = Path.GetFileName(jsFile);
            return new FilepathDTO("/static/css/" + jsFileName);
        }
    }
}