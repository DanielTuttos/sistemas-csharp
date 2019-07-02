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
    public partial class Form2 : Form
    {
        ClsAlumno Al = new ClsAlumno();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Al.ListadoAlumnos();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            

            
        }
    }
}
