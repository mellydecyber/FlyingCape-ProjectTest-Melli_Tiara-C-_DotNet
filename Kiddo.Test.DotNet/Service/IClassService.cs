using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Service
{
    public interface IClassService
    {
        IEnumerable<Class> GetAllClasses();
        IEnumerable<Class> FilterClasses(string? keyword, string? type);
    }
}
