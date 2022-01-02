using System;

namespace CodingChallenge.Data.Classes
{
   public class Circulo : Figura
    {
        public Circulo()
        {
            _STituloCastellano = "Círculo";
            _PTituloCastellano = "Círculos";

            _STituloIngles = "Circle";
            _PTituloIngles = "Circles";

            _STituloItaliano = "Cerchio";
            _PTituloItaliano = "Cerchios";

            _TipoFigura = Figuras.Circulo;
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
