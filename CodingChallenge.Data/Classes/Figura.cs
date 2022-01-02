using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{

    public abstract class Figura : IFigura
    {
        public Figuras _TipoFigura { get; set; }
        public decimal _SumaArea { get; set; }
        public decimal _SumaPerimetro { get; set; }
        public string _STituloCastellano { get; set; }
        public string _PTituloCastellano { get; set; }
        public string _STituloIngles { get; set; }
        public string _PTituloIngles { get; set; }
        public string _STituloItaliano { get; set; }
        public string _PTituloItaliano { get; set; }
        public decimal _Area { get; set; }
        public decimal _Perimetro { get; set; }
        public decimal _lado { get; set; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();


    }
}
