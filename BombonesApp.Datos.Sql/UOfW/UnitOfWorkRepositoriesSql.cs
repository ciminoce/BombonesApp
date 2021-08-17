using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Datos.Common.Reposotories;
using BombonesApp.Datos.Common.UofW;
using BombonesApp.Datos.Sql.Repositoires;

namespace BombonesApp.Datos.Sql.UOfW
{
    public class UnitOfWorkRepositoriesSql:IUnitOfWorkRepository
    {
        public IRepositorioTipoRelleno repositorioTipoRelleno { get; }

        public UnitOfWorkRepositoriesSql(SqlConnection context, SqlTransaction transaction)
        {
            repositorioTipoRelleno = new RepositorioTipoRelleno(context, transaction);
        }
    }
}
