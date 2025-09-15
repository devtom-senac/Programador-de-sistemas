using System.ComponentModel.DataAnnotations;

namespace StatusWS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [StringLength(255)]
        public string Photo { get; set; } = "https://tarefas.websupply.com.br/painel/assets/userDefault-uMDAqLiz.png";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public int StatusId { get; set; } = 1;
        public Status Status { get; set; }
    }
}

