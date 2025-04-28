namespace A10B
{
    partial class FormUlov
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPecaros = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonIzadji = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pecaroš";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Od datuma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Do datuma";
            // 
            // comboBoxPecaros
            // 
            this.comboBoxPecaros.FormattingEnabled = true;
            this.comboBoxPecaros.Location = new System.Drawing.Point(159, 38);
            this.comboBoxPecaros.Name = "comboBoxPecaros";
            this.comboBoxPecaros.Size = new System.Drawing.Size(185, 24);
            this.comboBoxPecaros.TabIndex = 3;
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOd.Location = new System.Drawing.Point(159, 77);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.Size = new System.Drawing.Size(141, 22);
            this.dateTimePickerOd.TabIndex = 4;
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDo.Location = new System.Drawing.Point(159, 116);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.Size = new System.Drawing.Size(141, 22);
            this.dateTimePickerDo.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(333, 249);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikazi.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPrikazi.Location = new System.Drawing.Point(474, 38);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(118, 46);
            this.buttonPrikazi.TabIndex = 7;
            this.buttonPrikazi.Text = "Prikaži";
            this.buttonPrikazi.UseVisualStyleBackColor = false;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzadji.ForeColor = System.Drawing.Color.Transparent;
            this.buttonIzadji.Location = new System.Drawing.Point(613, 38);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Size = new System.Drawing.Size(118, 46);
            this.buttonIzadji.TabIndex = 8;
            this.buttonIzadji.Text = "Izađi";
            this.buttonIzadji.UseVisualStyleBackColor = false;
            this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(411, 122);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(368, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // FormUlov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonIzadji);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerDo);
            this.Controls.Add(this.dateTimePickerOd);
            this.Controls.Add(this.comboBoxPecaros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUlov";
            this.Text = "FormUlov";
            this.Load += new System.EventHandler(this.FormUlov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPecaros;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonIzadji;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}