using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
    }
}
