using BaseLib.DataAccess.Implementations.EF;
using NorthwndWS.DataAccess.Contracts.Repositories;
using NorthwndWS.DataAccess.EF.Contexts;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.DataAccess.EF.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee, int, NorthwndContext>, IEmployeeRepository
    {
        public async Task<List<Employee>> GetByCity(string city, params string[] includeList)
        {
            return await FilterAsync(x => x.City == city, includeList);
        }
    }
}
