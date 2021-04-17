using Guia4_ADS_CrudCarrera.DAL;
using Guia4_ADS_CrudCarrera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.Services
{
    public class ServiceGrupos
    {
        // Instancia para acceder a todos los metodos de la DAL
        public GrupoDAL grupoDal = new GrupoDAL();

        // Para insertar estudiante
        public int insertar(Grupo grupo)
        {
            try
            {
                return grupoDal.insertarGrupo(grupo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para modificar un grupo
        public int modificar(int id, Grupo grupo)
        {
            try
            {
                return grupoDal.modificarGrupo(id, grupo);
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
                return grupoDal.eliminarGrupo(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para obtener todos los grupos.
        public List<Grupo> obtenerTodos()
        {
            return grupoDal.obtenerTodos();
        }

        // Para obtener por ID.
        public Grupo obtenerPorID(int id)
        {
            try
            {
                return grupoDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}