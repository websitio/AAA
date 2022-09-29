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

            // the above seemed like a solution at first glance, but how can it be? 
            // Logially impossible to know which of the categries 
            // the logged in user owns is applied to each cost without a CostCategoryId
            // my hand rolled seed data lulled me to laziness for a short while


        [ForeignKey("CostCategoryId")]
        public int CostCategoryId { get; set; }



        [ForeignKey("AppUserId")]
        public AppUser AppUser{get; set;}
         public int AppUserId {get; set;}
    }
}
