using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Economica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vpn_Regresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Vpn_Text_TextChanged(object sender, EventArgs e)
        {
            //865, 140
            Vpn_Label.Text = Vpn_Text.Text;
            R_Label1.Location = new Point((687 + (Vpn_Text.TextLength * 7)), 140);
            X_Label.Location = new Point((639 + (Vpn_Text.TextLength * 7)), 140);
            Linea_Superior_Panel.Size = new Size(220 + (Vpn_Text.TextLength * 9), 2);

        }

        private void R_Text_TextChanged(object sender, EventArgs e)
        {
            R_Label1.Text = R_Text.Text;
            R_Label2.Text = R_Text.Text + ")";
            N_Label.Location = new Point((714 + (R_Text.TextLength * 11)), 232);
            Linea_Inferior_Panel.Size = new Size(120 + (R_Text.TextLength * 9), 2);

        }

        private void N_Label_Click(object sender, EventArgs e)
        {

        }

        private void Vpn_Calcular_Click(object sender, EventArgs e)
        {
            double VPN = 0, R = 0, N = 0, VAE = 0 ;
            String Cadena_Formateada = "N2";

            try
            {
                VPN = Double.Parse(Vpn_Text.Text);
                R = Double.Parse(R_Text.Text);
                N = Double.Parse(N_Label.Text);
                VAE = (VPN*R/(1-(1/Math.Pow((1+R),N))));
                Cadena_Formateada = string.Format("{0:" + Cadena_Formateada + "}", VAE);
                Resultado_Label.Text = "Resultado: " + Cadena_Formateada;
            }catch (Exception ex) {
                MessageBox.Show("Dato Invalido Error: " + ex.ToString());
            }
        }

        private void Vpn_Limpiar_Click(object sender, EventArgs e)
        {
            R_Text.Text = null;
            Vpn_Text.Text = null;
            N_Text.Text = null;
            Resultado_Label.Text = "Resultado:"; 
        }
        private void N_Text_TextChanged(object sender, EventArgs e)
        {
            N_Label.Text = N_Text.Text;
        }
    }
}
