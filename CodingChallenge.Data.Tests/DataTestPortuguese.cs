using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;
using CodingChallenge.Data.Classes.Enums;


namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTestPortuguese
    {
        [TestCase]
        public void TestResumenListaVaciaFormas()
        {
            Assert.AreEqual("<h1>Lista vazia de formulários!</h1>",
                FormaGeometricaReport.Imprimir(new List<FormaGeometrica>(), (int)IdiomaEnum.Portugués));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Portugués);

            Assert.AreEqual("<h1>Relatório de formulários</h1>1 Quadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 25", resumen);
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

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Portugués);

            Assert.AreEqual("<h1>Relatório de formulários</h1>3 Quadrados | Área 35 | Perímetro 36 <br/>TOTAL:<br/>3 formas Perímetro 36 Área 35", resumen);
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
            var resumen = FormaGeometricaReport.Imprimir(formas, (int)IdiomaEnum.Portugués);

            Assert.AreEqual(
                "<h1>Relatório de formulários</h1>2 Quadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triângulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Área 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var cuadrados = new List<FormaGeometrica> { new Rectangulo(3, 4) };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Portugués);

            Assert.AreEqual("<h1>Relatório de formulários</h1>1 Retângulo | Área 12 | Perímetro 14 <br/>TOTAL:<br/>1 formas Perímetro 14 Área 12", resumen);
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

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Portugués);

            Assert.AreEqual("<h1>Relatório de formulários</h1>3 Retângulos | Área 38 | Perímetro 46 <br/>TOTAL:<br/>3 formas Perímetro 46 Área 38", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(4, 2, 1, 2, 3) };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Portugués);

            Assert.AreEqual("<h1>Relatório de formulários</h1>1 Trapézio | Área 9 | Perímetro 9 <br/>TOTAL:<br/>1 formas Perímetro 9 Área 9", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                    new Trapecio(4,2,1,2,3),
                    new Trapecio(3,2,1,2,1)
            };

            var resumen = FormaGeometricaReport.Imprimir(cuadrados, (int)IdiomaEnum.Portugués);

            Assert.AreEqual("<h1>Relatório de formulários</h1>2 Trapézios | Área 11,5 | Perímetro 17 <br/>TOTAL:<br/>2 formas Perímetro 17 Área 11,5", resumen);
        }
    }
}
