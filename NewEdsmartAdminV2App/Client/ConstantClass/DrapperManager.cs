using NewEdsmartAdminV2App.Shared.Interface;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace NewEdsmartAdminV2App.Client.ConstantClass
{
    public class DapperManager : IDrapperManager
    {
        private readonly IConfiguration _config;
        public DapperManager(IConfiguration config)
        {
            _config = config;
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        }
        public DbConnection GetConnection2()
        {
            return new SqlConnection(_config.GetConnectionString("Connection2"));
        }

        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }
        public T Get2<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("Connection2"));
            return db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }

        public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }
        public List<T> GetAllENV2<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("Connection2"));
            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }
        public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return db.Execute(sp, parms, commandType: commandType);
        }

        public void Dispose()
        {

        }
    }
}
