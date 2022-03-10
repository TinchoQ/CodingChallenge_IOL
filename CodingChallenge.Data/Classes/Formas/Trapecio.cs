using System;
using CodingChallenge.Data.Classes.Enums;


namespace CodingChallenge.Data.Classes.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private int _baseMayor;
        private int _baseMenor;
        private int _ladoIzquierdo;
        private int _ladoDerecho;
        private int _altura;
        public Trapecio(int baseMayor, int baseMenor, int ladoIzq, int ladoDer, int altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _ladoIzquierdo = ladoIzq;
            _ladoDerecho = ladoDer;
            _altura = altura;
            this.Tipo = (int)FormaGeometricaEnum.Trapecio;
        }
        public override decimal CalcularArea()
        {
            return (decimal)((_baseMayor + _baseMenor) * _altura) / 2;
        }
        public override decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _ladoIzquierdo + _ladoDerecho;
        }

    }
}
