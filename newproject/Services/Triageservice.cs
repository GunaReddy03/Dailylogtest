using Microsoft.EntityFrameworkCore;
using newproject.DBContext;
using newproject.Models;
using newproject.ViewModel;
using PromiseApp.Models.MidWifeModels;

namespace newproject.Services
{
    public class Triageservice : ITriageservice
    {
        private MidWifeDbContext _Context;
        public Triageservice(MidWifeDbContext context)
        {
            _Context = context;
        }

        public List<Dailylog_Triage> GetAll() => _Context.dailylog_Triages.ToList();



        public void AddANC(TriageViewModel Triage)
        {
            var _Triage = new Dailylog_Triage()
            {
                DailyLog = Triage.DailyLog,
                examination_type = Triage.examination_type,
                NameOftheMother = Triage.NameOftheMother,
                Age = Triage.Age,

                contactNumber = Triage.contactNumber,
                IPNumber = Triage.IPNumber,
                DateofVisit = DateTime.Now,
                TimeofVisit = DateTime.Now,
                TimeOfAssesment = DateTime.Now,
                LMP = DateTime.Now,
                EDD = DateTime.Now,
                DemographicDetailsTriage = Triage.DemographicDetailsTriage,
                Vitals_Triage = Triage.Vitals_Triage,
                Traige_Category = Triage.Traige_Category,
                Pathways_Of_Care = Triage.Pathways_Of_Care,
                Status_Of_Mother = Triage.Status_Of_Mother,
                DateOfAdmission = DateTime.Now,
                DateOfRefferalOut = DateTime.Now

            };
            _Context.dailylog_Triages.Add(_Triage);
            _Context.SaveChanges();
        }

        public Dailylog_Triage UpdateTriage(int Id, TriageViewModel Triage)
        {
            var _Triage = _Context.dailylog_Triages.FirstOrDefault(n => n.Id == Id);
            if (_Triage != null)
            {
                _Triage.examination_type = Triage.examination_type;
                _Triage.NameOftheMother = Triage.NameOftheMother;
                _Triage.Age = Triage.Age;

                _Triage.contactNumber = Triage.contactNumber;
                _Triage.IPNumber = Triage.IPNumber;
                _Triage.DateofVisit = DateTime.Now;
                _Triage.TimeofVisit = DateTime.Now;
                _Triage.TimeOfAssesment = DateTime.Now;
                _Triage.DemographicDetailsTriage = Triage.DemographicDetailsTriage;
                _Triage.LMP = Triage.LMP;
                _Triage.EDD = Triage.EDD;
                _Triage.Vitals_Triage = Triage.Vitals_Triage;
                _Triage.Traige_Category = Triage.Traige_Category;
                _Triage.Pathways_Of_Care = Triage.Pathways_Of_Care;
                _Triage.Status_Of_Mother = Triage.Status_Of_Mother;
                _Triage.DateOfAdmission = DateTime.Now;
                _Triage.DateOfRefferalOut = DateTime.Now;

                _Context.SaveChanges();

            }

            return _Triage;

        }
    }
}
