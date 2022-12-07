using Microsoft.AspNetCore.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRateLimiter(o =>
{
    o.AddFixedWindowLimiter("fixed", options =>
    {
        options.PermitLimit = 4;
        options.Window = TimeSpan.FromMinutes(1);
    });
});

var app = builder.Build();

app.UseRateLimiter();

app.MapGet("/", () => Results.Ok($"Hello World at { DateTime.Now.ToLongTimeString() }")).RequireRateLimiting("fixed");

app.Run();
