using MapGroup.WebApp.Routes;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGroup("/todos").MapTodos();

app.Run();
