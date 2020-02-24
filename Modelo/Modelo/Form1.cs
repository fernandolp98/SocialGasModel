using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modelo
{
    public partial class Form1 : Form
    {
        private readonly List<TSPiRole> _tspiRoles;
        private readonly double _gamma;
        //private double _ratio;

        private readonly double _xMax;
        private readonly double _yMax;
        //private readonly double _ratio;

        private List<List<double[]>> _pointsHistory;
        private int _currentIndexHistory;

        public Form1()
        {
            InitializeComponent();
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
                    Index = 7,
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

            _gamma = 0.01;
            //_ratio = 0;
            _xMax = 4;
            _yMax = 4;
            _pointsHistory = new List<List<double[]>>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var points = new List<double[]>();
            for(var index = 0; index<_tspiRoles.Count(); index++)
            {
                if (true)
                {
                    var guid = Guid.NewGuid();
                    var justNumbers = new string(guid.ToString().Where(Char.IsDigit).ToArray());
                    var seed = int.Parse(justNumbers.Substring(0, 4));
                    var random = new Random(seed);
                    var xValue = random.NextDouble() * (_xMax - 0) + 0;
                    var yValue = random.NextDouble() * (_yMax - 0) + 0;
                    var newPoints = new [] {xValue, yValue};
                    points.Add(newPoints);
                }
            }

            _currentIndexHistory = 0;
            _pointsHistory.Add(points);
            UpdatePoints();
        }

        private void PrintPoints(TSPiRole role)
        {
            if(role.Index == 0)
                Console.WriteLine(@"------------------------------------------------");
            Console.WriteLine($@"{role.Name} -> X: {role.X}, Y: {role.Y}");
        }

        private void UpdateChart()
        {
            chart1.Series.Clear();
            for (var index = 0; index < _tspiRoles.Count(); index++)
            {
                var role = _tspiRoles.ElementAt(index);
                var serie = new Series
                {
                    Name = role.Name,
                    ChartType = SeriesChartType.Point,
                };
                serie.Points.AddXY(role.X, role.Y);
                chart1.Series.Add(serie);
            }
        }

        private void GetNextPoints()
        {
            var newPoints = new List<double[]>();
            for (var index = 0; index < _tspiRoles.Count(); index++)
            {
                var rol = _tspiRoles.ElementAt(index);
                var newPos = new[]{PosX(rol),PosY(rol)};
                newPoints.Add(newPos);
            }
            _pointsHistory.Add(newPoints);
            _currentIndexHistory = _pointsHistory.Count - 1;
            UpdatePoints();
        }

        private void UpdatePoints()
        {
            var points = _pointsHistory.ElementAt(_currentIndexHistory);
            for (var index = 0; index < _tspiRoles.Count(); index++)
            {
                var rol = _tspiRoles.ElementAt(index);
                rol.X = points.ElementAt(index)[0];
                rol.Y = points.ElementAt(index)[1];
                PrintPoints(rol);
            }
            UpdateChart();
            lblTime.Text = $@"{_currentIndexHistory + 1}/{_pointsHistory.Count}";
        }

        private double PosX(TSPiRole rol)
        {
            //¿El rol anterior del primer rol (TL) es el último?
            var precendingRol = rol.Index == 0 ? _tspiRoles.ElementAt(_tspiRoles.Count - 1) : _tspiRoles.ElementAt(rol.Index - 1);//Se obtiene el rol anterior
            var posX = precendingRol.X;//Se obtiene la posicion en X del rol anterior
            var posY = precendingRol.Y;//Se obtiene la posicion en Y del rol anterior
            var step1 = 0.0; //Primer suumatoria de la ecuación
            var step2 = 0.0;//Segunda sumatoria de la ecuación
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = _tspiRoles[index];
                if (n == precendingRol) continue;
                var d = Math.Sqrt(Math.Pow(n.X - posX, 2) + Math.Pow(n.Y - posY, 2));
                //if (d > _ratio) continue; //Por el momento, todos son vecinos :) 
                step1 += (n.X - posX) / d;
            }
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = _tspiRoles[index];
                if (n == rol) continue;
                step2 += (double)n.InteractiveStyles[0, 1]; //Para el paso 3, ¿sólo hace la sumatoria de las X de los vecinos o de todos?
            }

            var step3 = (double)rol.InteractiveStyles[0, 1] * step2;
            var step4 = _gamma * step1 * step3;
            var result = posX + step4;
            return result;
        }
        private double PosY(TSPiRole rol)
        {
            //¿El rol anterior del primer rol (TL) es el último?
            var precendingRol = rol.Index == 0 ? _tspiRoles.ElementAt(_tspiRoles.Count - 1) : _tspiRoles.ElementAt(rol.Index - 1);//Se obtiene el rol anterior
            var posX = precendingRol.X;//Se obtiene la posicion en X del rol anterior
            var posY = precendingRol.Y;//Se obtiene la posicion en Y del rol anterior
            var step1 = 0.0; //Primer sumatoria de la ecuación
            var step2 = 0.0;//Segunda sumatoria de la ecuación
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = _tspiRoles[index];
                if (n == precendingRol) continue;
                var d = Math.Sqrt(Math.Pow(n.X - posX, 2) + Math.Pow(n.Y - posY, 2));
                //if (d > _ratio) continue; //Por el momento, todos son vecinos :) 
                step1 += (n.Y - posY) / d;
            }
            for (var index = 0; index < _tspiRoles.Count; index++)
            {
                var n = _tspiRoles[index];
                if (n == rol) continue;
                step2 += (double)n.InteractiveStyles[0, 1]; //Para el paso 3, ¿sólo hace la sumatoria de las X de los vecinos o de todos?
            }
            var step3 = (double)rol.InteractiveStyles[0, 1] * step2;
            var step4 = _gamma * step1 * step3;
            var result = posY + step4;
            return result;
        }

        private void pboxAdd_Click(object sender, EventArgs e)
        {
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
    }
}
