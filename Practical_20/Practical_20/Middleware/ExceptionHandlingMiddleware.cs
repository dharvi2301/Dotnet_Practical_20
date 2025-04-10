using Practical_20.Data;
using Practical_20.Models;
using Serilog;
using System.Net;
using System.Text.Json;

namespace Practical_20.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, ApplicationDbContext dbContext)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred.");
                await LogToDatabase(dbContext, ex);
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var result = JsonSerializer.Serialize(new { error = exception.Message });
            await context.Response.WriteAsync(result);
        }

        private async Task LogToDatabase(ApplicationDbContext dbContext, Exception ex)
        {
            var log = new AuditLog
            {
                Message = ex.Message,
                Level = "Error",
                Timestamp = DateTime.UtcNow
            };

            dbContext.AuditLogs.Add(log);
            await dbContext.SaveChangesAsync();
        }
    }
}
