using DesignPatterns.Models;
using DesignPatterns.Repositories;
using DesignPatterns.Factories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace DesignPatterns.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVehicleRepository _vehicleRepository;

        public HomeController(IVehicleRepository vehicleRepository, ILogger<HomeController> logger)
        {
            _vehicleRepository = vehicleRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Vehicles = _vehicleRepository.GetVehicles()
            };

            if (Request.Query.ContainsKey("error"))
            {
                ViewBag.ErrorMessage = Request.Query["error"];
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult AddMustang()
        {
            try
            {
                // Crear un Mustang utilizando la fábrica
                var mustang = VehicleFactory.CreateVehicle("Mustang");
                _vehicleRepository.AddVehicle(mustang);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al agregar Mustang.");
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult AddExplorer()
        {
            try
            {
                // Crear un Explorer utilizando la fábrica
                var explorer = VehicleFactory.CreateVehicle("Explorer");
                _vehicleRepository.AddVehicle(explorer);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al agregar Explorer.");
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult AddEscape()
        {
            try
            {
                // Crear un Escape utilizando la fábrica
                var escape = VehicleFactory.CreateVehicle("Escape");
                _vehicleRepository.AddVehicle(escape);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al agregar Escape.");
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult AddGas(Guid id)
        {
            try
            {
                // Buscar el vehículo por ID
                var vehicle = _vehicleRepository.Find(id);
                if (vehicle == null)
                {
                    throw new Exception("Vehicle not found.");
                }

                // Agregar gasolina al vehículo
                vehicle.AddGas();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al llenar tanque.");
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult StartEngine(Guid id)
        {
            try
            {
                // Buscar el vehículo por ID
                var vehicle = _vehicleRepository.Find(id);
                if (vehicle == null)
                {
                    throw new Exception("Vehicle not found.");
                }

                // Encender el motor del vehículo
                vehicle.StartEngine();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al encender el motor.");
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult StopEngine(Guid id)
        {
            try
            {
                // Buscar el vehículo por ID
                var vehicle = _vehicleRepository.Find(id);
                if (vehicle == null)
                {
                    throw new Exception("Vehicle not found.");
                }

                // Apagar el motor del vehículo
                vehicle.StopEngine();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al apagar el motor.");
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
