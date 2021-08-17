using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesApp.Datos.Common.UofW
{
    public interface IUnitOfWork
    {
        IUnitOfWorkAdapter Create();
    }
}
