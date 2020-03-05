using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modelo
{
    public partial class Form1 : Form
    {
        private readonly List<TSPiRole> _tspiRoles;
        private readonly double _gamma;

        private readonly double _xMax;
        private readonly double _yMax;
        private readonly double _ratio;
        private readonly double _epsilon;
        private readonly double _r;


        private List<List<double[]>> _pointsHistory;
        private int _currentIndexHistory;

        public Form1()
        {
            InitializeComponent();
            _gamma = .01;
            _epsilon = 0.05;
            _r = 3;
            _ratio = 10;
            _xMax = 4;
            _yMax = 4;
            _pointsHistory = new List<List<double[]>>();

            chart1.ChartAreas[0].AxisX.Maximum = _xMax;
            chart1.ChartAreas[0].AxisY.Maximum = _yMax;

            ///////////////////////////////////////////////////////////////////////////
            ///Inicializa normal
            _tspiRoles = TSPiRole.getRoles();



            ////////////////////////////////////////////////////////////////////////////
            //Divide entre 5 los valores de X
            for (var index = 0; index < 7; index++)
            {
                var role = _tspiRoles.ElementAt(index);
                for (var index2 = 0; index2 < 12; index2++)
                {
                    role.InteractiveStyles[index2, 1] = (double)role.InteractiveStyles[index2, 1] / 5;
                }
            }
            //////////////////////////////////////////////////////////////////////////
            ///Carga 200 roles
            //_tspiRoles = new List<TSPiRole>();
            //for (var i = 0; i < 100; i++)
            //{
            //    if (i < 50)
            //        _tspiRoles.Add(new TSPiRole { InteractiveStyles = new object[,] { { "t1", -1.0 } } });
            //    else
            //        _tspiRoles.Add(new TSPiRole { InteractiveStyles = new object[,] { { "t2", 1.0 } } });

            //}
            ///////////////////////////////////////////////////////////////////////////////
            ///Carga 4 puntos en las esquinas
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
            ///Agrega valores random x,y
            SetRandomPoints();
            ///////////////////////////////////////////////////////////////////////////////
        }
        private void SetRandomPoints()
        {
            var points = new List<double[]>();
            for (var index = 0; index < _tspiRoles.Count(); index++)
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

            for (var i = 0; i < 7; i++)
            {
                var xValue = i * .5 + 1;
                var yValue = 4 - i * .5;
                var newPoints = new[] { xValue, yValue };
                points.Add(newPoints);
            }

            _currentIndexHistory = 0;
            _pointsHistory.Add(points);
            UpdatePoints();
        }

        private void PrintPoints(TSPiRole role)
        {
            if (role.Index == 0)
                Console.WriteLine(@"------------------------------------------------");
            Console.WriteLine($@"{role.Name} -> X: {role.X}, Y: {role.Y}");
        }

        private void UpdateChart()
        {
            chart1.Series.Clear();
            //if(chart1.InvokeRequired)
            //{
            //    chart1.Invoke(new MethodInvoker(delegate
            //    {
            //        button1.Enabled = true;
            //        button2.Enabled = false;
            //    }));
            //}

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
            UpdateX(newXValues);
        }
        private double[] GetNewXValue(TSPiRole role)
        {
            var newX = new double[12];
            var step1 = 0.0;
            for (var index = 0; index < role.InteractiveStyles.Length / 2; index++)
            {
                var n = 0;
                for (var index2 = 0; index2 < _tspiRoles.Count; index2++)
                {
                    var nj = _tspiRoles[index2];
                    if (role == nj) continue;
                    if (Distance(role, nj)[0] > _ratio) continue;
                    step1 += F((double)nj.InteractiveStyles[index,1]);
                    n++;
                }
                if(n != 0)
                {
                    var step2 = (_epsilon / n) * step1;
                    var x = (double)role.InteractiveStyles[index, 1];
                    var step3 = (1 - _epsilon) * F(x);
                    newX[index] = step3 + step2;
                }
                else
                {
                    var step2 =  step1;
                    var x = (double)role.InteractiveStyles[index, 1];
                    var step3 =  F(x);
                    newX[index] = step3 + step2;
                }

            }
            return newX;
        }
        private double F(double x) //F da numeros negativos 
        {
            var f = _r * (x) * (1 - (x));
            return f;
        }
        private void GetNextPoints()
        {
            var newPoints = new List<double[]>();
            var rand = new Random();
            //var a = rand.Next(0, 11);
            var a = 0;
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var rol = _tspiRoles.ElementAt(index);
                var newPos = new[] { PosX(rol, a), PosY(rol, a) };
                newPoints.Add(newPos);
            }
            _pointsHistory.Add(newPoints);
            _currentIndexHistory = _pointsHistory.Count - 1;
            UpdatePoints();
            UpdateChart();
        }
        private void UpdateX(List<double[]> newValues)
        {
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var role = _tspiRoles[index];
                for(var index2 = 0; index2 < 12; index2++)
                {
                    role.InteractiveStyles[index2, 1] = newValues[index][index2];
                }
            }
        }
        private void UpdatePoints()
        {
            var points = _pointsHistory.ElementAt(_currentIndexHistory);
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var rol = _tspiRoles.ElementAt(index);
                rol.X = points.ElementAt(index)[0];
                rol.Y = points.ElementAt(index)[1];
                PrintPoints(rol);
            }
            UpdateChart();
            lblTime.Text = $@"{_currentIndexHistory + 1}/{_pointsHistory.Count}";
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
                if (m == 0)
                {
                    step1 += (n.X - posX);
                }
                else
                {
                    var nVal = (n.X - posX) / m;
                    step1 += nVal;
                }
                step2 += (double)n.InteractiveStyles[a, 1];
            }

            var step3 = (double)rol.InteractiveStyles[a, 1] * step2;
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
            if (rol.Name == "B")
            {
                if (true)
                {

                }
            }
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
                if (m == 0)
                {
                    step1 += (n.Y - posY);
                }
                else
                {
                    var nVal = (n.Y - posY) / m;
                    step1 += nVal;
                }
                step2 += (double)n.InteractiveStyles[a, 1];
            }
            var step3 = (double)rol.InteractiveStyles[a, 1] * step2;
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
            distances.Add(new double[] {Distance(x1, y1, x2, y2), x1, y1});
            distances.Add(new double[] {Distance(nx1, y1, x2, y2), nx1, y1});
            distances.Add(new double[] {Distance(nx2, y1, x2, y2), nx2, y1});
            distances.Add(new double[] {Distance(x1, ny1, x2, y2), x1, ny1});
            distances.Add(new double[] {Distance(x1, ny2, x2, y2), x1, ny2});
            distances.Add(new double[] {Distance(nx1, ny1, x2, y2), nx1, ny1});
            distances.Add(new double[] {Distance(nx2, ny2, x2, y2), nx2, ny2});
            distances.Add(new double[] {Distance(nx1, ny2, x2, y2), nx1, ny2});
            distances.Add(new double[] {Distance(nx2, ny1, x2, y2), nx2, ny1});

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
                //UpdateX();
                UpdatePoints();
            }
            if(_currentIndexHistory == 4)
            {
                Console.WriteLine("zdxz");
            }
            GetNewXValues();
            GetNextPoints();
        }

        private void pboxPrevious_Click(object sender, EventArgs e)
        {
            if (_currentIndexHistory > 0)
                _currentIndexHistory--;
            UpdatePoints();
        }

        private void pboxNext_Click(object sender, EventArgs e)
        {
            if (_currentIndexHistory < _pointsHistory.Count - 1)
                _currentIndexHistory++;
            UpdatePoints();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //var r1 = new TSPiRole()
            //{
            //    X = 2,
            //    Y = .5
            //};
            //var r2 = new TSPiRole()
            //{
            //    X = 2,
            //    Y = 1.5
            //};
            //Console.WriteLine(Distance(2, .5, 2, 1.5));
            //Console.WriteLine(Distance(r1, r2));

            var n = -47;
            n %= 4;
            n += 4;
            //n += 4;
            Console.WriteLine(n);
        }

        private void pboxPlay_Click(object sender, EventArgs e)
        {
            /*var delegado = new ThreadStart(Run);
            var hilo = new Thread(delegado);
            hilo.Start();*/
            //GetNewXValues();
            for(var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = 0;
                var ni = _tspiRoles.ElementAt(index);
                for (var index2 = 0; index2 < _tspiRoles.Count; index2++)
                {
                    var nj = _tspiRoles.ElementAt(index2);
                    if (ni == nj) continue;
                    var distance = Distance(ni, nj);
                    if (distance[0] > _ratio) continue;
                    Console.WriteLine($"{ni.Name} ({ni.X}, {ni.Y}) es vecino de {nj.Name} ({nj.X},{nj.Y}) con distancia {distance[0]} desde el punto ({distance[1]}, {distance[2]})");
                    n++;
                }
                Console.WriteLine($"Rol {ni.Name} tiene  {n} vecinos...");
            }
    }
        private void Run()
        {
            var isNumber = int.TryParse(txbIterations.Text, out var iterations);
            if (isNumber)
            {
                for (int index = 0; index < iterations; index++)
                {
                    if (_currentIndexHistory < _pointsHistory.Count - 1)
                    {
                        _currentIndexHistory = _pointsHistory.Count - 1;
                        UpdatePoints();
                    }
                    GetNextPoints();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
