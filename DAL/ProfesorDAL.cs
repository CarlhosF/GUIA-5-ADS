using Guia4_ADS_CrudCarrera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.DAL
{
    public class ProfesorDAL
    {
        // Listado de profesores, a nivel de memoria del proyecto
        public static List<Profesor> lstProfesores = new List<Profesor>();

        public ProfesorDAL() { }

        public int insertarProfesor(Profesor profesor)
        {
            try
            {
                // Si el listado tiene elementos entonces se genera el ID.
                if (lstProfesores.Count > 0)
                {
                    profesor.id = lstProfesores.Last().id + 1;
                }
                else
                {
                    // Si el listado esta vacio entonces el id será por default 1
                    profesor.id = 1;
                }
                lstProfesores.Add(profesor);
                return profesor.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarProfesor(int id, Profesor profesor)
        {
            try
            {
                // Buscando el indice en la lista
                lstProfesores[lstProfesores.FindIndex(temp => temp.id == id)] = profesor;
                return profesor.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para eliminar un profesor del listado
        public bool eliminarProfesor(int id)
        {
            try
            {
                lstProfesores.RemoveAt(lstProfesores.FindIndex(aux => aux.id == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para listar todos los profesores
        public List<Profesor> obtenerTodos()
        {
            return lstProfesores;
        }

        // para encontrar un profesor por ID
        public Profesor obtenerPorID(int id)
        {
            try
            {
                var elementos = lstProfesores.Find(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}