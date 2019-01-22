using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApplication.DAL.DataAccess
{
  public  interface IDbManager
    {
        IDbConnection CreateDbConnection();
    }
    public class DbManager:IDbManager
    {

        public IDbConnection CreateDbConnection()
        {
            var connectionString = ConfigurationManager.AppSettings["connectionString"];
            return new SqlConnection { ConnectionString = connectionString };
        }
        
    }
    public class DbManager1 : IDbManager
    {

        public IDbConnection CreateDbConnection()
        {
            var connectionString = ConfigurationManager.AppSettings["connectionString"];
            return new SqlConnection { ConnectionString = connectionString };
        }

    }
}
