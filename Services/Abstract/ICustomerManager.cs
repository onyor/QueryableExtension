using Domain.Models;
using Shared.Dtos;

namespace Business.Abstract
{
    public interface ICustomerManager
    {
        public Task<IList<CustomerDto>> GetAll();
    }
}
