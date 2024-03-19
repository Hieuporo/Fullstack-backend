//using Microsoft.AspNetCore.Http;
//using StoreProject.Domain.Constants;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreProject.Application.Exceptions
//{
//    public class ExceptionHelper
//    {
//        public async Task HandleExceptionAsync(HttpContext context, Exception exception)
//        {
//            string message;
//            string? title;
//            int statusCode = (int)HttpStatusCode.InternalServerError;
//            object? errorDetail = null;

//            switch (exception)
//            {
//                case BadRequestException:
//                    var myCustomException = (BadRequestException)exception;
//                    title = "EXCEPTION.TOKEN_EXPIRED";
//                    message = myCustomException.Message;
//                    statusCode = (int)HttpStatusCode.BadRequest;
//                    errorDetail = myCustomException.Details;
//                    context.Response.Headers.Add(ExceptionUtil.ResponseHeaders.TOKEN_EXPIRED, "false");
//                    break;

//                case SecurityTokenExpiredException:
//                    title = "EXCEPTION.TOKEN_EXPIRED";
//                    message = "EXCEPTION.PLEASE_RELOGIN";
//                    statusCode = (int)HttpStatusCode.Unauthorized;
//                    context.Response.Headers.Add(ExceptionUtil.ResponseHeaders.TOKEN_EXPIRED, "true");
//                    break;

//                default:
//                    title = "EXCEPTION.AN_ERROR_OCCURRED";
//                    message = "EXCEPTION.PLEASE_CONTACT_YOUR_SYSTEM_ADMINISTRATOR";
//                    statusCode = (int)HttpStatusCode.InternalServerError;
//                    errorDetail = new
//                    {
//                        Source = "Core Base",
//                        ExceptionMessage = exception.Message,
//                        InnerExceptionMessage = exception.InnerException != null ? exception.InnerException.Message : "",
//                        exception.StackTrace
//                    };
//                    context.Response.Headers.Add(ExceptionUtil.ResponseHeaders.TOKEN_EXPIRED, "false");
//                    break;
//            }

//            context.Response.ContentType = "application/json";
//            context.Response.StatusCode = statusCode;
//            message = string.IsNullOrEmpty(message) ? "" : message;
//            title = string.IsNullOrEmpty(title) ? "" : title;
//            await context.Response.WriteAsync(new ErrorDetails()
//            {
//                Title = title,
//                Message = message,
//                Details = errorDetail
//            }.ToString());
//        }
//    }
//}
