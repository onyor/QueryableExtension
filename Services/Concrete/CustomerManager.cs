using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EfManagement;
using Domain.Models;
using Shared.Dtos;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerManager
    {
        ICustomerDal _customerDal;
        IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal, IMapper mapper)
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }
        public async Task<IList<CustomerDto>> GetAll()
        {
            try
            {
                var result = await _customerDal.GetListAsync();

                var entityDto = _mapper.Map<IList<CustomerDto>>(result);
                return entityDto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
