using CodingChallenge.Data.Classes.Enums;
using System;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Circulo : FormaGeometrica
    {
        private decimal _diametro;

        public Circulo(decimal diametro) : base()
        {
            _diametro = diametro;
            this.Tipo = (int)FormaGeometricaEnum.Circulo;
        }
        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return  (decimal)Math.PI * _diametro;
        }
    }
}
