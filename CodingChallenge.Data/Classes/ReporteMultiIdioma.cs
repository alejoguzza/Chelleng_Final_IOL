using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;

namespace CodingChallenge.Data.Classes
{
    public static class ReporteMultiIdioma
    {

        static string _ArrayFigurasVacio;
        static string _Encabezado ;
        static string _Area;
        static string _Perimetro ;
        static string _Formas ;

        static void CargarIdiomas()
        {
            _ArrayFigurasVacio = Labes.ArrayFigurasVacio;
            _Encabezado = Labes.Encabezado;
           _Area = Labes.Area;
           _Perimetro = Labes.Perimetro;
            _Formas = Labes.Formas;
        }
        static string ObtenerLinea(Figura Fig, int cantidad, decimal perimetros, decimal areas)
        {
            return $"{cantidad} {TraducirForma(cantidad,Fig)} | {_Area} {areas:#.##} | {_Perimetro} {perimetros:#.##} <br/>";
            
        }

        static string ObtenerPie(int[] cantFig, decimal[] areas, decimal[] perimeters)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append($"{cantFig.Sum()} {_Formas}");
            sb.Append($" {_Perimetro} {perimeters.Sum().ToString("#.##")}");
            sb.Append($" {_Area} {areas.Sum().ToString("#.##")}");

            return sb.ToString();
        }

        static  string ObtenerTitulo(int cantidad)
        {
            if (cantidad == 0)
                return $"<h1>{_ArrayFigurasVacio}</h1>";//" < h1>Lista vacía de formas!</h1>";
            else
                return $"<h1>{_Encabezado}</h1>";//"<h1>Reporte de Formas</h1>";

        }

        static string TraducirForma(int cantidad,Figura Fig)
        {
            return cantidad == 1 ? Fig.STitulo : Fig.PTitulo;
        }

        public static string Imprimir(List<Figura> Listafigura,Idiomas Culture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo((int)Culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((int)Culture);

            CargarIdiomas();
            var sb = new StringBuilder();
            var TiposFiguras = Enum.GetValues(typeof(Figuras)).Cast<int>();

            var CantFormas = Listafigura.Any() ? Listafigura.Count : 0;
            decimal[] TotalAreas = new decimal[TiposFiguras.Count()];
            decimal[] TotalPerimetros = new decimal[TiposFiguras.Count()];
            int[] CantXFigura = new int[TiposFiguras.Count()];

            sb.Append(ObtenerTitulo(CantFormas));

            if (CantFormas == 0)
                return sb.ToString();
            else
            {
                foreach (var item in Listafigura)
                {
                    var fig = (int)item._TipoFigura;
                    CantXFigura[fig]++;
                    TotalAreas[fig] += item.CalcularArea();
                    TotalPerimetros[fig] += item.CalcularPerimetro();
                }
                for (int i = 0; i < TiposFiguras.Count(); i++)
                {
                    var figura = Listafigura.FirstOrDefault(x => (int)x._TipoFigura == i);
                    if (figura != null)
                        sb.Append(ObtenerLinea(figura, CantXFigura[i],  TotalPerimetros[i], TotalAreas[i]));
                }

                sb.Append(ObtenerPie(CantXFigura, TotalAreas, TotalPerimetros));

            }

            return sb.ToString();
        }
    }
}
