using System;
using System.Globalization;
using System.Threading;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : Figura
    {
        public Triangulo(Idiomas Culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((int)Culture);


            _TipoFigura = Figuras.TrianguloEquilatero;

            STitulo = Labes.Triangulo;
            PTitulo = Labes.Triangulos;
        }

        
        public decimal _lado2 { get; set; }
        public decimal _ladoA { get; set; } //Altura
        public override decimal CalcularArea()
        {
            _Area = ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
            return _Area;
        }

        public override decimal CalcularPerimetro()
        {
            _Perimetro = _lado * 3;

            return _Perimetro;
            
        }
    }
}
