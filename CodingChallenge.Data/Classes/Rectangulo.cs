using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : Figura
    {

        public Rectangulo(Idiomas Culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((int)Culture);
            


            _TipoFigura = Figuras.Rectangulo;

            STitulo = Labes.Rectengulo;
            PTitulo = Labes.Rectangulos;
        }

        
        public decimal _base { get; set; }
        public override decimal CalcularArea()
        {
            _Area = (_lado * _base);
            return _Area;
        }

        public override decimal CalcularPerimetro()
        {
            _Perimetro = (_lado * _base)* 2;
            return _Perimetro;
        }
    }
}
