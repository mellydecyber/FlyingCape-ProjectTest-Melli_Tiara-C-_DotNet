using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Repository
{
    public interface IClassRepository
    {
        IEnumerable<Class> GetAllClasses();
        IEnumerable<Class> FilterClasses(string? keyword, string? classTypeName);
    }
}
