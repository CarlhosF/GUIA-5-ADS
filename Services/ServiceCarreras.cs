using Guia4_ADS_CrudCarrera.DAL;
using Guia4_ADS_CrudCarrera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.Services{
    public class ServiceCarreras    {
        //INSTANCIA PARA ACCEDER A TODOS LOS METODOS DE LA DAL
        public CarreraDAL carreraDal = new CarreraDAL();

        //PARA INSERTAR CARRERA
        public int insertar(Carrera carrera) {
            try
            {
                return carreraDal.insertarCarrera(carrera);
            }            
            catch (Exception ex)            
            {
                throw;
            }
        }

        //PARA MODIFICAR UNA CARRERA
        public int modificar(int Id, Carrera carrera)        
        {
            try
            {
                return carreraDal.modificarCarrera(Id, carrera);
            }            
            catch (Exception ex)            
            {
                throw;
            }
        }

        //PARA ELIMINAR UNA CARRERA
        public bool eliminar(int Id)        
        {
            try
            {
                return carreraDal.eliminarCarrera(Id);
            }            
            catch (Exception ex)            
            {
                throw;
            }
        }

        //PARA OBTENER TODAS LAS CARRERAS.
        public List<Carrera> obtenerTodos() {
            return carreraDal.obtenerTodos();
        }

        //PARA OBTENER POR ID.
        public Carrera obtenerPorID(int Id) {
            try
            {
                return carreraDal.obtenerPorID(Id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}