using NewEdsmartAdminV2App.Shared.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEdsmartAdminV2App.Shared.Interface
{
    public interface ISchoolManager
    {
        Task<int> Count(string search);
        Task<List<School>> ListAll(int skip, int take, string orderBy, string direction, string search);

        Task<List<School>> ListAllENV2(int skip, int take, string orderBy, string direction, string search);
    }
}
