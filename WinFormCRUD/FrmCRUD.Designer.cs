namespace WinFormCRUD
{
    partial class FrmCRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnModificar = new Button();
            IstVisor = new ListBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 420);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(151, 52);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(324, 420);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(151, 52);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // IstVisor
            // 
            IstVisor.BackColor = SystemColors.ButtonHighlight;
            IstVisor.FormattingEnabled = true;
            IstVisor.ItemHeight = 15;
            IstVisor.Location = new Point(22, 12);
            IstVisor.Name = "IstVisor";
            IstVisor.Size = new Size(762, 394);
            IstVisor.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(618, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 52);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(815, 484);
            Controls.Add(btnEliminar);
            Controls.Add(IstVisor);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "FrmCRUD";
            Text = "Crud 1.0";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnModificar;
        private ListBox IstVisor;
        private Button btnEliminar;
    }
}
