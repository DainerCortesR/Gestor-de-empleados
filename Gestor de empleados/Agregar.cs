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
using System.Drawing.Imaging;
using Gestor_de_empleados.Clases;

namespace Gestor_de_empleados
{
    public partial class Agregar : Form
    {
        private General g = new General();
        public int ID = 1;
        private List<Employee> Employee = new List<Employee>();
        private int AltoImg = 0;
        private int AnchoImg = 0;



        public Agregar()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            this.txtID.Texts = Convert.ToString(ID);
            this.txtName.Texts = "";
            this.txtSurname.Texts = "";
            this.txtSalary.Texts = "";
            this.txtPosition.Texts = "";
            this.txtSearch.Texts = "";
            this.pictureBox1.Image = Properties.Resources.businessman;
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            try
            {
                g.LoadTxt(this.Employee);

                foreach (Employee emp in this.Employee)
                {
                    ID = Convert.ToInt32(emp.ID) + 1;
                }
                this.txtID.Texts = Convert.ToString(ID);
                General.ColorB = "Add";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }      

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.txtName.Texts.Trim() == "" || this.txtSurname.Texts.Trim() == "" || this.txtSalary.Texts.Trim() == "" ||
                    this.txtPosition.Texts.Trim() == "" || this.txtSearch.Texts.Trim() == "")
                {
                    MessageBox.Show("Por favor complete todos los campos");
                }
                else
                {
                    Employee person = new Employee();
                    person.ID = this.txtID.Texts;
                    person.Name = this.txtName.Texts;
                    person.Surname = this.txtSurname.Texts;
                    person.Salary = this.txtSalary.Texts;
                    person.Position = this.txtPosition.Texts;
                    person.ImagePath = Convert.ToString(ID) + ".jpeg";
                    this.Employee.Add(person);

                    g.SaveFile(this.Employee);



                    this.pictureBox1.Image.Save(@"C:\GestorEmpleados\Imagenes\" + person.ImagePath, ImageFormat.Jpeg);
                    ID += 1;
                    this.LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = 0;      
                this.openFileDialog1.Filter = "Imagen jpg (*.jpg)|*.jpg|Imagen jpeg (*.jpeg)|*.jpeg";
                this.openFileDialog1.FileName = "";
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox1.Load(this.openFileDialog1.FileName);
                    this.txtSearch.Texts = this.openFileDialog1.FileName;

                    this.AltoImg = pictureBox1.Image.Height;
                    this.AnchoImg = pictureBox1.Image.Width;
                    resultado = this.AnchoImg - this.AltoImg;

                    if (this.AltoImg > this.AnchoImg)
                    {
                        if (this.AnchoImg <= 300)
                        {
                            pictureBox1.Image = new Bitmap(this.openFileDialog1.FileName);
                        }
                        else
                        {
                            this.AltoImg = this.AltoImg / 2;
                            this.AnchoImg = this.AnchoImg / 2;
                            Bitmap bmp = new Bitmap(pictureBox1.Image, Convert.ToInt32(this.AnchoImg), Convert.ToInt32(this.AltoImg));
                            pictureBox1.Image = bmp;
                        }              
                    }
                    else if (this.AltoImg == this.AnchoImg || resultado <= 5)
                    {
                        this.AltoImg = 200;
                       this. AnchoImg = 200;
                        Bitmap bmp = new Bitmap(pictureBox1.Image, Convert.ToInt32(this.AnchoImg), Convert.ToInt32(this.AltoImg));
                        pictureBox1.Image = bmp;
                    }                                     
                    else
                    {
                        this.txtSearch.Texts = "";
                        this.pictureBox1.Image = Properties.Resources.businessman;
                        MessageBox.Show("Por favor seleccione una imagen 3x3 o 3x4");
                    }
                    
                }
            }
            catch (Exception)
            {
            }
        }

        //Metodos KeyPress
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CKeyPress.ActiveLetter(e);
        }

        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = CKeyPress.ActiveNum(e);
        }

        private void txtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CKeyPress.ActiveLetter(e);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CKeyPress.ActiveLetter(e);
        }
    }
}
