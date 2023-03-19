using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> Listar1()
        {
            List<Articulos> lista1 = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id as IdMarca, M.Descripcion as Marca," +
                    " C.Id as IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS" +
                    " A inner join CATEGORIAS C on A.IdCategoria = C.Id inner join MARCAS M on A.IdMarca = M.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) //  si me conecte recorro el lector cargado en memoria
                {
                    Articulos aux = new Articulos();

                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Imagen= (string)datos.Lector["ImagenUrl"];

                    //son de tipo clases nececito instanciar el objeto tiene una sobrecarga o dos
                    aux.Marca = new Marcas((string)datos.Lector["Marca"]);
                    aux.Categoria = new Categorias((string)datos.Lector["Categoria"]);

                    aux.Precio = (decimal)datos.Lector["Precio"];//con decimal acepta money

                    lista1.Add(aux);
                }

            //select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id as IdMarca, M.Descripcion as Marca, C.Id as IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS A inner join CATEGORIAS C on A.IdCategoria = C.Id inner join MARCAS M on A.IdMarca = M.Id
                return lista1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }
        public void Agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into  ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)" +
                    "Values(@codigo,@nombre,@desc,@idmarca,@idcat,@urlImg,@precio)");
                datos.agregarParametro("@codigo",nuevo.Codigo);
                datos.agregarParametro("@nombre", nuevo.Nombre);
                datos.agregarParametro("@desc", nuevo.Descripcion);
                datos.agregarParametro("@idmarca", nuevo.Marca.Id);
                datos.agregarParametro("@idcat", nuevo.Categoria.Id);
                datos.agregarParametro("@urlImg", nuevo.Imagen);
                datos.agregarParametro("@precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Modificar(Articulos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo=@codigo, Nombre=@nombre, Descripcion=@desc, " +
                    "IdMarca=@idmarca, IdCategoria=@idcat, ImagenUrl=@urlImg, Precio=@precio where Id=@Id");
                datos.agregarParametro("@codigo", modificar.Codigo);
                datos.agregarParametro("@nombre", modificar.Nombre);
                datos.agregarParametro("@desc", modificar.Descripcion);
                datos.agregarParametro("@idmarca", modificar.Marca.Id);
                datos.agregarParametro("@idcat", modificar.Categoria.Id);
                datos.agregarParametro("@urlImg", modificar.Imagen);
                datos.agregarParametro("@precio", modificar.Precio);
                datos.agregarParametro("@Id", modificar.IdArticulo);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id="+id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }

}
