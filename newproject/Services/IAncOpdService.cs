using newproject.Models;
using newproject.ViewModel;

namespace newproject.Services
{
    public interface IAncOpdService
    {
        void AddANC(AncOpdViewModel Anc);

        List<AncOpd> GetAll();
    }
}