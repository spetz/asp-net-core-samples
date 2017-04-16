using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace App.Filters
{
    public class ExceptionHandlerAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var error = new 
            {
                message = exception.Message
            };
            var result = new JsonResult(error);
            result.StatusCode = (int)HttpStatusCode.BadRequest;
            context.Result = result;
        }
    }
}