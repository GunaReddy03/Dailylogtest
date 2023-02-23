using newproject.DBContext;
using newproject.Models;
using newproject.ViewModel;

namespace newproject.Services
{
    public class AncOpdService : IAncOpdService
    {
        private MidWifeDbContext _Context;
        public AncOpdService(MidWifeDbContext context)
        {
            _Context = context;
        }

        public List<AncOpd> GetAll() => _Context.AncOpds.ToList();
        
        
        
        public void AddANC(AncOpdViewModel Anc)
        {
            var _books = new AncOpd()
            {
                DailyLog = Anc.DailyLog,
                NameOftheMother = Anc.NameOftheMother,
                Age = Anc.Age,
                contactNumber = Anc.contactNumber,
                ANCRegistration = Anc.ANCRegistration,
                DateOfVisit = DateTime.Now,
            };
            _Context.AncOpds.Add(_books);
            _Context.SaveChanges();
        }
    }
}
