using newproject.ViewModel;
using PromiseApp.Models.MidWifeModels;

namespace newproject.Services
{
    public interface ITriageservice
    {
        void AddANC(TriageViewModel Triage);
        List<Dailylog_Triage> GetAll();
        Dailylog_Triage UpdateTriage(int Id, TriageViewModel Triage);
    }
}