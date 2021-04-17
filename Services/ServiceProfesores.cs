using Guia4_ADS_CrudCarrera.DAL;
using Guia4_ADS_CrudCarrera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.Services
{
    public class ServiceProfesores
    {
        // Instancia para acceder a todos los metodos de la DAL
        public ProfesorDAL profesorDal = new ProfesorDAL();

        // Para insertar profesor
        public int insertar(Profesor profesor)
        {
            try
            {
                return profesorDal.insertarProfesor(profesor);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para modificar un profesor
        public int modificar(int id, Profesor profesor)
        {
            try
            {
                return profesorDal.modificarProfesor(id, profesor);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para eliminar

        public bool eliminar(int id)
        {
            try
            {
                return profesorDal.eliminarProfesor(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para obtener todos los profesores.
        public List<Profesor> obtenerTodos()
        {
            return profesorDal.obtenerTodos();
        }

        // Para obtener por ID.
        public Profesor obtenerPorID(int id)
        {
            try
            {
                return profesorDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}