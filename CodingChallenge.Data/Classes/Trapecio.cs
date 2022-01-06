using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : Figura
    {

        public Trapecio(Idiomas Culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((int)Culture);

            _TipoFigura = Figuras.Trapecio;

            STitulo = Labes.Trapecio;
            PTitulo = Labes.Trapecios;
        }

        
        public decimal _lado2 { get; set; }
        public decimal _ladoA { get; set; } //Altura
        public override decimal CalcularArea()
        {
            _Area = (_lado * _lado2 * _ladoA) / 2;
            return _Area;
        }

        public override decimal CalcularPerimetro()
        {
            _Perimetro = _lado * 3;
            return _Perimetro;
        }
    }
}
