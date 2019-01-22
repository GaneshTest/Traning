using Dapper;
using MVCApplication.DAL.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApplication.DAL.Repo
{
 
  public  interface IMeasureRepo
    {
        bool Insert();
        List<object> GetHedMeasures();
    }
   public class MeasureRepo : IMeasureRepo
    {
         IDbManager _dbManager;
        public MeasureRepo(IDbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public bool Insert()
        {
            throw new NotImplementedException();
        }
        public List<object> GetHedMeasures()
        {
            using (IDbConnection connection = _dbManager.CreateDbConnection())
            {

                string sql = "Select * from hed_measures where 1=@id";
                var affectedRows = connection.Query<object>(sql, new { id = 1 }).ToList();
                return affectedRows;
            }

        }
    }
}
