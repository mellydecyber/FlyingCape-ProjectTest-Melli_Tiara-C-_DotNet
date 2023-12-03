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

        public IEnumerable<Partner> GetAllPartner()
        {
            string jsonContent = File.ReadAllText(_jsonFilePath);
            List<Partner>? Partners = JsonSerializer.Deserialize<List<Partner>>(jsonContent);

            return Partners ?? new List<Partner>();
        }

        public IEnumerable<Partner> FilterPartner(string? keyword)
        {
            IEnumerable<Partner> allPartner = GetAllPartner();

            if (!string.IsNullOrEmpty(keyword))
            {
                allPartner = allPartner.Where(c =>
                    c.SchoolName.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            return allPartner;
        }
    }
}
