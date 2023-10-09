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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }



        private void vae_Btn_Click(object sender, EventArgs e)
        {
            inf_Label.Text = "El método del VAE consiste en calcular el rendimiento anual uniforme que genera la\n" +
                "inversión en un proyecto durante un período determinado. Para calcular el VAE\nutilizamos la siguiente formula: ";
            formula_Pic.ImageLocation = @"D:\Ingenieria_Economica\Ingenieria_Economica\Imagenes\VAE_Formula.jpg";
            donde_Label.Text = "Donde:\r\n\r\nVPN: es el valor presente neto\r\nr: la tasa de descuento\r\nn: el número de períodos";
            Opcion = 2;
            
        }

        private void pri_Btn_Click(object sender, EventArgs e)
        {
            inf_Label.Text = "Aca vamos a poner informacion del PRI padrino";
            Opcion = 3;

        }

        private void tir_Btn_Click(object sender, EventArgs e)
        {
            inf_Label.Text = "Aca vamos a poner informacion del TIR padrino";
            Opcion = 4;

        }

        private void salir_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos pajuera");
            
            Close();
        }


        private void vpn_Btn_Click(object sender, EventArgs e)
        {
            inf_Label.Text = "El valor presente neto (VPN) es el valor de los flujos de efectivo proyectados, descontados\r\n" +
                "al presente. Es un método de modelado financiero utilizado por los contadores para la \r\n" +
                "elaboración de presupuestos de capital y por analistas e inversores para evaluar la rentabilidad \r\n" +
                "de las inversiones y proyectos propuestos.";
            formula_Pic.ImageLocation = @"D:\Ingenieria_Economica\Ingenieria_Economica\Imagenes\VPN_Formula.png";
            donde_Label.Text = "Donde:\r\nVPN: es el valor presente neto\r\nt: es el periodo\r\nn: Es el tiempo de evaluacion\r\nFt: Periodo de recuperacion\r\ni: es la tasa de interes";
            Opcion = 1;

        }

        private void calcular_Btn_Click(object sender, EventArgs e)
        {
            switch (Opcion)
            {
                case 1:
                    MessageBox.Show("Opcion 1");
                    break;
                case 2:
                    MessageBox.Show("Opcion 2");
                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Show();

                    break;
                case 3:
                    MessageBox.Show("Opcion 3");

                    break;
                 case 4:
                    MessageBox.Show("Opcion 4");

                    break;
            }
        }
    }
}
