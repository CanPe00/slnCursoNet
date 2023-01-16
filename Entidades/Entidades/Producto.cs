using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto
        {
            get
            {
                decimal _PrecioBruto = 0;
                //PrecioBruto = PrecioCosto+ Margen
                _PrecioBruto = Convert.ToDecimal(1 + this.Margen) * PrecioCosto;
                return _PrecioBruto;
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                decimal _PrecioVenta = 0;
                // PrecioVenta = PrecioBruto + IVA
                _PrecioVenta = Convert.ToDecimal(1 + this.IVA) * PrecioBruto;
                return _PrecioVenta;
            }
        }

        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iVA, string proveedor, string categoria, string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iVA;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

        public Producto() { }
    }
}
