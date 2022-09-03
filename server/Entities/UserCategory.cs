using server.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Server.Entities
{
    public class UserCategory : AuditBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }
        [Required]  
        [MaxLength(50)]
        public string Name { get; set; }

         
        [MaxLength(150)]
        public string Description { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

        public ICollection<CostAmount> CostAmounts { get; set; } =
        new List<CostAmount>();

    }
}
