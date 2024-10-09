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
            var categoria = suppliersR.ObtenerTodos();
            dgvCategoria.DataSource = categoria;
        }
    }
}
