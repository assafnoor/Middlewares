using Microsoft.AspNetCore.Mvc.Filters;

namespace Middlewares.Configuration.Filters
{
    public class MyActionFilter :Attribute , IActionFilter
    {
        private readonly string _name;
        public MyActionFilter( string name)
        {
            _name = name;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"{_name}-this filetr excuted on:OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"{_name}-this filetr excuted on:OnActionExecuting");
        }
    }
}
