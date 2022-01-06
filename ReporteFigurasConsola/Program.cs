using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodingChallenge.Data.Classes;

namespace ReporteFigurasConsola
{
    //Se crea este proyecto de Consola, para ver los resultados de la ejecucion, por fuera del proyecto testin unit
    class Program
    {
        static void Main(string[] args)
        {
            var Cultura = Idiomas.Castellano;
            List<Figura> lstFig = GetFiguras(Cultura);

            var res = ReporteMultiIdioma.Imprimir(lstFig, Cultura);
            Console.WriteLine(res);


            var re2 = ReporteMultiIdioma.Imprimir(new List<Figura>(), Cultura);
            Console.WriteLine(re2);

            Console.ReadLine();
            
        }

       static List<Figura> GetFiguras(Idiomas Cultura)
        {
            
            List<Figura> lstFig = new List<Figura>();
            for (int i = 0; i < 5; i++)
            {
                var o = new Cuadrado(Cultura) { _lado = i };
                lstFig.Add(o);

                var c = new Circulo (Cultura) { _lado=i };
                lstFig.Add(c);

                var t = new Triangulo(Cultura) { _lado = i, _lado2 =i, _ladoA = i };
                lstFig.Add(t);

                var tr = new Trapecio(Cultura) { _lado = i+2, _lado2 = i, _ladoA = i+3 };
                lstFig.Add(tr);

                var r = new Rectangulo(Cultura) { _lado = i + 2, _base=i+3 };
                lstFig.Add(r);

               

            }

            return lstFig;
        }

    }
}
