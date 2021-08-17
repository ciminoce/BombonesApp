using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesApp.Datos.Common.DbHelper
{
    public interface IDbHelper
    {
        IDbCommand CreateCommand(string query);
    }
}
