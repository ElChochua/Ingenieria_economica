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
            this.Calcular_Btn = new System.Windows.Forms.Button();
            this.Limpiar_Btn = new System.Windows.Forms.Button();
            this.Fijar_Periodos_Btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Inversion_Inicial_Text = new System.Windows.Forms.TextBox();
            this.Numero_Periodos_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Interes_Text = new System.Windows.Forms.TextBox();
            this.Contenedor_Periodos = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.Resultado_Label = new System.Windows.Forms.Label();
            this.Decimales_Boton = new System.Windows.Forms.RadioButton();
            this.Millares_Boton = new System.Windows.Forms.RadioButton();
            this.gradientPanel1 = new Ingenieria_Economica.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Calcular_Btn);
            this.flowLayoutPanel1.Controls.Add(this.Limpiar_Btn);
            this.flowLayoutPanel1.Controls.Add(this.Fijar_Periodos_Btn);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(156, 456);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Calcular_Btn
            // 
            this.Calcular_Btn.FlatAppearance.BorderSize = 0;
            this.Calcular_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calcular_Btn.Location = new System.Drawing.Point(3, 3);
            this.Calcular_Btn.Name = "Calcular_Btn";
            this.Calcular_Btn.Size = new System.Drawing.Size(153, 104);
            this.Calcular_Btn.TabIndex = 0;
            this.Calcular_Btn.Text = "Calcular";
            this.Calcular_Btn.UseVisualStyleBackColor = true;
            this.Calcular_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Limpiar_Btn
            // 
            this.Limpiar_Btn.FlatAppearance.BorderSize = 0;
            this.Limpiar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar_Btn.Location = new System.Drawing.Point(3, 113);
            this.Limpiar_Btn.Name = "Limpiar_Btn";
            this.Limpiar_Btn.Size = new System.Drawing.Size(153, 104);
            this.Limpiar_Btn.TabIndex = 1;
            this.Limpiar_Btn.Text = "Limpiar";
            this.Limpiar_Btn.UseVisualStyleBackColor = true;
            this.Limpiar_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fijar_Periodos_Btn
            // 
            this.Fijar_Periodos_Btn.FlatAppearance.BorderSize = 0;
            this.Fijar_Periodos_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fijar_Periodos_Btn.Location = new System.Drawing.Point(3, 223);
            this.Fijar_Periodos_Btn.Name = "Fijar_Periodos_Btn";
            this.Fijar_Periodos_Btn.Size = new System.Drawing.Size(153, 104);
            this.Fijar_Periodos_Btn.TabIndex = 2;
            this.Fijar_Periodos_Btn.Text = "Fijar Periodos";
            this.Fijar_Periodos_Btn.UseVisualStyleBackColor = true;
            this.Fijar_Periodos_Btn.Click += new System.EventHandler(this.button3_Click);
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero De Periodos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "II = $";
            // 
            // Inversion_Inicial_Text
            // 
            this.Inversion_Inicial_Text.Location = new System.Drawing.Point(597, 113);
            this.Inversion_Inicial_Text.Name = "Inversion_Inicial_Text";
            this.Inversion_Inicial_Text.Size = new System.Drawing.Size(100, 20);
            this.Inversion_Inicial_Text.TabIndex = 5;
            this.Inversion_Inicial_Text.TextChanged += new System.EventHandler(this.Inversion_Inicial_Text_TextChanged);
            // 
            // Numero_Periodos_Text
            // 
            this.Numero_Periodos_Text.Location = new System.Drawing.Point(553, 87);
            this.Numero_Periodos_Text.Name = "Numero_Periodos_Text";
            this.Numero_Periodos_Text.Size = new System.Drawing.Size(100, 20);
            this.Numero_Periodos_Text.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(549, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "i = %";
            // 
            // Interes_Text
            // 
            this.Interes_Text.Location = new System.Drawing.Point(594, 143);
            this.Interes_Text.Name = "Interes_Text";
            this.Interes_Text.Size = new System.Drawing.Size(100, 20);
            this.Interes_Text.TabIndex = 8;
            // 
            // Contenedor_Periodos
            // 
            this.Contenedor_Periodos.Dock = System.Windows.Forms.DockStyle.Left;
            this.Contenedor_Periodos.Location = new System.Drawing.Point(156, 56);
            this.Contenedor_Periodos.Name = "Contenedor_Periodos";
            this.Contenedor_Periodos.Size = new System.Drawing.Size(387, 400);
            this.Contenedor_Periodos.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(557, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Picale w";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Resultado_Label
            // 
            this.Resultado_Label.AutoSize = true;
            this.Resultado_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Resultado_Label.Location = new System.Drawing.Point(550, 224);
            this.Resultado_Label.Name = "Resultado_Label";
            this.Resultado_Label.Size = new System.Drawing.Size(99, 24);
            this.Resultado_Label.TabIndex = 11;
            this.Resultado_Label.Text = "Resultado:";
            // 
            // Decimales_Boton
            // 
            this.Decimales_Boton.AutoSize = true;
            this.Decimales_Boton.Location = new System.Drawing.Point(550, 270);
            this.Decimales_Boton.Name = "Decimales_Boton";
            this.Decimales_Boton.Size = new System.Drawing.Size(161, 17);
            this.Decimales_Boton.TabIndex = 12;
            this.Decimales_Boton.TabStop = true;
            this.Decimales_Boton.Text = "Decimales(Mayor o igual 1M)";
            this.Decimales_Boton.UseVisualStyleBackColor = true;
            // 
            // Millares_Boton
            // 
            this.Millares_Boton.AutoSize = true;
            this.Millares_Boton.Location = new System.Drawing.Point(550, 294);
            this.Millares_Boton.Name = "Millares_Boton";
            this.Millares_Boton.Size = new System.Drawing.Size(106, 17);
            this.Millares_Boton.TabIndex = 13;
            this.Millares_Boton.TabStop = true;
            this.Millares_Boton.Text = "Numeros Enteros";
            this.Millares_Boton.UseVisualStyleBackColor = true;
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
            // VpnDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.Millares_Boton);
            this.Controls.Add(this.Decimales_Boton);
            this.Controls.Add(this.Resultado_Label);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Contenedor_Periodos);
            this.Controls.Add(this.Interes_Text);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Button Calcular_Btn;
        private System.Windows.Forms.Button Limpiar_Btn;
        private System.Windows.Forms.Button Fijar_Periodos_Btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Inversion_Inicial_Text;
        private System.Windows.Forms.TextBox Numero_Periodos_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Interes_Text;
        private System.Windows.Forms.FlowLayoutPanel Contenedor_Periodos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Resultado_Label;
        private System.Windows.Forms.RadioButton Decimales_Boton;
        private System.Windows.Forms.RadioButton Millares_Boton;
    }
}