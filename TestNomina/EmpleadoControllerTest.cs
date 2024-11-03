using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Nomina_API.Controllers;
using Nomina_API.Repository.IRepository;
using SharedModels;
using SharedModels.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNomina
{
    public class EmpleadoControllerTest
    {
        private readonly Mock<IEmpleadoRepository> _mockRepo;
        private readonly Mock<ILogger<EmpleadoController>> _mockLogger;
        private readonly Mock<IMapper> _mockMapper;
        private readonly EmpleadoController _controller;
        private readonly Mock<I_IngresoRepository> _mockIngRepo;
        private readonly Mock<IDeduccionRepository> _mockDeduRepo;
        private readonly Mock<INominaRepository> _mockNominaRepo;

        public EmpleadoControllerTest()
        {
            _mockRepo= new Mock<IEmpleadoRepository>();
            _mockIngRepo = new Mock<I_IngresoRepository>();
            _mockDeduRepo= new Mock<IDeduccionRepository>();
            _mockNominaRepo= new Mock<INominaRepository>();
            _mockMapper= new Mock<IMapper>();
            _mockLogger= new Mock<ILogger<EmpleadoController>>();
            _controller = new EmpleadoController(_mockRepo.Object,_mockLogger.Object,_mockMapper.Object,_mockIngRepo.Object,_mockDeduRepo.Object, _mockNominaRepo.Object);
        }
        [Fact]
        public async Task GetEmpleados_ReturnsOkResult_WithListOfEmpleados()
        {
            //Arrange
            var empleados = new List<Empleado>
            {
                new Empleado{ NumeroEmpleado =1, NumeroCedula="0011605061018J",NumeroINSS=09,NumeroRUC="J489545625885",
                PrimerNombre="Eduardo", SegundoNombre="Antonio", PrimerApellido="Hernandez", SegundoApellido="Manzanares",FechaNacimiento=new DateOnly(2005,9,13),Sexo="Femenino",EstadoCivil="Casado",
                Direccion="Bo.Chilamates",Telefono=22508976,Celular=78954254,FechaContratacion=new DateOnly(2020,2,16),FechaCierreContrato=new DateOnly(2026,2,16),EstadoEmpleado=true, YearsTrabajados=4}
            };
            var empleadoDtos = new List<EmpleadoDto> {
                new EmpleadoDto{NumeroEmpleado =1, NumeroCedula="0011605061018J",NumeroINSS=09,NumeroRUC="J489545625885",
                PrimerNombre="Eduardo", SegundoNombre="Antonio", PrimerApellido="Hernandez", SegundoApellido="Manzanares",FechaNacimiento=new DateOnly(2005,9,13),Sexo="Femenino",EstadoCivil="Casado",
                Direccion="Bo.Chilamates",Telefono=22508976,Celular=78954254,FechaContratacion=new DateOnly(2020,2,16),FechaCierreContrato=new DateOnly(2026,2,16),EstadoEmpleado=true, YearsTrabajados=4 } };

            _mockRepo.Setup(repo=> repo.GetAllAsync(null)).ReturnsAsync(empleados);
            _mockMapper
                .Setup(mapper =>
                mapper.Map<IEnumerable<EmpleadoDto>>(It.IsAny<IEnumerable<Empleado>>()))
                .Returns(empleadoDtos);
            //Act
            var result = await _controller.GetEmpleados();
            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<EmpleadoDto>>(okResult.Value);
            Assert.Single(returnValue);
            Assert.Equal(1, returnValue[0].NumeroEmpleado);
        }
        [Fact]
        public async Task GetEmpleado_ReturnNotFound_WhenEmpleadoNotFound()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetById(It.IsAny<int>()))
                .ReturnsAsync((Empleado)null);

            // Act
            var result = await _controller.GetEmpleado(1);

            // Assert
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);
            Assert.Equal("Empleado no encontrado.", notFoundResult.Value);
        }
        [Fact]
        public async Task PostEmpleado_ReturnsBadRequest_WhenModelStateIsInvalid()
        {
            // Arrange
            _controller.ModelState.AddModelError("PrimerNombre", "Required");

            var empleadoCreateDto = new EmpleadoCreateDto { PrimerNombre = "" };

            // Act
            var result = await _controller.PostEmpleado(empleadoCreateDto);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result.Result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
        [Fact]
        public async Task PutEmpleado_ReturnsNotFound_WhenEmpleadoDoesNotExist()
        {
            // Arrange
           
            var updateDto = new EmpleadoUpdateDto { NumeroEmpleado = 1 };
            _mockRepo.Setup(repo => repo.GetById(1)).ReturnsAsync((Empleado)null);

            // Act
            var result = await _controller.PutEmpleado(1, updateDto);

            // Assert
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            Assert.Equal(StatusCodes.Status404NotFound, notFoundResult.StatusCode);
            Assert.Equal("El empleado no existe.", notFoundResult.Value);
        }
        [Fact]
        public async Task DeleteEmpleado_ReturnsNoContent_WhenEmpleadoIsDeleted()
        {
            // Arrange
           
            var empleado = new Empleado
            {
                NumeroEmpleado = 1,
                NumeroCedula = "0011605061018J",
                NumeroINSS = 09,
                NumeroRUC = "J489545625885",
                PrimerNombre = "Eduardo",
                SegundoNombre = "Antonio",
                PrimerApellido = "Hernandez",
                SegundoApellido = "Manzanares",
                FechaNacimiento = new DateOnly(2005, 9, 13),
                Sexo = "Femenino",
                EstadoCivil = "Casado",
                Direccion = "Bo.Chilamates",
                Telefono = 22508976,
                Celular = 78954254,
                FechaContratacion = new DateOnly(2020, 2, 16),
                FechaCierreContrato = new DateOnly(2026, 2, 16),
                EstadoEmpleado = true,
                YearsTrabajados = 4
            };
            _mockRepo.Setup(repo => repo.GetById(1)).ReturnsAsync(empleado);
            _mockRepo.Setup(repo => repo.DeleteAsync(empleado)).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.DeleteEmpleado(1);

            // Assert
            var noContentResult = Assert.IsType<NoContentResult>(result);
            Assert.Equal(StatusCodes.Status204NoContent, noContentResult.StatusCode);
        }
    }
}
