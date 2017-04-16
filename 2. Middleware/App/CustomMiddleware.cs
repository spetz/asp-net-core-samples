using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace App
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine($"Invoking custom middleware, path: {httpContext.Request.Path}.");
            await _next.Invoke(httpContext);
        }
    }
}