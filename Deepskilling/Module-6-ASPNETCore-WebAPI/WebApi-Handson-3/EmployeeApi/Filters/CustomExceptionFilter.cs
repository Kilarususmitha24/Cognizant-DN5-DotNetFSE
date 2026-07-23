using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeApi.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        private readonly string logFile = "Logs/ErrorLog.txt";

        public override void OnException(ExceptionContext context)
        {
            Directory.CreateDirectory("Logs");

            File.AppendAllText(
                logFile,
                $"[{DateTime.Now}] {context.Exception.Message}{Environment.NewLine}"
            );

            context.Result = new ObjectResult(new
            {
                Message = "An unexpected error occurred."
            })
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}
