namespace Ingenieria_Economica
{
    partial class PeriodoDeRecuperacionInversion
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
            this.Salir_Btn = new System.Windows.Forms.Button();
            this.gradientPanel1 = new Ingenieria_Economica.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero_Periodos_Text = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Calcular_Btn);
            this.flowLayoutPanel1.Controls.Add(this.Limpiar_Btn);
            this.flowLayoutPanel1.Controls.Add(this.Fijar_Periodos_Btn);
            this.flowLayoutPanel1.Controls.Add(this.Salir_Btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Calcular_Btn
            // 
            this.Calcular_Btn.Location = new System.Drawing.Point(3, 3);
            this.Calcular_Btn.Name = "Calcular_Btn";
            this.Calcular_Btn.Size = new System.Drawing.Size(197, 99);
            this.Calcular_Btn.TabIndex = 3;
            this.Calcular_Btn.Text = "Calcular";
            this.Calcular_Btn.UseVisualStyleBackColor = true;
            // 
            // Limpiar_Btn
            // 
            this.Limpiar_Btn.Location = new System.Drawing.Point(3, 108);
            this.Limpiar_Btn.Name = "Limpiar_Btn";
            this.Limpiar_Btn.Size = new System.Drawing.Size(197, 110);
            this.Limpiar_Btn.TabIndex = 0;
            this.Limpiar_Btn.Text = "Limpiar";
            this.Limpiar_Btn.UseVisualStyleBackColor = true;
            // 
            // Fijar_Periodos_Btn
            // 
            this.Fijar_Periodos_Btn.Location = new System.Drawing.Point(3, 224);
            this.Fijar_Periodos_Btn.Name = "Fijar_Periodos_Btn";
            this.Fijar_Periodos_Btn.Size = new System.Drawing.Size(197, 110);
            this.Fijar_Periodos_Btn.TabIndex = 1;
            this.Fijar_Periodos_Btn.Text = "Fijar Periodos";
            this.Fijar_Periodos_Btn.UseVisualStyleBackColor = true;
            // 
            // Salir_Btn
            // 
            this.Salir_Btn.Location = new System.Drawing.Point(3, 340);
            this.Salir_Btn.Name = "Salir_Btn";
            this.Salir_Btn.Size = new System.Drawing.Size(197, 110);
            this.Salir_Btn.TabIndex = 2;
            this.Salir_Btn.Text = "Salir";
            this.Salir_Btn.UseVisualStyleBackColor = true;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.SpringGreen;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(200, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(600, 61);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.Color.DarkMagenta;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo de recuperacion De La Inversion(PRI)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero Periodos";
            // 
            // Numero_Periodos_Text
            // 
            this.Numero_Periodos_Text.Location = new System.Drawing.Point(211, 95);
            this.Numero_Periodos_Text.Name = "Numero_Periodos_Text";
            this.Numero_Periodos_Text.Size = new System.Drawing.Size(159, 20);
            this.Numero_Periodos_Text.TabIndex = 4;
            // 
            // PeriodoDeRecuperacionInversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero_Periodos_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PeriodoDeRecuperacionInversion";
            this.Text = "PeriodoDeRecuperacionInversion";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button Calcular_Btn;
        private System.Windows.Forms.Button Limpiar_Btn;
        private System.Windows.Forms.Button Fijar_Periodos_Btn;
        private System.Windows.Forms.Button Salir_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero_Periodos_Text;
    }
}