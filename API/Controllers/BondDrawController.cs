using Microsoft.AspNetCore.Mvc;
using SMS_BLL.Interfaces;

//using BLL.Interfaces;
//using BOL.Entities;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class BondDrawController : ControllerBase
    {
        private readonly IBondOwnedService _bondOwnedService;

        public BondDrawController(IBondOwnedService bondOwnedService)
        {
            _bondOwnedService = bondOwnedService;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get_OwnedBonds_All()
        //{
        //    var AllOwnedBonds = await _bondOwnedService.GetAll_OwnedBond();
        //    return Ok(AllOwnedBonds);
        //}
    }
}