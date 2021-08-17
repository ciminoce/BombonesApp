using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Entidades;

namespace BombonesApp.Datos.Common.Reposotories
{
    public interface IRepositorioTipoRelleno:IRepositorio<TipoRelleno>
    {
        bool EstaRelacionado(TipoRelleno tipoRelleno);
        TipoRelleno GetTipoPorId(int id);
        bool Existe(TipoRelleno tipoRelleno);
    }
}
