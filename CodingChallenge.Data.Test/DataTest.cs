using CodingChallenge.Data.Classes;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingChallenge.Data.Test
{

    [TestFixture]
    public class Tests
    {




        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var cultura = Idiomas.Ingles;
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReporteMultiIdioma.Imprimir(new List<Figura>(), cultura));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cultura = Idiomas.Castellano;
            var cuadrados = new List<Figura> { new Cuadrado (cultura) { _lado = 5 } };
            
            var resumen = ReporteMultiIdioma.Imprimir(cuadrados, cultura);
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cultura = Idiomas.Ingles;
            var cuadrados = new List<Figura>
            {
                new Cuadrado (cultura) {_lado=5},
                new Cuadrado (cultura) {_lado=1},
                new Cuadrado (cultura) {_lado=3}
            };


            var resumen = ReporteMultiIdioma.Imprimir(cuadrados, cultura);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var cultura = Idiomas.Ingles;

            var formas = new List<Figura>
            {
                new Cuadrado (cultura) {_lado=5},
                new Circulo (cultura) {_lado=3},
                new Triangulo (cultura) {_lado=4},
                new Cuadrado (cultura) {_lado=2},
                new Triangulo (cultura){_lado=9},
                new Circulo (cultura){_lado=2.75m},
                new Triangulo (cultura) {_lado=4.2m }
            };

            var resumen = ReporteMultiIdioma.Imprimir(formas, cultura);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var cultura = Idiomas.Castellano;
            var formas = new List<Figura>
            {
                new Cuadrado (cultura) {_lado=5},
                new Circulo(cultura)  {_lado=3},
                new Triangulo (cultura) {_lado=4},
                new Cuadrado (cultura) {_lado=2},
                new Triangulo (cultura) {_lado=9},
                new Circulo (cultura) {_lado=2.75m},
                new Triangulo (cultura) {_lado=4.2m }
            };

            var resumen = ReporteMultiIdioma.Imprimir(formas, cultura);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }


        [TestCase]
        public void TestResumenListaVacia()
        {

            var cultura = Idiomas.Castellano;
            var lst = new List<Figura>();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReporteMultiIdioma.Imprimir(lst, cultura));
        }

    }
}
