using MVCApplication.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVCApp.Service.Services
{
    public class SampleService : IMeasureService
    {
        private IMeasureRepo _measureRepo;
        public SampleService(IMeasureRepo measureRepo)
        {
            _measureRepo = measureRepo;
        }
        public List<object> GetHedMeasures()
        {
          return  _measureRepo.GetHedMeasures();
        }
    }
}
