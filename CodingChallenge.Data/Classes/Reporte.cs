using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Reporte : IReporte
    {
        public Idiomas _IdiomaReporte { get; set; }
        public abstract string ObtenerLinea(int cantidad, Figura fig, decimal perimetros, decimal areas);

        public abstract string TraducirForma(int cantidad, Figura fig);

        public abstract string ObtenerTitulo(int cantidad);

        public string Imprimir(List<Figura> Listafigura)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-AR");
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
                    if(figura!=null)
                        sb.Append(ObtenerLinea(CantXFigura[i], figura, TotalPerimetros[i], TotalAreas[i]));
                }

                sb.Append(ObtenerPie(CantXFigura, TotalAreas, TotalPerimetros));

            }

            return sb.ToString();
        }

        public abstract string ObtenerPie(int[] cantFig, decimal[] areas, decimal[] perimeters);
    }
}
