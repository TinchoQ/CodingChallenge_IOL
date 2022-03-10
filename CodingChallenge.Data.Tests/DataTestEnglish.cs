using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;
using CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTestEnglish
    {
        [TestCase]
        public void TestResumenListaVaciaFormas()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometricaReport.Imprimir(new List<FormaGeometrica>(), (int)IdiomaEnum.Inglés));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Inglés);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                    new Cuadrado(5),
                    new Cuadrado(1),
                    new Cuadrado(3)
            };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Inglés);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            var resumen = FormaGeometricaReport.Imprimir(formas, (int)IdiomaEnum.Inglés);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }


        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var cuadrados = new List<FormaGeometrica> { new Rectangulo(3, 4) };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Inglés);

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 12 | Perimeter 14 <br/>TOTAL:<br/>1 shapes Perimeter 14 Area 12", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                    new Rectangulo(3,4),
                    new Rectangulo(4,5),
                    new Rectangulo(6,1)
            };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Inglés);

            Assert.AreEqual("<h1>Shapes report</h1>3 Rectangles | Area 38 | Perimeter 46 <br/>TOTAL:<br/>3 shapes Perimeter 46 Area 38", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(4, 2, 1, 2, 3) };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Inglés);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeze | Area 9 | Perimeter 9 <br/>TOTAL:<br/>1 shapes Perimeter 9 Area 9", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                    new Trapecio(4,2,1,2,3),
                    new Trapecio(3,2,1,2,1)
            };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Inglés);

            Assert.AreEqual("<h1>Shapes report</h1>2 Trapezoids | Area 11,5 | Perimeter 17 <br/>TOTAL:<br/>2 shapes Perimeter 17 Area 11,5", resumen);
        }
    }
}
