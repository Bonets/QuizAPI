using System.Net;

namespace QuizAPI.Core
{
    public class ServiceResult
    {
        public List<ResponseMessage> ResponseMessages { get; set; }
        public List<ErrorMessage> ErrorMessages { get; set; } = new List<ErrorMessage>();
        public bool Success
        {
            get
            {
                return !ErrorMessages.Any();
            }
        }
        public HttpStatusCode HttpStatusCode { get; set; } = HttpStatusCode.OK;

    }

    public class ServiceResult<T> : ServiceResult
    {
        [Newtonsoft.Json.JsonIgnore]
        public Type ResponseDataType { get; set; }
        public T ResponseData { get; set; }
        public ServiceResult()
        {
            ResponseDataType = typeof(T);
        }

        public ServiceResult<T> BadRequestResult(string message)
        {
            HttpStatusCode = HttpStatusCode.BadRequest;
            ErrorMessages.Add(new ErrorMessage
            {
                ErrorType = ErrorType.Error,
                Message = message
            });
            return this;
        }
        public ServiceResult<T> NotFoundResult(string message = "Risorsa non trovata")
        {
            HttpStatusCode = HttpStatusCode.NotFound;
            ErrorMessages.Add(new ErrorMessage
            {
                ErrorType = ErrorType.Error,
                Message = message
            });
            return this;
        }
        public ServiceResult<T> ExceptionResult(string message = "Si è verificato un errore")
        {
            HttpStatusCode = HttpStatusCode.InternalServerError;
            ErrorMessages.Add(new ErrorMessage
            {
                ErrorType = ErrorType.Error,
                Message = message
            });
            return this;
        }
    }

    public class ResponseMessage
    {
        public ErrorType ErrorType = ErrorType.Info;
        public string Message { get; set; }
    }
    public class ErrorMessage
    {
        public ErrorType ErrorType { get; set; }
        public string Message { get; set; }
    }


    public enum ErrorType
    {
        Success,
        Warning,
        Error,
        Info
    }
}
