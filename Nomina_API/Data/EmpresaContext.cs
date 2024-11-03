

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
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Ingreso>()
                .HasOne(i => i.Empleado)
                .WithMany(e => e.Ingresos)
                .HasForeignKey(i => i.NumeroEmpleado)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<Deduccion>()
                .HasOne(d => d.Empleado)
                .WithMany(e => e.Deducciones)
                .HasForeignKey(d => d.NumeroEmpleado)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<Nomina>()
                .HasOne(n => n.Empleado)
                .WithMany(e => e.Nominas)
                .HasForeignKey(n => n.NumeroEmpleado)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
