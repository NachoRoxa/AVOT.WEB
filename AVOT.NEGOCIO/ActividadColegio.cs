using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    class ActividadColegio
    {
        private int _idActividad;
        private string _inversion;
        private int _recaudacion;
        private string _descripcion;
        private int _montoDeposito;
        private int _numeroDeposito;
        

        public int NumeroDeposito
        {
            get { return _numeroDeposito; }
            set { _numeroDeposito = value; }
        }


        public int MyProperty
        {
            get { return _montoDeposito; }
            set { _montoDeposito = value; }
        }

        public int MontoDeposito
        {
            get { return _montoDeposito; }
            set { _montoDeposito = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int Recaudacion
        {
            get { return _recaudacion; }
            set { _recaudacion = value; }
        }

        public string Inversion
        {
            get { return _inversion; }
            set { _inversion = value; }
        }


        public int IdActividad
        {
            get { return _idActividad; }
            set { _idActividad = value; }
        }
    }
}
