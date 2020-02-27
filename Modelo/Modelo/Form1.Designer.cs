namespace Modelo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "1,0");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "2,0");
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txbIterations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxPlay = new System.Windows.Forms.PictureBox();
            this.pboxAdd = new System.Windows.Forms.PictureBox();
            this.pboxNext = new System.Windows.Forms.PictureBox();
            this.pboxPrevious = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pboxPlay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbIterations);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.pboxAdd);
            this.panel1.Controls.Add(this.pboxNext);
            this.panel1.Controls.Add(this.pboxPrevious);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 636);
            this.panel1.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(63, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 31);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "0/0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 636);
            this.panel2.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Interval = 0.5D;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.Maximum = 4D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 0.1D;
            chartArea1.AxisX.MinorGrid.IntervalOffset = double.NaN;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX2.Interval = 1D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.Interval = 0.5D;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Interval = 1D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Maximum = 4D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 0.1D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Gray;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelAngle = 90;
            series1.LabelBackColor = System.Drawing.Color.DimGray;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Serie";
            series1.Points.Add(dataPoint1);
            series1.XValueMember = "10";
            series1.YValueMembers = "10";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint2);
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(917, 636);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // txbIterations
            // 
            this.txbIterations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIterations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.txbIterations.ForeColor = System.Drawing.SystemColors.Window;
            this.txbIterations.Location = new System.Drawing.Point(31, 171);
            this.txbIterations.Name = "txbIterations";
            this.txbIterations.Size = new System.Drawing.Size(124, 31);
            this.txbIterations.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Iterar";
            // 
            // pboxPlay
            // 
            this.pboxPlay.Image = global::Modelo.Properties.Resources.boton_de_play;
            this.pboxPlay.Location = new System.Drawing.Point(68, 208);
            this.pboxPlay.Name = "pboxPlay";
            this.pboxPlay.Size = new System.Drawing.Size(50, 50);
            this.pboxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxPlay.TabIndex = 9;
            this.pboxPlay.TabStop = false;
            this.pboxPlay.Click += new System.EventHandler(this.pboxPlay_Click);
            // 
            // pboxAdd
            // 
            this.pboxAdd.Image = global::Modelo.Properties.Resources.mas;
            this.pboxAdd.Location = new System.Drawing.Point(68, 12);
            this.pboxAdd.Name = "pboxAdd";
            this.pboxAdd.Size = new System.Drawing.Size(50, 50);
            this.pboxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxAdd.TabIndex = 4;
            this.pboxAdd.TabStop = false;
            this.pboxAdd.Click += new System.EventHandler(this.pboxAdd_Click);
            this.pboxAdd.DoubleClick += new System.EventHandler(this.pboxAdd_Click);
            // 
            // pboxNext
            // 
            this.pboxNext.Image = global::Modelo.Properties.Resources.proximo;
            this.pboxNext.Location = new System.Drawing.Point(124, 12);
            this.pboxNext.Name = "pboxNext";
            this.pboxNext.Size = new System.Drawing.Size(50, 50);
            this.pboxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxNext.TabIndex = 3;
            this.pboxNext.TabStop = false;
            this.pboxNext.Click += new System.EventHandler(this.pboxNext_Click);
            this.pboxNext.DoubleClick += new System.EventHandler(this.pboxNext_Click);
            // 
            // pboxPrevious
            // 
            this.pboxPrevious.Image = global::Modelo.Properties.Resources.anterior;
            this.pboxPrevious.Location = new System.Drawing.Point(12, 12);
            this.pboxPrevious.Name = "pboxPrevious";
            this.pboxPrevious.Size = new System.Drawing.Size(50, 50);
            this.pboxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxPrevious.TabIndex = 2;
            this.pboxPrevious.TabStop = false;
            this.pboxPrevious.Click += new System.EventHandler(this.pboxPrevious_Click);
            this.pboxPrevious.DoubleClick += new System.EventHandler(this.pboxPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1101, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboxNext;
        private System.Windows.Forms.PictureBox pboxPrevious;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pboxAdd;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pboxPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIterations;
    }
}

