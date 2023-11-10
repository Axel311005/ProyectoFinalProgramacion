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
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Authorization;


namespace Nomina_API.Controllers
{

    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class NominaController : ControllerBase
    {
        private readonly IEmpleadoRepository _empleadoRepo;
        public readonly I_IngresoRepository _ingresoRepo;
        public readonly IDeduccionRepository _deduccionRepo;
        private readonly INominaRepository _nominaRepo;
        private readonly ILogger<IngresoController> _logger;
        private readonly IMapper _mapper;


        public NominaController(IEmpleadoRepository empleadoRepo,I_IngresoRepository i_Ingreso,IDeduccionRepository deducRepo,
            INominaRepository nominaRepo,
            ILogger<IngresoController> logger,
            IMapper mapper)
        {
            _nominaRepo = nominaRepo;
            _empleadoRepo = empleadoRepo;
            _deduccionRepo = deducRepo;
            _ingresoRepo = i_Ingreso;
            _logger = logger;
            _mapper = mapper;
            
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<NominaDto>>> GetNominas()
        {
            try
            {
                _logger.LogInformation("Obteniendo las nominas");

                var nominas = await _nominaRepo.GetAllAsync();

                return Ok(_mapper.Map<IEnumerable<NominaDto>>(nominas));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener las nominas: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al obtener las nominas.");
            }
        }

        [HttpGet("nominas-completas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<NominaCompletaDto>>> GetNominasFinalTodosLosEmpleados()
        {
            try
            {
                _logger.LogInformation("Obteniendo las nominas de todos los empleados");

                var empleados = await _empleadoRepo.GetAllAsync();
                var ingresos = await _ingresoRepo.GetAllAsync();
                var deducciones = await _deduccionRepo.GetAllAsync();
                var nominas = await _nominaRepo.GetAllAsync();

                var resultado = from e in empleados
                                join i in ingresos on e.NumeroEmpleado equals i.NumeroEmpleado
                                join d in deducciones on e.NumeroEmpleado equals d.NumeroEmpleado
                                join n in nominas on e.NumeroEmpleado equals n.NumeroEmpleado
                                select new NominaCompletaDto
                                {
                                    NumeroEmpleado = e.NumeroEmpleado,
                                    NumeroCedula = e.NumeroCedula,
                                    NumeroINSS = e.NumeroINSS,
                                    NumeroRUC = e.NumeroRUC,
                                    PrimerNombre = e.PrimerNombre,
                                    SegundoNombre = e.SegundoNombre,
                                    PrimerApellido = e.PrimerApellido,
                                    SegundoApellido = e.SegundoApellido,
                                    FechaNacimiento = e.FechaNacimiento,
                                    Sexo = e.Sexo,
                                    EstadoCivil = e.EstadoCivil,
                                    Direccion = e.Direccion,
                                    Telefono = e.Telefono,
                                    Celular = e.Celular,
                                    FechaContratacion = e.FechaContratacion,
                                    FechaCierreContrato = e.FechaCierreContrato,
                                    EstadoEmpleado = e.EstadoEmpleado,
                                    YearsTrabajados = e.YearsTrabajados,
                                    SalarioOrdinario = i.SalarioOrdinario,
                                    Antiguedad = i.Antiguedad,
                                    RiesgoLaboral = i.RiesgoLaboral,
                                    Nocturnidad = i.Nocturnidad,
                                    HorasExtras = i.HorasExtras,
                                    ConceptoOtrosIngresos = i.ConceptoOtrosIngresos,
                                    OtrosIngresos = i.OtrosIngresos,
                                    TotalIngresos = i.TotalIngresos,
                                    INSS = d.INSS,
                                    IR =    d.IR,
                                    ConceptoOD = d.ConceptoOD,
                                    MontoOtrasDeducciones = d.MontoOtrasDeducciones,
                                    TotalDeducciones = d.TotalDeducciones,
                                    SalarioNeto = n.SalarioNeto,
                                    FechaNomina = n.FechaNomina
                                };
                   
               return Ok(resultado.ToList());

                
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener las nominas: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al obtener las nominas.");
            }
        }

       
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<NominaDto>> GetNomina(int id)
        {
            if (id <= 0)
            {
                _logger.LogError($"ID de nomina no válido: {id}");
                return BadRequest("ID de nomina no válido");
            }

            try
            {
                _logger.LogInformation($"Obteniendo nomina con ID: {id}");

                var nomina = await _nominaRepo.GetById(id);

                if (nomina == null)
                {
                    _logger.LogWarning($"No se encontró ninguna nomina con ID: {id}");
                    return NotFound("Nomina no encontrada.");
                }

                return Ok(_mapper.Map<NominaDto>(nomina));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener nomina con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al obtener la nomina.");
            }
        }

       
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<NominaDto>> PostNomina(NominaCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió una nomina nula en la solicitud.");
                return BadRequest("La nomina no puede ser nula.");
            }

            try
            {
                _logger.LogInformation($"Creando una nueva nomina para el empleado " +
                    $"con ID: {createDto.NumeroEmpleado}");

               
                var empleadoExist = await _empleadoRepo.ExistsAsync(
                    s => s.NumeroEmpleado == createDto.NumeroEmpleado);

                if (!empleadoExist)
                {
                    _logger.LogWarning($"El empleado con numero de empleado '{createDto.NumeroEmpleado}' no existe.");
                    ModelState.AddModelError("EmpleadoNoExiste", "¡El empleado no existe!");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("El modelo de nomina no es válido.");
                    return BadRequest(ModelState);
                }

                var verIngreso=await _ingresoRepo.ObtenerRegistroIngreso(createDto.NumeroEmpleado);
                createDto.SalarioNeto = await _nominaRepo.GetSalarioNeto(createDto.NumeroEmpleado);
                var newNomina = _mapper.Map<Nomina>(createDto);
               
                var verDeduccion=await _deduccionRepo.ObtenerRegistroDeduccion(createDto.NumeroEmpleado);

                if (await _ingresoRepo.ObtenerIngresoPorNumeroEmpleado(createDto.NumeroEmpleado) == false)
                {
                    return BadRequest("No existe un ingreso para este empleado por lo que no puede generar una nomina");
                }
                if (await _deduccionRepo.ObtenerDeduccionPorNumeroEmpleado(createDto.NumeroEmpleado) == false)
                {
                    return BadRequest("No existe una deducción para este empleado por lo que no puede generar una nomina");
                }

                if (await _nominaRepo.ObtenerNominaPorNumeroEmpleado(createDto.NumeroEmpleado))
                {
                    return BadRequest("Ya existe una nomina para este empleado");
                }

                if (verIngreso != null && verDeduccion != null)
                {

                    await _nominaRepo.CreateAsync(newNomina);

                    _logger.LogInformation($"Nueva nomina creado con ID: " +
                        $"{newNomina.NominaID}");
                    return CreatedAtAction(nameof(GetNominas),
                        new { id = newNomina.NominaID }, newNomina);
                }
                return BadRequest("No se puede ejecutar nomina si no existe un registro de ingreso o deducciones.");
                

                
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear una nueva nomina: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al crear una nueva nomina.");
            }
        }

       
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutNomina(int id,
            NominaUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.NominaID)
            {
                return BadRequest("Los datos de entrada no son válidos o " +
                    "el ID de nomina no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando nomina con ID: {id}");

                var existingNomina = await _nominaRepo.GetById(id);
                if (existingNomina == null)
                {
                    _logger.LogInformation($"No se encontró ninguna nomina con ID: {id}");
                    return NotFound("La nomina no existe.");
                }

               
                var empleadoExists = await _empleadoRepo.ExistsAsync(
                    s => s.NumeroEmpleado == updateDto.NumeroEmpleado);

                if (!empleadoExists)
                {
                    _logger.LogWarning($"El empleado con numero de empleado '{updateDto.NumeroEmpleado}' no existe.");
                    ModelState.AddModelError("EmpleadoNoExiste", "¡El empleado no existe!");
                    return BadRequest(ModelState);
                }

                var verIngreso = await _ingresoRepo.ObtenerRegistroIngreso(updateDto.NumeroEmpleado);
                updateDto.SalarioNeto = await _nominaRepo.GetSalarioNeto(updateDto.NumeroEmpleado);

                if (await _ingresoRepo.ObtenerIngresoPorNumeroEmpleado(updateDto.NumeroEmpleado) == false)
                {
                    return BadRequest("No existe un ingreso para este empleado por lo que no puede generar una nomina");
                }
                if (await _deduccionRepo.ObtenerDeduccionPorNumeroEmpleado(updateDto.NumeroEmpleado) == false)
                {
                    return BadRequest("No existe una deducción para este empleado por lo que no puede generar una nomina");
                }

                
                _mapper.Map(updateDto, existingNomina);

                await _nominaRepo.SaveChangesAsync();

                _logger.LogInformation($"Nomina con ID {id} actualizada correctamente.");

                return NoContent();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!await _nominaRepo.ExistsAsync(a => a.NominaID == id))
                {
                    _logger.LogWarning($"No se encontró ninguna nomina con ID: {id}");
                    return NotFound("La nomina no se encontró durante la actualización");
                }
                else
                {
                    _logger.LogError($"Error de concurrencia al actualizar la nomina " +
                        $"con ID: {id}. Detalles: {ex.Message}");
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error interno del servidor al actualizar la nomina.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al actualizar la nomina: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al actualizar la nomina.");
            }
        }

     
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteNomina(int id)
        {
            try
            {
                _logger.LogInformation($"Eliminando nomina con ID: {id}");

                var nomina = await _nominaRepo.GetById(id);
                if (nomina == null)
                {
                    _logger.LogInformation($"Eliminando nomina con ID: {id}");
                    return NotFound("Nomina no encontrada.");
                }

                await _nominaRepo.DeleteAsync(nomina);

                _logger.LogInformation($"Nomina con ID {id} eliminada correctamente.");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al eliminar el nomina con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Se produjo un error al eliminar la nomina.");
            }
        }
    }
}
