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
    public class GruposController : Controller
    {
        
        public ServiceGrupos servicio = new ServiceGrupos();

        public GruposController() { }


        [HttpGet]
        public ActionResult Index()
        {
            var grupo = servicio.obtenerTodos();
            return View(grupo);
        }

        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var grupo = new Grupo();
            
            if (id.HasValue)
            {
                grupo = servicio.obtenerPorID(id.Value);
            }
            
            ViewData["Operacion"] = operacion;
            return View(grupo);
        }

        [HttpPost]
        public ActionResult Form(Grupo grupo)
        {
            try
            {
                
                if (grupo.id == 0)
                {
                    servicio.insertar(grupo);
                }
                else
                {
                    
                    servicio.modificar(grupo.id, grupo);
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