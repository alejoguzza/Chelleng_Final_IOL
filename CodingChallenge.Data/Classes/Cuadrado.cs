using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{

    public class Cuadrado : Figura
    {
        public Cuadrado(Idiomas Culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((int)Culture);


            _TipoFigura = Figuras.Cuadrado;

            STitulo = Labes.Cuadrado;
            PTitulo = Labes.Cuadrados;
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
