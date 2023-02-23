using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class LocalDBClass
    {
        public string stringConn;
        public SqlConnection ConnDB;

        public LocalDBClass()
        {
            stringConn = "";
            ConnDB = new SqlConnection(stringConn);
            ConnDB.Open();
        }
    }
}
