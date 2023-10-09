namespace Ingenieria_Economica
{
    partial class VpnDiseño
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Inversion_Inicial_Text = new System.Windows.Forms.TextBox();
            this.Periodos_Panel = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Ingenieria_Economica.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero_Periodos_Text = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(156, 456);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 104);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(3, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 104);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fijar Periodos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 104);
            this.button4.TabIndex = 3;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero De Periodos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "II = $";
            // 
            // Inversion_Inicial_Text
            // 
            this.Inversion_Inicial_Text.Location = new System.Drawing.Point(317, 86);
            this.Inversion_Inicial_Text.Name = "Inversion_Inicial_Text";
            this.Inversion_Inicial_Text.Size = new System.Drawing.Size(100, 20);
            this.Inversion_Inicial_Text.TabIndex = 5;
            this.Inversion_Inicial_Text.TextChanged += new System.EventHandler(this.Inversion_Inicial_Text_TextChanged);
            // 
            // Periodos_Panel
            // 
            this.Periodos_Panel.Location = new System.Drawing.Point(167, 121);
            this.Periodos_Panel.Name = "Periodos_Panel";
            this.Periodos_Panel.Size = new System.Drawing.Size(183, 316);
            this.Periodos_Panel.TabIndex = 6;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Violet;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(156, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(644, 56);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.TopColor = System.Drawing.Color.Red;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VALOR PRESENTE NETO(VPN)";
            // 
            // Numero_Periodos_Text
            // 
            this.Numero_Periodos_Text.Location = new System.Drawing.Point(167, 87);
            this.Numero_Periodos_Text.Name = "Numero_Periodos_Text";
            this.Numero_Periodos_Text.Size = new System.Drawing.Size(100, 20);
            this.Numero_Periodos_Text.TabIndex = 2;
            // 
            // VpnDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.Periodos_Panel);
            this.Controls.Add(this.Inversion_Inicial_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero_Periodos_Text);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "VpnDiseño";
            this.Text = "VpnDiseño";
            this.Load += new System.EventHandler(this.VpnDiseño_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Inversion_Inicial_Text;
        private System.Windows.Forms.Panel Periodos_Panel;
        private System.Windows.Forms.TextBox Numero_Periodos_Text;
    }
}