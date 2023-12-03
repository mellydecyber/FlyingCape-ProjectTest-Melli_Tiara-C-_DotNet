using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Repository
{
    public interface IPartnerRepository
    {
        IEnumerable<Partner> GetAllPartner();
        IEnumerable<Partner> FilterPartner(string? keyword);
    }
}
