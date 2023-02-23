using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using newproject.DBContext;
using newproject.Models;
using newproject.ViewModel;

namespace newproject.Services
{
    public class DailyLogNOPDService
    {
        private MidWifeDbContext MidWifeDbContext;
        //private IDailyLogServices dialylogService;

        public DailyLogNOPDService(MidWifeDbContext context)
        {
            MidWifeDbContext = context;
        }
        public List<DailyLog> GetDailyLogs() => MidWifeDbContext.DailyLogs.ToList();
       
        public void AddDailyLog(DailyLogViewModel dlvm)
        {
            System.Diagnostics.Debug.WriteLine("in AddDailyLog service file");
            var _books = new DailyLog();
            {

            }
            MidWifeDbContext.DailyLogs.Add(_books);
            MidWifeDbContext.SaveChanges();
        }
        //public List<DailyLogNOpd> GetAll() => MidWifeDbContext.DailyLogs.ToList();
        //public void AddDailyLogNOPD(DailyLogNOPDViewModel DLNVM)
        //{
        //    var _books = new DailyLogNOpd()
        //    {

        //    }
        //        MidWifeDbContext.DailyLogs.Add(_books);
        //        MidWifeDbContext.AncOpds.Add(_books);
        //        MidWifeDbContext.SaveChanges();
        //}
    }
}
