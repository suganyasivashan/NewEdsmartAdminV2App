using NewEdsmartAdminV2App.Shared.Entities;
using NewEdsmartAdminV2App.Client.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using NewEdsmartAdminV2App.Shared.Interface;

namespace NewEdsmartAdminV2App.Client.ConstantClass
{ 
    public class SchoolManager : ISchoolManager
    {
        private readonly IDrapperManager _dapperManager;

        public SchoolManager(IDrapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Count(string search)
        {
            var totSchool = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [School] WHERE Title like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totSchool;
        }

        public Task<List<School>> ListAll(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var articles = Task.FromResult(_dapperManager.GetAll<School>
                ($"SELECT * FROM [School] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return articles;
        }

        public Task<List<School>> ListAllENV2(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var schools = Task.FromResult(_dapperManager.GetAllENV2<School>
                ($"SELECT * FROM [School] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return schools;
        }
    }
}

