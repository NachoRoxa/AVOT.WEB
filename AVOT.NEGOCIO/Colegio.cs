using AVOT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AVOT.NEGOCIO
{
    public class Colegio
    {
        private int _idColegio;
        private String _nombreColegio;
        private String _direccion;
        private String _rut;
        private String _telefono;

        public Colegio()
        {
        }

        public Colegio(int idColegio, string nombreColegio, string direccion, string rut, string telefono)
        {
            IdColegio = idColegio;
            NombreColegio = nombreColegio;
            Direccion = direccion;
            Rut = rut;
            Telefono = telefono;
        }

        public String Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }


        public String Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }


        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public String NombreColegio
        {
            get { return _nombreColegio; }
            set { _nombreColegio = value; }
        }


        public int IdColegio
        {
            get { return _idColegio; }
            set { _idColegio = value; }
        }

        public bool ReadColegio(int id_colegio) {
            try
            {
                string sqlcommand = "SELECT * FROM COLEGIOS WHERE ID_COLEGIO = :id_colegio";
                Conexion conn = new Conexion(sqlcommand);
                conn.Command.Parameters.Add("id_colegio", id_colegio);
                conn.Read();

                while (conn.Reader.Read())
                {
                    IdColegio = conn.Reader.GetInt32(0);
                    NombreColegio = conn.Reader.GetString(1);
                    Direccion = conn.Reader.GetString(2);
                    Rut = conn.Reader.GetString(3);
                    Telefono = conn.Reader.GetString(4);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
