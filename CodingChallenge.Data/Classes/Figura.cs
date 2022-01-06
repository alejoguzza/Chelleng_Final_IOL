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

        public string STitulo { get; set; }
        public string PTitulo { get; set; }
        public decimal _Area { get; set; }
        public decimal _Perimetro { get; set; }
        public decimal _lado { get; set; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();


    }
}
