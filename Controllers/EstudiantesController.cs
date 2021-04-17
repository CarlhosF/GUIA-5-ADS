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
    public class EstudiantesController : Controller
    {
        
        public ServiceEstudiantes servicio = new ServiceEstudiantes();

        public EstudiantesController() { }


        [HttpGet]
        public ActionResult Index()
        {
            var estudiante = servicio.obtenerTodos();
            return View(estudiante);
        }

        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var estudiante = new Estudiante();
            
            if (id.HasValue)
            {
                estudiante = servicio.obtenerPorID(id.Value);
            }
            
            ViewData["Operacion"] = operacion;
            return View(estudiante);
        }

        [HttpPost]
        public ActionResult Form(Estudiante estudiante)
        {
            try
            {
                
                if (estudiante.id == 0)
                {
                    servicio.insertar(estudiante);
                }
                else
                {
                    
                    servicio.modificar(estudiante.id, estudiante);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                
                servicio.eliminar(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}