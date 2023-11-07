namespace Tasks
{
    public static class MiddlewareExtentionMethod
    {
        public static IApplicationBuilder UseTaskMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TaskMiddleware>();
        }
    }
}
