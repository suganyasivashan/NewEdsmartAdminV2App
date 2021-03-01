using NewEdsmartAdminV2App.Client.Interface;
using NewEdsmartAdminV2App.Client.Entities;
using NewEdsmartAdminV2App.Client.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NewEdsmartAdminV2App.Client.ConstantClass
{
    public class SchoolManager : ISchoolManager
    {
        public readonly IDrapperManager _drapperManager;

        public SchoolManager(IDrapperManager dapperManager)
        {
            this._drapperManager = dapperManager;
        }

        public Task<List<SchoolENV1>> ListAllENV1()
        {
            var school = Task.FromResult(_drapperManager.GetAllENV1<SchoolENV1>
                ($"SELECT * FROM [SchoolENV1]", null, commandType: CommandType.Text));
            return school;
        }
        public Task<List<SchoolENV2>> ListAllENV2()
        {
            var schools = Task.FromResult(_drapperManager.GetAllENV1<SchoolENV2>
                ($"SELECT * FROM [SchoolENV2]", null, commandType: CommandType.Text));
            return schools;
        }

    }
}
