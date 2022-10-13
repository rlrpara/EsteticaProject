using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using VendaFacil.Service.ViewModel.Entities;

namespace VendaFacil.Service.Middleware
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            ErrorResponseViewModel errorResponseViewModel;

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToLower().Equals("development"))
            {
                errorResponseViewModel = new ErrorResponseViewModel(HttpStatusCode.InternalServerError.ToString(),
                                             $"{ex.Message} {ex?.InnerException?.Message}");
            }
            else
            {
                errorResponseViewModel = new ErrorResponseViewModel(HttpStatusCode.InternalServerError.ToString(),
                                             "Erro interno no servidor;");
            }
            context.Response.StatusCode = ((int)HttpStatusCode.InternalServerError);

            var resultado = JsonConvert.SerializeObject(errorResponseViewModel);
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(resultado);
        }
    }
}
