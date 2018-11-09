using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVOT.DAL;
using System.Data;
using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace AVOT.NEGOCIO
{
    public class Alumno
    {
        private String _run;
        private String _nombre;
        private String _apellidoPaterno;
        private String _apellidoMaterno;
        private int _montoPersonal;
        private Curso _curso;
        private Apoderado _apoderado;
        private Tour _tour;

        public Alumno()
        {
        }
        
        public Alumno(string run, string nombre, string apellidoPaterno, string apellidoMaterno, int montoPersonal, Curso curso, Apoderado apoderado, Tour tour)
        {
            Run = run;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            MontoPersonal = montoPersonal;
            Curso = curso;
            Apoderado = apoderado;
            Tour = tour;
        }

        public Tour Tour
        {
            get { return _tour; }
            set { _tour = value; }
        }

        public Apoderado Apoderado
        {
            get { return _apoderado; }
            set { _apoderado = value; }
        }

        public Curso Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        public int MontoPersonal
        {
            get { return _montoPersonal; }
            set { _montoPersonal = value; }
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

        public String Run
        {
            get { return _run; }
            set { _run = value; }
        }

        //public DataTable ListarAlumnos()
        //{
        //    String comando = "PR_LIST_ALUMNOS";
        //    Conexion2 conn = new Conexion2(comando);
        //    conn.TipoProcedimiento();
        //    conn.AgregarParametroCursorOut("registros");
        //    conn.Adapter.SelectCommand = conn.Comm;
        //    DataTable tabla = new DataTable();
        //    conn.Adapter.Fill(tabla);
        //    return tabla;
        //}

        public List<Alumno> ListarAlumno(string runAp)
        {
            try
            {
                List<Alumno> listaAlumnos = new List<Alumno>();
                Conexion conn = new Conexion("PR_LISTAR_ALUMNOS");
                conn.AddString("IN_RUN_APODERADO", runAp, tipoParametro.input);
                conn.ExecReaderRef("OUT_LIST");
                while (conn.Reader.Read()) {
                    Alumno alumno = new Alumno();
                    Curso curso = new Curso();
                    Apoderado apoderado = new Apoderado();
                    Tour tour = new Tour();
                    Colegio colegio = new Colegio();
                    colegio.NombreColegio = conn.Reader.GetString(5);
                    curso.Colegio = colegio;
                    apoderado.Nombre = conn.Reader.GetString(6);
                    apoderado.Apellido = conn.Reader.GetString(7);
                    alumno.Run = conn.Reader.GetString(0);
                    alumno.Nombre = conn.Reader.GetString(1);
                    alumno.ApellidoPaterno = conn.Reader.GetString(2);
                    alumno.ApellidoMaterno = conn.Reader.GetString(3);
                    alumno.MontoPersonal = conn.Reader.GetInt32(4);
                    alumno.Curso = curso;
                    alumno.Apoderado = apoderado;
                    alumno.Tour = tour;
                    listaAlumnos.Add(alumno);
                }
                return listaAlumnos;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                throw ex;
            }

        }
    }
}
