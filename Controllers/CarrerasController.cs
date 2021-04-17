using Guia4_ADS_CrudCarrera.Models;
using Guia4_ADS_CrudCarrera.Services;
using Guia4_ADS_CrudCarrera.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guia4_ADS_CrudCarrera.Controllers
{
    public class CarrerasController : Controller
    {
        
        public ServiceCarreras servicio = new ServiceCarreras();

        public CarrerasController() { }

        [HttpGet]
        public ActionResult Index()
        {
            var carrera = servicio.obtenerTodos();

            return View(carrera);
        }

        [HttpGet]
        public ActionResult Form(int? Id/*puede aceptar nulos*/, Operacion operacion)
        {
            var carrera = new Carrera();
            
            if (Id.HasValue)
            {
                carrera = servicio.obtenerPorID(Id.Value);
            }
            
            ViewData["Operacion"] = operacion;
            return View(carrera);
        }

        [HttpPost]
        public ActionResult Form(Carrera carrera)
        {
            try
            {
                
                if (carrera.Id == 0)
                {
                    servicio.insertar(carrera);
                }
                else
                {
                    
                    servicio.modificar(carrera.Id, carrera);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw;

            }
        }

        [HttpGet]
        public ActionResult Delete(int Id) 
        {
            try
            {
                
                servicio.eliminar(Id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw;

            }
        }
    }
}