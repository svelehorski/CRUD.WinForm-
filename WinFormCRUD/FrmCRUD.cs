namespace WinFormCRUD

{
    public partial class FrmCRUD : Form
    {

        private List<Entidades.Producto> productos;

        public FrmCRUD()
        {
            InitializeComponent();
            this.productos = new List<Entidades.Producto>();
        }

        private void ActualizarVisor()
        {
            this.IstVisor.Items.Clear();
            foreach (var item in this.productos)
            {
                this.IstVisor.Items.Add(item.Mostrar());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ShowDialog();

            DialogResult dialogResultRta = frmProducto.DialogResult;
            if (dialogResultRta == DialogResult.OK)
            {
                this.productos.Add(frmProducto.producto);
                this.ActualizarVisor();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.IstVisor.SelectedIndex;
            if (indice != -1) 
            {
                FrmProducto frmProducto = new FrmProducto(this.productos[indice]);
                frmProducto.ShowDialog();

                DialogResult dialogResultRta = frmProducto.DialogResult;
                if (dialogResultRta == DialogResult.OK)
                {
                    this.productos[indice] = frmProducto.producto;
                    this.ActualizarVisor();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.IstVisor.SelectedIndex;
            if(indice != -1)
            {
                this.productos.RemoveAt(indice);
                this.ActualizarVisor();
            }
        }


    }

}
