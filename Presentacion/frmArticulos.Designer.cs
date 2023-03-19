
namespace Presentacion
{
    partial class frmArticulos
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbxArticulo = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.gbxArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(28, 382);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(271, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 61);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(103, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(129, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // gbxArticulo
            // 
            this.gbxArticulo.Controls.Add(this.lblCategoria);
            this.gbxArticulo.Controls.Add(this.lblMarca);
            this.gbxArticulo.Controls.Add(this.cboCategoria);
            this.gbxArticulo.Controls.Add(this.cboMarca);
            this.gbxArticulo.Controls.Add(this.lblPrecio);
            this.gbxArticulo.Controls.Add(this.txtPrecio);
            this.gbxArticulo.Controls.Add(this.lblImagen);
            this.gbxArticulo.Controls.Add(this.txtImagen);
            this.gbxArticulo.Controls.Add(this.lblDescripcion);
            this.gbxArticulo.Controls.Add(this.txtDescripcion);
            this.gbxArticulo.Controls.Add(this.lblNombre);
            this.gbxArticulo.Controls.Add(this.txtNombre);
            this.gbxArticulo.Controls.Add(this.lblCodigo);
            this.gbxArticulo.Controls.Add(this.txtCodigo);
            this.gbxArticulo.Location = new System.Drawing.Point(28, 25);
            this.gbxArticulo.Name = "gbxArticulo";
            this.gbxArticulo.Size = new System.Drawing.Size(318, 351);
            this.gbxArticulo.TabIndex = 4;
            this.gbxArticulo.TabStop = false;
            this.gbxArticulo.Text = "Articulo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(28, 318);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(28, 280);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(103, 315);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(129, 21);
            this.cboCategoria.TabIndex = 13;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(103, 277);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(129, 21);
            this.cboMarca.TabIndex = 12;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(28, 237);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(103, 234);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(129, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(28, 195);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 8;
            this.lblImagen.Text = "Imagen:";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(103, 192);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(129, 20);
            this.txtImagen.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 153);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 150);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(129, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(365, 34);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(304, 342);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 5;
            this.pbxArticulo.TabStop = false;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.gbxArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmArticulos";
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            this.gbxArticulo.ResumeLayout(false);
            this.gbxArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gbxArticulo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}