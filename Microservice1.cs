using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace micrpService1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PriceController : ControllerBase
    {

        private readonly ILogger<PriceController> _logger;

        public PriceController(ILogger<PriceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(string me)
        {

            if (me == null)
                me = "1";

            if ( me.Equals("1"))
                return "100 AUD";
            if (me.Equals("2"))
                return "200 AUD";
            if (me.Equals("3"))
                return "300 AUD";
            else
                return "WRONG PRODUCT";
        }
    }
}
