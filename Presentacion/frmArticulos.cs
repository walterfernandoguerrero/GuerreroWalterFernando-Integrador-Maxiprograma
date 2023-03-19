using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmArticulos : Form //este formulario tiene varias instancias  para usar un solo formulario para varias acciones
    {
        //variables globales del formulario
        private Articulos articulo = null; // variable de tipo articulo
        private bool detalle = false; //bandera para mostrar detalles
        
        
        public frmArticulos() // sin sobrecarga
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }
        public frmArticulos(Articulos articulo)//1ra sobrecarga (recibe un objeto Articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";

        }
        public frmArticulos(Articulos articulo, bool detalle)//"2da sobrecarga (recibe un objeto Articulo y una bandera bool)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.detalle = detalle;
            Text = "Detalle Articulo";

        }



        private void frmArticulos_Load(object sender, EventArgs e)
        {
            //cargar los combos con los datos de la base 
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            //combo categoria
            cboCategoria.DataSource = categoriaNegocio.Listar(); // origen de mi tabla de BD
            cboCategoria.ValueMember = "Id"; // clave de busqueda
            cboCategoria.DisplayMember = "Descripcion"; //texto del combo
            //combo marca
            cboMarca.DataSource = marcaNegocio.Listar();// origen
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
            //fin de combos

            try
            {
                if (articulo!=null)//vino de boton modificar
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.Imagen;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.Text = articulo.Marca.Descripcion;
                    cboCategoria.Text = articulo.Categoria.Descripcion;
                    RecargarImagen(articulo.Imagen);
                }
                //if (articulo.Imagen!="")
                //{
                //    RecargarImagen(articulo.Imagen);
                //}
                //else
                //{
                //    MessageBox.Show("No hay imagen");
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            if (detalle==true)
            {
                gbxArticulo.Enabled = false;
                btnAceptar.Visible = false;
                btnCancelar.Visible = false;
            }
  
        }
       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                if (articulo == null)
                {
                    articulo = new Articulos();//esta variable global ya fue creada pero tenia null
                }
                //al apretar Aceptar cargo mi variable global con las cajas y combos
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Imagen = txtImagen.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);//lo tuve que googlear para pasar a decimal jajaj
                articulo.Marca = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;

                // programo inteligencia del boton para agregar o modificar

                if (articulo.IdArticulo == 0) // si no tiene numero de id no vino  de la grilla es de (Agregar)
                {
                    negocio.Agregar(articulo);
                    MessageBox.Show("Se agrego un nuevo articulo");
                    Dispose();

                }
                else// si tiene ID
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("se modifico el articulo que eligio");
                    Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RecargarImagen(string img)
        {
            try
            {
                if (img != "")
                {
                    pbxArticulo.Load(img);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("no se pudo cargar la imagen.¿ se cargo alguna? , ¿hay internet?, ¿la url es valida? ");
            }
        }
    }
}
