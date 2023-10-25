namespace Ingenieria_Economica
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.informacion_Label = new System.Windows.Forms.Label();
            this.vpn_Btn = new System.Windows.Forms.Button();
            this.vae_Btn = new System.Windows.Forms.Button();
            this.pri_Btn = new System.Windows.Forms.Button();
            this.tir_Btn = new System.Windows.Forms.Button();
            this.salir_Btn = new System.Windows.Forms.Button();
            this.inf_Label = new System.Windows.Forms.Label();
            this.formula_Pic = new System.Windows.Forms.PictureBox();
            this.donde_Label = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Ingenieria_Economica.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.calcular_Btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formula_Pic)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.informacion_Label);
            this.flowLayoutPanel1.Controls.Add(this.vpn_Btn);
            this.flowLayoutPanel1.Controls.Add(this.vae_Btn);
            this.flowLayoutPanel1.Controls.Add(this.pri_Btn);
            this.flowLayoutPanel1.Controls.Add(this.tir_Btn);
            this.flowLayoutPanel1.Controls.Add(this.salir_Btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 483);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // informacion_Label
            // 
            this.informacion_Label.AutoSize = true;
            this.informacion_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informacion_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacion_Label.Location = new System.Drawing.Point(3, 0);
            this.informacion_Label.Name = "informacion_Label";
            this.informacion_Label.Size = new System.Drawing.Size(164, 48);
            this.informacion_Label.TabIndex = 1;
            this.informacion_Label.Text = "Información Sobre Los Metodos";
            this.informacion_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vpn_Btn
            // 
            this.vpn_Btn.FlatAppearance.BorderSize = 0;
            this.vpn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vpn_Btn.Location = new System.Drawing.Point(3, 51);
            this.vpn_Btn.Name = "vpn_Btn";
            this.vpn_Btn.Size = new System.Drawing.Size(197, 71);
            this.vpn_Btn.TabIndex = 3;
            this.vpn_Btn.Text = "Valor Presente Neto (V.P.N)";
            this.vpn_Btn.UseVisualStyleBackColor = true;
            this.vpn_Btn.Click += new System.EventHandler(this.vpn_Btn_Click);
            // 
            // vae_Btn
            // 
            this.vae_Btn.FlatAppearance.BorderSize = 0;
            this.vae_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vae_Btn.Location = new System.Drawing.Point(3, 128);
            this.vae_Btn.Name = "vae_Btn";
            this.vae_Btn.Size = new System.Drawing.Size(197, 71);
            this.vae_Btn.TabIndex = 0;
            this.vae_Btn.Text = "Valor Actual Equivalente (V.A.E)";
            this.vae_Btn.UseVisualStyleBackColor = true;
            this.vae_Btn.Click += new System.EventHandler(this.vae_Btn_Click);
            // 
            // pri_Btn
            // 
            this.pri_Btn.FlatAppearance.BorderSize = 0;
            this.pri_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pri_Btn.Location = new System.Drawing.Point(3, 205);
            this.pri_Btn.Name = "pri_Btn";
            this.pri_Btn.Size = new System.Drawing.Size(197, 74);
            this.pri_Btn.TabIndex = 0;
            this.pri_Btn.Text = "Periodo Recuperacion de la Inversion(P.R.I)";
            this.pri_Btn.UseVisualStyleBackColor = true;
            this.pri_Btn.Click += new System.EventHandler(this.pri_Btn_Click);
            // 
            // tir_Btn
            // 
            this.tir_Btn.FlatAppearance.BorderSize = 0;
            this.tir_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tir_Btn.Location = new System.Drawing.Point(3, 285);
            this.tir_Btn.Name = "tir_Btn";
            this.tir_Btn.Size = new System.Drawing.Size(197, 74);
            this.tir_Btn.TabIndex = 0;
            this.tir_Btn.Text = "Tasa Interna De Rendimiento (T.I.R)";
            this.tir_Btn.UseVisualStyleBackColor = true;
            this.tir_Btn.Click += new System.EventHandler(this.tir_Btn_Click);
            // 
            // salir_Btn
            // 
            this.salir_Btn.FlatAppearance.BorderSize = 0;
            this.salir_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_Btn.Location = new System.Drawing.Point(3, 365);
            this.salir_Btn.Name = "salir_Btn";
            this.salir_Btn.Size = new System.Drawing.Size(197, 79);
            this.salir_Btn.TabIndex = 0;
            this.salir_Btn.Text = "Salir";
            this.salir_Btn.UseVisualStyleBackColor = true;
            this.salir_Btn.Click += new System.EventHandler(this.salir_Btn_Click);
            // 
            // inf_Label
            // 
            this.inf_Label.AutoSize = true;
            this.inf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inf_Label.Location = new System.Drawing.Point(206, 51);
            this.inf_Label.Name = "inf_Label";
            this.inf_Label.Size = new System.Drawing.Size(129, 20);
            this.inf_Label.TabIndex = 1;
            this.inf_Label.Text = "Elige una Opción";
            // 
            // formula_Pic
            // 
            this.formula_Pic.Image = ((System.Drawing.Image)(resources.GetObject("formula_Pic.Image")));
            this.formula_Pic.Location = new System.Drawing.Point(210, 159);
            this.formula_Pic.Name = "formula_Pic";
            this.formula_Pic.Size = new System.Drawing.Size(197, 120);
            this.formula_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formula_Pic.TabIndex = 2;
            this.formula_Pic.TabStop = false;
            this.formula_Pic.WaitOnLoad = true;
            this.formula_Pic.Click += new System.EventHandler(this.formula_Pic_Click);
            // 
            // donde_Label
            // 
            this.donde_Label.AutoSize = true;
            this.donde_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donde_Label.Location = new System.Drawing.Point(210, 282);
            this.donde_Label.Name = "donde_Label";
            this.donde_Label.Size = new System.Drawing.Size(0, 20);
            this.donde_Label.TabIndex = 3;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 50F;
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Red;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(200, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(661, 48);
            this.gradientPanel1.TabIndex = 4;
            this.gradientPanel1.TopColor = System.Drawing.Color.Blue;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGENIERIA ECONOMICA";
            // 
            // calcular_Btn
            // 
            this.calcular_Btn.Location = new System.Drawing.Point(724, 401);
            this.calcular_Btn.Name = "calcular_Btn";
            this.calcular_Btn.Size = new System.Drawing.Size(125, 42);
            this.calcular_Btn.TabIndex = 5;
            this.calcular_Btn.Text = "Calcular";
            this.calcular_Btn.UseVisualStyleBackColor = true;
            this.calcular_Btn.Click += new System.EventHandler(this.calcular_Btn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 483);
            this.Controls.Add(this.calcular_Btn);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.donde_Label);
            this.Controls.Add(this.formula_Pic);
            this.Controls.Add(this.inf_Label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formula_Pic)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button vae_Btn;
        private System.Windows.Forms.Button pri_Btn;
        private System.Windows.Forms.Button tir_Btn;
        private System.Windows.Forms.Label informacion_Label;
        private System.Windows.Forms.Button salir_Btn;
        private System.Windows.Forms.Label inf_Label;
        private System.Windows.Forms.Button vpn_Btn;
        private System.Windows.Forms.PictureBox formula_Pic;
        private System.Windows.Forms.Label donde_Label;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private int Opcion;
        private System.Windows.Forms.Button calcular_Btn;
    }
}