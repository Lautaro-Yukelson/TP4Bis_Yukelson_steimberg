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
            ListaPaises.Add(new Pais(Pais.agregarId(), "Argentina", "argentina.webp", 45810000, DateTime.Parse("09/07/1810"), "Cataratas del Iguazú"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "España", "espana.webp", 46733038, DateTime.Parse("12/10/1492"), "La Alhambra"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "Canadá", "canada.webp", 37961548, DateTime.Parse("01/07/1867"), "Las Cataratas del Niágara"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "Colombia", "colombia.webp", 50372424, DateTime.Parse("20/07/1810"), "La Ciudad Perdida"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "México", "mexico.webp", 126190788, DateTime.Parse("16/09/1810"), "Chichén Itzá"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "Francia", "francia.webp", 67210000, DateTime.Parse("14/07/1789"), "La Torre Eiffel"));
            ListaPaises.Add(new Pais(Pais.agregarId(), "Rusia", "rusia.webp", 144526636, DateTime.Parse("12/06/1990"), "La Plaza Roja"));
        }

        public static List<Pais> ListarPaises(){
            if (!(ListaPaises.Count() != null)) {
                IniciarLista();
                
            }
            return ListaPaises;
        }

        public static Pais DetallePais(int id){
            return ListaPaises[id-1];
        }

        public static int CantPaises(){
            return ListaPaises.Count();
        }
    }
}