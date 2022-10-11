using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace PresentacionCarSof
{
    public partial class FrmCompilador : Form
    {
        private ManejadorLéxico _manejadorLéxico;
        public FrmCompilador()
        {
            InitializeComponent();
            _manejadorLéxico = new ManejadorLéxico();
        }

        private void btnLexico_Click(object sender, EventArgs e)
        {
            _manejadorLéxico.HacerLexico(txtEditor.Text, dtgTokens);
        }
    }
}
