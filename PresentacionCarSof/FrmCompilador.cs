using System;
using System.Windows.Forms;
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
