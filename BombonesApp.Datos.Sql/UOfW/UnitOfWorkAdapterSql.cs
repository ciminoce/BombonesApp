using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Datos.Common.UofW;

namespace BombonesApp.Datos.Sql.UOfW
{
    public class UnitOfWorkAdapterSql:IUnitOfWorkAdapter
    {
        private SqlConnection _context { get; set; }
        private SqlTransaction _transaction { get; set; }

        public UnitOfWorkAdapterSql()
        {
            _context =(SqlConnection) ConexionBd.GetInstancia().GetConexion();
            _context.Open();
            _transaction = _context.BeginTransaction();
            repositories = new UnitOfWorkRepositoriesSql(_context, _transaction);
        }
        public void Dispose()
        {
            if (_transaction!=null)
            {
                _transaction.Dispose();
            }

            if (_context!=null)
            {  
                _context.Close();
                _context.Dispose();
            }

            repositories = null;
        }

        public IUnitOfWorkRepository repositories { get; set; }

        public void SaveChanges()
        {
            _transaction.Commit();//confirma los cambios
        }
    }
}
