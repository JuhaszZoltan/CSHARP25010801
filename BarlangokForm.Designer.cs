namespace CSHARP25010801
{
    partial class BarlangokForm
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
            lblUI01 = new Label();
            tbMelyseg = new TextBox();
            btnKereses = new Button();
            lblUI02 = new Label();
            lblUI03 = new Label();
            lblUI04 = new Label();
            btnMentes = new Button();
            tbHosszusag = new TextBox();
            tbAzonosito = new TextBox();
            lblBarlangNeve = new Label();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(24, 49);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(100, 25);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Azonosító:";
            // 
            // tbMelyseg
            // 
            tbMelyseg.Location = new Point(168, 253);
            tbMelyseg.Name = "tbMelyseg";
            tbMelyseg.Size = new Size(135, 32);
            tbMelyseg.TabIndex = 1;
            // 
            // btnKereses
            // 
            btnKereses.Location = new Point(349, 37);
            btnKereses.Name = "btnKereses";
            btnKereses.Size = new Size(181, 49);
            btnKereses.TabIndex = 2;
            btnKereses.Text = "Barlang keresése";
            btnKereses.UseVisualStyleBackColor = true;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(24, 118);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(126, 25);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Barlang neve:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(24, 187);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(105, 25);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "Hosszúság:";
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(24, 256);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(86, 25);
            lblUI04.TabIndex = 0;
            lblUI04.Text = "Mélység:";
            // 
            // btnMentes
            // 
            btnMentes.Enabled = false;
            btnMentes.Location = new Point(349, 175);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(181, 49);
            btnMentes.TabIndex = 2;
            btnMentes.Text = "Adatok mentése";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // tbHosszusag
            // 
            tbHosszusag.Location = new Point(168, 184);
            tbHosszusag.Name = "tbHosszusag";
            tbHosszusag.Size = new Size(135, 32);
            tbHosszusag.TabIndex = 1;
            // 
            // tbAzonosito
            // 
            tbAzonosito.Location = new Point(168, 46);
            tbAzonosito.Name = "tbAzonosito";
            tbAzonosito.Size = new Size(135, 32);
            tbAzonosito.TabIndex = 1;
            // 
            // lblBarlangNeve
            // 
            lblBarlangNeve.AutoSize = true;
            lblBarlangNeve.Location = new Point(168, 118);
            lblBarlangNeve.Name = "lblBarlangNeve";
            lblBarlangNeve.Size = new Size(89, 25);
            lblBarlangNeve.TabIndex = 0;
            lblBarlangNeve.Text = "#######";
            // 
            // BarlangokForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 348);
            Controls.Add(btnMentes);
            Controls.Add(btnKereses);
            Controls.Add(tbAzonosito);
            Controls.Add(tbHosszusag);
            Controls.Add(tbMelyseg);
            Controls.Add(lblUI04);
            Controls.Add(lblUI03);
            Controls.Add(lblBarlangNeve);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "BarlangokForm";
            Text = "Barlangok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbMelyseg;
        private Button btnKereses;
        private Label lblUI02;
        private Label lblUI03;
        private Label lblUI04;
        private Button btnMentes;
        private TextBox tbHosszusag;
        private TextBox tbAzonosito;
        private Label lblBarlangNeve;
    }
}
