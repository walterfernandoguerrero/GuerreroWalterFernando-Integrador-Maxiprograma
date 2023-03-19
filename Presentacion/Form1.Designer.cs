
namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblBuscadorArt = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnQuitarSeleccion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(325, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 45);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(9, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(310, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(45, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(164, 417);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(81, 30);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(283, 417);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 30);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrar.Location = new System.Drawing.Point(392, 417);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(81, 30);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblBuscadorArt
            // 
            this.lblBuscadorArt.AutoSize = true;
            this.lblBuscadorArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscadorArt.Location = new System.Drawing.Point(6, 16);
            this.lblBuscadorArt.Name = "lblBuscadorArt";
            this.lblBuscadorArt.Size = new System.Drawing.Size(294, 15);
            this.lblBuscadorArt.TabIndex = 6;
            this.lblBuscadorArt.Text = "Buscador de Articulos, por Nombre o Marca. \r\n";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(45, 108);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(543, 294);
            this.dgvArticulos.TabIndex = 7;
            this.dgvArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvArticulos_MouseClick);
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxArticulos.Location = new System.Drawing.Point(619, 49);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(307, 353);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 8;
            this.pbxArticulos.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(645, 417);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // btnQuitarSeleccion
            // 
            this.btnQuitarSeleccion.Location = new System.Drawing.Point(424, 13);
            this.btnQuitarSeleccion.Name = "btnQuitarSeleccion";
            this.btnQuitarSeleccion.Size = new System.Drawing.Size(97, 45);
            this.btnQuitarSeleccion.TabIndex = 10;
            this.btnQuitarSeleccion.Text = "Quitar Seleccion";
            this.btnQuitarSeleccion.UseVisualStyleBackColor = true;
            this.btnQuitarSeleccion.Click += new System.EventHandler(this.btnQuitarSeleccion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBuscadorArt);
            this.groupBox1.Controls.Add(this.btnQuitarSeleccion);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(45, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCADOR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Articulos ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblBuscadorArt;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnQuitarSeleccion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

