//using BLL.Interfaces;

//using BOL.Entities;
using BOL.Entities;
using DAL.Interfaces;
using SMS_BLL.Interfaces;

//using static BOL.DTOs.Master_setup_Dto;

namespace BLL.Services
{
    public class BondDrawService : IBondDrawService
    {
        private readonly IBondOwnedRepository _OB;

        public BondDrawService(IBondOwnedRepository OB)
        {
            _OB = OB;
        }

        //public async Task<IEnumerable<BondOwned>> GetAll_OwnedBond()
        //{
        //    return await _OB.All_OwnedBond();
        //}
    }
}