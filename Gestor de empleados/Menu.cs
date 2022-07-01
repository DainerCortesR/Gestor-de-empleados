using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestor_de_empleados.Clases;

namespace Gestor_de_empleados
{
    public partial class Menu : Form
    {
        private int poX = 0;
        private int PoY = 0;
        General g = new General();

        public Menu()
        {
            InitializeComponent();
        }

        //Boton Salir
        private void picExits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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

        //abrir formulario dentro del formulario
        public void OpenChild(object frmChild)
        {
            if (panelChild.Controls.Count > 0)
            {
                panelChild.Controls.RemoveAt(0);          
            }

            Form frm = frmChild as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(frm);
            panelChild.Tag = frm;
            frm.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenChild(new Employees());
            this.OpcionesColor();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChild(new Agregar());
            this.OpcionesColor();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenChild(new Editar());
            this.OpcionesColor();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OpenChild(new Eliminar());
            this.OpcionesColor();
        }

        private void btnSignOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        //Metodo para cambiar y devolver color de los botones
        private void OpcionesColor()
        {
            //Boton empleados
            if (General.ColorB == "Employees")
            {
                General.MantenerColor(this.btnEmployees);
            }
            else
            {
                General.DevolverColor(this.btnEmployees);
            }

            //Boton añadir empleados
            if (General.ColorB == "Add")
            {
                General.MantenerColor(this.btnAdd);
            }
            else
            {
                General.DevolverColor(this.btnAdd);
            }

            //Boton editar empleados
            if (General.ColorB == "Edit")
            {
                General.MantenerColor(this.btnEdit);
            }
            else
            {
                General.DevolverColor(this.btnEdit);
            }

            //Boton eliminar empleados
            if (General.ColorB == "Delete")
            {
                General.MantenerColor(this.btnDelete);
            }
            else
            {
                General.DevolverColor(this.btnDelete);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                OpenChild(new Agregar());
                this.OpcionesColor();
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

        private void panelUp_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }
    }
}
