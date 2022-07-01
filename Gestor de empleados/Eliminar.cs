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
    public partial class Eliminar : Form
    {
        private General g = new General();
        private List<Employee> Employees = new List<Employee>();
        private int Index = -1;
        private bool Continuar = false;
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            try
            {
                General.ColorB = "Delete";
                g.LoadTxt(this.Employees);
                g.UpdateView(this.dataGridView1, this.Employees);
            }
            catch (Exception)
            {
            }
        }

        string Guardar = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow seleccion = this.dataGridView1.SelectedRows[0];
                this.Index = this.dataGridView1.Rows.IndexOf(seleccion);
                Employee person = this.Employees[Index];
                this.txtName.Texts = person.Name;
                this.txtSurname.Texts = person.Surname;
                this.txtSalary.Texts = person.Salary;
                this.txtPosition.Texts = person.Position;
                this.pictureBox1.Image = new Bitmap(@"C:\GestorEmpleados\Imagenes\" + person.ImagePath);
                this.Guardar = person.ImagePath;

                this.Continuar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                this.txtName.Texts = "";
                this.txtSurname.Texts = "";
                this.txtSalary.Texts = "";
                this.txtPosition.Texts = "";
                this.pictureBox1.Image = Properties.Resources.businessman;
                this.Continuar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Continuar == true)
                {
                    this.Delete();
                    g.Papelera(Guardar);
                    g.SaveFile(this.Employees);
                    g.UpdateView(this.dataGridView1, this.Employees);
                    this.LimpiarCampos();

            //        File.Delete(@"C:\GestorEmpleados\Imagenes\" + this.Almacenar);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un empleado");
                }
          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }           
        }      

        public void Delete()
        {
            if (this.Index > -1)
            {
                this.Employees.RemoveAt(this.Index);
                this.Index = -1;
            }
        }

        //Metodo Keypress Afecta a todas las cajas de texto
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
