using System;
using CodingChallenge.Data.Classes.Enums;


namespace CodingChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private decimal _lado;
        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
            this.Tipo = (int)FormaGeometricaEnum.TrianguloEquilatero;
        }
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }
        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }    
}
