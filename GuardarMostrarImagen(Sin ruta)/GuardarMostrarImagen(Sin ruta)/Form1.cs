using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardarMostrarImagen_Sin_ruta_
{
    public partial class Form1 : Form
    {
        Imagen img = new Imagen();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if(this.openFileDialog1.FileName.Equals("")==false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: "+ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img.abrirConexion();
            img.cargarImagenes(cbListaFotos);
            cbListaFotos.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(img.insertarImagen(txtDescripcion.Text, pictureBox1));
            cbListaFotos.Items.Clear();
            img.cargarImagenes(cbListaFotos);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            img.verImagen(pictureBox1, cbListaFotos.SelectedItem.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
