using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesApp.Datos.Common.UofW
{
    /// <summary>
    /// Se encarga de conectarse con la BD
    /// y acceder a los repositorios
    /// Implementa la interfase IDisposable para poder
    /// utilizar la estructura using y liberar recursos
    /// </summary>
    public interface IUnitOfWorkAdapter:IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        IUnitOfWorkRepository repositories { get; set; }

        void SaveChanges();//va a confirmar los cambios
    }
}
