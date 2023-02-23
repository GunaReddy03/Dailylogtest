using MessagePack;
using Microsoft.EntityFrameworkCore;
using newproject.Models;
//using PromiseApp.Core;
using System.ComponentModel.DataAnnotations;

namespace PromiseApp.Models.MidWifeModels
{
    
    public class Dailylog_Triage 
    {
        
        public int Id { get; set; }
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
    public class DemographicDetailsTriage
    {
        public bool? YearsOfMarriage { get; set; }
        public string? Consanguinity { get; set; }
        public int GestationalAgeinWeeks { get; set; }
        public int Gravida { get; set; }
        public int Para { get; set; }
        public int Abortion { get; set; }
        public int Living { get; set; }
       
        public string? NameOfCompanion { get; set; }

    }
    public class Vitals_Triage
    {
        public int temperature { get; set; }
        public int Pulse { get; set; }
        public int Respiration { get; set; }
        public int BloodPressure { get; set; }
        public bool NotifiedDoc { get; set; }
        public int BMI { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string? Nutritional_Status { get; set; }
        public bool Fetal_Heart_Rate_Monitored { get; set; }
        public int Fetal_Heart_rate { get; set; }
        public bool Notified_Doctor { get; set; }
        public bool? Present_Complaints { get; set; }

    }
    public class Traige_Category
    {
        public bool? Red { get; set; }
        public bool? Yellow { get; set; }
        public bool? Green { get; set; }
    }
    public class Status_of_mother
    {

        public bool? StatusOfMother { get; set; }
        
    }

}
