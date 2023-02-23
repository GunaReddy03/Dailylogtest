using newproject.Models;
using PromiseApp.Models.MidWifeModels;

namespace newproject.ViewModel
{
    public class TriageViewModel
    {
        public bool? examination_type { get; set; }
        public string? NameOftheMother { get; set; }
        public int Age { get; set; }
        public string? contactNumber { get; set; }
        public string? IPNumber { get; set; }
        public DateTime DateofVisit { get; set; }
        public DateTime TimeofVisit { get; set; }
        public DateTime TimeOfAssesment { get; set; }
        public DemographicDetailsTriage? DemographicDetailsTriage { get; set; }
        public DateTime LMP { get; set; }
        public DateTime EDD { get; set; }
        public Vitals_Triage? Vitals_Triage { get; set; }
        public Traige_Category? Traige_Category { get; set; }
        public bool? Pathways_Of_Care { get; set; }
        public Status_of_mother? Status_Of_Mother { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public DateTime DateOfRefferalOut { get; set; }
        public DailyLog? DailyLog { get; set; }
    }
}
