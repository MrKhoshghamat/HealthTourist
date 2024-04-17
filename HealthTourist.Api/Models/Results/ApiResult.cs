using System.Net;

namespace HealthTourist.Api.Models.Results;

public class ApiResult<TMethod, TData, TResponse>
{
    public TMethod Method { get; set; }
    public bool IsSucceed { get; set; }
    public TResponse Response { get; set; }
    public TData Data { get; set; }
    public string ErrorMessage { get; set; }
    public HttpStatusCode HttpResponse { get; set; }
}