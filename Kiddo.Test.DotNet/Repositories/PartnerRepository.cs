using System.Text.Json;
using Kiddo.Test.Dotnet.Models;

namespace Kiddo.Test.Dotnet.Repository
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly string _jsonFilePath;

        public PartnerRepository(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
        }

        public IEnumerable<ClassPartner> GetAllPartner()
        {
            string jsonContent = File.ReadAllText(_jsonFilePath);
            List<ClassPartner>? classPartners = JsonSerializer.Deserialize<List<ClassPartner>>(jsonContent);

            return classPartners ?? new List<ClassPartner>();
        }

        public IEnumerable<ClassPartner> FilterPartner(string? keyword)
        {
            IEnumerable<ClassPartner> allPartner = GetAllPartner();

            if (!string.IsNullOrEmpty(keyword))
            {
                allPartner = allPartner.Where(c =>
                    c.SchoolName.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            return allPartner;
        }
    }
}
