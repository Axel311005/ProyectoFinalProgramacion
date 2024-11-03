using SharedModels.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public interface INominaRepository
    {
        Task<IEnumerable<NominaCompletaDto>> GetNominaGeneral();
    }
}
