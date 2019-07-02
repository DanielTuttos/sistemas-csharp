using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaLogicadeNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        ClsAlumno Al = new ClsAlumno();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msj = "";
            try
            {
                Al.m_Dni = txtDni.Text;
                Al.m_Apellidos = txtApellidos.Text;
                Al.m_Nombres = txtNombre.Text;
                Al.m_Sexo = rbnMasculino.Checked == true ? 'M' : 'F';
                Al.m_FechaNac = dateTimePicker1.Value;
                Al.m_Direccion = txtDireccion.Text;

                msj= Al.Registrar_Alumnos();

                MessageBox.Show(msj);


            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fr = new Form2();
            fr.ShowDialog();

        }
      
   
    }
}
