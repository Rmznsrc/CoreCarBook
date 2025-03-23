using CoreCarBook.Application.Interfaces.RentACarInterfaces;
using CoreCarBook.Domain.Entities;
using CoreCarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Persistance.Repositories.RentACarRepositories
{

    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = await _context.RentACars.Where(filter).ToListAsync();
            return values;
        }
    }
}
