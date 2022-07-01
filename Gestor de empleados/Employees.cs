using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Gestor_de_empleados.Clases;

namespace Gestor_de_empleados
{
    public partial class Employees : Form
    {
        private General g = new General();
        private List<Employee> employees = new List<Employee>();
        private int Index = -1;
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            General.ColorB = "Employees";
            try
            {
                dataGridView1.DataSource = null;
                g.LoadTxt(this.employees);
                g.UpdateView(this.dataGridView1, this.employees);

                //Muestra el primer empleado
                Employee person = employees[0];
                lblName.Text = "Nombre: " + person.Name;
                lblSurname.Text = "Apellido: " + person.Surname;
                lblSalary.Text = "Salario: " + person.Salary;
                lblPosition.Text = "Cargo: " + person.Position;
                pictureBox1.Image = new Bitmap(@"C:\GestorEmpleados\Imagenes\\" + person.ImagePath);
            }
            catch (Exception)
            {
            }
        }
    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow seleccion = this.dataGridView1.SelectedRows[0];
                this.Index = this.dataGridView1.Rows.IndexOf(seleccion);
                Employee person = this.employees[this.Index];
                this.lblName.Text = "Nombre: " + person.Name;
                this.lblSurname.Text = "Apellido: " + person.Surname;
                this.lblSalary.Text = "Salario: " + person.Salary;
                this.lblPosition.Text = "Cargo: " + person.Position;
                this.pictureBox1.Image = new Bitmap(@"C:\GestorEmpleados\Imagenes\\" + person.ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
