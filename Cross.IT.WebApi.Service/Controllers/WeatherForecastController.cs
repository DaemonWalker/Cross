using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cross.ILogic;
using Cross.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cross.IT.WebApi.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IAccountLogic accountService;

        public WeatherForecastController(IAccountLogic accountService)
        {
            this.accountService = accountService;
        }

        [HttpGet]
        public object Get()
        {
            return accountService.Login("", "");
        }
    }
}
