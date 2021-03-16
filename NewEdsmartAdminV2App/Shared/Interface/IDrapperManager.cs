using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace NewEdsmartAdminV2App.Shared.Interface
{
    public interface IDrapperManager : IDisposable
    {
        DbConnection GetConnection();

        DbConnection GetConnection2();
        T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);

        T Get2<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAllENV2<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);

    }
}
