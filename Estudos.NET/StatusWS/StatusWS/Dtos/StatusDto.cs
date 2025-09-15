namespace StatusWS.Dtos
{
    public class StatusDto
    {
        public int StatusId { get; set; }
        public string? CustomText { get; set; }
        public DateTime UpdateAt { get; set; }
        public StatusTypeDto StatusType { get; set; } // Incluímos o DTO do tipo de status
    }
}
