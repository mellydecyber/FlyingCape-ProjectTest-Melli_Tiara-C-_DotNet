using Kiddo.Test.Dotnet.Models;
using Kiddo.Test.Dotnet.Service;
using Microsoft.AspNetCore.Mvc;

namespace Kiddo.Test.Dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerService _partnerService;

        public PartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpGet]
        public IEnumerable<Partner> GetAllPartner()
        {
            return _partnerService.GetAllPartner();
        }

        [HttpGet("filter")]
        public IEnumerable<Partner> FilterPartner([FromQuery] string? keyword)
        {
            return _partnerService.FilterPartner(keyword);
        }
    }
}
