﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_empleados.Clases
{
    class CKeyPress
    {
        public static bool ActiveLetter(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !"|".Contains(e.KeyChar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ActiveNum(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
