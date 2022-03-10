using CodingChallenge.Data.Classes.Enums;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Cuadrado : FormaGeometrica
    {
        private int _lado;

        public Cuadrado(int lado)
        {
            _lado = lado;
            this.Tipo = (int)FormaGeometricaEnum.Cuadrado;

        }
        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }
        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
