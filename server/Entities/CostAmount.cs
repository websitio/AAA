using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using server.Entities.BaseEntities;


namespace Server.Entities
{
    public class CostAmount : AuditBase
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]      
        public int Id { get; set; }
        public decimal Cost { get; set; }
         
        [MaxLength(150)]
        public string? Description { get; set; }



        // [ForeignKey("CostCategoryId")]
        // public CostCategory CostCategory { get; set; }
        // public int CostCategoryId { get; set; }



        [ForeignKey("AppUserId")]
        public AppUser AppUser{get; set;}
         public int AppUserId {get; set;}
    }
}
