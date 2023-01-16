using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class admProductos
    {
        public static List<Producto> Listar()
        {//TODO
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto());
            return productos;
        }

        public static List<Producto> Listar(string categoria)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto());
            //TODO SELECT WHERE CAEGORIA
            return productos;
        }

        public static List<Producto> Listar(string categoria, string subCategoria)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto());
            //TODO SELECT WHERE CAEGORIA AND SUBCATEGORIA
            return productos;
        }

        public static Producto ListarDetalle(string nombre)
        {
            
            //TODO SELECT WHERE NOOMBRE
            return null;
        }



    }
}
