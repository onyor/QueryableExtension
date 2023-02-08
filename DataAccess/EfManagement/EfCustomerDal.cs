using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Data;
using Domain.Models;

namespace DataAccess.EfManagement
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,NorthwindDbContext>, ICustomerDal
    {

    }
}
