using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Datos.Sql.UOfW;
using BombonesApp.Entidades;
using BombonesApp.Servicios;

namespace BombonesApp.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ListarRegistros();

            EsperaTecla();

            #region alta
            //var unitOfWork = new UnitOfWorkSql();
            //var servicio = new ServicioTipoRelleno(unitOfWork);
            //var tipo = new TipoRelleno()
            //{
            //    Descripcion = "Pepito"
            //};
            //int cantidad = servicio.Agregar(tipo);
            //if (cantidad == 1)
            //{
            //    Console.WriteLine("Registro agregado");
            //}
            //ListarRegistros();

            //EsperaTecla();

            #endregion
            #region Editar
            //var unitOfWork = new UnitOfWorkSql();
            //var servicio = new ServicioTipoRelleno(unitOfWork);

            //var tipoEditar = servicio.GetPorId(38);
            //if (tipoEditar == null)
            //{
            //    Console.WriteLine("tipo no encontrado");
            //}

            //tipoEditar.Descripcion = "Pone orden Albert";
            //int cantidadEditada = servicio.Editar(tipoEditar);
            //if (cantidadEditada == 1)
            //{
            //    Console.WriteLine("Registro editado");
            //}
            //ListarRegistros();

            //EsperaTecla();

            #endregion

            #region Borrar
            var unitOfWork = new UnitOfWorkSql();
            var servicio = new ServicioTipoRelleno(unitOfWork);

            var tipoBorrar = servicio.GetPorId(38);
            if (tipoBorrar == null)
            {
                Console.WriteLine("tipo no encontrado");
            }

            int cantidadBorrar = servicio.Borrar(tipoBorrar);
            if (cantidadBorrar > 0)
            {
                Console.WriteLine("Registro borrado");
                ListarRegistros();
                EsperaTecla();
            }
            else
            {
                Console.WriteLine("Error al borrar");
            }
            #endregion
            Console.ReadLine();
        }

        private static void EsperaTecla()
        {
            Console.WriteLine("Presione tecla para continuar");
            Console.ReadLine();
        }

        private static void ListarRegistros()
        {

            var unitOfWork = new UnitOfWorkSql();
            var servicio = new ServicioTipoRelleno(unitOfWork);
            var rellenos = servicio.GetLista();
            //var lista = ServicioTipoRelleno.GetInstancia().GetLista();
            foreach (var tipoRelleno in rellenos)
            {
                Console.WriteLine($"{tipoRelleno.Descripcion} - {tipoRelleno.TipoRellenoId}");
            }
        }
    }
}
