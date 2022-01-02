using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : Figura
    {

        public Trapecio()
        {
            _STituloCastellano = "Trapecio";
            _PTituloCastellano = "Trapecios";

            _STituloIngles = "Trapeze";
            _PTituloIngles = "Trapezes";

            _STituloItaliano = "Trapezio";
            _PTituloItaliano = "Trapezios";

            _TipoFigura = Figuras.Trapecio;
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
