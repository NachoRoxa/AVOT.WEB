using AVOT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class Curso
    {
        private int _idCurso;
        private int _montoRecaudado;
        private Colegio _colegio;

        public Curso()
        {

        }

        public Curso(int idCurso, int montoRecaudado, Colegio colegio)
        {
            IdCurso = idCurso;
            MontoRecaudado = montoRecaudado;
            Colegio = colegio;
        }

        public Colegio Colegio
        {
            get { return _colegio; }
            set { _colegio = value; }
        }


        public int MontoRecaudado
        {
            get { return _montoRecaudado; }
            set { _montoRecaudado = value; }
        }


        public int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        public bool ReadCurso(int id_curso)
        {
            try
            {
                string sqlcommand = "SELECT * FROM CURSOS WHERE ID_CURSO = :id_curso";
                Conexion conn = new Conexion(sqlcommand);
                conn.Command.Parameters.Add("id_curso", id_curso);
                conn.Read();

                while (conn.Reader.Read())
                {
                    IdCurso = conn.Reader.GetInt32(0);
                    MontoRecaudado = conn.Reader.GetInt32(1);
                    Colegio colegio = new Colegio();
                    colegio.ReadColegio(conn.Reader.GetInt32(2));
                    Colegio = colegio;
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
