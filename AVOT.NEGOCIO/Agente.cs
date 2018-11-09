using AVOT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class Agente
    {
        private String _run;
        private String _user;
        private String _passwd;
        private String _nombre;
        private String _apellidoPaterno;
        private String _apellidoMaterno;
        private int _administrador;
        private int _estado;

        public Agente()
        {
        }

        public Agente(string run, string user, string passwd, string nombre, string apellidoPaterno, string apellidoMaterno, int administrador, int estado)
        {
            Run = run;
            User = user;
            Passwd = passwd;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Administrador = administrador;
            Estado = estado;
        }

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public int Administrador
        {
            get { return _administrador; }
            set { _administrador = value; }
        }


        public String ApellidoMaterno
        {
            get { return _apellidoMaterno; }
            set { _apellidoMaterno = value; }
        }


        public String ApellidoPaterno
        {
            get { return _apellidoPaterno; }
            set { _apellidoPaterno = value; }
        }


        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public String Passwd
        {
            get { return _passwd; }
            set { _passwd = value; }
        }


        public String User
        {
            get { return _user; }
            set { _user = value; }
        }


        public String Run
        {
            get { return _run; }
            set { _run = value; }
        }

        public bool ReadAgente(string run) {
            try
            {
                string sqlcommand = "SELECT * FROM AGENTES WHERE RUN = :run";
                Conexion conn = new Conexion(sqlcommand);
                conn.Command.Parameters.Add("run", run);
                conn.Read();

                while (conn.Reader.Read())
                {
                    Run = "";
                    User = "";
                    Passwd = "";
                    Nombre = conn.Reader.GetString(3);
                    ApellidoPaterno = conn.Reader.GetString(4);
                    ApellidoMaterno = conn.Reader.GetString(5);
                    Administrador = 0;
                    Estado = conn.Reader.GetInt32(7);
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
