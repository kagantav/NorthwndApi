using BaseLib.DataAccess.Implementations.EF;
using NorthwndWS.DataAccess.Contracts.Repositories;
using NorthwndWS.DataAccess.EF.Contexts;
using NorthwndWS.Model.Entities;

namespace NorthwndWS.DataAccess.EF.Repositories
{
    internal class CustomerRepository:BaseRepository<Customer,string,NorthwndContext>,ICustomerRepository
    {
    }
}
