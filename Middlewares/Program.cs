using Middlewares;
using Middlewares.Configuration.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add(new MyFilter());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello world!");
//});


//app.Use(async (context, next) =>
//{

//    // Do work that can write to the Response.
//    await next.Invoke();
//    // Do logging or other work that doesn't write to the Response.
//});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello from 2nd delegate.");
//});


//app.Map("/map1", HandleMapTest1);

//app.Map("/map2", HandleMapTest2);


//app.UseMiddleware<Custom>();


//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello world!");

//});



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//static void HandleMapTest1(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Map Test 1");
//    });
//}

//static void HandleMapTest2(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Map Test 2");
//    });
//}