namespace WinFormCRUD
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar_click = new Button();
            btnCancelar_click = new Button();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAceptar_click
            // 
            btnAceptar_click.Location = new Point(24, 325);
            btnAceptar_click.Name = "btnAceptar_click";
            btnAceptar_click.Size = new Size(90, 55);
            btnAceptar_click.TabIndex = 0;
            btnAceptar_click.Text = "Aceptar";
            btnAceptar_click.UseVisualStyleBackColor = true;
            btnAceptar_click.Click += btnAceptar_Click;
            // 
            // btnCancelar_click
            // 
            btnCancelar_click.Location = new Point(178, 325);
            btnCancelar_click.Name = "btnCancelar_click";
            btnCancelar_click.Size = new Size(90, 55);
            btnCancelar_click.TabIndex = 1;
            btnCancelar_click.Text = "Cancelar";
            btnCancelar_click.UseVisualStyleBackColor = true;
            btnCancelar_click.Click += btnCancelar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(24, 55);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(244, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(24, 224);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(244, 23);
            txtPrecio.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Codigo:";
            //label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            //label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Precio:";
            //label3.Click += label3_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 392);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(btnCancelar_click);
            Controls.Add(btnAceptar_click);
            Name = "FrmProducto";
            Text = "Form1";
            Load += FrmProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar_click;
        private Button btnCancelar_click;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}