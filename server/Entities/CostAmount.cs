using server.Entities.BaseEntities;

namespace server.Entities
{
    public class CostAmount : AuditBase
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public UserCategory? UserCategory { get; set; }

    }
}
