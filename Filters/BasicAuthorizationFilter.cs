using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Filters
{
    public class BasicAuthorizationFilter : IAuthorizationFilter
    {
        private string password = "12345";
        private string username = "admin";
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.Filters.OfType<DisableBasicAuthorization>().Any())
            {
                return;
            }
            if (!context.HttpContext.Request.Headers.Keys.Contains(HeaderNames.Authorization))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            string header = context.HttpContext.Request.Headers[HeaderNames.Authorization];
            if (!header.Split(" ")[0].Equals("Basic"))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            string decodedAuthenticationToken =
                Encoding.UTF8.GetString(Convert.FromBase64String(header.Split(" ")[1]));
            string user = decodedAuthenticationToken.Split(":")[0];
            string pass = decodedAuthenticationToken.Split(":")[1];
            if (!username.Equals(user) || !password.Equals(pass))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
