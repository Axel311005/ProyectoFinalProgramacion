

using Microsoft.EntityFrameworkCore;
using SharedModels;

namespace Nomina_API.Data
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options) :
            base (options)
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Deduccion> Deducciones { get;set; }
        public DbSet<Nomina> Nominas { get; set;}
    }
}
