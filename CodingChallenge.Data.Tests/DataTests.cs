using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;
using CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometricaReport.Imprimir(new List<FormaGeometrica>(), (int)IdiomaEnum.Español));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5)};

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Español);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
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

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Español);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 formas Perimetro 36 Area 35", resumen);
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

            var resumen = FormaGeometricaReport.Imprimir(formas, (int)IdiomaEnum.Español);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var cuadrados = new List<FormaGeometrica> { new Rectangulo(3,4) };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Español);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 12 | Perimetro 14 <br/>TOTAL:<br/>1 formas Perimetro 14 Area 12", resumen);
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

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Español);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Rectángulos | Area 38 | Perimetro 46 <br/>TOTAL:<br/>3 formas Perimetro 46 Area 38", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(4,2,1,2,3) };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Español);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 9 | Perimetro 9 <br/>TOTAL:<br/>1 formas Perimetro 9 Area 9", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                    new Trapecio(4,2,1,2,3),
                    new Trapecio(3,2,1,2,1)
            };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Español);

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Trapecios | Area 11,5 | Perimetro 17 <br/>TOTAL:<br/>2 formas Perimetro 17 Area 11,5", resumen);
        }
    }
}
