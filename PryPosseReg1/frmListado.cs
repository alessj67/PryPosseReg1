using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PryPosseReg1
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        clsVector vector = new clsVector();

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        vector.OrdenarCodigoAscendente();
                    }
                    else
                    {
                        vector.OrdenarCodigoDescendente();
                    }
                    break;
                case 1:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        vector.OrdenarNombreAscendente();
                    }
                    else
                    {
                        vector.OrdenarNombreDescendente();
                    }
                    break;
                case 2:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        vector.OrdenarDeudaAscendente();
                    }
                    else
                    {
                        vector.OrdenarDeudaDescendente();
                    }
                    break;
                case 3:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        vector.OrdenarLimiteAscendente();
                    }
                    else
                    {
                        vector.OrdenarLimiteDescendente();
                    }
                    break;
            }
            dgvLista.Rows.Clear();

            for (int i = 0; i < clsVector.ind; i++)
            {
                dgvLista.Rows.Add(
                    clsVector.clientes[i].codigo,
                    clsVector.clientes[i].usuario,
                    clsVector.clientes[i].limite,
                    clsVector.clientes[i].deuda
                    );
            }

        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            clsVector.Precarga();

        }
    }
}
