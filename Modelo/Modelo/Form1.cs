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

        private List<List<double[]>> _pointsHistory;
        private int _currentIndexHistory;

        public Form1()
        {
            InitializeComponent();
            _gamma = 0.001;
            _ratio = 2;
            _xMax = 4;
            _yMax = 4;
            _pointsHistory = new List<List<double[]>>();
            _tspiRoles = new List<TSPiRole>
            {
                new TSPiRole()
                {
                    Index = 0,
                    Name = "TL",
                    InteractiveStyles = new object[,]
                    {
                        { "DM", 5.0 },
                        { "AT", 5.0 },
                        { "FT", 5.0 },
                        { "AP", 5.0 },
                        { "FC", 3.0 },
                        { "TT", 2.0 },
                        { "CY", 3.0 },
                        { "TR", 2.0 },
                        { "DS", 5.0 },
                        { "RS", 5.0 },
                        { "IM", 1.0 },
                        { "CR", 5.0 },
                    }
                },
                new TSPiRole()
                {
                    Index = 1,
                    Name = "PM",
                    InteractiveStyles = new object[,]
                    {
                        { "DM", 4.0 },
                        { "AT", 4.0 },
                        { "FT", 4.0 },
                        { "AP", 5.0 },
                        { "FC", 3.0 },
                        { "TT", 1.0 },
                        { "CY", 1.0 },
                        { "TR", 1.0 },
                        { "DS", 3.0 },
                        { "RS", 4.0 },
                        { "IM", 1.0 },
                        { "CR", 5.0 },
                    }
                },
                new TSPiRole()
                {
                    Index = 2,
                    Name = "QM",
                    InteractiveStyles = new object[,]
                    {
                        { "DM", 4.0 },
                        { "AT", 0.0 },
                        { "FT", 4.0 },
                        { "AP", 4.0 },
                        { "FC", 1.0 },
                        { "TT", 1.0 },
                        { "CY", 2.0 },
                        { "TR", 0.0 },
                        { "DS", 4.0 },
                        { "RS", 4.0 },
                        { "IM", 0.0 },
                        { "CR", 3.0 },
                    }
                },
                new TSPiRole()
                {
                    Index = 3,
                    Name = "SM",
                    InteractiveStyles = new object[,]
                    {
                        { "DM", 2.0 },
                        { "AT", 3.0 },
                        { "FT", 3.0 },
                        { "AP", 3.0 },
                        { "FC", 5.0 },
                        { "TT", 3.0 },
                        { "CY", 2.0 },
                        { "TR", 2.0 },
                        { "DS", 4.0 },
                        { "RS", 4.0 },
                        { "IM", 2.0 },
                        { "CR", 3.0 },
                    }
                },
                new TSPiRole()
                {
                    Index = 4,
                    Name = "DS",
                    InteractiveStyles = new object[,]
                    {
                        { "DM", 3.0 },
                        { "AT", 5.0 },
                        { "FT", 5.0 },
                        { "AP", 4.0 },
                        { "FC", 5.0 },
                        { "TT", 1.0 },
                        { "CY", 5.0 },
                        { "TR", 4.0 },
                        { "DS", 4.0 },
                        { "RS", 4.0 },
                        { "IM", 3.0 },
                        { "CR", 3.0 },
                    }
                },
                new TSPiRole()
                {
                    Index = 5,
                    Name = "IM",
                    InteractiveStyles = new object[,]
                    {
                        { "DM", 4.0 },
                        { "AT", 4.0 },
                        { "FT", 4.0 },
                        { "AP", 4.0 },
                        { "FC", 4.0 },
                        { "TT", 1.0 },
                        { "CY", 4.0 },
                        { "TR", 4.0 },
                        { "DS", 3.0 },
                        { "RS", 4.0 },
                        { "IM", 3.0 },
                        { "CR", 5.0 },
                    }
                },
                new TSPiRole()
                {
                    Index = 6,
                    Name = "TM",
                    InteractiveStyles = new object[,]
                    {
                        { "DM", 3.0 },
                        { "AT", 5.0 },
                        { "FT", 5.0 },
                        { "AP", 4.0 },
                        { "FC", 3.0 },
                        { "TT", 2.0 },
                        { "CY", 4.0 },
                        { "TR", 4.0 },
                        { "DS", 4.0 },
                        { "RS", 4.0 },
                        { "IM", 1.0 },
                        { "CR", 1.0 },
                    }
                }
            };


        }

        private void Form1_Load(object sender, EventArgs e)
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

            //for (var i = 0; i < 7; i++)
            //{
            //    var xValue = i * .5 + 1; 
            //    var yValue = 4 - i * .5;
            //    var newPoints = new[] { xValue, yValue };
            //    points.Add(newPoints);
            //}

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
            //if(chart1.InvokeRequired)
            //{
            //    chart1.Invoke(new MethodInvoker(delegate
            //    {
            //        button1.Enabled = true;
            //        button2.Enabled = false;
            //    }));
            //}
            chart1.Series.Clear();
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var role = _tspiRoles.ElementAt(index);
                var serie = new Series
                {
                    Name = $"{role.Name} ({Math.Round(role.X, 2)}, {Math.Round(role.Y, 2)})",
                    ChartType = SeriesChartType.Point
                };
                serie.Points.AddXY(role.X, role.Y);
                chart1.Series.Add(serie);
            }

        }
        private void GetNewXValue()
        {
            var newXValues = new List<double[]>();
            var rand = new Random();
            //var a = rand.Next(0, 11);
            var a = 7;
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var rol = _tspiRoles.ElementAt(index);
                for(var index2 = 0; index2 < rol.InteractiveStyles.Length; index2++)
                {

                }
                var newPos = new[] { PosX(rol, a), PosY(rol, a) };
                newXValues.Add(newPos);
            }
        }
        private void GetNextPoints()
        {
            var newPoints = new List<double[]>();
            var rand = new Random();
            //var a = rand.Next(0, 11);
            var a = 7;
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
        private void UpdateX()
        {

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
            //¿El rol anterior del primer rol (TL) es el último? ¿O se refiere al "tiempo" o "iteración"?
            /*var previusRole = rol.Index == 0 ? _tspiRoles.ElementAt(_tspiRoles.Count - 1) : _tspiRoles.ElementAt(rol.Index - 1);//Se obtiene el rol anterior
            var posX = previusRole.X;//Se obtiene la posicion en X del rol anterior
            var posY = previusRole.Y;//Se obtiene la posicion en Y del rol anterior*/
            var posX = rol.X;
            var posY = rol.Y;

            var step1 = 0.0; //Primer suumatoria de la ecuación
            var step2 = 0.0;//Segunda sumatoria de la ecuación
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = _tspiRoles[index];
                //if (n == previusRole) continue;
                if (n == rol) continue;
                var d = Distance(rol, n);
                if (d > _ratio) continue;
                step1 += (n.X - posX) / d;
                step2 += (double)n.InteractiveStyles[a, 1]; //Para el paso 3, ¿sólo hace la sumatoria de las X de los vecinos o de todos?

            }
            //for (var index = 0; index < _tspiRoles.Count; index++) //Hace la sumatoria del paso 2 sólo de los vecinos
            //{
            //    var n = _tspiRoles[index];
            //    if (n == rol) continue;
            //    step2 += (double)n.InteractiveStyles[a, 1]; //Para el paso 3, ¿sólo hace la sumatoria de las X de los vecinos o de todos?
            //}

            var step3 = (double)rol.InteractiveStyles[a, 1] * step2;
            var step4 = _gamma * step1 * step3;
            var result = posX + step4;

            if (result > _xMax)
                result %= _xMax;
            if (result < 0)
            {
                result %= _xMax;
                result += _xMax;
            }
            return result;

        }
        private double PosY(TSPiRole rol, int a)
        {
            //¿El rol anterior del primer rol (TL) es el último? ¿O se refiere al "tiempo" o "iteración"?
            /*var previusRole = rol.Index == 0 ? _tspiRoles.ElementAt(_tspiRoles.Count - 1) : _tspiRoles.ElementAt(rol.Index - 1);//Se obtiene el rol anterior
            var posX = previusRole.X;//Se obtiene la posicion en X del rol anterior
            var posY = previusRole.Y;//Se obtiene la posicion en Y del rol anterior*/
            var posX = rol.X;
            var posY = rol.Y;

            var step1 = 0.0; //Primer suumatoria de la ecuación
            var step2 = 0.0;//Segunda sumatoria de la ecuación
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = _tspiRoles[index];
                //if (n == previusRole) continue;
                if (n == rol) continue;
                var d = Distance(rol, n);
                if (d > _ratio) continue; //Por el momento, todos son vecinos :) 
                step1 += (n.Y - posY) / d;
                step2 += (double)n.InteractiveStyles[a, 1]; //Para el paso 3, ¿sólo hace la sumatoria de las X de los vecinos o de todos?

            }
            //for (var index = 0; index < _tspiRoles.Count; index++)
            //{
            //    var n = _tspiRoles[index];
            //    if (n == rol) continue;
            //    step2 += (double)n.InteractiveStyles[a, 1]; //Para el paso 3, ¿sólo hace la sumatoria de las X de los vecinos o de todos?
            //}

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
        private double Distance(TSPiRole role1, TSPiRole role2)
        {
            var distances = new List<double>();
            var x1 = role1.X;
            var y1 = role1.Y;
            var x2 = role2.X;
            var y2 = role2.Y;
            var nx1 = role1.X + _xMax;
            var nx2 = role1.X - _xMax;
            var ny1 = role1.Y + _yMax;
            var ny2 = role1.Y - _yMax;
            distances.Add(Distance(x1, y1, x2, y2));
            distances.Add(Distance(nx1, y1, x2, y2));
            distances.Add(Distance(nx2, y1, x2, y2));
            distances.Add(Distance(x1, ny1, x2, y2));
            distances.Add(Distance(x1, ny2, x2, y2));
            distances.Add(Distance(nx1, ny1, x2, y2));
            distances.Add(Distance(nx2, ny2, x2, y2));
            distances.Add(Distance(nx1, ny2, x2, y2));
            distances.Add(Distance(nx2, ny1, x2, y2));

            distances.Sort();

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
                UpdateX();
                UpdatePoints();
            }
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
            var delegado = new ThreadStart(Run);
            var hilo = new Thread(delegado);
            hilo.Start();
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
