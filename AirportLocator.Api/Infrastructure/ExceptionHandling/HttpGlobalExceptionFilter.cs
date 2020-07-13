using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AirportLocator.Api.Infrastructure.ExceptionHandling
{
    public class HttpGlobalExceptionFilter : IExceptionFilter
    {

        public HttpGlobalExceptionFilter()
        { }

        public void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult("An error has occured!");
            context.ExceptionHandled = true;
        }
    }
}
