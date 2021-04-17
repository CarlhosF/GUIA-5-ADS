using Guia4_ADS_CrudCarrera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.DAL
{
    public class MateriaDAL
    {
        // Listado de materias, a nivel de memoria del proyecto
        public static List<Materia> lstMaterias = new List<Materia>();

        public MateriaDAL() { }

        public int insertarMateria(Materia materia)
        {
            try
            {
                // Si el listado tiene elementos entonces se genera el ID.
                if (lstMaterias.Count > 0)
                {
                    materia.id = lstMaterias.Last().id + 1;
                }
                else
                {
                    // Si el listado esta vacio entonces el id será por default 1
                    materia.id = 1;
                }
                lstMaterias.Add(materia);
                return materia.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarMateria(int id, Materia materia)
        {
            try
            {
                // Buscando el indice en la lista
                lstMaterias[lstMaterias.FindIndex(temp => temp.id == id)] = materia;
                return materia.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para eliminar una materia del listado
        public bool eliminarMateria(int id)
        {
            try
            {
                lstMaterias.RemoveAt(lstMaterias.FindIndex(aux => aux.id == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para listar todos las materias
        public List<Materia> obtenerTodos()
        {
            return lstMaterias;
        }

        // para encontrar una materia por ID
        public Materia obtenerPorID(int id)
        {
            try
            {
                var elementos = lstMaterias.Find(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}