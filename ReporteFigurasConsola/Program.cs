using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Classes;

namespace ReporteFigurasConsola
{
    //Se crea este proyecto de Consola, para ver los resultados de la ejecucion, por fuera del proyecto testin unit
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lstFig = GetFiguras();
            Console.WriteLine("CASTELLANO");
            ReporteCastellano r = new ReporteCastellano();
            var s= r.Imprimir(lstFig);
            Console.WriteLine(s);

            Console.WriteLine("INGLES");
            ReporteIngles i = new ReporteIngles();
            var ri = i.Imprimir(lstFig);

            Console.WriteLine(ri);

            Console.WriteLine("ITALIANO");
            ReporteItaliano it = new ReporteItaliano();
            var t = it.Imprimir(lstFig);

            Console.WriteLine(t);
            
            ReporteItaliano itv = new ReporteItaliano();
            var tv = it.Imprimir(new List<Figura>());
            Console.WriteLine(tv);


            Console.ReadLine();
            
        }

       static List<Figura> GetFiguras()
        {
            List<Figura> lstFig = new List<Figura>();
            for (int i = 0; i < 5; i++)
            {
                var o = new Cuadrado { _lado = i };
                lstFig.Add(o);

                var c = new Circulo { _lado=i };
                lstFig.Add(c);

                var t = new Triangulo { _lado = i, _lado2 =i, _ladoA = i };
                lstFig.Add(t);

                var tr = new Trapecio { _lado = i+2, _lado2 = i, _ladoA = i+3 };
                lstFig.Add(tr);

                var r = new Rectangulo { _lado = i + 2, _base=i+3 };
                lstFig.Add(r);

               

            }

            return lstFig;
        }

    }
}
