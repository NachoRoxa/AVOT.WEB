using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class AbonosPersonales
    {
        private int _idAbonoPersonal;
        private int _monto;
        private int _numeroRegistroAbono;
        private String _tipoAbono;
        private DateTime _fechaAbono;
        private Alumno _alumno;
        

        public AbonosPersonales()
        {
          
        }

        public AbonosPersonales(int idAbonoPersonal, int monto, int numeroRegistroAbono, string tipoAbono, DateTime fechaAbono, Alumno alumno)
        {
            IdAbonoPersonal = idAbonoPersonal;
            Monto = monto;
            NumeroRegistroAbono = numeroRegistroAbono;
            TipoAbono = tipoAbono;
            FechaAbono = fechaAbono;
            Alumno = alumno;
        }

        public Alumno Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }


        public DateTime FechaAbono
        {
            get { return _fechaAbono; }
            set { _fechaAbono = value; }
        }


        public String TipoAbono
        {
            get { return _tipoAbono; }
            set { _tipoAbono = value; }
        }


        public int NumeroRegistroAbono
        {
            get { return _numeroRegistroAbono; }
            set { _numeroRegistroAbono = value; }
        }


        public int Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }


        public int IdAbonoPersonal
        {
            get { return _idAbonoPersonal; }
            set { _idAbonoPersonal = value; }
        }

    }
}
