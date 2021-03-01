using NewEdsmartAdminV2App.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEdsmartAdminV2App.Client.Interface
{
    public interface ISchoolManager
    {
        Task<List<SchoolENV1>> ListAllENV1();
        Task<List<SchoolENV2>> ListAllENV2();
    }
}
