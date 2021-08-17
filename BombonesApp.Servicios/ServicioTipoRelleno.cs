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
                using (var context = _unitOfWork.Create())
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
            try
            {
                int registrosAgregados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosAgregados = context.repositories.repositorioTipoRelleno.Agregar(tipoRelleno);
                    context.SaveChanges();
                }

                return registrosAgregados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoRelleno tipoRelleno)
        {
            try
            {
                using (var context = _unitOfWork.Create())
                {
                    return context.repositories.repositorioTipoRelleno.EstaRelacionado(tipoRelleno);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoRelleno tipoRelleno)
        {
            try
            {
                using (var context = _unitOfWork.Create())
                {
                    return context.repositories.repositorioTipoRelleno.Existe(tipoRelleno);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(TipoRelleno tipoRelleno)
        {
            try
            {
                int registrosBorrados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosBorrados = context.repositories.repositorioTipoRelleno.Borrar(tipoRelleno);
                    context.SaveChanges();
                }

                return registrosBorrados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(TipoRelleno tipoRelleno)
        {
            try
            {
                int registrosEditados = 0;
                using (var context = _unitOfWork.Create())
                {
                    registrosEditados = context.repositories.repositorioTipoRelleno.Editar(tipoRelleno);
                    context.SaveChanges();
                }

                return registrosEditados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoRelleno GetPorId(int id)
        {
            try
            {
                using (var context = _unitOfWork.Create())
                {
                    return context.repositories.repositorioTipoRelleno.GetTipoPorId(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
