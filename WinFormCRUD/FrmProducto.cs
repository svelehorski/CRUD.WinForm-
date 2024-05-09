using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinFormCRUD
{
    public partial class FrmProducto : Form
    {

        public Producto producto;


        public FrmProducto()
        {
            InitializeComponent();
        }

        public FrmProducto(Producto producto):this()
        {
            this.producto = producto;
            this.txtCodigo.Text = producto.codigo.ToString();
            this.txtNombre.Text = producto.nombre;
            this.txtPrecio.Text = producto.precio.ToString();
            this.txtCodigo.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);
            this.producto = new Producto(codigo,txtNombre.Text, precio);
            this.DialogResult = DialogResult.OK; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
