using Core.DataAccess.Abstract;
using Domain.Models;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
