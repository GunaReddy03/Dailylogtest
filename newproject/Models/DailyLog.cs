namespace newproject.Models
{
    public class DailyLog
    {
        public int Id { get; set; }
        public DateTime ActivityDate { get; set; }
        public string? Designation { get; set; }
        public string? WorkingStatus { get; set; }
        public string? FacilityPosed { get; set; }
        public string? AreaOfPosting { get; set; }
    }
}
