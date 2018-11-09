using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class Viaje
    {
        private int _idViaje;
        private String _origen;
        private String _destino;
        private int _costo;
        private int _estado;
        private EmpresaTransporte _empresaTranspporte;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;

        public Viaje(int idViaje, string origen, string destino, int costo, int estado, EmpresaTransporte empresaTranspporte, DateTime fechaInicio, DateTime fechaTermino, DateTime fechaTerminio)
        {
            IdViaje = idViaje;
            Origen = origen;
            Destino = destino;
            Costo = costo;
            Estado = estado;
            EmpresaTransporte = empresaTranspporte;
            FechaInicio = fechaInicio;
            FechaTermino = fechaTermino;
        }

        public DateTime FechaTermino
        {
            get { return _fechaTermino; }
            set { _fechaTermino = value; }
        }


        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }


        public EmpresaTransporte EmpresaTransporte
        {
            get { return _empresaTranspporte; }
            set { _empresaTranspporte = value; }
        }


        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }


        public String Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }


        public String Origen
        {
            get { return _origen; }
            set { _origen = value; }
        }


        public int IdViaje
        {
            get { return _idViaje; }
            set { _idViaje = value; }
        }

    }
}
