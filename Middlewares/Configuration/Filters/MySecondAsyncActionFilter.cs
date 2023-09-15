using Microsoft.AspNetCore.Mvc.Filters;

namespace Middlewares.Configuration.Filters
{
    public class MySecondAsyncActionFilter : Attribute ,  IAsyncActionFilter
    {
        private readonly string _calerName;
        public MySecondAsyncActionFilter(string calername)
        {
            _calerName = calername;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"{_calerName}-async filter :during excutione ");
            await next();
            Console.WriteLine($"{_calerName}-async filter :after excutione ");
        }
    }
}
