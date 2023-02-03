using mi_primer_proyecto.Models;
using mi_primer_proyecto.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace mi_primer_proyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioEquipos repositorioEquipos;
        private readonly ServicioDelimitado servicioDelimitado;
        private readonly ServicioTransitorio servicioTransitorio;
        private readonly ServicioUnico servicioUnico;
        private readonly ServicioDelimitado servicioDelimitado2;
        private readonly ServicioTransitorio servicioTransitorio2;
        private readonly ServicioUnico servicioUnico2;

        public HomeController(ILogger<HomeController> logger, IRepositorioEquipos repositorioEquipos,
            ServicioDelimitado servicioDelimitado,
            ServicioTransitorio servicioTransitorio,
            ServicioUnico servicioUnico,

            ServicioDelimitado servicioDelimitado2,
            ServicioTransitorio servicioTransitorio2,
            ServicioUnico servicioUnico2)
        {
            _logger = logger;
            this.repositorioEquipos = repositorioEquipos;
            this.servicioDelimitado = servicioDelimitado;
            this.servicioTransitorio = servicioTransitorio;
            this.servicioUnico = servicioUnico;
            this.servicioDelimitado2 = servicioDelimitado2;
            this.servicioTransitorio2 = servicioTransitorio2;
            this.servicioUnico2 = servicioUnico2;
        }

        public IActionResult Index()
        {
            ViewBag.name= "Joan Solis";
            ViewBag.ocupacion = "Analista de Sistema";

            
            var equipo = repositorioEquipos.ObtenerEquipos().Take(3).ToList();
            var guidViewModel = new EjemploGuidView()
            {
                Delimitado = servicioDelimitado.ObtenerGuid,
                Transitorio = servicioTransitorio.ObtenerGuid,
                Unico = servicioUnico.ObtenerGuid
            };
            var guidViewModel2 = new EjemploGuidView()
            {
                Delimitado = servicioDelimitado2.ObtenerGuid,
                Transitorio = servicioTransitorio2.ObtenerGuid,
                Unico = servicioUnico2.ObtenerGuid
            };
            var modelo = new IndexHome() { 
                Equipo = equipo ,
                EjemploGuid_1 = guidViewModel,
                EjemploGuid_2 = guidViewModel2
            };

            return View(modelo);
        }
       

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult _Resumen()
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