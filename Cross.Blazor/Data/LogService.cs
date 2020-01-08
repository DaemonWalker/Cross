using Cross.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Blazor.Data
{
    public class LogService: BaseService
    {
        private readonly IAccountLogic _accountLogic;
        public LogServicecs(IAccountLogic accountLogic)
        {
            this._accountLogic = accountLogic;
        }
    }
}
