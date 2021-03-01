using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NewEdsmartAdminV2App.Client.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace NewEdsmartAdminV2App.Client.ConstantClass
{
    public class DrapperManager :IDrapperManager
    {
        private readonly IConfiguration _config;
        public DrapperManager(IConfiguration config)
        {
            _config = config;
        }

        public DbConnection GetConnection1()
        {
            return new SqlConnection(_config.GetConnectionString("Connection1"));
        }
        public DbConnection GetConnection2()
        {
            return new SqlConnection(_config.GetConnectionString("Connection2"));
        }
        public List<T> GetAllENV1<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("Connection1"));
            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }
        public List<T> GetAllENV2<T>(string sp, DynamicParameters parms, CommandType commandType=CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("Connection2"));
            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
