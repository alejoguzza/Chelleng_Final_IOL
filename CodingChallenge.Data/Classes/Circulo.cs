using System;
using System.Globalization;
using System.Threading;

namespace CodingChallenge.Data.Classes
{
   public class Circulo : Figura
    {
        public Circulo(Idiomas Culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((int)Culture);
            _TipoFigura = Figuras.Circulo;

            STitulo = Labes.Circulo;
            PTitulo = Labes.Circulos;
        }

        
        public override decimal CalcularArea()
        {
            _Area = (decimal)Math.PI * (_lado / 2) * (_lado / 2);
            return _Area;
        }

        public override decimal CalcularPerimetro()
        {
            _Perimetro = (decimal)Math.PI* _lado;

            return _Perimetro;
        }
    }
}
