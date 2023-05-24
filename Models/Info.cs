using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP4Bis_Yukelson_steimberg.Models
{
    public class Info
    {
        private static List<Pais> ListaPaises { get; set; } = new List<Pais>();

        private static void IniciarLista(){
            ListaPaises.Add(new Pais(Pais.agregarId(), "Argentina", "argentina.png", 45810000, DateTime.Parse("09/07/1810").Date, "Cataratas del Iguazú"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "España", "espana.png", 46733038, DateTime.Parse("12/10/1492").Date, "La Alhambra"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "Canadá", "canada.png", 37961548, DateTime.Parse("01/07/1867").Date, "Las Cataratas del Niágara"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "Colombia", "colombia.png", 50372424, DateTime.Parse("20/07/1810").Date, "La Ciudad Perdida"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "México", "mexico.png", 126190788, DateTime.Parse("16/09/1810").Date, "Chichén Itzá"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "Francia", "francia.png", 67210000, DateTime.Parse("14/07/1789").Date, "La Torre Eiffel"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "Rusia", "rusia.png", 144526636, DateTime.Parse("12/06/1990").Date, "La Plaza Roja"));
        }


        public static List<Pais> ListarPaises(){
            if (ListaPaises.Count() < 1){
                IniciarLista();
            }
            return ListaPaises;
        }

        public static Pais DetallePais(int id){
            return ListaPaises[id];
        }

        public static int CantPaises(){
            return ListaPaises.Count();
        }
    }
}