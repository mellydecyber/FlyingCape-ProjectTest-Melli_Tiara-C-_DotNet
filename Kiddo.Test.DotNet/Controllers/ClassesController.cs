using Kiddo.Test.Dotnet.Models;
using Kiddo.Test.Dotnet.Service;
using Microsoft.AspNetCore.Mvc;

namespace Kiddo.Test.Dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassesController(IClassService ClassService)
        {
            _classService = ClassService;
        }

        [HttpGet]
        public IEnumerable<Class> GetAllClasses()
        {
            return _classService.GetAllClasses();
        }

        [HttpGet("filter")]
        public IEnumerable<Class> FilterClasses([FromQuery] string? keyword, [FromQuery] string? type)
        {
            return _classService.FilterClasses(keyword, type);
        }
    }
}
