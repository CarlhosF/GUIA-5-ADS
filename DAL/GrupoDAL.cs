using Guia4_ADS_CrudCarrera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.DAL
{
    public class GrupoDAL
    {
        // Listado de grupos, a nivel de memoria del proyecto
        public static List<Grupo> lstGrupos = new List<Grupo>();

        public GrupoDAL() { }

        public int insertarGrupo(Grupo grupo)
        {
            try
            {
                // Si el listado tiene elementos entonces se genera el ID.
                if (lstGrupos.Count > 0)
                {
                    grupo.id = lstGrupos.Last().id + 1;
                }
                else
                {
                    // Si el listado esta vacio entonces el id será por default 1
                    grupo.id = 1;
                }
                lstGrupos.Add(grupo);
                return grupo.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarGrupo(int id, Grupo grupo)
        {
            try
            {
                // Buscando el indice en la lista
                lstGrupos[lstGrupos.FindIndex(temp => temp.id == id)] = grupo;
                return grupo.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para eliminar un grupo del listado
        public bool eliminarGrupo(int id)
        {
            try
            {
                lstGrupos.RemoveAt(lstGrupos.FindIndex(aux => aux.id == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para listar todos los grupos
        public List<Grupo> obtenerTodos()
        {
            return lstGrupos;
        }

        // para encontrar un grupo por ID
        public Grupo obtenerPorID(int id)
        {
            try
            {
                var elementos = lstGrupos.Find(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}