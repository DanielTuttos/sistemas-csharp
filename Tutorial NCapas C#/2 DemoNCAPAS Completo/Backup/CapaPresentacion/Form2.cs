using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        private clsAlumno Alu = new clsAlumno();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alu.Dni = txtDni.Text;
            Alu.Apellidos = txtApellidos.Text;
            Alu.Nombres = txtNombre.Text;
            Alu.Sexo=rbnMasculino.Checked==true ? 'M':'F';
            Alu.FechaNacimiento = Convert.ToDateTime(dateTimePicker1.Value);
            Alu.Direccion = txtDireccion.Text;
            MessageBox.Show(Alu.RegistrarAlumnos(),"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Limpiar();
        }

        private void Limpiar() {
            txtDni.Clear();
            txtApellidos.Clear();
            txtNombre.Clear();
            rbnMasculino.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            txtDireccion.Clear();
            txtDni.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Alu.Dni = txtDni.Text;
            Alu.Apellidos = txtApellidos.Text;
            Alu.Nombres = txtNombre.Text;
            Alu.Sexo = rbnMasculino.Checked == true ? 'M' : 'F';
            Alu.FechaNacimiento = Convert.ToDateTime(dateTimePicker1.Value);
            Alu.Direccion = txtDireccion.Text;
            MessageBox.Show(Alu.ActualizarDatos(),"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Alu.Dni = txtDni.Text;
            MessageBox.Show(Alu.EliminarRegistro(),"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow row;
            Alu.Dni = txtDni.Text;
            dt = Alu.BuscarAlumno(Alu.Dni);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                txtApellidos.Text = row[2].ToString();
                txtNombre.Text = row[3].ToString();
                if (row[4].ToString() == "M")
                    rbnMasculino.Checked = true;
                else
                    rbnFemenino.Checked = true;
                dateTimePicker1.Value = Convert.ToDateTime(row[5].ToString());
                txtDireccion.Text = row[6].ToString();
                MessageBox.Show("Registro Encontrado Ok...!!!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Registro de Alumno no Existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Limpiar();
            }
        }
    }
}
