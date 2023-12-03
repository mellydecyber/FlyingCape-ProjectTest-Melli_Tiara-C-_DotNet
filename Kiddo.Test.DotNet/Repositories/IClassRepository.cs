using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Repository
{
    public interface IClassRepository
    {
        IEnumerable<ClassPartner> GetAllClasses();
        IEnumerable<ClassPartner> FilterClasses(string? keyword, string? classTypeName);
    }
}
