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
                    DataGridViewColumn InversionInicialColumn = new DataGridViewTextBoxColumn();
                    InversionInicialColumn.HeaderText = "Año 0";
                    Tabla_Datos.Columns.Add(InversionInicialColumn);
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
                        DataGridViewColumn DataGrindColumn = new DataGridViewTextBoxColumn();
                        DataGrindColumn.HeaderText = "Año " + i.ToString();
                        DataGrindColumn.Name = "Columna_Año_" + i.ToString();
                        ListaColumnas.Add(DataGrindColumn);
                        Tabla_Datos.Columns.Add(DataGrindColumn);
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
            foreach (TextBox i in ListaTextBox)
            {
                Contenedor_Periodos_Layout.Controls.Remove(i);
                i.Dispose();
                Contenedor_Periodos_Layout.Controls.Remove(i);
            }
            foreach (Label j in ListaLabels)
            {
                Contenedor_Periodos_Layout.Controls.Remove(j);
                j.Dispose();
            }
            foreach(DataGridViewColumn h in ListaColumnas)
            {
                Tabla_Datos.Columns.Remove(h);
                h.Dispose();
            }
            ListaColumnas.Clear();
            ListaTextBox.Clear();
            ListaLabels.Clear();
        }
    }
    
}
