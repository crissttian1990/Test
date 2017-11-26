using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WhoozatAPI.Middlewares
{
    public class CustonMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly WhoozatConfiguration _myConfig;
        public CustonMiddleware(RequestDelegate next, IOptions<WhoozatConfiguration> myConfig)
        {
            _next = next;
            _myConfig = myConfig.Value;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Debug.WriteLine($" ----> Request asked for {httpContext.Request.Path} from version {_myConfig.Version}");

            //  Call the next middleware delegate in the pipeline
            await _next.Invoke(httpContext);
        }
    }
}
