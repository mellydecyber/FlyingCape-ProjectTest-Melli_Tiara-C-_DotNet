using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Repository
{
    public interface IPartnerRepository
    {
        IEnumerable<ClassPartner> GetAllPartner();
        IEnumerable<ClassPartner> FilterPartner(string? keyword);
    }
}
