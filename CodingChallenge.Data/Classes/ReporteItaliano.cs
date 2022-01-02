using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ReporteItaliano: Reporte
    {
        public ReporteItaliano()
        {
            _IdiomaReporte = Idiomas.Italiano;
        }
        public override string ObtenerLinea( int cantidad, Figura fig, decimal perimetros, decimal areas)
        {
            return $"{cantidad} {TraducirForma(cantidad, fig)} | Area {areas:#.##} | Perimeter {perimetros:#.##} <br/>";

        }

        public override string ObtenerPie(int[] cantFig, decimal[] areas, decimal[] perimeters)
        {
            var sb = new StringBuilder();
            sb.Append("TOTALE:<br/>");
            sb.Append($"{cantFig.Sum()} formes ");
            sb.Append($"Perimetro {perimeters.Sum().ToString("#.##")} ");
            sb.Append($"Area {areas.Sum().ToString("#.##")}");

            return sb.ToString();
        }

        public override string ObtenerTitulo(int cantidad)
        {
            if (cantidad == 0)
                return "<h1>la lista è vuota mascalsone!</h1>";
            else
                return "<h1>Reporte di formes</h1>";
        
        }

        public override string TraducirForma(int cantidad, Figura fig)
        {
            return cantidad == 1 ? fig._STituloItaliano: fig._PTituloItaliano;
        }
    }
}
