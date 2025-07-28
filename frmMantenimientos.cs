
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_progra2
{
    public partial class frmMantenimientos : Form
    {
        private Equipo equipoActual;

        public frmMantenimiento(Equipo equipo)
        {
            InitializeComponent();
            equipoActual = equipo;
        }
    }
}

