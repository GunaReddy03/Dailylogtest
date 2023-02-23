namespace newproject.Models
{
    public class AncOpd
    {
        public int Id { get; set; }
        public string? NameOftheMother { get; set; }
        public int Age { get; set; }
        public string? contactNumber { get; set; }
        public string? ANCRegistration { get; set; }
        public DateTime DateOfVisit { get; set; }
        public DailyLog? DailyLog { get; set; }
    }
}
