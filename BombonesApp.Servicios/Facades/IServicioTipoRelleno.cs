using System.Collections.Generic;
using BombonesApp.Entidades;

namespace BombonesApp.Servicios.Facades
{
    public interface IServicioTipoRelleno
    {
        List<TipoRelleno> GetLista();
        int Agregar(TipoRelleno tipoRelleno);
        bool EstaRelacionado(TipoRelleno tipoRelleno);
        bool Existe(TipoRelleno tipoRelleno);
        int Borrar(TipoRelleno tipoRelleno);
        int Editar(TipoRelleno tipoRelleno);
        TipoRelleno GetPorId(int id);
    }
}