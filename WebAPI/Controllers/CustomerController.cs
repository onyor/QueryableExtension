using DataAccess.Data;
using DataAccess.Interface;
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

        public CustomerController(ILogger<CustomerController> logger, NorthwindDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("GetCustomer")]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            try
            {
                var customerList = await _context.Customers.Include(x=>x.Orders).ToListAsync();

                return Ok(customerList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}