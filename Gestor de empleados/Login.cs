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

namespace Gestor_de_empleados
{
    public partial class Login : Form
    {
        private ErrorProvider Error;
        private int poX = 0;
        private int PoY = 0;
        private List<string> Papelera = new List<string>();
        public Login()
        {
            InitializeComponent();
            Error = new ErrorProvider();
        }

        private void picExits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton Salir
        private void picExits_MouseDown(object sender, MouseEventArgs e)
        {
            this.picExits.Image = Properties.Resources.GrayExitsClic;
        }

        private void picExits_MouseHover(object sender, EventArgs e)
        {
            this.picExits.Image = Properties.Resources.GrayExitsHover;
        }

        private void picExits_MouseLeave(object sender, EventArgs e)
        {
            this.picExits.Image = Properties.Resources.GrayExits;
        }

        //Boton Minimizar
        private void picMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMinimized_MouseDown(object sender, MouseEventArgs e)
        {
            this.picMinimized.Image = Properties.Resources.GrayMinimizedClic;
        }

        private void picMinimized_MouseHover(object sender, EventArgs e)
        {
            this.picMinimized.Image = Properties.Resources.GrayMinimizedHover;
        }

        private void picMinimized_MouseLeave(object sender, EventArgs e)
        {
            this.picMinimized.Image = Properties.Resources.GrayMinimized;
        }

        //Codigo
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.txtUser.Texts.Equals("0533"))
                {
                    Error.SetError(this.txtUser, "Usuario incorrecto");
                }
                else if (!this.txtPassword.Texts.Equals("admin"))
                {
                    Error.SetError(this.txtPassword, "Contraseña incorrecta");
                }
                else
                {
                    Menu f2 = new Menu();
                    f2.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MoveForm(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                this.poX = e.X;
                this.PoY = e.Y;
            }
            else
            {
                Left = Left + (e.X - this.poX);
                Top = Top + (e.Y - this.PoY);
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            this.MoveForm(e);
        }

        private void panelUp_MouseMove(object sender, MouseEventArgs e)
        {
            this.MoveForm(e);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Error.Clear();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Error.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(@"C:\GestorEmpleados"))
                {
                    Directory.CreateDirectory(@"C:\GestorEmpleados");
                }
                if (!Directory.Exists(@"C:\GestorEmpleados\BaseDatos"))
                {
                    Directory.CreateDirectory(@"C:\GestorEmpleados\BaseDatos");
                }
                if (!Directory.Exists(@"C:\GestorEmpleados\Imagenes"))
                {
                    Directory.CreateDirectory(@"C:\GestorEmpleados\Imagenes");
                }
                if (!File.Exists(@"C:\GestorEmpleados\Imagenes\\Papelera.txt"))
                {
                    File.Create(@"C:\GestorEmpleados\Imagenes\\Papelera.txt");          
                }
                if (!File.Exists(@"C:\GestorEmpleados\BaseDatos\\BD.txt"))
                {
                    TextWriter write = new StreamWriter(@"C:\GestorEmpleados\BaseDatos\\BD.txt");
                    write.Close();
                }
                this.LoadPaperBin();
                this.EliminarImg();
                this.ReiniciarPapelera();
            }
            catch (Exception)
            {
            }
        }
        public void LoadPaperBin()
        {
            try
            {
                StreamReader reader = new StreamReader(@"C:\GestorEmpleados\Imagenes\\Papelera.txt");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int position;
                    string valor = "";
                    position = line.IndexOf("|");
                    valor = line.Substring(0, position);
                    this.Papelera.Add(valor);             
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
        public void EliminarImg()
        {
            try
            {
                foreach (var item in this.Papelera)
                {
                    File.Delete(@"C:\GestorEmpleados\Imagenes\" + item);
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
            }
        }

        public void ReiniciarPapelera()
        {
            StreamWriter write2 = new StreamWriter(@"C:\GestorEmpleados\Imagenes\\Papelera.txt");
            write2.Write("");
            write2.Close();
        }
    }
}
