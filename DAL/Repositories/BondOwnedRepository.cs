using BOL.Entities;
using DAL.DataContext;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BondOwnedRepository : IBondOwnedRepository
    {
        private readonly db_prizebond_DBContext _context;

        public BondOwnedRepository(db_prizebond_DBContext sclContext)
        {
            _context = sclContext;
        }

        public async Task<IEnumerable<BondOwned>> GetAll_OwnedBond()
        {
            return await _context.BondOwned_instances.ToListAsync();
        }
    }
}