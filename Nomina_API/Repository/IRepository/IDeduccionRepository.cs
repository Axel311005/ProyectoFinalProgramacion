using SharedModels;

namespace Nomina_API.Repository.IRepository
{
    public interface IDeduccionRepository : IRepository<Deduccion>
    {

        Task<Deduccion> UpdateAsync(Deduccion entity);

        Task<double> CalcularIr(double IngresoAnual);
        Task<double> CalcularInss(double TotalIngresos);
        Task<double> GetSalarioTotal(int id);

        Task<double> CalTotalDeduc(double INSS, double IR,double otrasDeducciones);
        Task<Deduccion> ObtenerRegistroDeduccion(int id);
        Task<bool> ObtenerDeduccionPorNumeroEmpleado(int id);

    }
}
