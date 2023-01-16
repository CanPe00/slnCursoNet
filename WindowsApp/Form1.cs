using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Producto producto=new Producto("Parlante JBL",
                "Chico. De color verde y dorado",
                10000,
                0.50,
                0.21,
                "Candela Perez",
                "Electrónica",
                "Música");

            
            //producto.Nombre = "Parlante JBL";
            //producto.Descripcion = "Chico. De color verde y dorado";
            //producto.PrecioCosto = 10000;
            //producto.Margen = 0.50;
            //producto.IVA = 0.21;
            //producto.Proveedor = "Candela Perez";
            //producto.Categoria = "Electrónica";
            //producto.SubCategoria = "Música";

            MessageBox.Show("\t¡PRODUCTO CREADO!\n" +
                "\n\nNombre: " + producto.Nombre +
                "\nDescripción: " + producto.Descripcion + 
                "\nPrecio Costo: $" + producto.PrecioCosto +
                "\nMargen: " + producto.Margen*100 +" %"+ 
                "\nIVA: " + producto.IVA *100 + " %" +
                "\nPrecio Bruto (Precio Costo + Margen): $" + Math.Round(producto.PrecioBruto,2) +
                "\nPrecio Venta (PrecioBruto + IVA): $" + Math.Round(producto.PrecioVenta, 2) +
                "\nProveedor: " + producto.Proveedor + 
                "\nCategoría: " + producto.Categoria + 
                "\nSub Categoría:  " + producto.SubCategoria,"FELICITACIONES",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }
       

        private void btnClienteIndividuo_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo= new ClienteIndividuo(
                "Mariela",
                "Gonzalez",

               "mariugonzalez@gmail.com",
               "34674589633",
               "Maipu 563");

            //clienteIndividuo.Nombre = "Mariela";
            //clienteIndividuo.Apellido = "Gonzalez";
            //clienteIndividuo.CUIT = "20262007614";
            //clienteIndividuo.Email = "mariugonzalez@gmail.com";
            //clienteIndividuo.Telefono = "34674589633";
            //clienteIndividuo.Direccion = "Maipu 563";

            MessageBox.Show("\t¡CLIENTE CREADO!\n" +
                "\nNombre: " + clienteIndividuo.Nombre +
                "\nApellido: " + clienteIndividuo.Apellido +
                "\nEmail: " + clienteIndividuo.Email +
                "\nTeléfono: " + clienteIndividuo.Telefono +
                "\nDirección: " + clienteIndividuo.Direccion,"FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
