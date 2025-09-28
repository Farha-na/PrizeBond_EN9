using BOL.Entities;
using static BOL.DTOs.Master_setup_Dto;

namespace SMS_BLL.Interfaces
{
    public interface IBondOwnedService
    {
        Task<IEnumerable<BondOwned>> GetAll_OwnedBond();
    }
}