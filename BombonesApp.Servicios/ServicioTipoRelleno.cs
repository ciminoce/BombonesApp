using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Datos.Common.Reposotories;
using BombonesApp.Datos.Common.UofW;
using BombonesApp.Datos.Sql;
using BombonesApp.Datos.Sql.Repositoires;
using BombonesApp.Entidades;
using BombonesApp.Servicios.Facades;

namespace BombonesApp.Servicios
{
    public class ServicioTipoRelleno : IServicioTipoRelleno
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServicioTipoRelleno(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<TipoRelleno> GetLista()
        {
            try
            {
                List<TipoRelleno> rellenos = new List<TipoRelleno>();
                using (var context=_unitOfWork.Create())
                {
                    rellenos = context.repositories.repositorioTipoRelleno.GetLista();

                }

                return rellenos;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer los rellenos");
            }
        }

        public int Agregar(TipoRelleno tipoRelleno)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(TipoRelleno tipoRelleno)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TipoRelleno tipoRelleno)
        {
            throw new NotImplementedException();
        }

        public int Borrar(TipoRelleno tipoRelleno)
        {
            throw new NotImplementedException();
        }

        public int Editar(TipoRelleno tipoRelleno)
        {
            throw new NotImplementedException();
        }

        public TipoRelleno GetPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
