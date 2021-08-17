using System.Data;

namespace BombonesApp.Datos.Common
{
    public interface IConexionBd
    {
        IDbConnection GetConexion();
    }
}