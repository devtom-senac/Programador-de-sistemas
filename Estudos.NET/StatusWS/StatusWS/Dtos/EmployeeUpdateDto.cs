namespace StatusWS.Dtos
{
    public class EmployeeUpdateDto
    {
        public string? Photo { get; set; }
        public int? StatusId { get; set; }
        public string? CustomText { get; set; }
        public bool? IsActive { get; set; }
    }
}
