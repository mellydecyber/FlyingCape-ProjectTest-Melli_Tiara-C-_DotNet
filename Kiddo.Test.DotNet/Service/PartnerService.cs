using Kiddo.Test.Dotnet.Models;
using Kiddo.Test.Dotnet.Repository;

namespace Kiddo.Test.Dotnet.Service
{
    public class PartnerService : IPartnerService
    {
        private readonly IPartnerRepository _partnerRepository;

        public PartnerService(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        public IEnumerable<ClassPartner> GetAllPartner()
        {
            return _partnerRepository.GetAllPartner();
        }

        public IEnumerable<ClassPartner> FilterPartner(string? keyword)
        {
            return _partnerRepository.FilterPartner(keyword);
        }
    }
}
