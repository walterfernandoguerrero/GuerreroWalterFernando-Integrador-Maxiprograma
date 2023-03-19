using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulos> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulos agregar = new frmArticulos(); //variable tipo formulario 
            agregar.ShowDialog();
            Form1_Load(sender, e);// forzar a recargar el formulario cuando volves se ven los cambios que realizaste en la grilla
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnQuitarSeleccion.Visible = false;
            try
            {
                ArticulosNegocio articulosNegocio = new ArticulosNegocio();

                listaArticulos = articulosNegocio.Listar1(); //Cargo mi lista de objetos con el metodo Listar1()

                dgvArticulos.DataSource = listaArticulos; //paso datos a la Grilla

                //quitar algunos Campos de mi grilla , selecionar la primera fila y su imagen
                quitarCampos();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }//fin del Form load

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            Articulos seleccion = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            RecargarImagen(seleccion.Imagen);
            lblDescripcion.Text = seleccion.Descripcion;

        }
        private void RecargarImagen(string img)
        {
            try
            {
                if (img!="")
                {
                    pbxArticulos.Load(img);
                }
            }
            catch (Exception )
            {

                MessageBox.Show("no se pudo cargar la imagen.¿ se cargo alguna? , ¿hay internet?, ¿la url es valida? ");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
         //selecciono una fila de la grilla y la guardo en una variable objeto Articulos
         Articulos unArticulo = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
         //creo una variable de tipo formulario con sobrecarga
         frmArticulos modificar = new frmArticulos(unArticulo);
         modificar.ShowDialog();
         Form1_Load(sender, e);
           
           

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //selecciono una fila de la grilla y la guardo en una variable objeto Articulos
            Articulos unArticulo = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            //creo una variable de tipo formulario con sobrecarga
            frmArticulos mostrar = new frmArticulos(unArticulo,true);
            mostrar.ShowDialog();
            Form1_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //selecciono una fila de la grilla y la guardo en una variable objeto Articulos
            Articulos unArticulo = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                //pregunto si confirmo eliminacion
                if (MessageBox.Show("Sera Eliminado... ", "El articulo: "+ unArticulo.Nombre, MessageBoxButtons.YesNo, MessageBoxIcon.Question )==DialogResult.Yes )
                {
                    negocio.Eliminar(unArticulo.IdArticulo);
                    MessageBox.Show("Eliminado correctamente");
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                btnQuitarSeleccion.Visible = true;
                if (txtBuscar.Text != "")
                {
                    //filtro de lista 
                    List<Articulos> listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                    dgvArticulos.DataSource = listaFiltrada;
                    //quitar algunos Campos de mi grilla
                    quitarCampos();

                }
                else
                {
                    dgvArticulos.DataSource = null;// borrar el filtro cuando este vacio el txtbox
                    dgvArticulos.DataSource = listaArticulos;
                    quitarCampos();
                    btnQuitarSeleccion.Visible = false;

                }
            }
            catch (Exception )
            {

                MessageBox.Show("No hay resultado para su busqueda");
                dgvArticulos.DataSource = null;// borrar el filtro cuando este vacio el txtbox
                dgvArticulos.DataSource = listaArticulos;
                btnQuitarSeleccion.Visible = false;
                txtBuscar.Focus();

            }
            
        }
        private void quitarCampos()
        {
            //quitar algunos Campos de mi grilla
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];
                Articulos seleccion = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                RecargarImagen(seleccion.Imagen);
                lblDescripcion.Text = seleccion.Descripcion;
            
            
        }

        private void btnQuitarSeleccion_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = null;// borrar el filtro cuando este vacio el txtbox
            dgvArticulos.DataSource = listaArticulos;
            quitarCampos();
            txtBuscar.Text = "";
            btnQuitarSeleccion.Visible = false;
        }
    }
}
