using Guia4_ADS_CrudCarrera.DAL;
using Guia4_ADS_CrudCarrera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.Services
{
    public class ServiceMaterias
    {
        // Instancia para acceder a todos los metodos de la DAL
        public MateriaDAL materiaDal = new MateriaDAL();

        // Para insertar materia
        public int insertar(Materia materia)
        {
            try
            {
                return materiaDal.insertarMateria(materia);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para modificar una materia
        public int modificar(int id, Materia materia)
        {
            try
            {
                return materiaDal.modificarMateria(id, materia);
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
                return materiaDal.eliminarMateria(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para obtener todas las materias.
        public List<Materia> obtenerTodos()
        {
            return materiaDal.obtenerTodos();
        }

        // Para obtener por ID.
        public Materia obtenerPorID(int id)
        {
            try
            {
                return materiaDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}