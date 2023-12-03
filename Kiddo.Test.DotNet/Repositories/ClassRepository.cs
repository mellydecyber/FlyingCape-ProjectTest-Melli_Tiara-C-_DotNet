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

        public IEnumerable<ClassPartner> GetAllClasses()
        {
            string jsonContent = File.ReadAllText(_jsonFilePath);
            List<ClassPartner>? classPartners = JsonSerializer.Deserialize<List<ClassPartner>>(jsonContent);

            return classPartners ?? new List<ClassPartner>();
        }

        public IEnumerable<ClassPartner> FilterClasses(string? keyword, string? classTypeName)
        {
            IEnumerable<ClassPartner> allClasses = GetAllClasses();

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
