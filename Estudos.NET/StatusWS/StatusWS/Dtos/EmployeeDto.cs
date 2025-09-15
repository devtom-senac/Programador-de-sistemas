namespace StatusWS.Dtos
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Photo { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public StatusDto? Status { get; set; }

    }
}

