using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Gestor_de_empleados.Clases
{
    class General
    {
        //Variable para cambiar color de los botones
        public static string ColorB = "";

        //Metodos que se implementan en las clases de los formularios
        public void Load(DataGridView dtg, List<Employee> employees, Label name, Label surname,
            Label salary, Label position, PictureBox pic)
        {
            try
            {
                dtg.DataSource = null;
                LoadTxt(employees);
                UpdateView(dtg, employees);

                //Muestra el primer empleado
                Employee person = employees[0];
                name.Text = "Nombre: " + person.Name;
                surname.Text = "Apellido: " + person.Surname;
                salary.Text = "Salario:" + person.Salary;
                position.Text = "Cargo: " + person.Position;
                pic.Image = new Bitmap(@"C:\GestorEmpleados\Imagenes\\" + person.ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveFile(List<Employee> employees)
        {
            try
            {
                StreamWriter write = new StreamWriter(@"C:\GestorEmpleados\BaseDatos\BD.txt");
                foreach (Employee person in employees)
                {
                    write.WriteLine(person.ID + "|" + person.Name + "|" + person.Surname + "|" + person.Salary + "|" + person.Position + "|" + person.ImagePath + "|");
                }
                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Papelera(string img)
        {
            try
            {
                StreamWriter write = File.AppendText(@"C:\GestorEmpleados\Imagenes\\Papelera.txt");
                write.WriteLine(img + "|");
                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            public void UpdateView(DataGridView dtg, List<Employee> Employees)
        {
            try
            {
                dtg.DataSource = null;
                dtg.DataSource = Employees;
                dtg.Columns[0].Visible = false;
                dtg.Columns[1].HeaderText = "Nombre";
                dtg.Columns[2].HeaderText = "Apellido";
                dtg.Columns[3].HeaderText = "Salario";
                dtg.Columns[4].HeaderText = "Cargo";
                dtg.Columns[5].Visible = false;

                dtg.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadTxt(List<Employee> Employees)
        {
            try
            {
                StreamReader reader = new StreamReader(@"C:\GestorEmpleados\BaseDatos\BD.txt");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int position;
                    Employee person = new Employee();
                    position = line.IndexOf("|");
                    person.ID = line.Substring(0, position);
                    line = line.Substring(position + 1);
                    position = line.IndexOf("|");
                    person.Name = line.Substring(0, position);
                    line = line.Substring(position + 1);
                    position = line.IndexOf("|");
                    person.Surname = line.Substring(0, position);
                    line = line.Substring(position + 1);
                    position = line.IndexOf("|");
                    person.Salary = line.Substring(0, position);
                    line = line.Substring(position + 1);
                    position = line.IndexOf("|");
                    person.Position = line.Substring(0, position);
                    line = line.Substring(position + 1);
                    position = line.IndexOf("|");
                    person.ImagePath = line.Substring(0, position);
                    Employees.Add(person);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution finished");
            }
        }

        public static void MantenerColor(Button btn)
        {
            btn.BackColor = Color.FromArgb(88, 207, 186);
        }

        public static void DevolverColor(Button btn)
        {
            btn.BackColor = Color.FromArgb(74, 173, 155);
        }
    }
}
