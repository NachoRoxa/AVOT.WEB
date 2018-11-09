using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class Seguro
    {
        private int _idSeguro;
        private int _diasCobertura;
        private int _costo;
        private String _descripcion;
        private int _estado;
        private int _idAseguradora;
        private Aseguradora _aseguradora;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;

        public Seguro(int idSeguro, int diasCobertura, int costo, string descripcion, int estado, int idAseguradora, Aseguradora aseguradora, DateTime fechaInicio, DateTime fechaTermino)
        {
            IdSeguro = idSeguro;
            DiasCobertura = diasCobertura;
            Costo = costo;
            Descripcion = descripcion;
            Estado = estado;
            IdAseguradora = idAseguradora;
            Aseguradora = aseguradora;
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


        public Aseguradora Aseguradora
        {
            get { return _aseguradora; }
            set { _aseguradora = value; }
        }


        public int IdAseguradora
        {
            get { return _idAseguradora; }
            set { _idAseguradora = value; }
        }


        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }


        public int DiasCobertura
        {
            get { return _diasCobertura; }
            set { _diasCobertura = value; }
        }


        public int IdSeguro
        {
            get { return _idSeguro; }
            set { _idSeguro = value; }
        }

    }
}
