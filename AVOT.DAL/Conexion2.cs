using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleDataAdapter = Oracle.ManagedDataAccess.Client.OracleDataAdapter;
using OracleCommand = Oracle.ManagedDataAccess.Client.OracleCommand;
using OracleConnection = Oracle.ManagedDataAccess.Client.OracleConnection;

namespace AVOT.DAL
{
    public class Conexion2
    {
        private OracleConnection _conn;
        private OracleCommand _comm;
        private OracleDataAdapter _adapter;
        private String _connString;

        public Conexion2(String comm)
        {
            this._connString = "DATA SOURCE=localhost:1521/xe; USER ID=AVOT; PASSWORD=paso;";
            this._conn = new OracleConnection(_connString);
            this._conn.Open();
            this._adapter = new OracleDataAdapter();
            this._comm = new OracleCommand(comm, _conn);
        }

        public void TipoProcedimiento()
        {
            Comm.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void AgregarParametroCursorOut(String nombre)
        {
            Comm.Parameters.Add(nombre, OracleType.Cursor).Direction=ParameterDirection.Output;
        }

        public OracleDataAdapter Adapter
        {
            get { return _adapter; }
        }

        public OracleCommand Comm
        {
            get { return _comm; }
        }
    }
}
