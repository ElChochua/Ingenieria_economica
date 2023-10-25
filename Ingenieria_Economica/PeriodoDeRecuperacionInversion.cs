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
    public partial class PeriodoDeRecuperacionInversion : Form
    {
        private List<TextBox> ListaTextBox = new List<TextBox>();
        private List<Label> ListaLabels = new List<Label>();
        private List<DataGridViewColumn> ListaColumnas = new List<DataGridViewColumn>();
        private List<double> Inversion_Inicial_Mas_Flujo_Efectivo = new List<double>();
        private List<double> Flujo_Efectivo_Anual = new List<double>();
        private int Numero_Periodos = 0;
        public PeriodoDeRecuperacionInversion()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        //Contenedor de periodos
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            Contenedor_Periodos_Layout.AutoScroll = true;
            Contenedor_Periodos_Layout.AutoScrollMinSize = new Size(0, 225);
        }
        //Boton Fijar Periodos
        private void Fijar_Periodos_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                Numero_Periodos = int.Parse(Numero_Periodos_Text.Text);
                if(Numero_Periodos > 0)
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
                        ListaTextBox.Add(_textBox);
                        ListaLabels.Add(_label);
                        Contenedor_Periodos_Layout.Controls.Add(_label);
                        Contenedor_Periodos_Layout.Controls.Add(_textBox);
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

        private void Salir_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar_Btn_Click(object sender, EventArgs e)
        {
            Numero_Periodos_Text.Enabled = true;
            Numero_Periodos_Text.Text = null;
            Fijar_Periodos_Btn.Enabled = true;
            /*
            Interes_Text.Text = null;
            Inversion_Inicial_Text.Text = null;
            Resultado_Label.Text = "Resultado:";
            */
            Tabla_Datos.Columns.Clear();
            Contenedor_Periodos_Layout.Controls.Clear();
            Inversion_Inicial_Text.Text = null;
            Tabla_Datos.Columns.Clear();
            Tabla_Datos.Rows.Clear();
            ListaColumnas.Clear();
            ListaTextBox.Clear();
            ListaLabels.Clear();
        }
        public double Calcular_PRI(double A, double B, double C, double D)
        {
            Double PRI = 0;
            PRI = A + (B - C) / D;
            return PRI;
        }

        private void Calcular_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewColumn InversionInicialColumn = new DataGridViewTextBoxColumn();
                InversionInicialColumn.HeaderText = "Año 0";
                Tabla_Datos.Columns.Add(InversionInicialColumn);
                DataGridViewRow FlujoEfectivo = new DataGridViewRow();
                FlujoEfectivo.Cells.Add(new DataGridViewTextBoxCell { Value = Inversion_Inicial_Text.Text });

                int counter = 1;
                foreach (TextBox i in ListaTextBox)
                {
                    DataGridViewColumn DataGrindColumn = new DataGridViewTextBoxColumn();
                    DataGrindColumn.HeaderText = "Año " + counter.ToString();
                    DataGrindColumn.Name = "Columna_Año_" + counter.ToString();
                    FlujoEfectivo.Cells.Add(new DataGridViewTextBoxCell { Value = i.Text });
                    ListaColumnas.Add(DataGrindColumn);
                    Tabla_Datos.Columns.Add(DataGrindColumn);
                    counter++;
                }

                double Inversion_Inicial = Double.Parse("-" + Inversion_Inicial_Text.Text);
                double II_Inmutable = Inversion_Inicial;
                int Periodo_Recuperacion = 0;

                DataGridViewRow Inversion_Inicial_Menos_Flujo_Efectivo = new DataGridViewRow();
                Inversion_Inicial_Menos_Flujo_Efectivo.Cells.Add(new DataGridViewTextBoxCell { Value = Inversion_Inicial_Text.Text });
                int contador = 0;
                foreach (TextBox j in ListaTextBox)
                {
                    Inversion_Inicial = (Inversion_Inicial + Double.Parse(j.Text));
                    Inversion_Inicial_Mas_Flujo_Efectivo.Add(Inversion_Inicial);
                    Inversion_Inicial_Menos_Flujo_Efectivo.Cells.Add(new DataGridViewTextBoxCell { Value = Inversion_Inicial_Mas_Flujo_Efectivo[contador].ToString() });
                    if (Inversion_Inicial_Mas_Flujo_Efectivo[contador] >= 0.0)
                    {
                        Periodo_Recuperacion = contador - 1;
                    }                    
                    contador++;
                }
                //To Do 
                //Sacar FEA = FE + FE-II
                double FEA = 0;
                DataGridViewRow Fila_FEA = new DataGridViewRow();
                Fila_FEA.Cells.Add(new DataGridViewTextBoxCell { Value = (II_Inmutable - II_Inmutable).ToString()});

                FEA = Double.Parse(ListaTextBox[0].Text);
                Flujo_Efectivo_Anual.Add(FEA);
                for(int i = 1; i < ListaTextBox.Count; i++)
                {
                    FEA += Double.Parse(ListaTextBox[i].Text);
                    Flujo_Efectivo_Anual.Add(FEA);
                }
                foreach(double i in Flujo_Efectivo_Anual)
                {
                    Fila_FEA.Cells.Add(new DataGridViewTextBoxCell { Value = i.ToString() });
                }
                double A = Periodo_Recuperacion, B = Math.Abs(II_Inmutable), C = Flujo_Efectivo_Anual[Periodo_Recuperacion-1], D = Double.Parse(ListaTextBox[Periodo_Recuperacion].Text);

                double PRI = Calcular_PRI(A,B,C,D);
                int PRI_Enteros = (int)PRI;
                double decimales = PRI - PRI_Enteros;
                int Meses = (int)(decimales * 12),
                    Dias = (int)(decimales*30.44);
                double Resto_Meses = (decimales * 12) - Meses;
                double Resto_Dias = (Resto_Meses * 30.44) - Dias;
                int Horas = (int)(Resto_Dias * 24);
                double Resto_Horas = (Resto_Dias * 24) - Horas;
                int Minutos = (int)(Resto_Horas * 60);
                int Segundos = (int)((Resto_Horas * 60 - Minutos) * 60);

                Años_Label.Text = PRI_Enteros.ToString();
                Meses_Label.Text = Meses.ToString();
                Dias_Label.Text = Dias.ToString();
                Horas_Label.Text = Horas.ToString();
                Minutos_Label.Text = Minutos.ToString();
                Segundos_Label.Text = Segundos.ToString();

                Tabla_Datos.Rows.Add(FlujoEfectivo);
                Tabla_Datos.Rows.Add(Inversion_Inicial_Menos_Flujo_Efectivo);
                Tabla_Datos.Rows.Add(Fila_FEA);
                Tabla_Datos.ReadOnly = true;

                MessageBox.Show("PeriodoRecuperacion: " + Periodo_Recuperacion + "\nA: " + A + "\nB:" + B + "\nC: " + C+ "\nD: " + D +"\nPRI: " + PRI);

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al calcular: " + ex.ToString());    
            }
            

            
        }
    }
    
}
