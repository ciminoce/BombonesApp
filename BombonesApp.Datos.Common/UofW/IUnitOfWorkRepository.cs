using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Datos.Common.Reposotories;

namespace BombonesApp.Datos.Common.UofW
{
    /// <summary>
    /// Se agregan las interfases de cada repositorio
    /// </summary>
    public interface IUnitOfWorkRepository
    {
        IRepositorioTipoRelleno repositorioTipoRelleno { get; }
    }
}
