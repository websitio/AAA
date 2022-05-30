using System.Collections.Generic;
namespace API.Entities
{
    public class AppUser
    {
      

        public int Id { get; set; }
        public string? UserName { get; set; }       //"N" not "n"  = future proofed 

        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }

        //        public ICollection<Photo> Photos { get; set; }
        //        public ICollection<CostCategory> {get; set;}
        //        public ICollection<Cost> {get; set;}
    }
}
