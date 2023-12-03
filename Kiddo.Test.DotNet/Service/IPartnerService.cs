using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Service
{
    public interface IPartnerService
    {
        IEnumerable<ClassPartner> GetAllPartner();
        IEnumerable<ClassPartner> FilterPartner(string? keyword);
    }
}
