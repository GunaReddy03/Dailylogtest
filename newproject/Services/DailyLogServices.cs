using newproject.DBContext;
using newproject.Models;
using newproject.ViewModel;

namespace newproject.Services
{
    public class DailyLogServices : IDailyLogServices
    {
        private MidWifeDbContext _Context;
        public DailyLogServices(MidWifeDbContext context)
        {
            _Context = context;
        }
        public List<DailyLog> GetAll() => _Context.DailyLogs.ToList();
        public void AddDailyLog(DailyLogViewModel DLVM)
        {
            var _log = new DailyLog()
            {
                ActivityDate = DLVM.ActivityDate,
                Designation = DLVM.Designation,
                WorkingStatus = DLVM.WorkingStatus,
                FacilityPosed = DLVM.FacilityPosed,
                AreaOfPosting = DLVM.AreaOfPosting,
            };
            _Context.DailyLogs.Add(_log);
            _Context.SaveChanges();
        }

        public DailyLog AddDailyLog(DailyLog DLVM)
        {
            System.Diagnostics.Debug.WriteLine("in AddDailyLog Service");
            System.Diagnostics.Debug.WriteLine(DLVM.ToString);
            var _log = new DailyLog()
            {
                ActivityDate = DLVM.ActivityDate,
                Designation = DLVM.Designation,
                WorkingStatus = DLVM.WorkingStatus,
                FacilityPosed = DLVM.FacilityPosed,
                AreaOfPosting = DLVM.AreaOfPosting,
            };
            _Context.DailyLogs.Add(_log);
            _Context.SaveChanges();
            return _log;
        }
    }
}
