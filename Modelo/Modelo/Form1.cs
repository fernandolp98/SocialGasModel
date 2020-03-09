using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modelo
{
    public partial class Form1 : Form
    {
        ManualResetEvent _event = new ManualResetEvent(true);

        private readonly List<TSPiRole> _tspiRoles;
        private readonly List<string> _interactiveStyles;

        private readonly double _xMax;
        private readonly double _yMax;

        private double _ratio;
        private double _gamma;
        private double _epsilon;
        private double _r;

        private int _sleep = 500;
        private Thread _hilo;


        private readonly List<List<double[]>> _pointsHistory;
        private readonly List<List<double[]>> _interactiveStylesHistory;

        private int _currentIndexHistory;

        public Form1()
        {
            InitializeComponent();

            _gamma = .001;
            _epsilon = 0.01;
            _r = 3;
            _ratio = 2;
            _xMax = 4;
            _yMax = 4;

            _pointsHistory = new List<List<double[]>>();
            _interactiveStylesHistory = new List<List<double[]>>();
            _currentIndexHistory = 0;

            chart1.ChartAreas[0].AxisX.Maximum = _xMax;
            chart1.ChartAreas[0].AxisY.Maximum = _yMax;

            ///////////////////////////////////////////////////////////////////////////
            //Inicializa normal
            _tspiRoles = TSPiRole.getRoles();
            _interactiveStylesHistory.Add(TSPiRole.GetInteractiveStyles());

            _interactiveStyles = new List<string> { "DM", "AT", "FT", "AP", "FC", "TT", "CY", "TR", "DS", "RS", "IM", "CR" };

            ////////////////////////////////////////////////////////////////////////////
            //Divide entre 5 los valores de X
            //for (var index = 0; index < 7; index++)
            //{
            //    var role = _tspiRoles.ElementAt(index);
            //    for (var index2 = 0; index2 < 12; index2++)
            //    {
            //        role.InteractiveStyles[index2, 1] = (double)role.InteractiveStyles[index2, 1] / 5;
            //    }
            //}
            //////////////////////////////////////////////////////////////////////////
            //Carga 200 roles
            //_tspiRoles = new List<TSPiRole>();
            //for (var i = 0; i < 100; i++)
            //{
            //    if (i < 50)
            //        _tspiRoles.Add(new TSPiRole { InteractiveStyles = new object[,] { { "t1", -1.0 } } });
            //    else
            //        _tspiRoles.Add(new TSPiRole { InteractiveStyles = new object[,] { { "t2", 1.0 } } });

            //}
            ///////////////////////////////////////////////////////////////////////////////
            //Carga 4 puntos en las esquinas
            //_tspiRoles = new List<TSPiRole>();
            //_tspiRoles.Add(new TSPiRole { Name = "A", InteractiveStyles = new object[,] { { "", 1.0 } } });
            //_tspiRoles.Add(new TSPiRole { Name = "B", InteractiveStyles = new object[,] { { "", 1.0 } } });
            //_tspiRoles.Add(new TSPiRole { Name = "C", InteractiveStyles = new object[,] { { "", 2.0 } } });
            //_tspiRoles.Add(new TSPiRole { Name = "D", InteractiveStyles = new object[,] { { "", 2.0 } } });
            //_tspiRoles.Add(new TSPiRole { Name = "E", InteractiveStyles = new object[,] { { "", 3.0 } } });
            //_tspiRoles.Add(new TSPiRole { Name = "F", InteractiveStyles = new object[,] { { "", 3.0 } } });


            //var points = new List<double[]>();
            //points.Add(new[] { 1.0, 3.0 });
            //points.Add(new[] { 3.5, 2.0 });
            //points.Add(new[] { 2.5, 1.0 });
            //points.Add(new[] { 3.0, 3.5 });
            //points.Add(new[] { 1.0, 1.0 });
            //points.Add(new[] { 2.0, 1.5 });

            //_currentIndexHistory = 0;
            //_pointsHistory.Add(points);
            //UpdatePoints();
            ///////////////////////////////////////////////////////////////////////////////



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////////
            //Agrega valores random x,y
            SetRandomPoints();
            UpdateInteractiveStyles();
            UpdateTable();
            ///////////////////////////////////////////////////////////////////////////////
        }
        private void SetRandomPoints()
        {
            var points = new List<double[]>();
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var guid = Guid.NewGuid();
                var justNumbers = new string(guid.ToString().Where(Char.IsDigit).ToArray());
                var seed = int.Parse(justNumbers.Substring(0, 4));
                var random = new Random(seed);

                var xValue = random.NextDouble() * (_xMax - 0) + 0;
                var yValue = random.NextDouble() * (_yMax - 0) + 0;
                var newPoints = new[] { xValue, yValue };
                points.Add(newPoints);
            }

            _pointsHistory.Add(points);
            UpdatePoints();
        }

        private void UpdateTable2()
        {
            dataGridView1.Rows.Clear();
            for (var index = 0; index < _interactiveStyles.Count; index++)
            {
                var values = new object[7];
                for (var index2 = 0; index2 < _tspiRoles.Count; index2++)
                {
                    var role = _tspiRoles.ElementAt(index2);
                    values[index2] = role.InteractiveStyles[index];
                }
                dataGridView1.Rows.Add(values);
                dataGridView1.Rows[index].HeaderCell.Value = _interactiveStyles.ElementAt(index);
            }
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
        private void PrintPoints(TSPiRole role)
        {
            if (role.Index == 0)
                Console.WriteLine(@"------------------------------------------------");
            Console.WriteLine($@"{role.Name} -> X: {role.X}, Y: {role.Y}");
        }

        private void UpdateChart2()
        {
            chart1.Series.Clear();
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var role = _tspiRoles.ElementAt(index);
                var serie = new Series
                {
                    //Name = $"{role.Name} - ({Math.Round(role.X, 2)}, {Math.Round(role.Y, 2)})",
                    Name = $"{role.Name})",
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



            ///////////////////////////////////////////////////////////////////
            //chart1.Series.Clear();
            //var serie = new Series
            //{
            //    Name = $"Team 1",
            //    ChartType = SeriesChartType.Point
            //};
            //var serie2 = new Series
            //{
            //    Name = $"Team 2",
            //    ChartType = SeriesChartType.Point
            //};
            //for (var index = 0; index < _tspiRoles.Count / 2; index++)
            //{
            //    var role = _tspiRoles.ElementAt(index);
            //    serie.Points.AddXY(role.X, role.Y);
            //}
            //for (var index = _tspiRoles.Count / 2; index < _tspiRoles.Count; index++)
            //{
            //    var role = _tspiRoles.ElementAt(index);

            //    serie2.Points.AddXY(role.X, role.Y);
            //}
            //chart1.Series.Add(serie);
            //chart1.Series.Add(serie2);
        }
        private void GetNewXValues()
        {
            var newXValues = new List<double[]>();
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                newXValues.Add(GetNewXValue(_tspiRoles[index]));
            }
            _interactiveStylesHistory.Add(newXValues);
            UpdateInteractiveStyles();
        }
        private double[] GetNewXValue(TSPiRole role)
        {
            var newX = new double[12];
            var step1 = 0.0;
            for (var index = 0; index < _interactiveStyles.Count; index++)
            {
                var n = 0;
                for (var index2 = 0; index2 < _tspiRoles.Count; index2++)
                {
                    var nj = _tspiRoles[index2];
                    if (role == nj) continue;
                    if (Distance(role, nj)[0] > _ratio) continue;
                    step1 += F(nj.InteractiveStyles[index]);
                    n++;
                }
                if(n != 0)
                {
                    var step2 = (_epsilon / n) * step1;
                    var x = role.InteractiveStyles[index];
                    var step3 = (1 - _epsilon) * F(x);
                    newX[index] = step3 + step2;
                }
                else
                {
                    var step2 =  step1;
                    var x = role.InteractiveStyles[index];
                    var step3 =  F(x);
                    newX[index] = step3 + step2;
                }

            }
            return newX;
        }
        private double F(double x) //F da numeros negativos 
        {
            x /= 5;
            var f = _r * (x) * (1 - (x));
            return f * 5;
        }
        private void GetNextPosition()
        {
            var newPoints = new List<double[]>();
            var rand = new Random();
            var a = rand.Next(0, 11);
            //var a = 0;
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var rol = _tspiRoles.ElementAt(index);
                var newPos = new[] { PosX(rol, a), PosY(rol, a) };
                newPoints.Add(newPos);
            }
            _pointsHistory.Add(newPoints);
            UpdatePoints();
        }
        private void UpdateInteractiveStyles()
        {
            var values = _interactiveStylesHistory.ElementAt(_currentIndexHistory);
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var role = _tspiRoles[index];
                role.InteractiveStyles = values[index];
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
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = _tspiRoles[index];
                if (n == rol) //Si es el mismo rol
                {
                    continue;
                }
                var d = Distance(rol, n);
                posX = d[1];
                var m = d[0];
                if (m > _ratio) //Si la magnitud es mayo al radio establecido
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

            if (result > _yMax)
                result %= _yMax;
            if (result < 0)
            {
                result %= _yMax;
                result += _yMax;
            }
            return result;

        }
        private double PosY(TSPiRole rol, int a)
        {
            var posY = rol.Y;

            var step1 = 0.0; //Primer suumatoria de la ecuación
            var step2 = 0.0;//Segunda sumatoria de la ecuación
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = _tspiRoles[index];
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

            if (result > _yMax)
                result %= _yMax;
            if (result < 0)
            {
                result %= _yMax;
                result += _yMax;
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
            var nx1 = role1.X + _xMax;
            var nx2 = role1.X - _xMax;
            var ny1 = role1.Y + _yMax;
            var ny2 = role1.Y - _yMax;
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
                UpdateInteractiveStyles();
                UpdatePoints();
            }

            _currentIndexHistory++;
            lblTime.Text = $@"{_currentIndexHistory + 1}/{_pointsHistory.Count + 1}";
            GetNewXValues();
            GetNextPosition();
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

        private void txbRatio_Validated(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbRatio.Text, out var newValue);
            if (isNumber)
                _ratio = newValue;
            txbRatio.Text = _ratio.ToString(CultureInfo.InvariantCulture);
        }

        private void txbGamma_Validated(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbGamma.Text, out var newValue);
            if (isNumber)
                _gamma = newValue;
            txbGamma.Text = _gamma.ToString(CultureInfo.InvariantCulture);
        }

        private void txbEpsilon_Validated(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbEpsilon.Text, out var newValue);
            if (isNumber)
                _epsilon = newValue;
            txbEpsilon.Text = _epsilon.ToString(CultureInfo.InvariantCulture);
        }

        private void txbR_Validated(object sender, EventArgs e)
        {
            var isNumber = double.TryParse(txbR.Text, out var newValue);
            if (isNumber)
                _r = newValue;
            txbR.Text = _r.ToString(CultureInfo.InvariantCulture);
        }


    }
}
