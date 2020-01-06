using Cross.ILogic;
using Cross.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Blazor.Data
{
    public class LogApi
    {
        private readonly IAccountLogic _accountLogic;
        public LogApi(IAccountLogic accountLogic)
        {
            this._accountLogic = accountLogic;
        }
    }
}
