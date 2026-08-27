using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PryPosseReg1
{
    public partial class frmAgregarClientes : Form
    {
        public frmAgregarClientes()
        {
            InitializeComponent();
        }

        clsVector vector = new clsVector();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            vector.Agregar(txtCodigo.Text, txtDeuda.Text, txtUsuario.Text, txtLimite.Text);
        }
    }
}
