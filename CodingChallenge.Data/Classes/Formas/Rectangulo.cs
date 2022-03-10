using System;
using CodingChallenge.Data.Classes.Enums;


namespace CodingChallenge.Data.Classes.Formas
{
    public class Rectangulo : FormaGeometrica
    {
        private int _base;
        private int _altura;

        public Rectangulo(int lado, int altura)
        {
            _base = lado;
            _altura = altura;
            this.Tipo = (int)FormaGeometricaEnum.Rectangulo;

        }
        public override decimal CalcularArea()
        {
            return _base * _altura;
        }
        public override decimal CalcularPerimetro()
        {
            return (_base + _altura) * 2;
        }
    }
}
