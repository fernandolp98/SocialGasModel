using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TSPiRole
    {
        public string Name { get; set; }
        public double[] InteractiveStyles { get; set; }

        public int Index { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public TSPiRole()
        {
            
        }
        public static List<TSPiRole> getRoles()
        {
            var roles = new List<TSPiRole>
            {
                new TSPiRole()
                {
                    Index = 0,
                    Name = "TL",
                },
                new TSPiRole()
                {
                    Index = 1,
                    Name = "PM",
                },
                new TSPiRole()
                {
                    Index = 2,
                    Name = "QM",
                },
                new TSPiRole()
                {
                    Index = 3,
                    Name = "SM",
                },
                new TSPiRole()
                {
                    Index = 4,
                    Name = "DS",
                },
                new TSPiRole()
                {
                    Index = 5,
                    Name = "IM",
                },
                new TSPiRole()
                {
                    Index = 6,
                    Name = "TM",
                },
            };
            return roles;
        }

        public static List<double[]> GetInteractiveStyles()
        {
            var interactiveStyles = new List<double[]>
            {
                new[] {5.0, 5.0, 5.0, 5.0, 3.0, 2.0, 3.0, 2.0, 5.0, 5.0, 1.0, 5.0},
                new[] {4.0, 4.0, 4.0, 5.0, 3.0, 1.0, 1.0, 1.0, 3.0, 4.0, 1.0, 5.0},
                new[] {4.0, 0.0, 4.0, 4.0, 1.0, 1.0, 2.0, 0.0, 4.0, 4.0, 0.0, 3.0},
                new[] {2.0, 3.0, 3.0, 3.0, 5.0, 3.0, 2.0, 2.0, 4.0, 4.0, 2.0, 3.0},
                new[] {3.0, 5.0, 5.0, 4.0, 5.0, 1.0, 5.0, 4.0, 4.0, 4.0, 3.0, 3.0},
                new[] {4.0, 4.0, 4.0, 4.0, 4.0, 1.0, 4.0, 4.0, 3.0, 4.0, 3.0, 5.0},
                new[] {3.0, 5.0, 5.0, 4.0, 3.0, 2.0, 4.0, 4.0, 4.0, 4.0, 1.0, 1.0}
            };

            return interactiveStyles;
        }
    }
}
