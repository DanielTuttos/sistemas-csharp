﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using Domain.ValueObjects;

namespace Presentation.Forms
{
    public partial class FormEmployee : Form
    {
        private EmployeeModel employee = new EmployeeModel();

        public FormEmployee()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            ListEmployees();
        }
        private void ListEmployees() {
            try
            {
                dataGridView1.DataSource = employee.GetAll();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employee.FindById(txtSearch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employee.IdNumber = txtIdNumber.Text;
            employee.Mail = txtMail.Text;
            employee.Name = txtName.Text;
            employee.Birthday = txtBirthday.Value;

            bool valid = new Helps.DataValidation(employee).Validate();
            if (valid == true) {
                string result = employee.SaveChanges();
                MessageBox.Show(result );
                ListEmployees();
                Restart();
            }
        }
        private void Restart()
        {
            panel1.Enabled = false;
            txtIdNumber.Clear();
            txtMail.Clear();
            txtName.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            employee.State = EntityState.Added;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                employee.State = EntityState.Modified;
                employee.IdPk =  Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
                txtIdNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtMail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtBirthday.Value = Convert.ToDateTime( dataGridView1.CurrentRow.Cells[4].Value);
            }
            else
                MessageBox.Show("Select row");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                employee.State = EntityState.Deleted;
                employee.IdPk = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
              string result=  employee.SaveChanges();
                MessageBox.Show(result );
                ListEmployees();
            }
            else
                MessageBox.Show("Select row");
        }
    }
}
