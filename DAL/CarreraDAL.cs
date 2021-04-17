using Guia4_ADS_CrudCarrera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.DAL{
    public class CarreraDAL    
    {
        //LISTADO DE CARRERAS, A NIVEL DE MEMORIA DEL PROYECTO
        public static List<Carrera> lstCarreras = new List<Carrera>();

        //CONSTRUCTOR
        public CarreraDAL() {            
        }

        //INSERTAR CARRERA
        public int insertarCarrera(Carrera carrera) {
            try
            {
                //SI EL LISTADO TIENE ELEMENTOS ENTONCES SE GENERA EL Id.
                if (lstCarreras.Count > 0)
                {
                    carrera.Id = lstCarreras.Last().Id + 1;
                }
                else
                {
                    //SI EL LISTADO ESTA VACIO ENTONCES EL Id SERA POR DEFAULT 1
                    carrera.Id = 1;
                }
                lstCarreras.Add(carrera);
                return carrera.Id;
            }            
            catch(Exception ex)            
            {
                throw;
            }
        }

        //MODIFICAR CARRERA
        public int modificarCarrera(int Id, Carrera carrera)        
        {
            try
            {
                //BUSCANDO EL INDICE EN LA LISTA
                lstCarreras[lstCarreras.FindIndex(temp => temp.Id == Id)] = carrera;
                return carrera.Id;
            }            
            catch (Exception ex)            
            {
                throw;
            }
        }

        //ELIMINAR CARRERA
        public bool eliminarCarrera(int Id) {
            try
            {
                lstCarreras.RemoveAt(lstCarreras.FindIndex(aux => aux.Id == Id));

                return true;
            }            
            catch (Exception ex)            
            {
                throw;
            }
        }

        //PARA LISTAR TODOS LAS CARRERAS
        public List<Carrera> obtenerTodos() {
            return lstCarreras;
        }

        //BUSCAR CARRERA POR Id.
        public Carrera obtenerPorID(int Id) {
            try
            {
                var elementos = lstCarreras.Find(temp => temp.Id == Id);
                return elementos;
            }            
            catch (Exception ex)            
            {
                throw;

            }
        }
    }
}