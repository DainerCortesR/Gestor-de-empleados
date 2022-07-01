using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Gestor_de_empleados.Clases;

namespace Gestor_de_empleados
{
    public partial class Editar : Form
    {
        private General g = new General();
        private List<Employee> Employees = new List<Employee>();
        private int Index = -1;
        private int ID = 0;
        private bool Continuar = false;

        public Editar()
        {
            InitializeComponent();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            try
            {
                General.ColorB = "Edit";

                g.LoadTxt(this.Employees);
                g.UpdateView(this.dataGridView1, this.Employees);
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
                Employee person = this.Employees[Index];
                this.ID = Convert.ToInt32(person.ID);
                this.txtName.Texts = person.Name;
                this.txtSurname.Texts = person.Surname;
                this.txtSalary.Texts = person.Salary;
                this.txtPosition.Texts = person.Position;
                this.pictureBox1.Image = new Bitmap(@"C:\GestorEmpleados\Imagenes\" + person.ImagePath);
                this.Continuar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LimpiarCampos()
        {
            this.txtName.Texts = "";
            this.txtSurname.Texts = "";
            this.txtSalary.Texts = "";
            this.txtPosition.Texts = "";
            this.pictureBox1.Image = null;
            this.pictureBox1.Image = Properties.Resources.businessman;
            this.Continuar = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Continuar == true)
                {
                    if (this.txtName.Texts.Trim() == "" || this.txtSurname.Texts.Trim() == "" || this.txtSalary.Texts.Trim() == "" ||
                        this.txtPosition.Texts.Trim() == "")
                    {
                        MessageBox.Show("Por favor complete todos los campos");
                    }
                    else
                    {
                        Employee person = new Employee();
                        person.ID = Convert.ToString(this.ID);
                        person.Name = this.txtName.Texts;
                        person.Surname = this.txtSurname.Texts;
                        person.Salary = this.txtSalary.Texts;
                        person.Position = this.txtPosition.Texts;
                        person.ImagePath = Convert.ToString(this.ID) + ".jpeg";
                        if (this.Index > -1)
                        {
                            this.Employees[this.Index] = person;
                            this.Index = -1;
                        }
                        else
                        {
                            this.Employees.Add(person);
                        }
                        g.SaveFile(this.Employees);
                        this.LimpiarCampos();
                        g.UpdateView(this.dataGridView1, this.Employees);
                        MessageBox.Show("Empleado modificado correctamente");
                    }
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

        //Metodos KeyPress
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CKeyPress.ActiveLetter(e);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CKeyPress.ActiveLetter(e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CKeyPress.ActiveNum(e);
        }

        private void txtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CKeyPress.ActiveLetter(e);
        }
    }
}
