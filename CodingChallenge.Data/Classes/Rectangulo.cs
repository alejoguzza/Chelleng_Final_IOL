using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : Figura
    {

        public Rectangulo()
        {
            _STituloCastellano = "Rectangulo";
            _PTituloCastellano = "Rectangulos";

            _STituloIngles = "Rectangle";
            _PTituloIngles = "Rectangles";

            _STituloItaliano = "Rectangolo";
            _PTituloItaliano = "Rectangolos";

            _TipoFigura = Figuras.Rectangulo;
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
