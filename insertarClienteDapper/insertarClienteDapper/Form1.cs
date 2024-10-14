using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertarClienteDapper
{
    public partial class Form1 : Form
    {

        SuppliersRepository suppliersR = new SuppliersRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodo_Click(object sender, EventArgs e)
        {
            var proveedor = suppliersR.ObtenerTodos();
            dgvProveedor.DataSource = proveedor;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoProveedor = crearProveedor();
            var insertados = suppliersR.InsertarProveedor(nuevoProveedor);
            MessageBox.Show($"{insertados} registros insertados");
            var proveedor = suppliersR.ObtenerTodos();
            dgvProveedor.DataSource = proveedor;
        }

        private Suppliers crearProveedor()
        {
            var nuevo = new Suppliers
            {
                CompanyName = tbxCompanyName.Text,
                ContactName = tbxContactName.Text,
                ContactTitle = tbxContactTitle.Text,
                Address = tbxAddress.Text,
                City = tbxCity.Text,
            };

            return nuevo;
        }
    }
}
