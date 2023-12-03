using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Service
{
    public interface IPartnerService
    {
        IEnumerable<Partner> GetAllPartner();
        IEnumerable<Partner> FilterPartner(string? keyword);
    }
}
