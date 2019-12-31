using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Cross.Tests.Share
{
    public class CrossServiceCollection : List<ServiceDescriptor>, IServiceCollection
    {
    }
}
