using MVCApplication.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVCApp.Service.Services
{
    public interface IMeasureService
    {
        List<object> GetHedMeasures();
    }
    public class MeasureService : IMeasureService
    {
        private IMeasureRepo _measurerepo;
        public MeasureService(IMeasureRepo measureRepo)
        {
            _measurerepo = measureRepo;
        }
        public List<object> GetHedMeasures()
        {
            return _measurerepo.GetHedMeasures();
        }
    }
}
