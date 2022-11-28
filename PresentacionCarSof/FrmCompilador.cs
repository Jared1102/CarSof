using System;
using System.Windows.Forms;
using Manejadores;
using Entidades;
using System.Collections.Generic;

namespace PresentacionCarSof
{
    public partial class FrmCompilador : Form
    {
        private ManejadorLéxico _manejadorLéxico;
        private ManejadorSintactico _manejadorSintactico;
        private List<Tokens> tokens=new List<Tokens>();
        public FrmCompilador()
        {
            InitializeComponent();
            _manejadorLéxico = new ManejadorLéxico();
            _manejadorSintactico = new ManejadorSintactico();
        }

        private void btnLexico_Click(object sender, EventArgs e)
        {
            tokens.Clear();
            tokens = _manejadorLéxico.HacerLexico(txtEditor.Text, dtgTokens);
        }

        private void btnSintactico_Click(object sender, EventArgs e)
        {
            _manejadorSintactico.HacerSintactico(tokens, dtgSintactico);
        }
    }
}
