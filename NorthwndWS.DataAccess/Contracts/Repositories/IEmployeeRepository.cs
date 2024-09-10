using BaseLib.DataAccess.Contracts;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.DataAccess.Contracts.Repositories
{
    public interface IEmployeeRepository:IRepository<Employee,int>
    {
        Task<List<Employee>> GetByCity(string city, params string[] includeList);
    }
}
