using server.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Server.Entities
{
    [Table("Categories")]
    public class Category : AuditBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int
        Id
        { get; set; }

        [Required]
        [MaxLength(50)]
        public string
        Name
        { get; set; }


        [MaxLength(150)]
        public string
        Description
        { get; set; }

        [Required]
        [ForeignKey("AppUserId")]
        public int
        AppUserId
        { get; set; }

        public ICollection<Cost>  CostAmounts { get; set; } = new List<Cost>();

    }
}
