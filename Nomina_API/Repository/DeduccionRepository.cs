using Microsoft.EntityFrameworkCore;
using Nomina_API.Data;
using Nomina_API.Repository.IRepository;
using SharedModels;

namespace Nomina_API.Repository
{
    public class DeduccionRepository :Repository<Deduccion>, IDeduccionRepository 
    {
        private readonly EmpresaContext _context;

        public DeduccionRepository(EmpresaContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<Deduccion> UpdateAsync(Deduccion entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
