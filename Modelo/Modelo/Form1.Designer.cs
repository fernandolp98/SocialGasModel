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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "1,0");
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "2,0");
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbRatio = new System.Windows.Forms.TextBox();
            this.txbEpsilon = new System.Windows.Forms.TextBox();
            this.txbR = new System.Windows.Forms.TextBox();
            this.txbGamma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIterations = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pboxAdd = new System.Windows.Forms.PictureBox();
            this.pboxNext = new System.Windows.Forms.PictureBox();
            this.pboxPrevious = new System.Windows.Forms.PictureBox();
            this.pboxPlay = new System.Windows.Forms.PictureBox();
            this.pboxStop = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStop)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbIterations);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.pboxAdd);
            this.panel1.Controls.Add(this.pboxNext);
            this.panel1.Controls.Add(this.pboxPrevious);
            this.panel1.Controls.Add(this.pboxPlay);
            this.panel1.Controls.Add(this.pboxStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 636);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbRatio);
            this.groupBox1.Controls.Add(this.txbEpsilon);
            this.groupBox1.Controls.Add(this.txbR);
            this.groupBox1.Controls.Add(this.txbGamma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 160);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // txbRatio
            // 
            this.txbRatio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRatio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRatio.ForeColor = System.Drawing.SystemColors.Window;
            this.txbRatio.Location = new System.Drawing.Point(98, 26);
            this.txbRatio.Name = "txbRatio";
            this.txbRatio.Size = new System.Drawing.Size(62, 22);
            this.txbRatio.TabIndex = 23;
            this.txbRatio.Text = "4";
            this.txbRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbRatio.Validated += new System.EventHandler(this.txbRatio_Validated);
            // 
            // txbEpsilon
            // 
            this.txbEpsilon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbEpsilon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEpsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEpsilon.ForeColor = System.Drawing.SystemColors.Window;
            this.txbEpsilon.Location = new System.Drawing.Point(98, 84);
            this.txbEpsilon.Name = "txbEpsilon";
            this.txbEpsilon.Size = new System.Drawing.Size(62, 22);
            this.txbEpsilon.TabIndex = 22;
            this.txbEpsilon.Text = ".2";
            this.txbEpsilon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbEpsilon.Validated += new System.EventHandler(this.txbEpsilon_Validated);
            // 
            // txbR
            // 
            this.txbR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbR.ForeColor = System.Drawing.SystemColors.Window;
            this.txbR.Location = new System.Drawing.Point(98, 113);
            this.txbR.Name = "txbR";
            this.txbR.Size = new System.Drawing.Size(62, 22);
            this.txbR.TabIndex = 21;
            this.txbR.Text = "3";
            this.txbR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbR.Validated += new System.EventHandler(this.txbR_Validated);
            // 
            // txbGamma
            // 
            this.txbGamma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbGamma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGamma.ForeColor = System.Drawing.SystemColors.Window;
            this.txbGamma.Location = new System.Drawing.Point(98, 55);
            this.txbGamma.Name = "txbGamma";
            this.txbGamma.Size = new System.Drawing.Size(62, 22);
            this.txbGamma.TabIndex = 20;
            this.txbGamma.Text = ".001";
            this.txbGamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbGamma.Validated += new System.EventHandler(this.txbGamma_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "r:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Epsilon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gamma:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Radio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "500 ms";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 222);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(166, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Iterar";
            // 
            // txbIterations
            // 
            this.txbIterations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIterations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txbIterations.ForeColor = System.Drawing.SystemColors.Window;
            this.txbIterations.Location = new System.Drawing.Point(27, 115);
            this.txbIterations.Name = "txbIterations";
            this.txbIterations.Size = new System.Drawing.Size(124, 22);
            this.txbIterations.TabIndex = 7;
            this.txbIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 18);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "1/1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pboxPlay
            // 
            this.pboxPlay.Image = global::Modelo.Properties.Resources.boton_de_play;
            this.pboxPlay.Location = new System.Drawing.Point(64, 143);
            this.pboxPlay.Name = "pboxPlay";
            this.pboxPlay.Size = new System.Drawing.Size(50, 50);
            this.pboxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxPlay.TabIndex = 9;
            this.pboxPlay.TabStop = false;
            this.pboxPlay.Click += new System.EventHandler(this.pboxPlay_Click);
            // 
            // pboxStop
            // 
            this.pboxStop.Image = global::Modelo.Properties.Resources.detener;
            this.pboxStop.Location = new System.Drawing.Point(64, 143);
            this.pboxStop.Name = "pboxStop";
            this.pboxStop.Size = new System.Drawing.Size(50, 50);
            this.pboxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxStop.TabIndex = 17;
            this.pboxStop.TabStop = false;
            this.pboxStop.Visible = false;
            this.pboxStop.Click += new System.EventHandler(this.pboxStop_Click);
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
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.Interval = 0.5D;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.Maximum = 4D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.Interval = 0.1D;
            chartArea2.AxisX.MinorGrid.IntervalOffset = double.NaN;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisX2.Interval = 1D;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.Interval = 0.5D;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.Interval = 1D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.Maximum = 4D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.Interval = 0.1D;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Gray;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelAngle = 90;
            series3.LabelBackColor = System.Drawing.Color.DimGray;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Serie";
            series3.Points.Add(dataPoint3);
            series3.XValueMember = "10";
            series3.YValueMembers = "10";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            series4.Points.Add(dataPoint4);
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(903, 604);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbRatio;
        private System.Windows.Forms.TextBox txbEpsilon;
        private System.Windows.Forms.TextBox txbR;
        private System.Windows.Forms.TextBox txbGamma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboxStop;
        private System.Windows.Forms.Button button1;
    }
}

