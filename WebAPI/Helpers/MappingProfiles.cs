using AutoMapper;
using Domain.Models;
using Shared.Dtos;

namespace WebAPI.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Customer, CustomerDto>();
        }
    }
}
