namespace A10B
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIzmena = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnaliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOAplikaciji = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIzlaz = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.comboBoxGrad = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIzmena,
            this.toolStripButtonAnaliza,
            this.toolStripButtonOAplikaciji,
            this.toolStripButtonIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonIzmena
            // 
            this.toolStripButtonIzmena.Image = global::A10B.Properties.Resources.update;
            this.toolStripButtonIzmena.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzmena.Name = "toolStripButtonIzmena";
            this.toolStripButtonIzmena.Size = new System.Drawing.Size(61, 74);
            this.toolStripButtonIzmena.Text = "Izmena";
            this.toolStripButtonIzmena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIzmena.Click += new System.EventHandler(this.toolStripButtonIzmena_Click);
            // 
            // toolStripButtonAnaliza
            // 
            this.toolStripButtonAnaliza.Image = global::A10B.Properties.Resources.charts;
            this.toolStripButtonAnaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnaliza.Name = "toolStripButtonAnaliza";
            this.toolStripButtonAnaliza.Size = new System.Drawing.Size(62, 74);
            this.toolStripButtonAnaliza.Text = "Analiza";
            this.toolStripButtonAnaliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAnaliza.Click += new System.EventHandler(this.toolStripButtonAnaliza_Click);
            // 
            // toolStripButtonOAplikaciji
            // 
            this.toolStripButtonOAplikaciji.Image = global::A10B.Properties.Resources.info_icon;
            this.toolStripButtonOAplikaciji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOAplikaciji.Name = "toolStripButtonOAplikaciji";
            this.toolStripButtonOAplikaciji.Size = new System.Drawing.Size(87, 74);
            this.toolStripButtonOAplikaciji.Text = "O aplikaciji";
            this.toolStripButtonOAplikaciji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOAplikaciji.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButtonIzlaz
            // 
            this.toolStripButtonIzlaz.Image = global::A10B.Properties.Resources.exit;
            this.toolStripButtonIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzlaz.Name = "toolStripButtonIzlaz";
            this.toolStripButtonIzlaz.Size = new System.Drawing.Size(54, 74);
            this.toolStripButtonIzlaz.Text = "Izlaz";
            this.toolStripButtonIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIzlaz.Click += new System.EventHandler(this.toolStripButtonIzlaz_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(264, 106);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(635, 276);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Šifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(827, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Grad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Adresa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Prezime";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ime";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Šifra";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(56, 80);
            this.textBoxSifra.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.ReadOnly = true;
            this.textBoxSifra.Size = new System.Drawing.Size(76, 20);
            this.textBoxSifra.TabIndex = 14;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(56, 103);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(115, 20);
            this.textBoxIme.TabIndex = 15;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(56, 126);
            this.textBoxPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(115, 20);
            this.textBoxPrezime.TabIndex = 16;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(56, 149);
            this.textBoxAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(115, 20);
            this.textBoxAdresa.TabIndex = 17;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(56, 197);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(115, 20);
            this.textBoxTelefon.TabIndex = 18;
            // 
            // comboBoxGrad
            // 
            this.comboBoxGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrad.FormattingEnabled = true;
            this.comboBoxGrad.Location = new System.Drawing.Point(56, 171);
            this.comboBoxGrad.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGrad.Name = "comboBoxGrad";
            this.comboBoxGrad.Size = new System.Drawing.Size(115, 21);
            this.comboBoxGrad.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 437);
            this.Controls.Add(this.comboBoxGrad);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzmena;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnaliza;
        private System.Windows.Forms.ToolStripButton toolStripButtonOAplikaciji;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzlaz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.ComboBox comboBoxGrad;
    }
}

