using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class qty : ControllerBase
    {
        private readonly ILogger<qty> _logger;

        public qty(ILogger<qty> logger)
        {
            _logger = logger;
        }

        [HttpGet]
      public string Get(string me)
        {

            var url = "";
            var client = new WebClient();
            url = "https://localhost:44373/quantity?me="+me;
            string temp = "";
            string response = client.DownloadString(url);
            if (!string.IsNullOrEmpty(response))
            {

                temp = response.ToString();
                return temp;

            }
            return "0";     
        }

    }


    [ApiController]
    [Route("[controller]")]
    public class price : ControllerBase
    {
   
        private readonly ILogger<price> _logger;

        public price(ILogger<price> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(string me)
        {

            var url = "";
            var client = new WebClient();
            url = "https://localhost:44376/price?me=" + me;
            string temp = "";
            string response = client.DownloadString(url);
            if (!string.IsNullOrEmpty(response))
            {

                temp = response.ToString();
                return temp;

            }
            return "0";
        }
    }
}
