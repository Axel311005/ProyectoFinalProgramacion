using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nomina_API.Repository.IRepository;
using SharedModels.Dto;
using SharedModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using System.Configuration;
using ConfigurationManager = System.Configuration.ConfigurationManager;
using Nomina_API.Repository;
using Microsoft.AspNetCore.Authorization;


namespace Nomina_API.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoController : ControllerBase
    {
        private readonly IEmpleadoRepository _empleadoRepo;
        private readonly I_IngresoRepository _ingresoRepo;
        private readonly ILogger<IngresoController> _logger;
        private readonly IMapper _mapper;
        
        
        public IngresoController(IEmpleadoRepository empleadoRepo,
            I_IngresoRepository ingresoRepo,
            ILogger<IngresoController> logger,
            IMapper mapper)
        {
            _ingresoRepo = ingresoRepo;
            _empleadoRepo = empleadoRepo;
            _logger = logger;
            _mapper = mapper;
            
        }

        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<IngresoDto>>> GetIngresos()
        {
            try
            {
                _logger.LogInformation("Obteniendo los ingresos");

                var ingresos = await _ingresoRepo.GetAllAsync();

                return Ok(_mapper.Map<IEnumerable<IngresoDto>>(ingresos));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener los ingresos: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al obtener los ingresos.");
            }
        }

       
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IngresoDto>> GetIngreso(int id)
        {
            if (id <= 0)
            {
                _logger.LogError($"ID de ingreso no válido: {id}");
                return BadRequest("ID de ingreso no válido");
            }

            try
            {
                _logger.LogInformation($"Obteniendo ingreso con ID: {id}");

                var ingreso = await _ingresoRepo.GetById(id);

                if (ingreso == null)
                {
                    _logger.LogWarning($"No se encontró ningún ingreso con ID: {id}");
                    return NotFound("Ingreso no encontrado.");
                }

                return Ok(_mapper.Map<IngresoDto>(ingreso));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener ingreso con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al obtener el ingreso.");
            }
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IngresoDto>> PostIngreso(IngresoCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un ingreso nulo en la solicitud.");
                return BadRequest("El ingreso no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo ingreso para el empleado " +
                    $"con ID: {createDto.NumeroEmpleado}");

                // Verificar si el empleado existe
                var empleadoExist = await _empleadoRepo.ExistsAsync(
                    s => s.NumeroEmpleado == createDto.NumeroEmpleado);

                if (!empleadoExist)
                {
                    _logger.LogWarning($"El empleado con numero de empleado '{createDto.NumeroEmpleado}' no existe.");
                    ModelState.AddModelError("EmpleadoNoExiste", "¡El empleado no existe!");
                    return BadRequest(ModelState);
                }


                // Verificar la validez del modelo
                if (!ModelState.IsValid)
                {
                    _logger.LogError("El modelo de ingreso no es válido.");
                    return BadRequest(ModelState);
                }

                var salariobase = createDto.SalarioOrdinario;

                

                int yearsTrabajados = await _ingresoRepo.GetYearsTrabajadosById(createDto.NumeroEmpleado);
                if (yearsTrabajados == 0)
                {
                    return NotFound();
                }

                createDto.Antiguedad = await _ingresoRepo.CalcAntiguedad(yearsTrabajados, salariobase);

                createDto.Nocturnidad = await _ingresoRepo.CalcNoctunidadRisgoLab(salariobase);
                createDto.RiesgoLaboral =  await _ingresoRepo.CalcNoctunidadRisgoLab(salariobase);

                var horas = createDto.HorasExtras;
                createDto.HorasExtras = 0;

                createDto.HorasExtras =await _ingresoRepo.CaclHorasExtras(horas, salariobase);
                createDto.TotalIngresos = await _ingresoRepo.CalSalario(createDto.SalarioOrdinario, createDto.Antiguedad,
                    createDto.RiesgoLaboral,createDto.Nocturnidad,createDto.HorasExtras, createDto.OtrosIngresos);


                var newIngreso = _mapper.Map<Ingreso>(createDto);
               
                if(await _ingresoRepo.ObtenerIngresoPorNumeroEmpleado(createDto.NumeroEmpleado))
                {
                    return BadRequest("Ya existe un ingreso para este empleado");
                }

                await _ingresoRepo.CreateAsync(newIngreso);

                _logger.LogInformation($"Nuevo ingreso creado con ID: " +
                    $"{newIngreso.IngresoID}");
                return CreatedAtAction(nameof(GetIngresos),
                    new { id = newIngreso.IngresoID }, newIngreso);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo ingreso: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al crear un nuevo ingreso.");
            }
        }

      
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutIngreso(int id,
            IngresoUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.IngresoID)
            {
                return BadRequest("Los datos de entrada no son válidos o " +
                    "el ID de ingreso no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando ingreso con ID: {id}");

                var existingIngreso = await _ingresoRepo.GetById(id);
                if (existingIngreso == null)
                {
                    _logger.LogInformation($"No se encontró ningún ingreso con ID: {id}");
                    return NotFound("El ingreso no existe.");
                }

                
                var empleadoExists = await _empleadoRepo.ExistsAsync(
                    s => s.NumeroEmpleado == updateDto.NumeroEmpleado);

                if (!empleadoExists)
                {
                    _logger.LogWarning($"El empleado con numero de empleado '{updateDto.NumeroEmpleado}' no existe.");
                    ModelState.AddModelError("EmpleadoNoExiste", "¡El empleado no existe!");
                    return BadRequest(ModelState);
                }


                var salariobase = updateDto.SalarioOrdinario;

                int yearsTrabajados =await _ingresoRepo.GetYearsTrabajadosById(updateDto.NumeroEmpleado);
                if (yearsTrabajados == 0)
                {
                    return NotFound();
                }

                updateDto.Antiguedad = await _ingresoRepo.CalcAntiguedad(yearsTrabajados, salariobase);

                updateDto.Nocturnidad =await _ingresoRepo.CalcNoctunidadRisgoLab(salariobase);
                updateDto.RiesgoLaboral = await _ingresoRepo.CalcNoctunidadRisgoLab(salariobase);

                var horas = updateDto.HorasExtras;
                updateDto.HorasExtras = 0;

                updateDto.HorasExtras = await _ingresoRepo.CaclHorasExtras(horas, salariobase);
                updateDto.TotalIngresos =await  _ingresoRepo.CalSalario(updateDto.SalarioOrdinario, updateDto.Antiguedad, updateDto.RiesgoLaboral, updateDto.Nocturnidad, updateDto.HorasExtras, updateDto.OtrosIngresos);

               
                
                _mapper.Map(updateDto, existingIngreso);

                await _ingresoRepo.SaveChangesAsync();

                _logger.LogInformation($"Ingreso con ID {id} actualizado correctamente.");

                return NoContent();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!await _ingresoRepo.ExistsAsync(a => a.IngresoID == id))
                {
                    _logger.LogWarning($"No se encontró ningún ingreso con ID: {id}");
                    return NotFound("El ingreso no se encontró durante la actualización");
                }
                else
                {
                    _logger.LogError($"Error de concurrencia al actualizar el ingreso " +
                        $"con ID: {id}. Detalles: {ex.Message}");
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error interno del servidor al actualizar el ingreso.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al actualizar el ingreso: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al actualizar el ingreso.");
            }
        }

    
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteIngreso(int id)
        {
            try
            {
                _logger.LogInformation($"Eliminando ingreso con ID: {id}");

                var ingreso = await _ingresoRepo.GetById(id);
                if (ingreso == null)
                {
                    _logger.LogInformation($"Eliminando ingreso con ID: {id}");
                    return NotFound("Ingreso no encontrado.");
                }

                await _ingresoRepo.DeleteAsync(ingreso);
                

                _logger.LogInformation($"Ingreso con ID {id} eliminada correctamente.");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al eliminar el ingreso con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Se produjo un error al eliminar el ingreso.");
            }
        }
    }
}
