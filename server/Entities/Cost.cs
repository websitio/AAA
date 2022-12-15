using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using server.Entities.BaseEntities;

namespace Server.Entities
{
    [Table("Costs")]
    public class Cost : AuditBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int 
        Id { get; set; }

        public decimal 
        CostAmount { get; set; }

        [MaxLength(150)]
        public string? 
        Description { get; set; }

        [Required]
        [ForeignKey("CostCategoryId")]
        public int 
        CostCategoryId { get; set; }

    }
}
