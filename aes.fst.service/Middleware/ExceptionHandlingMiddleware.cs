namespace aes.fst.service.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHandlingMiddleware> logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            this.logger = logger;
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (InvalidOperationException e)
            {
                logger.LogError(e, e.Message);
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync(e.Message);
            }
            catch (Exception e)
            {
                logger.LogError(e, e.Message);
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync(e.Message);
            }
        }
    }
}
