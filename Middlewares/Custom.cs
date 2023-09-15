namespace Middlewares
{
    public class Custom
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public Custom(RequestDelegate next, ILogger<String> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("custom");
            await _next(context);
            _logger.LogInformation("custom2");
        } 
    }
}
