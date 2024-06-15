using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nomina_API.Repository.IRepository;
using SharedModels;
using SharedModels.Dto;

namespace Nomina_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeduccionController : ControllerBase
    {
        private readonly IEmpleadoRepository _empleadoRepo;
        private readonly IDeduccionRepository _deduccionRepo;
        private readonly ILogger<DeduccionController> _logger;
        private readonly IMapper _mapper;

        public DeduccionController(IEmpleadoRepository empleadoRepo,
            IDeduccionRepository deduccionRepo,
            ILogger<DeduccionController> logger,
            IMapper mapper)
        {
            _deduccionRepo = deduccionRepo;
            _empleadoRepo = empleadoRepo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<DeduccionDto>>> GetDeducciones()
        {
            try
            {
                _logger.LogInformation("Obteniendo las deducciones");

                var deducciones = await _deduccionRepo.GetAllAsync();

                return Ok(_mapper.Map<IEnumerable<DeduccionDto>>(deducciones));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener las deducciones: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al obtener las deducciones.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DeduccionDto>> GetDeduccion(int id)
        {
            if (id <= 0)
            {
                _logger.LogError($"ID de deducción no válido: {id}");
                return BadRequest("ID de deducción no válido");
            }

            try
            {
                _logger.LogInformation($"Obteniendo deducción con ID: {id}");

                var deduccion = await _deduccionRepo.GetById(id);

                if (deduccion == null)
                {
                    _logger.LogWarning($"No se encontró ninguna deduccion con ID: {id}");
                    return NotFound("Deduccion no encontrada.");
                }

                return Ok(_mapper.Map<DeduccionDto>(deduccion));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener deducción con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al obtener la deduccion.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DeduccionDto>> PostAttendance(DeduccionCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió una deducción nula en la solicitud.");
                return BadRequest("La deducción no puede ser nula.");
            }

            try
            {
                _logger.LogInformation($"Creando una nueva deducción para el empleado " +
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
                    _logger.LogError("El modelo de deducción no es válido.");
                    return BadRequest(ModelState);
                }

                // Crear la nueva deduccion
                var newDeduccion = _mapper.Map<Deduccion>(createDto);

                await _deduccionRepo.CreateAsync(newDeduccion);

                _logger.LogInformation($"Nueva deduccion creada con ID: " +
                    $"{newDeduccion.DeduccionID}");
                return CreatedAtAction(nameof(GetDeducciones),
                    new { id = newDeduccion.DeduccionID }, newDeduccion);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear una nueva deducción: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al crear una nueva deducción.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutDeduccion(int id,
            DeduccionUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.DeduccionID)
            {
                return BadRequest("Los datos de entrada no son válidos o " +
                    "el ID de deducción no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando deducción con ID: {id}");

                var existingDeduccion = await _deduccionRepo.GetById(id);
                if (existingDeduccion == null)
                {
                    _logger.LogInformation($"No se encontró ninguna deducción con ID: {id}");
                    return NotFound("La deducción no existe.");
                }

                // Verificar si el empleado existe
                var empleadoExists = await _empleadoRepo.ExistsAsync(
                    s => s.NumeroEmpleado == updateDto.NumeroEmpleado);

                if (!empleadoExists)
                {
                    _logger.LogWarning($"El empleado con numero de empleado '{updateDto.NumeroEmpleado}' no existe.");
                    ModelState.AddModelError("EmpleadoNoExiste", "¡El empleado no existe!");
                    return BadRequest(ModelState);
                }

                // Actualizar solo las propiedades necesarias del empleado existente
                _mapper.Map(updateDto, existingDeduccion);

                await _deduccionRepo.SaveChangesAsync();

                _logger.LogInformation($"Deducción con ID {id} actualizada correctamente.");

                return NoContent();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!await _deduccionRepo.ExistsAsync(a => a.DeduccionID == id))
                {
                    _logger.LogWarning($"No se encontró ninguna deducción con ID: {id}");
                    return NotFound("La deducción no se encontró durante la actualización");
                }
                else
                {
                    _logger.LogError($"Error de concurrencia al actualizar la deducción " +
                        $"con ID: {id}. Detalles: {ex.Message}");
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error interno del servidor al actualizar la deducción.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al actualizar la deducción: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al actualizar la deducción.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteDeduccion(int id)
        {
            try
            {
                _logger.LogInformation($"Eliminando deducción con ID: {id}");

                var deduccion = await _deduccionRepo.GetById(id);
                if (deduccion == null)
                {
                    _logger.LogInformation($"Eliminando deducción con ID: {id}");
                    return NotFound("deducción no encontrada.");
                }

                await _deduccionRepo.DeleteAsync(deduccion);

                _logger.LogInformation($"Deducción con ID {id} eliminada correctamente.");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al eliminar la deducción con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Se produjo un error al eliminar la deducción.");
            }
        }
    }
}
