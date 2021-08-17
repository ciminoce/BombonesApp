using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Datos.Common.UofW;

namespace BombonesApp.Datos.Sql.UOfW
{
    public class UnitOfWorkSql:IUnitOfWork
    {
        public IUnitOfWorkAdapter Create()
        {
            return new UnitOfWorkAdapterSql();
        }
    }
}
