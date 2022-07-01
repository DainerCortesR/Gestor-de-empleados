
namespace Gestor_de_empleados
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignOff = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMinimized = new System.Windows.Forms.PictureBox();
            this.picExits = new System.Windows.Forms.PictureBox();
            this.panelUp = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.f4Elipse1 = new Gestor_de_empleados.Diseño.F4Elipse();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExits)).BeginInit();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(173)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.btnSignOff);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnEmployees);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 582);
            this.panel2.TabIndex = 1;
            // 
            // btnSignOff
            // 
            this.btnSignOff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignOff.FlatAppearance.BorderSize = 0;
            this.btnSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOff.ForeColor = System.Drawing.Color.White;
            this.btnSignOff.Image = global::Gestor_de_empleados.Properties.Resources.Out;
            this.btnSignOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOff.Location = new System.Drawing.Point(0, 276);
            this.btnSignOff.Name = "btnSignOff";
            this.btnSignOff.Size = new System.Drawing.Size(190, 48);
            this.btnSignOff.TabIndex = 4;
            this.btnSignOff.Text = "Salir";
            this.btnSignOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOff.UseVisualStyleBackColor = true;
            this.btnSignOff.Click += new System.EventHandler(this.btnSignOff_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Gestor_de_empleados.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 48);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar empleado";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Gestor_de_empleados.Properties.Resources.Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(0, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 48);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar empleados";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Gestor_de_empleados.Properties.Resources.ImgAdd;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir empleado";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = global::Gestor_de_empleados.Properties.Resources.ViewEmployee;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 84);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(190, 48);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Empleados";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::Gestor_de_empleados.Properties.Resources.logooo;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(173)))), ((int)(((byte)(155)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(173)))), ((int)(((byte)(155)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(190, 84);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picMinimized);
            this.panel1.Controls.Add(this.picExits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 18);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // picMinimized
            // 
            this.picMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMinimized.Image = global::Gestor_de_empleados.Properties.Resources.GrayMinimized;
            this.picMinimized.Location = new System.Drawing.Point(802, 0);
            this.picMinimized.Name = "picMinimized";
            this.picMinimized.Size = new System.Drawing.Size(38, 18);
            this.picMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimized.TabIndex = 6;
            this.picMinimized.TabStop = false;
            this.picMinimized.Click += new System.EventHandler(this.picMinimized_Click);
            this.picMinimized.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMinimized_MouseDown);
            this.picMinimized.MouseLeave += new System.EventHandler(this.picMinimized_MouseLeave);
            this.picMinimized.MouseHover += new System.EventHandler(this.picMinimized_MouseHover);
            // 
            // picExits
            // 
            this.picExits.Dock = System.Windows.Forms.DockStyle.Right;
            this.picExits.Image = global::Gestor_de_empleados.Properties.Resources.GrayExits;
            this.picExits.Location = new System.Drawing.Point(840, 0);
            this.picExits.Name = "picExits";
            this.picExits.Size = new System.Drawing.Size(38, 18);
            this.picExits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExits.TabIndex = 5;
            this.picExits.TabStop = false;
            this.picExits.Click += new System.EventHandler(this.picExits_Click);
            this.picExits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picExits_MouseDown);
            this.picExits.MouseLeave += new System.EventHandler(this.picExits_MouseLeave);
            this.picExits.MouseHover += new System.EventHandler(this.picExits_MouseHover);
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.panel1);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(190, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(878, 22);
            this.panelUp.TabIndex = 3;
            this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(190, 22);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(878, 560);
            this.panelChild.TabIndex = 4;
            // 
            // f4Elipse1
            // 
            this.f4Elipse1.CornerRadius = 20;
            this.f4Elipse1.TargetControl = this;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 582);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExits)).EndInit();
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSignOff;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMinimized;
        private System.Windows.Forms.PictureBox picExits;
        private System.Windows.Forms.Panel panelChild;
        private Diseño.F4Elipse f4Elipse1;
    }
}