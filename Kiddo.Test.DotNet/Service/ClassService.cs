using Kiddo.Test.Dotnet.Models;
using Kiddo.Test.Dotnet.Repository;

namespace Kiddo.Test.Dotnet.Service
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;

        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public IEnumerable<Class> GetAllClasses()
        {
            return _classRepository.GetAllClasses();
        }

        public IEnumerable<Class> FilterClasses(string? keyword, string? classTypeName)
        {
            return _classRepository.FilterClasses(keyword, classTypeName);
        }
    }
}
