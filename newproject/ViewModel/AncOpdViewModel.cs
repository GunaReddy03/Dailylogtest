using newproject.Models;

namespace newproject.ViewModel
{
    public class AncOpdViewModel
    {
        //public int Id { get; set; }
        public string? NameOftheMother { get; set; }
        public int Age { get; set; }
        public string? contactNumber { get; set; }
        public string? ANCRegistration { get; set; }
        public DateTime DateOfVisit { get; set; }

        public DailyLog? DailyLog { get; set; }
    }
}
