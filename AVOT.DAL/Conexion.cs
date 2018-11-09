using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace AVOT.DAL
{
    public class Conexion
    {
        private OracleConnection conn;
        private OracleCommand comm;
        private OracleDataReader reader;
        private OracleDataAdapter adapter;
        private String connString = "DATA SOURCE=localhost:1521/xe; USER ID=AVOT; PASSWORD=paso;";

        public Conexion(string commString)
        {
            conn = new OracleConnection();
            comm = new OracleCommand();
            adapter = new OracleDataAdapter();
            conn.ConnectionString = connString;
            conn.Open();
            comm = conn.CreateCommand();
            comm.CommandText = commString;
        }

        public void Read()
        {
            reader = comm.ExecuteReader();
        }

        public void ExecuteNonQuery()
        {
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.BindByName = true;
            comm.ExecuteNonQuery();
        }

        public void TypeProcedure()
        {
            comm.BindByName = true;
            comm.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void AddInt(string nombreParametro, int entero, tipoParametro tipo)
        {
            switch (tipo)
            {
                case tipoParametro.input:
                    comm.Parameters.Add(nombreParametro, OracleDbType.Int32, entero, System.Data.ParameterDirection.Input);
                    break;
                case tipoParametro.output:
                    comm.Parameters.Add(nombreParametro, OracleDbType.Int32, entero, System.Data.ParameterDirection.Output);
                    break;
            }
        }

        public void AddString(string nombreParametro, string cadena, tipoParametro tipo)
        {
            switch (tipo)
            {
                case tipoParametro.input:
                    comm.Parameters.Add(nombreParametro, OracleDbType.Varchar2, cadena, System.Data.ParameterDirection.Input);
                    break;
                case tipoParametro.output:
                    comm.Parameters.Add(nombreParametro, OracleDbType.Varchar2, cadena, System.Data.ParameterDirection.Output);
                    break;

            }
        }

        public void AddDate(string nombreParametro, DateTime fecha, tipoParametro tipo)
        {
            switch (tipo)
            {
                case tipoParametro.input:
                    comm.Parameters.Add(nombreParametro, OracleDbType.Date, fecha, System.Data.ParameterDirection.Input);
                    break;
                case tipoParametro.output:
                    comm.Parameters.Add(nombreParametro, OracleDbType.Date, fecha, System.Data.ParameterDirection.Input);
                    break;
            }
        }

        public OracleDataReader Reader
        {
            get { return reader; }
        }

        public OracleCommand Command
        {
            get { return comm; }
        }

        public OracleDataAdapter Adapter
        {
            get { return adapter; }
        }

        public void ExecReaderRef(string p_name) {
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.BindByName = true;
            OracleParameter p_cursor = new OracleParameter();
            p_cursor.OracleDbType = OracleDbType.RefCursor;
            p_cursor.ParameterName = p_name;
            p_cursor.Direction = System.Data.ParameterDirection.Output;
            comm.Parameters.Add(p_cursor);
            reader = comm.ExecuteReader();
        }

        public void Dispose()
        {
            conn.Close();
            conn.Dispose();
        }

    }
}
