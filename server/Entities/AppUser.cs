using server.Entities.BaseEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class AppUser : AuditBase
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }     //"N" not "n"  = future proofed '

        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }

        //        public ICollection<Photo> Photos { get; set; }
        //        public ICollection<CostCategory> {get; set;}
        //        public ICollection<Cost> {get; set;}
    }
}
