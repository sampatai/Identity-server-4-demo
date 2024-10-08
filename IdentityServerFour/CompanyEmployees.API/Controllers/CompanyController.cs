using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace CompanyEmployees.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/companies")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
                var claims = User.Claims;
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
