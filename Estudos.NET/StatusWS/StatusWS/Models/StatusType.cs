using System.ComponentModel.DataAnnotations;

namespace StatusWS.Models
{
    public class StatusType
    {
        [Key]
        public int StatusTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [StringLength(255)]
        public string IconUrl { get; set; }
        public ICollection<Status> Statuses { get; set; }
    }
}
