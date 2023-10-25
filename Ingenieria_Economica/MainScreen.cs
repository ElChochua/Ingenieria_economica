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
            formula_Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            donde_Label.Text = "Donde:\r\n\r\nVPN: es el valor presente neto\r\nr: la tasa de descuento\r\nn: el número de períodos";
            Opcion = 2;
            
        }

        private void pri_Btn_Click(object sender, EventArgs e)
        {
            inf_Label.Text = "El periodo de recuperación de la inversión (PRI) o payback se refiere al tiempo que\n" +
                "le toma a un negocio recuperar el capital invertido inicialmente. A través de una fórmula\nse calculan" +
                "los años, los meses y días que demora; a su vez, permite determinar si un\n" +
                "proyecto es rentable o no.";
            formula_Pic.ImageLocation = @"D:\Ingenieria_Economica\Ingenieria_Economica\Imagenes\PRI_Formula.png";
            donde_Label.Text = "Donde:\n" +
                "a = año anterior inmediato al que se recupera la inversión.\r\n" +
                "b = inversión inicial del negocio.\r\n" +
                "c = flujo de efectivo acumulado del año anterior inmediato al que se recupera la inversión.\r\n" +
                "d = flujo de efectivo del año exacto en el que se recupera la inversión. ";
            Opcion = 3;

        }

        private void tir_Btn_Click(object sender, EventArgs e)
        {
            inf_Label.Text = "La Tasa Interna de Retorno o TIR es la tasa de interés o de rentabilidad que ofrece una\n" +
                "inversión. Así, se puede decir que la Tasa Interna de Retorno es el porcentaje de beneficio o pérdida\n" +
                "que conlleva cualquier inversión.\nLa TIR es un factor invaluable para el éxito de una empresa o\n" +
                "negocio. Para tal efecto, puede ser de ayuda financiar la empresa.";
            formula_Pic.ImageLocation = @"D:\Ingenieria_Economica\Ingenieria_Economica\Imagenes\TIR_Formula.jpg";
            formula_Pic.SizeMode = PictureBoxSizeMode.AutoSize;
            donde_Label.Text = "F representa los flujos de caja en cada periodo.\r\n" +
                "I0 es el valor del desembolso inicial de la inversión.\r\n" +
                "n es el número de periodos considerado.";
            Opcion = 4;

        }

        private void salir_Btn_Click(object sender, EventArgs e)
        {            
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
                    this.Hide();
                    VpnDiseño vpn = new VpnDiseño();
                    vpn.ShowDialog();
                    this.Show();
                    break;
                case 2:
                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Show();

                    break;
                case 3:
                    this.Hide();
                    PeriodoDeRecuperacionInversion Per = new PeriodoDeRecuperacionInversion();
                    Per.ShowDialog();
                    this.Show();

                    break;
                 case 4:
                    this.Hide();
                    Tasa_Intern_Retorno tasa = new Tasa_Intern_Retorno();
                    tasa.ShowDialog();
                    this.Show();
                    break;
            }
        }

        private void formula_Pic_Click(object sender, EventArgs e)
        {

        }
    }
}
