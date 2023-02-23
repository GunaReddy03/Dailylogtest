using newproject.Models;
using newproject.ViewModel;

namespace newproject.Services
{
    public interface IDailyLogServices
    {
        void AddDailyLog(DailyLogViewModel DLVM);

        DailyLog AddDailyLog(DailyLog DL);
        List<DailyLog> GetAll();
    }
}