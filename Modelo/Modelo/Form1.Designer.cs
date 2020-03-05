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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "1,0");
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "2,0");
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboxPlay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIterations = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pboxAdd = new System.Windows.Forms.PictureBox();
            this.pboxNext = new System.Windows.Forms.PictureBox();
            this.pboxPrevious = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 636);
            this.panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisX.Interval = 0.5D;
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisX.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MajorGrid.Interval = 1D;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.Maximum = 4D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisX.MinorGrid.Enabled = true;
            chartArea5.AxisX.MinorGrid.Interval = 0.1D;
            chartArea5.AxisX.MinorGrid.IntervalOffset = double.NaN;
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea5.AxisX2.Interval = 1D;
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisY.Interval = 0.5D;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MajorGrid.Interval = 1D;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.Maximum = 4D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.AxisY.MinorGrid.Enabled = true;
            chartArea5.AxisY.MinorGrid.Interval = 0.1D;
            chartArea5.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea5.BackColor = System.Drawing.Color.DimGray;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.BackColor = System.Drawing.Color.Gray;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.LabelAngle = 90;
            series9.LabelBackColor = System.Drawing.Color.DimGray;
            series9.LabelForeColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "Serie";
            series9.Points.Add(dataPoint9);
            series9.XValueMember = "10";
            series9.YValueMembers = "10";
            series9.YValuesPerPoint = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Legend = "Legend1";
            series10.Name = "Series2";
            series10.Points.Add(dataPoint10);
            series10.YValuesPerPoint = 2;
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(903, 604);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TL,
            this.PM,
            this.QM,
            this.SM,
            this.DS,
            this.IM,
            this.TM});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(903, 604);
            this.dataGridView1.TabIndex = 0;
            // 
            // TL
            // 
            this.TL.HeaderText = "TL";
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            // 
            // PM
            // 
            this.PM.HeaderText = "PM";
            this.PM.Name = "PM";
            this.PM.ReadOnly = true;
            // 
            // QM
            // 
            this.QM.HeaderText = "QM";
            this.QM.Name = "QM";
            this.QM.ReadOnly = true;
            // 
            // SM
            // 
            this.SM.HeaderText = "SM";
            this.SM.Name = "SM";
            this.SM.ReadOnly = true;
            // 
            // DS
            // 
            this.DS.HeaderText = "DS";
            this.DS.Name = "DS";
            this.DS.ReadOnly = true;
            // 
            // IM
            // 
            this.IM.HeaderText = "IM";
            this.IM.Name = "IM";
            this.IM.ReadOnly = true;
            // 
            // TM
            // 
            this.TM.HeaderText = "TM";
            this.TM.Name = "TM";
            this.TM.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboxNext;
        private System.Windows.Forms.PictureBox pboxPrevious;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pboxAdd;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pboxPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIterations;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TM;
    }
}

