using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modelo
{
    public partial class Form1 : Form
    {
        readonly ManualResetEvent _event = new ManualResetEvent(true);

        private List<TSPiRole> _tspiRoles;
        private List<object[]> _interactiveStyles;

        private double _xMaxChart;
        private double _yMaxChart;

        private double _ratio;
        private double _gamma;
        private double _epsilon;
        private double _r;

        private int _sleep = 500;
        private Thread _hilo;


        private  List<List<double[]>> _pointsHistory;
        private List<List<double[]>> _interactiveStylesHistory;
        private List<int> _isSelectedHistory;


        private int _currentIndexHistory;


        public Form1()
        {
            InitializeComponent();
            Restart();
        }

        private void Restart()
        {
            _gamma = 0.0;
            _epsilon = 0.0;
            _r = 0.0;
            _ratio = 0.0;
            _xMaxChart = 0;
            _yMaxChart = 0;
            _tspiRoles = new List<TSPiRole>();
            _interactiveStyles = new List<object[]>();
            _pointsHistory = new List<List<double[]>>();
            _interactiveStylesHistory = new List<List<double[]>>();
            _isSelectedHistory = new List<int>();
            _currentIndexHistory = 0;
            LoadData();

            chart1.ChartAreas[0].AxisX.Maximum = _xMaxChart;
            chart1.ChartAreas[0].AxisY.Maximum = _yMaxChart;
            txbGamma.Text = _gamma.ToString(CultureInfo.InvariantCulture);
            txbEpsilon.Text = _epsilon.ToString(CultureInfo.InvariantCulture);
            txbR.Text = _r.ToString(CultureInfo.InvariantCulture);
            txbRatio.Text = _ratio.ToString(CultureInfo.InvariantCulture);
            txbAxisX.Text = _xMaxChart.ToString(CultureInfo.InvariantCulture);
            txbAxisY.Text = _yMaxChart.ToString(CultureInfo.InvariantCulture);


            pboxSaveAxisX.Visible = false;
            pboxSaveAxisY.Visible = false;
            pboxSaveR.Visible = false;
            pboxSaveEpsilon.Visible = false;
            pboxSaveGamma.Visible = false;
            pboxSaveRange.Visible = false;
            pboxSaveRatio.Visible = false;

            SetRandomPoints();
            UpdateInteractiveStyles();
            UpdateTable();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {

            if (File.Exists("initialData.txt"))
            {
                try
                {
                    using (var sr = new StreamReader("initialData.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains("@gamma="))
                            {
                                var value = line.Split('=');
                                var error = double.TryParse(value[1], out _gamma);
                                if (!error)
                                {
                                    MessageBox.Show($@"El valor para gamma es incorrecto: {value[1]}. Revise su archivo initialData.txt");
                                }
                            }
                            else if (line.Contains("@epsilon="))
                            {
                                var value = line.Split('=');
                                var error = double.TryParse(value[1], out _epsilon);
                                if (!error)
                                {
                                    MessageBox.Show($@"El valor para gamma es incorrecto: {value[1]}. Revise su archivo initialData.txt");
                                }
                            }
                            else if (line.Contains("@r="))
                            {
                                var value = line.Split('=');
                                var error = double.TryParse(value[1], out _r);
                                if (!error)
                                {
                                    MessageBox.Show($@"El valor para r es incorrecto: {value[1]}. Revise su archivo initialData.txt");
                                }
                            }
                            else if (line.Contains("@ratio="))
                            {
                                var value = line.Split('=');
                                var error = double.TryParse(value[1], out _ratio);
                                if (!error)
                                {
                                    MessageBox.Show($@"El valor para ratio es incorrecto: {value[1]}. Revise su archivo initialData.txt");
                                }
                            }
                            else if (line.Contains("@xMaxChart"))
                            {
                                var value = line.Split('=');
                                var error = double.TryParse(value[1], out _xMaxChart);
                                if (!error)
                                {
                                    MessageBox.Show($@"El valor maximo para el eje X en la gráfica es incorrecto: {value[1]}. Revise su archivo initialData.txt");
                                }
                            }
                            else if (line.Contains("@yMaxChart"))
                            {
                                var value = line.Split('=');
                                var error = double.TryParse(value[1], out _yMaxChart);
                                if (!error)
                                {
                                    MessageBox.Show($@"El valor maximo para el eje Y en la gráfica es incorrecto: {value[1]}. Revise su archivo initialData.txt");
                                }
                            }
                            else if (line.Contains("@Roles"))
                            {
                                line = sr.ReadLine();
                                var roles = line.Split(',');
                                foreach (var rol in roles)
                                {
                                    _tspiRoles.Add(new TSPiRole(rol));
                                }
                            }
                            else if (line.Contains("@interactiveStyles"))
                            {
                                line = sr.ReadLine();
                                var interactiveStyles = line.Split(',');
                                foreach (var interactiveStyle in interactiveStyles)
                                {
                                    var value = interactiveStyle.Split(':');
                                    _interactiveStyles.Add(new object[] { value[0], int.Parse(value[1]) });
                                }
                            }
                            else if (line.Contains("@DataTableStart"))
                            {
                                var interactiveStyles = new List<double[]>();
                                while ((line = sr.ReadLine()) != "@DataTableEnd")
                                {
                                    if (line == null) continue;
                                    var values = line.Split(',');
                                    if (values.Length != _tspiRoles.Count)
                                    {
                                        MessageBox.Show($@"Se econtraron discrepancias al leer los valores de X. En una de las líneas no coincide con el número de roles ingresados. Ingrese un archivo válido.");
                                        this.Close();
                                    }
                                    var values2 = new double[_tspiRoles.Count];
                                    for (var index = 0; index < values.Length; index++)
                                    {
                                        values2[index] = double.Parse(values[index]);
                                    }
                                    interactiveStyles.Add(values2);
                                }

                                if (interactiveStyles.Count != _interactiveStyles.Count)
                                {
                                    MessageBox.Show($@"Se econtraron discrepancias al leer los valores de X. Hacen falta líneas para el número de estilos ingresados. Ingrese un archivo válido");
                                    this.Close();
                                }
                                _interactiveStylesHistory.Add(interactiveStyles);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocurrió un error al leer el archivo initialData. Ingrese un archivo válido. " + e.Message );
                }
            }
            else
            {
                MessageBox.Show(@"No se encontró el archivo initialData.txt para iniciar el programa");
            }
        }
        private void SetRandomPoints()
        {
            var points = new List<double[]>();
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var guid = Guid.NewGuid();
                var justNumbers = new string(guid.ToString().Where(char.IsDigit).ToArray());
                var seed = int.Parse(justNumbers.Substring(0, 4));
                var random = new Random(seed);

                var xValue = random.NextDouble() * (4 - 0) + 0;
                var yValue = random.NextDouble() * (4 - 0) + 0;
                var newPoints = new[] { xValue, yValue };
                points.Add(newPoints);
            }

            _pointsHistory.Add(points);
            UpdatePoints();
        }
        private int GetRandom(int min, int max)
        {
            var guid = Guid.NewGuid();
            var justNumbers = new string(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            var random = new Random(seed);
            return random.Next(min, max);
        }
        private int GetRandomIs()
        {
            var interactiveStyles = new List<string>();
            var isSelect = new List<string>();
            var isAparitions = new List<int>();
            var weights = new List<int>();
            var n = 0;
            for (var index = 0; index < _interactiveStyles.Count; index++)
            {
                var isSelected = (string)_interactiveStyles.ElementAt(index)[0];
                interactiveStyles.Add(isSelected);
                isSelect.Add(isSelected);
                isAparitions.Add(0);
                weights.Add((int)_interactiveStyles.ElementAt(index)[1]);
                n += (int)_interactiveStyles.ElementAt(index)[1];
            }
            var listIS = new List<int>();
            while(listIS.Count < n)
            {
                var selectedIndex = GetRandom(0, isSelect.Count);
                var position = interactiveStyles.IndexOf(isSelect.ElementAt(selectedIndex));
                var weight = weights.ElementAt(position);
                var aparitions = isAparitions.ElementAt(position);
                if(aparitions < weight)
                {
                    listIS.Add(position);
                    aparitions++;
                    if(aparitions == weight)
                    {
                        isSelect.RemoveAt(selectedIndex);
                    }
                    isAparitions[position] = aparitions;
                }
            }
            return listIS.ElementAt(GetRandom(0, listIS.Count - 1));
        }

        private void UpdateTable2()
        {
            dataGridView1.Rows.Clear();
            for (var index = 0; index < _interactiveStyles.Count; index++)
            {
                var values = new object[_tspiRoles.Count];
                for (var index2 = 0; index2 < _tspiRoles.Count; index2++)
                {
                    var role = _tspiRoles.ElementAt(index2);
                    values[index2] = role.InteractiveStyles[index];
                }
                dataGridView1.Rows.Add(values);
                dataGridView1.Rows[index].HeaderCell.Value = _interactiveStyles.ElementAt(index)[0];
            }
            txbIS.Text = _currentIndexHistory > 0 ? _interactiveStyles.ElementAt(_isSelectedHistory.ElementAt(_currentIndexHistory - 1))[0].ToString() : "-";
        }
        private void UpdateTable()
        {
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new MethodInvoker(UpdateTable2));
            }
            else
            {
                UpdateTable2();
            }
        }
        private void UpdateChart2()
        {
            chart1.Series.Clear();
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var role = _tspiRoles.ElementAt(index);
                var serie = new Series
                {
                    Name = $"{role.Name} - ({Math.Round(role.X, 2)}, {Math.Round(role.Y, 2)})",
                    ChartType = SeriesChartType.Point
                };
                serie.Points.AddXY(role.X, role.Y);
                chart1.Series.Add(serie);
            }
        }
        private void UpdateChart()
        {
            if (chart1.InvokeRequired)
            {
                chart1.Invoke(new MethodInvoker(UpdateChart2));
            }
            else
            {
                UpdateChart2();
            }
        }
        private void GetNewXValues()
        {
            var newXValues = new List<double[]>();
            var a = GetRandomIs();
            _isSelectedHistory.Add(a);
            for (var index = 0; index < _interactiveStyles.Count; index++)
            {
                var vector = new double[_tspiRoles.Count];
                for (var index2 = 0; index2 < _tspiRoles.Count; index2++)
                {
                    vector[index2] = _tspiRoles[index2].InteractiveStyles[index];
                }
                newXValues.Add(vector);
            }

            var newVector = GetNewXValue(newXValues[a]);
            newXValues[a] = newVector;
            _interactiveStylesHistory.Add(newXValues);
            UpdateInteractiveStyles(newVector);
        }
        private double[] GetNewXValue(double[] vector)
        {
            if (vector == null) throw new ArgumentNullException(nameof(vector));
            var newVector = new double[_tspiRoles.Count];
            for (var index1 = 0; index1 < _tspiRoles.Count; index1++)
            {
                var step1 = 0.0;
                var n = 0;
                for (var index2 = 0; index2 < _tspiRoles.Count; index2++)
                {
                    if(index1 == index2) continue;
                    var d = Distance(_tspiRoles[index1], _tspiRoles[index2]);
                    var m = d[0];
                    if (m > _ratio) continue;//Si la magnitud es mayor al radio establecido
                    n++;

                    step1 += F(vector[index2]);
                }

                if (n > 0)
                    newVector[index1] = (1 - _epsilon) * F(vector[index1]) + (_epsilon / n) * step1;
                else
                    newVector[index1] = F(vector[index1]);

            }

            return newVector;
        }
        private double F(double x) //F da numeros negativos 
        {
            x /= 5; //X se divide entre 5 para que de un valor entre 0 y 1
            var f = _r * x * (1 - x);//Funcion de x
            return f * 5;
        }
        private void GetNextPosition()//Funcion Inicial para obtener la nueva posicion (X, Y) de todos los roles (Puntos en el gráfico)
        {
            var newPoints = new List<double[]>();//Crea una ueva lista de posiciones (x, y) que serán los que se calcuarán
            var a = _isSelectedHistory[_currentIndexHistory];//Obtiene de manera aleatoria un estilo interactivo
            for (var index = _tspiRoles.Count - 1; index >= 0; index--)//Recorre cada uno de los roles para calcular su nueva posicion (X, Y)
            {
                var rol = _tspiRoles.ElementAt(index);//Obtiene el rol en la posicion (index) de la iteración
                var newPos = new[] { PosX(rol, a), PosY(rol, a) };//Obtiene la nueva posición (X, Y) para Ri con el estilo interactivo a
                newPoints.Add(newPos);//Agrega los nuevos puntos del rol a la lista de nuevos puntos
            }
            _pointsHistory.Add(newPoints);//Agrega todos los puntos a la historia
            UpdatePoints();//Manda actualizar los puntos en la gráfica
        }
        private void UpdateInteractiveStyles()
        {
            var currentVaulues = _interactiveStylesHistory.ElementAt(_currentIndexHistory);
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var values = new double[_interactiveStyles.Count];
                for (var index2 = 0; index2 < _interactiveStyles.Count; index2++)
                {
                    values[index2] = currentVaulues.ElementAt(index2)[index];
                }
                var role = _tspiRoles[index];
                role.InteractiveStyles = values;
            }
            UpdateTable();
        }

        private void UpdateInteractiveStyles(double[] newVector)
        {
            var a = _isSelectedHistory[_currentIndexHistory];
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var role = _tspiRoles[index];
                role.InteractiveStyles[a] = newVector[index];
            }
            UpdateTable();
        }
        private void UpdatePoints()
        {
            var points = _pointsHistory.ElementAt(_currentIndexHistory);
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var rol = _tspiRoles.ElementAt(index);
                rol.X = points.ElementAt(index)[0];
                rol.Y = points.ElementAt(index)[1];
            }
            UpdateChart();
        }

        private double PosX(TSPiRole rol, int a)
        {
            var posX = rol.X;

            var step1 = 0.0; //Primer suumatoria de la ecuación
            var step2 = 0.0;//Segunda sumatoria de la ecuación
            foreach (var n in _tspiRoles)
            {
                if (n == rol) //Si es el mismo rol
                {
                    continue;
                }
                var d = Distance(rol, n);
                posX = d[1];
                var m = d[0];
                if (m > _ratio) //Si la magnitud es mayor al radio establecido
                {
                    continue;
                }
                if (m > 0)
                {
                    var nVal = (n.X - posX) / m;
                    step1 += nVal;
                }
                else
                {
                    var nVal = n.X - posX;
                    step1 += nVal;

                }
                step2 += n.InteractiveStyles[a];
            }

            var step3 = rol.InteractiveStyles[a] * step2;
            var step4 = _gamma * step1 * step3;
            var result = posX + step4;

            if (result > _yMaxChart)
                result %= _yMaxChart;
            if (result < 0)
            {
                result %= _yMaxChart;
                result += _yMaxChart;
            }
            return result;

        }
        private double PosY(TSPiRole rol, int a)
        {
            var posY = rol.Y;

            var step1 = 0.0; 
            var step2 = 0.0;
            foreach (var n in _tspiRoles)
            {
                if (n == rol)
                {
                    continue;
                }
                var d = Distance(rol, n);
                posY = d[2];
                var m = d[0];
                if (m > _ratio)
                {
                    continue;
                }
                if (m > 0)
                {
                    var nVal = (n.Y - posY) / m;
                    step1 += nVal;
                }
                else
                {
                    var nVal = n.Y - posY;
                    step1 += nVal;

                }
                step2 += n.InteractiveStyles[a];
            }
            var step3 = rol.InteractiveStyles[a] * step2;
            var step4 = _gamma * step1 * step3;
            var result = posY + step4;

            if (result > _yMaxChart)
                result %= _yMaxChart;
            if (result < 0)
            {
                result %= _yMaxChart;
                result += _yMaxChart;
            }
            return result;
        }
        private double[] Distance(TSPiRole role1, TSPiRole role2)
        {
            var distances = new List<double[]>();

            var x1 = role1.X;
            var y1 = role1.Y;
            var x2 = role2.X;
            var y2 = role2.Y;
            var nx1 = role1.X + _xMaxChart;
            var nx2 = role1.X - _xMaxChart;
            var ny1 = role1.Y + _yMaxChart;
            var ny2 = role1.Y - _yMaxChart;
            distances.Add(new [] {Distance(x1, y1, x2, y2), x1, y1});
            distances.Add(new [] {Distance(nx1, y1, x2, y2), nx1, y1});
            distances.Add(new [] {Distance(nx2, y1, x2, y2), nx2, y1});
            distances.Add(new [] {Distance(x1, ny1, x2, y2), x1, ny1});
            distances.Add(new [] {Distance(x1, ny2, x2, y2), x1, ny2});
            distances.Add(new [] {Distance(nx1, ny1, x2, y2), nx1, ny1});
            distances.Add(new [] {Distance(nx2, ny2, x2, y2), nx2, ny2});
            distances.Add(new [] {Distance(nx1, ny2, x2, y2), nx1, ny2});
            distances.Add(new [] {Distance(nx2, ny1, x2, y2), nx2, ny1});

            distances = distances.OrderBy(x => x[0]).ToList();


            return distances.ElementAt(0);
        }
        private double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        #region MyRegion
        private void pboxAdd_Click(object sender, EventArgs e)
        {
            if (_currentIndexHistory < _pointsHistory.Count - 1)
            {
                _currentIndexHistory = _pointsHistory.Count - 1;
            }

            GetNewXValues();
            GetNextPosition();
            _currentIndexHistory++;
            UpdatePoints();
            UpdateInteractiveStyles();
            lblTime.Text = $@"{_currentIndexHistory + 1}/{_pointsHistory.Count}";
        }

        private void pboxPrevious_Click(object sender, EventArgs e)
        {
            if (_currentIndexHistory > 0)
                _currentIndexHistory--;
            lblTime.Text = $@"{_currentIndexHistory + 1}/{_pointsHistory.Count}";
            UpdatePoints();
            UpdateInteractiveStyles();

        }

        private void pboxNext_Click(object sender, EventArgs e)
        {
            if (_currentIndexHistory < _pointsHistory.Count - 1)
                _currentIndexHistory++;
            lblTime.Text = $@"{_currentIndexHistory + 1}/{_pointsHistory.Count}";
            UpdatePoints();
            UpdateInteractiveStyles();

        }
        #endregion

        private void pboxPlay_Click(object sender, EventArgs e)
        {
            if (_hilo != null && _hilo.IsAlive) return;
            ThreadStart delegado = Run;
            _hilo = new Thread(delegado);
            _hilo.Start();
            pboxPlay.Visible = false;
            pboxStop.Visible = true;
        }
        private void pboxStop_Click(object sender, EventArgs e)
        {
            _hilo.Abort();
            pboxPlay.Visible = true;
            pboxStop.Visible = false;
        }
        private void Run()
        {
            var isNumber = int.TryParse(txbIterations.Text, out var iterations);
            if (!isNumber) return;
            for (var index = 0; index < iterations; index++)
            {
                _event.WaitOne();
                if (_currentIndexHistory < _pointsHistory.Count - 1)
                {
                    _currentIndexHistory = _pointsHistory.Count - 1;
                    UpdatePoints();
                }
                GetNewXValues();
                GetNextPosition();
                _currentIndexHistory++;
                lblTime.Invoke(new MethodInvoker(delegate
                {
                    lblTime.Text = $@"{_currentIndexHistory + 1}/{_pointsHistory.Count}";

                }));
                Thread.Sleep(_sleep);
            }
            pboxPlay.Invoke(new MethodInvoker(delegate
            {
                pboxPlay.Visible = true;
                pboxStop.Visible = false;
            }));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = $@"{trackBar1.Value * 100} ms";
            _sleep = trackBar1.Value * 100;
        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {
            Restart();
            lblTime.Text = "1/1";
        }

        private void txbRatio_TextChanged(object sender, EventArgs e)
        {
            if (pboxSaveRatio.Visible) return;
            pboxSaveRatio.Visible = true;
        }
        private void txbGamma_TextChanged(object sender, EventArgs e)
        {
            if (pboxSaveGamma.Visible) return;
            pboxSaveGamma.Visible = true;
        }

        private void txbEpsilon_TextChanged(object sender, EventArgs e)
        {
            if (pboxSaveEpsilon.Visible) return;
            pboxSaveEpsilon.Visible = true;
        }

        private void txbR_TextChanged(object sender, EventArgs e)
        {
            if (pboxSaveR.Visible) return;
            pboxSaveR.Visible = true;
        }
        private void txbAxisX_TextChanged(object sender, EventArgs e)
        {
            if (pboxSaveAxisX.Visible) return;
            pboxSaveAxisX.Visible = true;
        }

        private void txbAxisY_TextChanged(object sender, EventArgs e)
        {
            if (pboxSaveAxisY.Visible) return;
            pboxSaveAxisY.Visible = true;

        }
        private void txRange_TextChanged(object sender, EventArgs e)
        {
            if (pboxSaveRange.Visible) return;
            pboxSaveRange.Visible = true;
        }
        private void pboxSaveRatio_Click(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbRatio.Text, out var newValue);
            if (isNumber)
                _ratio = newValue;
            txbRatio.Text = _ratio.ToString(CultureInfo.InvariantCulture);
            pboxSaveRatio.Visible = false;
        }
        private void pboxSaveGamma_Click(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbGamma.Text, out var newValue);
            if (isNumber)
                _gamma = newValue;
            txbGamma.Text = _gamma.ToString(CultureInfo.InvariantCulture);
            pboxSaveGamma.Visible = false;
        }

        private void pboxSaveEpsilon_Click(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbEpsilon.Text, out var newValue);
            if (isNumber)
                _epsilon = newValue;
            txbEpsilon.Text = _epsilon.ToString(CultureInfo.InvariantCulture);
            pboxSaveEpsilon.Visible = false;
        }

        private void pboxSaveR_Click(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbR.Text, out var newValue);
            if (isNumber)
                _r = newValue;
            txbR.Text = _r.ToString(CultureInfo.InvariantCulture);
            pboxSaveR.Visible = false;
        }
        private void pboxSaveAxisX_Click(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbAxisX.Text, out var newValue);
            if (isNumber)
                _xMaxChart = newValue;
            txbAxisX.Text = _xMaxChart.ToString(CultureInfo.InvariantCulture);
            pboxSaveAxisX.Visible = false;
            chart1.ChartAreas[0].AxisX.Maximum = _xMaxChart;
        }

        private void pboxSaveAxisY_Click(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbAxisY.Text, out var newValue);
            if (isNumber)
                _yMaxChart = newValue;
            txbAxisY.Text = _yMaxChart.ToString(CultureInfo.InvariantCulture);
            pboxSaveAxisY.Visible = false;
            chart1.ChartAreas[0].AxisY.Maximum = _yMaxChart;
        }
        private void pboxSaveRange_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var patch = "saveFile.txt";
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo Delimitado Por Comas (*.csv)|*.csv";
                sfd.DefaultExt = "csv";
                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    patch = sfd.FileName;
                }
            }

            var lines = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var str = "";
                for (var index = 0; index < row.Cells.Count; index++)
                {
                    str += row.Cells[index].Value + ",";
                }

                lines += str + "\n";
            }

            using (var fs = new FileStream(patch, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(lines);
                }
            }
        }
    }
}
