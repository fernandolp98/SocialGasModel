using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public partial class Form1 : Form
    {
        private List<TSPiRole> _TSPIRoles;
        private double _gamma;
        private double _ratio;

        private double _xMax;
        private double _yMax;

        public Form1()
        {
            InitializeComponent();
            _TSPIRoles = new List<TSPiRole>
            {
                new TSPiRole()
                {
                    Name = "TL",
                    InteractiveStyles = new object[12,2]
                    {
                        { "DM", 5 },
                        { "AT", 5 },
                        { "FT", 5 },
                        { "AP", 5 },
                        { "FC", 3 },
                        { "TT", 2 },
                        { "CY", 3 },
                        { "TR", 2 },
                        { "DS", 5 },
                        { "RS", 5 },
                        { "IM", 1 },
                        { "CR", 5 },
                    }
                },
                new TSPiRole()
                {
                    Name = "PM",
                    InteractiveStyles = new object[12,2]
                    {
                        { "DM", 4 },
                        { "AT", 4 },
                        { "FT", 4 },
                        { "AP", 5 },
                        { "FC", 3 },
                        { "TT", 1 },
                        { "CY", 1 },
                        { "TR", 1 },
                        { "DS", 3 },
                        { "RS", 4 },
                        { "IM", 1 },
                        { "CR", 5 },
                    }
                },
                new TSPiRole()
                {
                    Name = "QM",
                    InteractiveStyles = new object[12,2]
                    {
                        { "DM", 4 },
                        { "AT", 0 },
                        { "FT", 4 },
                        { "AP", 4 },
                        { "FC", 1 },
                        { "TT", 1 },
                        { "CY", 2 },
                        { "TR", 0 },
                        { "DS", 4 },
                        { "RS", 4 },
                        { "IM", 0 },
                        { "CR", 3 },
                    }
                },
                new TSPiRole()
                {
                    Name = "SM",
                    InteractiveStyles = new object[12,2]
                    {
                        { "DM", 5 },
                        { "AT", 5 },
                        { "FT", 5 },
                        { "AP", 5 },
                        { "FC", 3 },
                        { "TT", 2 },
                        { "CY", 3 },
                        { "TR", 2 },
                        { "DS", 5 },
                        { "RS", 5 },
                        { "IM", 1 },
                        { "CR", 5 },
                    }
                },
                new TSPiRole()
                {
                    Name = "DS",
                    InteractiveStyles = new object[12,2]
                    {
                        { "DM", 3 },
                        { "AT", 5 },
                        { "FT", 5 },
                        { "AP", 4 },
                        { "FC", 5 },
                        { "TT", 1 },
                        { "CY", 5 },
                        { "TR", 4 },
                        { "DS", 4 },
                        { "RS", 4 },
                        { "IM", 3 },
                        { "CR", 3 },
                    }
                },
                new TSPiRole()
                {
                    Name = "IM",
                    InteractiveStyles = new object[12,2]
                    {
                        { "DM", 4 },
                        { "AT", 4 },
                        { "FT", 4 },
                        { "AP", 4 },
                        { "FC", 4 },
                        { "TT", 1 },
                        { "CY", 4 },
                        { "TR", 4 },
                        { "DS", 3 },
                        { "RS", 4 },
                        { "IM", 3 },
                        { "CR", 5 },
                    }
                },
                new TSPiRole()
                {
                    Name = "IM",
                    InteractiveStyles = new object[12,2]
                    {
                        { "DM", 3 },
                        { "AT", 5 },
                        { "FT", 5 },
                        { "AP", 4 },
                        { "FC", 3 },
                        { "TT", 2 },
                        { "CY", 4 },
                        { "TR", 4 },
                        { "DS", 4 },
                        { "RS", 4 },
                        { "IM", 1 },
                        { "CR", 1 },
                    }
                }
            };

            _gamma = 0.01;
            _ratio = 1;
            _xMax = 4;
            _yMax = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int index = 0; index<_TSPIRoles.Count(); index++)
            {
                var currentRole = _TSPIRoles.ElementAt(index);
                if (true)
                {
                    var guid = Guid.NewGuid();
                    var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                    var seed = int.Parse(justNumbers.Substring(0, 4));
                    var random = new Random(seed);
                    var xValue = random.NextDouble() * (_xMax - 0) + 0;
                    var yValue = random.NextDouble() * (_yMax - 0) + 0;
                    currentRole.X = xValue;
                    currentRole.Y = yValue;
                }
                Console.WriteLine($"{currentRole.Name} -> X: {currentRole.X}, Y: {currentRole.Y}");
            }
        }
    }
}
