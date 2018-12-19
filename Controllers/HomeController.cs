using System;
using Microsoft.AspNetCore.Mvc;

namespace ProductCatalog.Controllers
{
    public class HomeController
    {
        [HttpGet]
        [Route("")]
        public object Get() => new { version = "Version 0.0.2" };

        [HttpGet]
        [Route("error")]
        public string Error() => throw new Exception("Algum erro ocorreu");
    }
}