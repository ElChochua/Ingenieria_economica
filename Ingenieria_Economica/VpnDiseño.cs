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
    public partial class VpnDiseño : Form
    {
        private int textBoxCount = 0;
        private int counter = 0;
        public VpnDiseño()
        {
            InitializeComponent();
        }

        private void VpnDiseño_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Inversion_Inicial_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            try
            {
                // Crear un nuevo TextBox
                TextBox newTextBox = new TextBox();
                Label newLabel = new Label();
                // Configurar propiedades del nuevo TextBox
                newLabel.Name = "Label_Fe" + textBoxCount.ToString();
                newTextBox.Name = "textBox" + textBoxCount.ToString();
                newTextBox.Location = new System.Drawing.Point(40, 30 + textBoxCount * 30); // Posición en el Panel
                newLabel.Location = new System.Drawing.Point(10,30 + textBoxCount * 30);
                newTextBox.Size = new System.Drawing.Size(120, 20);
                newLabel.Size = new System.Drawing.Size(50, 20);
                newLabel.Text = "Fe"+textBoxCount.ToString();
                if(textBoxCount >= 9)
                {
                    newLabel.Name = "Label_Fe" + textBoxCount.ToString();
                    newTextBox.Name = "textBox" + textBoxCount.ToString();
                    newTextBox.Location = new System.Drawing.Point(180, counter * 30); // Posición en el Panel
                    newLabel.Location = new System.Drawing.Point(130, 10 counter * 30);
                    newTextBox.Size = new System.Drawing.Size(140, 20);
                    newLabel.Size = new System.Drawing.Size(50, 20);
                    newLabel.Text = "Fe" + textBoxCount.ToString();
                }

                // Agregar el TextBox al Panel
                Periodos_Panel.Controls.Add(newTextBox);
                Periodos_Panel.Controls.Add(newLabel);

                // Incrementar el contador
                textBoxCount++;
                counter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }*/

        }
    }
}
