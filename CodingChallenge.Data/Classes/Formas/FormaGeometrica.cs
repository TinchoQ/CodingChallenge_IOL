using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        private int _tipo { get; set; }

        public int Tipo
        {
            get { return _tipo; }
            set
            {
                _tipo = value;
            }
        }
        public abstract decimal CalcularPerimetro();
        public abstract decimal CalcularArea();
    }
}
