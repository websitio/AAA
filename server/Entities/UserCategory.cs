using API.Entities;
using server.Entities.BaseEntities;

namespace server.Entities
{
    public class UserCategory : AuditBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AppUser AppUser { get; set; }
        public int? AppUserId { get; set; }

        public ICollection<CostAmount> CostAmounts { get; set; } =
        new List<CostAmount>();

    }
}
