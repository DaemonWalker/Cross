using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Share
{
    public class ServiceInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
                invocation.ReturnValue = new { Data = invocation.ReturnValue, Result = 1 };
            }
            catch (Exception e)
            {
                invocation.ReturnValue = new { Data = e.Message, Result = 0 };
            }
        }
    }
}
