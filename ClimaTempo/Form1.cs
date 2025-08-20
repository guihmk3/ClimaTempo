using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimaTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificador_Click(object sender, EventArgs e)
        {
            if (txbTemp.Text == "") // verificar se o campos não esta vazio 
            {
                MessageBox.Show("Preencha a Temperatura:", "Erro!,",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double a = double.Parse(txbTemp.Text);
            if (a < 15)
            {
                pibClima.Image = Properties.Resources.frio;
            }
            else if (a >= 15 &&  a <= 30)
            {
                pibClima.Image = Properties.Resources.solcomnuvem;
            }
            else if (a > 30)
            {
                pibClima.Image = Properties.Resources.solforte;
            }

            lblDia.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void txbTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txbTemp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede o "bip" do Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            
        }
    }
}
