using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Filters
{
    class MiddlewareCounter { 
        
    private readonly RequestDelegate _next; 
    public MiddlewareCounter(RequestDelegate next)
     {
            _next = next; 
     }
        
    public async Task Invoke(HttpContext context)
    { 
    if (context.Request.Cookies.ContainsKey("COUNTER"))
    { string value;
    if (context.Request.Cookies.TryGetValue("COUNTER", out value))
    { 
    var counter = int.Parse(value) + 1;
    context.Response.Cookies.Append("COUNTER", counter.ToString());
     }
     } else { context.Response.Cookies.Append("COUNTER", "1");
         } 
   await _next(context); }
    
    }
}
