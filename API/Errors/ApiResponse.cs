using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have mad",
                401 => "Autorized, you are not",
                404 => "response found, it was not",
                500 => "Error are the path to the dark side. Error lead to anger. Anger leads to hate. Hate leads to carrer change",
                _ => null
            };
        }
    }
}