
namespace P_Triangulo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.btnDescobrir = new System.Windows.Forms.Button();
            this.BTNlIMPAR = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(9, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(459, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VAMOS DESCOBRIR QUAL É O TIPO DO SEU TRIÂNGULO?";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLadoA.Location = new System.Drawing.Point(177, 41);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(50, 15);
            this.lblLadoA.TabIndex = 1;
            this.lblLadoA.Text = "LADO A";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLadoB.Location = new System.Drawing.Point(174, 69);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(50, 15);
            this.lblLadoB.TabIndex = 2;
            this.lblLadoB.Text = "LADO B";
            this.lblLadoB.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLadoC.Location = new System.Drawing.Point(174, 96);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(49, 15);
            this.lblLadoC.TabIndex = 3;
            this.lblLadoC.Text = "LADO C";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(233, 33);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(52, 23);
            this.txtLadoA.TabIndex = 4;
            this.txtLadoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLadoA.TextChanged += new System.EventHandler(this.txtLadoA_TextChanged);
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(233, 61);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(52, 23);
            this.txtLadoB.TabIndex = 5;
            this.txtLadoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(233, 88);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(52, 23);
            this.txtLadoC.TabIndex = 6;
            this.txtLadoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDescobrir
            // 
            this.btnDescobrir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDescobrir.Location = new System.Drawing.Point(337, 60);
            this.btnDescobrir.Name = "btnDescobrir";
            this.btnDescobrir.Size = new System.Drawing.Size(82, 23);
            this.btnDescobrir.TabIndex = 7;
            this.btnDescobrir.Text = "DESCOBRIR";
            this.btnDescobrir.UseVisualStyleBackColor = true;
            this.btnDescobrir.Click += new System.EventHandler(this.btnDescobrir_Click);
            // 
            // BTNlIMPAR
            // 
            this.BTNlIMPAR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNlIMPAR.Location = new System.Drawing.Point(111, 126);
            this.BTNlIMPAR.Name = "BTNlIMPAR";
            this.BTNlIMPAR.Size = new System.Drawing.Size(82, 23);
            this.BTNlIMPAR.TabIndex = 8;
            this.BTNlIMPAR.Text = "LIMPAR";
            this.BTNlIMPAR.UseVisualStyleBackColor = true;
            this.BTNlIMPAR.Click += new System.EventHandler(this.BTNlIMPAR_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(268, 126);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(82, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 233);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.BTNlIMPAR);
            this.Controls.Add(this.btnDescobrir);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "TRIÂNGULOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Button btnDescobrir;
        private System.Windows.Forms.Button BTNlIMPAR;
        private System.Windows.Forms.Button btnFechar;
    }
}

