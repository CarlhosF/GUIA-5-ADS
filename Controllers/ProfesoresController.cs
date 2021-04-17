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
    public class ProfesoresController : Controller
    {
        
        public ServiceProfesores servicio = new ServiceProfesores();

        public ProfesoresController() { }


        [HttpGet]
        public ActionResult Index()
        {
            var profesor = servicio.obtenerTodos();
            return View(profesor);
        }

        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var profesor = new Profesor();
            
            if (id.HasValue)
            {
                profesor = servicio.obtenerPorID(id.Value);
            }
            
            ViewData["Operacion"] = operacion;
            return View(profesor);
        }

        [HttpPost]
        public ActionResult Form(Profesor profesor)
        {
            try
            {
                
                if (profesor.id == 0)
                {
                    servicio.insertar(profesor);
                }
                else
                {
                    
                    servicio.modificar(profesor.id, profesor);
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