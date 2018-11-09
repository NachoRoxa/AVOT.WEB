using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class Estadia
    {
        private int _idEstadia;
        private String _direccion;
        private int _costoPorDia;
        private int _estado;
        private int _cantidad;
        private String _nombre;
        private DateTime _fechaIngreso;
        private DateTime _fechaSalida;

        public Estadia(int idEstadia, string direccion, int costoPorDia, int estado, int cantidad, string nombre, DateTime fechaIngreso, DateTime fechaSalida)
        {
            IdEstadia = idEstadia;
            Direccion = direccion;
            CostoPorDia = costoPorDia;
            Estado = estado;
            Cantidad = cantidad;
            Nombre = nombre;
            FechaIngreso = fechaIngreso;
            FechaSalida = fechaSalida;
        }

        public DateTime FechaSalida
        {
            get { return _fechaSalida; }
            set { _fechaSalida = value; }
        }


        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }


        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }


        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public int CostoPorDia
        {
            get { return _costoPorDia; }
            set { _costoPorDia = value; }
        }


        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public int IdEstadia
        {
            get { return _idEstadia; }
            set { _idEstadia = value; }
        }

    }
}
