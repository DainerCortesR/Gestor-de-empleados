using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_empleados
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBoxF4 : UserControl
    {
        private Color borderColor = Color.Black;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;
        private Color borderFocusColor = Color.Red;

        public TextBoxF4()
        {
            InitializeComponent();
        }

        //Eventos
        public event EventHandler _TextChanged;

        //Encapsulamiento
        [Category("Universo F4")]
        public Color BorderColor
        {
            get
            {
                return this.borderColor;
            }
            set
            {
                this.borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Universo F4")]
        public int BorderSize
        {
            get
            {
                return this.borderSize;
            }
            set
            {
                this.borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Universo F4")]
        public bool UnderlinedStyle
        {
            get
            {
                return this.underlinedStyle;
            }
            set
            {
                this.underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Universo F4")]
        public bool PassWordChar
        {
            get
            {
                return this.txt.UseSystemPasswordChar;
            }
            set
            {
                this.txt.UseSystemPasswordChar = value;
            }
        }

        [Category("Universo F4")]
        public bool Multiline
        {
            get
            {
                return this.txt.Multiline;
            }
            set
            {
                this.txt.Multiline = value;
            }
        }

        [Category("Universo F4")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                this.txt.BackColor = value;
            }
        }

        [Category("Universo F4")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                this.txt.ForeColor = value;
            }
        }

        [Category("Universo F4")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                this.txt.Font = value;
                if (this.DesignMode)
                {
                    this.UpdateControlHeight();
                }
            }
        }

        [Category("Universo F4")]
        public string Texts
        {
            get
            {
                return this.txt.Text;
            }
            set
            {
                this.txt.Text = value;
            }
        }

        [Category("Universo F4")]
        public Color BorderFocusColor 
        {
            get
            {
                return this.borderFocusColor;
            }
            set
            {
                this.borderFocusColor = value;
            }
        }

        //Metodos virtuales
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using(Pen penBorder = new Pen(this.borderColor, this.borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!this.isFocused)
                {
                    if (this.underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
                else
                {
                    penBorder.Color = this.borderFocusColor;

                    if (this.underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }            
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                this.UpdateControlHeight();
            }     
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.UpdateControlHeight();
        }

        //Metodos privados
        private void UpdateControlHeight()
        {
            int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
            this.txt.Multiline = true;
            this.txt.MinimumSize = new Size(0, txtHeight);
            this.txt.Multiline = false;
            this.Height = this.txt.Height + this.Padding.Top + this.Padding.Bottom;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (this._TextChanged != null)
            {
                this._TextChanged.Invoke(sender, e);
            }
        }

        private void txt_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void txt_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void txt_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            this.isFocused = false;
            this.Invalidate();
        }
    }
}
