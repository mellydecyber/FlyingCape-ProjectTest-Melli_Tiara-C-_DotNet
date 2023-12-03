using System.Text.Json;
using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Repository
{
    public class ClassRepository : IClassRepository
    {
        private readonly string _jsonFilePath;

        public ClassRepository(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
        }

        public IEnumerable<Class> GetAllClasses()
        {
            string jsonContent = File.ReadAllText(_jsonFilePath);
            List<Class>? Partners = JsonSerializer.Deserialize<List<Class>>(jsonContent);

            return Partners ?? new List<Class>();
        }

        public IEnumerable<Class> FilterClasses(string? keyword, string? classTypeName)
        {
            IEnumerable<Class> allClasses = GetAllClasses();

            if (!string.IsNullOrEmpty(keyword))
            {
                allClasses = allClasses.Where(c =>
                    c.ClassName.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(classTypeName))
            {
                // Filter by ClassTypeName
                allClasses = allClasses.Where(c =>
                    c.ClassTypeName != null &&
                    c.ClassTypeName.Equals(classTypeName, StringComparison.OrdinalIgnoreCase));
            }

            return allClasses;
        }
    }
}
