﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Economica
{
    public partial class VpnDiseño : Form
    {
        private int numero_Periodos = 0;
        private List<TextBox> listaTextBoxes = new List<TextBox>();
        private List<Label> listaLabels = new List<Label>();
        public VpnDiseño()
        {
            InitializeComponent();
        }

        private void VpnDiseño_Load(object sender, EventArgs e)
        {

        }
        //Boton Calcular
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Cadena_Formateada = "N2";
                double VPN = Double.Parse("-" + Inversion_Inicial_Text.Text);
                double Interes = Double.Parse(Interes_Text.Text);
                int i = 1;

                foreach (TextBox textBox in listaTextBoxes)
                {
                    double Valor_Periodo = Double.Parse(textBox.Text);
                    VPN += (Valor_Periodo / Math.Pow(1 + Interes, i));
                    i++;
                }
                if (Millares_Boton.Checked)
                {
                    Cadena_Formateada = string.Format("{0:" + Cadena_Formateada + "}", VPN);
                    Resultado_Label.Text = "Resultado: " + Cadena_Formateada;
                }
                else if (Decimales_Boton.Checked)
                {
                    VPN *= 1000000;
                    Cadena_Formateada = string.Format("{0:" + Cadena_Formateada + "}",VPN);
                    Resultado_Label.Text = "Resultado: " + Cadena_Formateada;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void Inversion_Inicial_Text_TextChanged(object sender, EventArgs e)
        {

        }
        //Fijar Periodos
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Numero_Periodos_Text.Enabled = false;
                numero_Periodos = int.Parse(Numero_Periodos_Text.Text);
                
                for(int i = 1; i <= numero_Periodos; i++)
                {
                    TextBox _textBox = new TextBox();
                    Label _label = new Label();
                    _textBox.Name = "Periodo" + i.ToString() + "_Text";
                    _label.Name = "Label_Fe" + i.ToString();
                    _textBox.Size = new Size(120, 20);
                    _label.Size = new Size(50, 20);
                    _label.Text = "Fe" + i.ToString();
                    listaTextBoxes.Add(_textBox);
                    listaLabels.Add(_label);
                    Contenedor_Periodos.Controls.Add(_label);
                    Contenedor_Periodos.Controls.Add(_textBox);
                }
            }
            catch(Exception ex)
            {
                if (numero_Periodos == 0 || Numero_Periodos_Text.Text == null) Numero_Periodos_Text.Enabled = true;
                MessageBox.Show("Error: " + ex.ToString());
            }
         
        }
        //Boton regresar
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Boton Limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            Numero_Periodos_Text.Enabled = true;
            Numero_Periodos_Text.Text = null;
            Interes_Text.Text = null;
            Inversion_Inicial_Text.Text = null;
            Resultado_Label.Text = "Resultado:";
            
              foreach(TextBox i in listaTextBoxes)
              {
                  Contenedor_Periodos.Controls.Remove(i);
                  i.Dispose();
              }
              foreach (Label j in listaLabels)
              {
                  Contenedor_Periodos.Controls.Remove(j);
                  j.Dispose();
              }
            listaTextBoxes.Clear();
            listaLabels.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de elementos en TxtBox" + listaTextBoxes.Count + "\n Labels " + listaLabels.Count);

        }

        private void Contenedor_Periodos_Paint(object sender, PaintEventArgs e)
        {
            Contenedor_Periodos.AutoScroll = true;
            Contenedor_Periodos.AutoScrollMinSize = new Size(0, 225);
        }
    }
}
