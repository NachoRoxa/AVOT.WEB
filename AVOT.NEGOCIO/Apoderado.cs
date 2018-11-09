using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVOT.DAL;
using Oracle.ManagedDataAccess;

namespace AVOT.NEGOCIO
{
    public class Apoderado
    {
        private String _run;
        private String _user;
        private String _telefono;
        private String _correo;
        private String _passwd;
        private String _nombre;
        private String _apellido;
        private int _representante;

        public Apoderado()
        {

        }

        public Apoderado(string run, string user, string telefono, string correo, string passwd, string nombre, string apellido, int representante)
        {
            Run = run;
            User = user;
            Telefono = telefono;
            Correo = correo;
            Passwd = passwd;
            Nombre = nombre;
            Apellido = apellido;
            Representante = representante;
        }

        public int Representante
        {
            get { return _representante; }
            set { _representante = value; }
        }


        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
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


        public String Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public String Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
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


        public bool ReadApoderado(string usuario)
        {
            String sqlcommnad = "Select * from APODERADOS WHERE USUARIO = :usuario";
            Conexion conn = new Conexion(sqlcommnad);
            conn.Command.Parameters.Add("usuario", usuario);
            conn.Read();

            while (conn.Reader.Read())
            {
                Run = conn.Reader.GetString(0);
                User = conn.Reader.GetString(1);
                Telefono = conn.Reader.GetString(2);
                Correo = conn.Reader.GetString(3);
                Passwd = conn.Reader.GetString(4);
                Nombre = conn.Reader.GetString(5);
                Apellido = conn.Reader.GetString(6);
                Representante = conn.Reader.GetInt32(7);
                return true;
            }
            return false;
        }

        public bool ReadApoderadoRun(string run)
        {
            String sqlcommnad = "Select * from APODERADOS WHERE RUN = :run";
            Conexion conn = new Conexion(sqlcommnad);
            conn.Command.Parameters.Add("run", run);
            conn.Read();

            while (conn.Reader.Read())
            {
                Run = conn.Reader.GetString(0);
                User = conn.Reader.GetString(1);
                Telefono = conn.Reader.GetString(2);
                Correo = conn.Reader.GetString(3);
                Passwd = conn.Reader.GetString(4);
                Nombre = conn.Reader.GetString(5);
                Apellido = conn.Reader.GetString(6);
                Representante = conn.Reader.GetInt32(7);
                return true;
            }
            return false;
        }

        public bool UpdatePass(string usuario, string pass)
        {
            try
            {
                Conexion conn = new Conexion("PR_UPDATE_AP_PASS");
                conn.AddString("IN_USUARIO", usuario, tipoParametro.input);
                conn.AddString("IN_PASSWD", pass, tipoParametro.input);
                conn.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return false;
            }
        }

        public bool GetUsuarioCorreo(string correo)
        {
            String sqlcommnad = "Select * from APODERADOS WHERE CORREO = :correo";
            Conexion conn = new Conexion(sqlcommnad);
            conn.Command.Parameters.Add("correo", correo);
            conn.Read();

            while (conn.Reader.Read())
            {
                Run = conn.Reader.GetString(0);
                User = conn.Reader.GetString(1);
                Telefono = conn.Reader.GetString(2);
                Correo = conn.Reader.GetString(3);
                Passwd = conn.Reader.GetString(4);
                Nombre = conn.Reader.GetString(5);
                Apellido = conn.Reader.GetString(6);
                Representante = conn.Reader.GetInt32(7);
                return true;
            }
            return false;
        }

    }
}
