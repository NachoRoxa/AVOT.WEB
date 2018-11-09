using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class EmpresaTransporte
    {
        private int _idTransporte;
        private String _nombreEmpresa;
        private String _tipoTransporte;

        public EmpresaTransporte(int idTransporte, string nombreEmpresa, string tipoTransporte)
        {
            _idTransporte = idTransporte;
            NombreEmpresa = nombreEmpresa;
            TipoTransporte = tipoTransporte;
        }

        public String TipoTransporte
        {
            get { return _tipoTransporte; }
            set { _tipoTransporte = value; }
        }


        public String NombreEmpresa
        {
            get { return _nombreEmpresa; }
            set { _nombreEmpresa = value; }
        }


        public int Idtransporte
        {
            get { return _idTransporte; }
            set { _idTransporte = value; }
        }

    }
}
