using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    interface IReporte
    {
        string ObtenerLinea(int cantidad, Figura fig, decimal perimetros, decimal areas);

        string TraducirForma(int cantidad, Figura fig);

        string ObtenerTitulo(int cantidad);

        string Imprimir(List<Figura> Listafigura);

        string ObtenerPie(int[] cantFig, decimal[] areas, decimal[] perimeters);
    }
        
}
