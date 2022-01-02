using CodingChallenge.Data.Classes;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingChallenge.Data.Test
{
    
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            ReporteCastellano rc = new ReporteCastellano();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                rc.Imprimir(new List<Figura>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            ReporteIngles rc = new ReporteIngles();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                rc.Imprimir(new List<Figura>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Figura> { new Cuadrado { _lado = 5 } };
            ReporteCastellano rc = new ReporteCastellano();
            var resumen = rc.Imprimir(cuadrados);
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Figura>
            {
                new Cuadrado {_lado=5},
                new Cuadrado {_lado=1},
                new Cuadrado {_lado=3}
            };

            ReporteIngles rc = new ReporteIngles();
            var resumen = rc.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            ReporteIngles rc = new ReporteIngles();

            var formas = new List<Figura>
            {
                new Cuadrado {_lado=5},
                new Circulo {_lado=3},
                new Triangulo {_lado=4},
                new Cuadrado {_lado=2},
                new Triangulo {_lado=9},
                new Circulo {_lado=2.75m},
                new Triangulo {_lado=4.2m }
            };

            var resumen = rc.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            ReporteCastellano rc = new ReporteCastellano();
            var formas = new List<Figura>
            {
                new Cuadrado {_lado=5},
                new Circulo {_lado=3},
                new Triangulo {_lado=4},
                new Cuadrado {_lado=2},
                new Triangulo {_lado=9},
                new Circulo {_lado=2.75m},
                new Triangulo {_lado=4.2m }
            };

            var resumen = rc.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
