using Microsoft.AspNetCore.Mvc.Filters;

namespace Middlewares.Configuration.Filters
{
    public class MyAsyncActionFilter : Attribute ,  IAsyncActionFilter , IOrderedFilter
    {
        private readonly string _calerName;
        public int Order { get; set; }  
        public MyAsyncActionFilter(string calername,int order=0)
        {
            _calerName = calername;
            Order = order;
        }

     

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"{_calerName}-async filter :during excutione ");
            await next();
            Console.WriteLine($"{_calerName}-async filter :after excutione ");
        }
    }
}
