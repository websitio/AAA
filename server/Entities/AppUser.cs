using server.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Entities
{
    [Table("Users")]
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

        public ICollection<Category> UserCategories {get;  set;} 
        = new List<Category>();
}
        #region extra props
        /* public string Gender { get; set; }
         public string Introduction { get; set; }
         public string UsingKeycostFor { get; set; }
         public string Interests { get; set; }
         public string City { get; set; }
         public string Country { get; set; }
         public string JobCurrent {get; set;}
          public string JobPreferred {get; set;}
         public string Email { get; set; }
 */
        #endregion

    }



