using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtClave.Clear();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "usuario" && txtClave.Text == "123")
            {
                FrmInicio frmInicio = new FrmInicio();
                this.Hide();
                frmInicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingreados son incorrectos");
                txtUsuario.Clear();
                txtClave.Clear();
            }
        }
    }
}
