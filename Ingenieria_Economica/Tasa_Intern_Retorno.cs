using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ingenieria_Economica
{
    public partial class Tasa_Intern_Retorno : Form
    {
        public Tasa_Intern_Retorno()
        {
            InitializeComponent();
        }
        private int Numero_Periodos = 0;
        private List<TextBox> Lista_TextBox = new List<TextBox>();
        private List<double> Lista_Flujos = new List<double>();

        private void Fijar_Periodos_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                Numero_Periodos = int.Parse(Numero_Periodos_Text.Text);
                if (Numero_Periodos > 0)
                {

                    for (int i = 1; i <= Numero_Periodos; i++)
                    {
                        TextBox _textBox = new TextBox();
                        Label _label = new Label();
                        _textBox.Name = "Periodo" + i.ToString() + "_Text";
                        _label.Name = "Label_Fe" + i.ToString();
                        _textBox.Size = new Size(120, 20);
                        _label.Size = new Size(50, 20);
                        _label.Text = "Fe" + i.ToString();
                        Lista_TextBox.Add(_textBox);
                        Panel_Flujos_Efectivo.Controls.Add(_label);
                        Panel_Flujos_Efectivo.Controls.Add(_textBox);
                        
                    }
                    Fijar_Periodos_Btn.Enabled = false;
                    Numero_Periodos_Text.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void Panel_Flujos_Efectivo_Paint(object sender, PaintEventArgs e)
        {
            Panel_Flujos_Efectivo.AutoScroll = true;
            
        }

        private void Limpiar_Btn_Click(object sender, EventArgs e)
        {
            Panel_Flujos_Efectivo.Controls.Clear();
            Lista_Flujos.Clear();
            Lista_TextBox.Clear();
            Numero_Periodos_Text.Enabled = true;
            Fijar_Periodos_Btn.Enabled = true;
        }
        /*
        Ft son los flujos de dinero en cada periodo t
        I 0   es la inversión realiza en el momento inicial ( t = 0 )
        n es el número de periodos de tiempo
        k es el tipo de descuento o tipo de interés exigido a la inversión
         */
        public double Calcular_VAN(List<double> lista_Flujos, double Inversion_inicial, double Descuento)
        {
            double VAN = Inversion_inicial;
            int Periodo = 1;
            foreach (double i in lista_Flujos)
            {
                VAN += (i / (Math.Pow(1 + Descuento, Periodo)));
                //MessageBox.Show("Inversion Inicial: "+ Inversion_inicial + "\nValor VAN" + VAN + "\nPeriodo" + Periodo + "\nCosa" + (Math.Pow(1 + Descuento, Periodo)));
                Periodo++;
            }
            return VAN;
        }
        private void Calcular_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                double Inversion_Inicial = Double.Parse("-" + Inversion_Inicial_Text.Text);
                double TIR = Inversion_Inicial;
                Lista_Flujos.Add(Inversion_Inicial);
                foreach(TextBox i in Lista_TextBox)
                {
                    if (double.TryParse(i.Text, out double flujos))
                    {
                        Lista_Flujos.Add(flujos);
                    }
                    else return;
                }

                
                Double[] arreglo_Flujos = Lista_Flujos.ToArray();
                double IRR = Financial.IRR(ref arreglo_Flujos, 0.1);
                IRR *= 100;
                TIR_Label.Text = IRR.ToString("F4");
                if (IRR > 0)
                {
                    Imagen_Rentabilidad.ImageLocation = @"D:\Ingenieria_Economica\Ingenieria_Economica\Imagenes\Gato_Pizza.jpg";
                    Rentabilidad_Label.Text = "Proyecto Rentable";
                }else if (IRR < 0)
                {
                    Imagen_Rentabilidad.ImageLocation = @"D:\Ingenieria_Economica\Ingenieria_Economica\Imagenes\Gato_Boom.jpg";
                    Rentabilidad_Label.Text = "Proyecto no Rentable";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void Regresar_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
