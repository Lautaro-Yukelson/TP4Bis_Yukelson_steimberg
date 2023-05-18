using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP4Bis_Yukelson_steimberg.Models
{
    public class Pais
    {
        private static int ID {get; set;} = 1;
        public string Nombre { get; private set; }
        public string imgBandera { get; private set; }
        public int Poblacion { get; private set; }
        public DateTime FechaIndependencia{get; private set;}
        public string AtractivosTuristicos {get; private set;}

        public Pais(int id, string nombre, string img, int poblacion, DateTime fechaIndependencia, string atractivosTuristicos){
            ID = id;
            Nombre = nombre;
            imgBandera = img;
            Poblacion = poblacion;
            FechaIndependencia = fechaIndependencia;
            AtractivosTuristicos = atractivosTuristicos;
        }

        public static int agregarId(){
            ID++;
            return ID--;
        }
    }
}