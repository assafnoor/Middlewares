using Microsoft.AspNetCore.Mvc.Filters;

namespace Middlewares.Configuration.Filters
{
    public class MyFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"this filetr excuted on:OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
           Console.WriteLine($"this filetr excuted on:OnActionExecuting");
        }
    }
}
