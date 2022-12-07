namespace MapGroup.WebApp.Routes
{
    public static class TodoRoutes
    {
        public static RouteGroupBuilder MapTodos(this RouteGroupBuilder builder)
        {
            builder.MapGet("/", GetTodos);

            return builder;
        }

        public static IResult GetTodos()
        {
            return TypedResults.Ok("Hello World !!");
        }
    }
}
