using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{

    public class Cuadrado : Figura
    {
        public Cuadrado()
        {
            _STituloCastellano = "Cuadrado";
            _PTituloCastellano = "Cuadrados";

            _STituloIngles = "Square";
            _PTituloIngles = "Squares";

            _STituloItaliano = "Quadrato";
            _PTituloItaliano = "Quadratos";

            _TipoFigura = Figuras.Cuadrado;
        }

        public override decimal CalcularArea()
        {
            _Area= _lado * _lado;

            return _Area;       
        }

        public override decimal CalcularPerimetro()
        {
            _Perimetro = _lado * 4;

            return _Perimetro;   
            
        }

   
    }
}
