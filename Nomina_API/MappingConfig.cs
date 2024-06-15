using AutoMapper;
using SharedModels.Dto;
using SharedModels;

namespace Nomina_API
{
    public class MappingConfig :Profile
    {

        public MappingConfig()
        {
            CreateMap<Empleado,EmpleadoDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoCreateDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoUpdateDto>().ReverseMap();
            CreateMap<Deduccion, DeduccionDto>().ReverseMap();
            CreateMap<Deduccion, DeduccionCreateDto>().ReverseMap();
            CreateMap<Deduccion, DeduccionUpdateDto>().ReverseMap();


        }
    }
}
