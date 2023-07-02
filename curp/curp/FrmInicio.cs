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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdato.Text == "1")
            {
                Fordatos fordatos = new Fordatos();
                this.Hide();
                fordatos.Show();
            }
            else
            {
                MessageBox.Show("Dato incorrecto");
                txtdato.Clear();
            }
        }
    }
}
