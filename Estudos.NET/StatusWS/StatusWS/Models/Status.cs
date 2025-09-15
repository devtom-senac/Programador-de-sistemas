using System.ComponentModel.DataAnnotations;

namespace StatusWS.Models
{
    public class Status
    {
        // Chave Primária
        [Key]
        public int StatusId { get; set; }

        [StringLength(255)]
        public string? CustomText { get; set; }
        public DateTime UpdateAt { get; set; } = DateTime.UtcNow;
        public int StatusTypeId { get; set; }
        public StatusType StatusType { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
