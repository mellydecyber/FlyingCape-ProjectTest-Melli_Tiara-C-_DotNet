using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Service
{
    public interface IClassService
    {
        IEnumerable<ClassPartner> GetAllClasses();
        IEnumerable<ClassPartner> FilterClasses(string? keyword, string? classTypeName);
    }
}
