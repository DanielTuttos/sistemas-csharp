using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuardarMostrarImagen_Sin_ruta_
{
    class Imagen
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        SqlDataReader sqldr;

        public string abrirConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=PracticaImagen;Integrated Security=True");
                cn.Open();
                return "Conectado";
            }
            catch(Exception ex)
            {
                return "No conectado: " + ex.ToString();
            }
        }

        public string insertarImagen(string descripcion, PictureBox pbImagen)
        {
            string mensaje = "Se inserto la imagen";
            try
            {
                cmd = new SqlCommand("Insert into IMG(Descripcion,img) values(@Descripcion,@Imagen)", cn);
                cmd.Parameters.Add("@Descripcion", SqlDbType.NChar);
                cmd.Parameters.Add("@Imagen",SqlDbType.Image);

                cmd.Parameters["@Descripcion"].Value = descripcion;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
               mensaje = "No se inserto la imagen: " + ex.ToString();
            }
            return mensaje;
        }

        public void verImagen(PictureBox pbFoto,string descripcion)
        {
            try
            {
                da= new SqlDataAdapter("Select img from IMG where Descripcion = '"+descripcion+"'",cn);
                ds = new DataSet();
                da.Fill(ds, "IMG");
                byte[] datos = new byte[0];
                dr = ds.Tables["IMG"].Rows[0];
                datos = (byte[])dr["img"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }
        }

        public void cargarImagenes(ComboBox cbImg)
        {
         try
         {
             cmd = new SqlCommand("Select Descripcion from IMG", cn);
             sqldr = cmd.ExecuteReader();
             while(sqldr.Read())
             {
                 cbImg.Items.Add(sqldr["Descripcion"]);
             }
             sqldr.Close();
         }
            catch(Exception ex)
         {
             MessageBox.Show("No se cargaron las imagenes en el ComboBox: " + ex.ToString());
         }
        }
    }
}
