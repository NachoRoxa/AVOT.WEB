using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class ActividadGira
    {
        private int _idActividad;
        private String _tipoActividad;
        private int _costo;
        private String _descripcion;
        private int _estado;
        private DateTime _fecha;
        private int _duracionHoras;

        public ActividadGira(int idActividad, string tipoActividad, int costo, string descripcion, int estado, DateTime fecha, int duracionHoras)
        {
            IdActividad = idActividad;
            TipoActividad = tipoActividad;
            Costo = costo;
            Descripcion = descripcion;
            Estado = estado;
            Fecha = fecha;
            DuracionHoras = duracionHoras;
        }

        public int DuracionHoras
        {
            get { return _duracionHoras; }
            set { _duracionHoras = value; }
        }


        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
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


        public String TipoActividad
        {
            get { return _tipoActividad; }
            set { _tipoActividad = value; }
        }


        public int IdActividad
        {
            get { return _idActividad; }
            set { _idActividad = value; }
        }

    }
}
