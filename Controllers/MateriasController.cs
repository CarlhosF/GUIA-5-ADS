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
    public class MateriasController : Controller
    {
        
        public ServiceMaterias servicio = new ServiceMaterias();

        public MateriasController() { }


        [HttpGet]
        public ActionResult Index()
        {
            var materia = servicio.obtenerTodos();
            return View(materia);
        }

        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var materia = new Materia();
            
            if (id.HasValue)
            {
                materia = servicio.obtenerPorID(id.Value);
            }
            
            ViewData["Operacion"] = operacion;
            return View(materia);
        }

        [HttpPost]
        public ActionResult Form(Materia materia)
        {
            try
            {
                
                if (materia.id == 0)
                {
                    servicio.insertar(materia);
                }
                else
                {
                 
                    servicio.modificar(materia.id, materia);
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