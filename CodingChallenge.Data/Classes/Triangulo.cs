using System;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : Figura
    {
        public Triangulo()
        {
            _STituloCastellano = "Triángulo";
            _PTituloCastellano = "Triángulos";

            _STituloIngles = "Triangle";
            _PTituloIngles = "Triangles";

            _STituloItaliano = "Triangolo";
            _PTituloItaliano = "Triangolos";

            _TipoFigura = Figuras.TrianguloEquilatero;
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
