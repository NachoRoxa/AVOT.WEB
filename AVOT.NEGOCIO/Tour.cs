using AVOT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class Tour
    {
        private int _idTour;
        private int _valortotal;
        private String _descripcion;
        private int _numeroContrato;
        private Agente _agente;
        private DateTime _fechaCreacion;
        private DateTime _fechaInicio;

        public Tour()
        {
        }

        public Tour(int idTour, int valortotal, string descripcion, int numeroContrato, Agente agente, DateTime fechaCreacion, DateTime fechaInicio)
        {
            IdTour = idTour;
            ValorTotal = valortotal;
            Descripcion = descripcion;
            NumeroContrato = numeroContrato;
            Agente = agente;
            FechaCreacion = fechaCreacion;
            FechaInicio = fechaInicio;
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }


        public DateTime FechaCreacion
        {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }
        }


        public Agente Agente
        {
            get { return _agente; }
            set { _agente = value; }
        }


        public int NumeroContrato
        {
            get { return _numeroContrato; }
            set { _numeroContrato = value; }
        }


        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


        public int ValorTotal
        {
            get { return _valortotal; }
            set { _valortotal = value; }
        }


        public int IdTour
        {
            get { return _idTour; }
            set { _idTour = value; }
        }
        public bool ReadTour(int id_tour) {
            try
            {
                string sqlcommand = "SELECT * FROM TOURS WHERE ID_TOUR = :id_tour";
                Conexion conn = new Conexion(sqlcommand);
                conn.Command.Parameters.Add("id_tour", id_tour);
                conn.Read();

                while (conn.Reader.Read())
                {
                    Agente agente = new Agente();
                    agente.ReadAgente(conn.Reader.GetString(4));
                    IdTour = conn.Reader.GetInt32(0);
                    ValorTotal = conn.Reader.GetInt32(1);
                    Descripcion = conn.Reader.GetString(2);
                    NumeroContrato = conn.Reader.GetInt32(3);
                    Agente = agente;
                    FechaCreacion = conn.Reader.GetDateTime(5);
                    FechaInicio = conn.Reader.GetDateTime(6);
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
