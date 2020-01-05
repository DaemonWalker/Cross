using Cross.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Blazor.Data
{
    public class LogApi
    {
        private readonly IAccountService _accountService;
        public LogApi(IAccountService accountService)
        {
            this._accountService = accountService;
        }
    }
}
