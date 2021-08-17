using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Datos.Common.DbHelper;

namespace BombonesApp.Datos.Sql.DbHelper
{
    public class DbHelperSql:IDbHelper
    {
        protected SqlConnection _context;
        protected SqlTransaction _transaction;

        public DbHelperSql(SqlConnection context, SqlTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        protected DbHelperSql()
        {
            
        }
        public IDbCommand CreateCommand(string query)
        {
            return new SqlCommand(query, _context, _transaction);
        }
    }
}
