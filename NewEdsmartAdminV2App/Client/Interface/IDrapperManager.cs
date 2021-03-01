using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace NewEdsmartAdminV2App.Client.Interface
{
    public interface IDrapperManager : IDisposable
    {
        DbConnection GetConnection1();
        DbConnection GetConnection2();
        List<T> GetAllENV1<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAllENV2<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        
    }
}