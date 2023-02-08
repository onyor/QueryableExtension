using Business.Abstract;
using DataAccess.Data;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;
        private readonly NorthwindDbContext _context;
        private readonly ICustomerManager _customerManager;

        public CustomerController(ILogger<CustomerController> logger, NorthwindDbContext context, ICustomerManager customerManager)
        {
            _logger = logger;
            _context = context;
            _customerManager = customerManager;
        }

        [HttpGet("GetCustomer")]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            try
            {
                var result = await _customerManager.GetAll();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}