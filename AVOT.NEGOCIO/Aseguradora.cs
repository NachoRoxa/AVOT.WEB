using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class Aseguradora
    {
        private String _rut;
        private String _nombreAseguradora;
        private String _direccion;

        public Aseguradora(string rut, string nombreAseguradora, string direccion)
        {
            Rut = rut;
            NombreAseguradora = nombreAseguradora;
            Direccion = direccion;
        }

        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public String NombreAseguradora
        {
            get { return _nombreAseguradora; }
            set { _nombreAseguradora = value; }
        }


        public String Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
    }
}
