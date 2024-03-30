using StoreProject.Domain.Common;

namespace StoreProject.Domain.Entities
{
    public class Ward : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }

    }
}
