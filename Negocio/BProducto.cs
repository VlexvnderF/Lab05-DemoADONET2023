using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class BProducto
    {
        DProducto datos = new DProducto();

        public List<Producto> Listar(string nombre)
        {

            
            var productos = datos.Listar();
            var result = productos.Where(x => x.Nombre == nombre
            || string.IsNullOrEmpty(nombre)
            ).ToList();
            return result;

        }


        public void Insertar(Producto producto)
        {
            try
            {
                var productos =datos.Listar();                
                var max= productos.Select(x=>x.IdProducto).Max();
                producto.IdProducto = max+1;

                datos.Insertar(producto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
