using System.Collections.Generic;

namespace BombonesApp.Datos.Common.Reposotories
{
    public interface IRepositorio<T> where T:class
    {
        List<T> GetLista();
        int Agregar(T obj);
        int Borrar(T obj);
        int Editar(T obj);
    }
}