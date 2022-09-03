using server.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Entities
{
    public class AppUser : AuditBase
    {
         
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]  
        [MaxLength(50)]
        public string UserName { get; set; }
        
        public byte[] PasswordHash { get; set; }
        
        public byte[] PasswordSalt { get; set; }


        public ICollection<UserCategory> UserCategories {get; set;}
        = new List<UserCategory>();

        public ICollection<CostAmount> CostAmounts {get; set;}
       = new List<CostAmount>();



    }
        
}
