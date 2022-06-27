using System.ComponentModel.DataAnnotations;

namespace server.Entities.BaseEntities
{
    public abstract class AuditBase
    {
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string? CreateBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string? UpdateBy { get; set; }   


    }
}
