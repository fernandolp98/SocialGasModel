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

        public double X { get; set; }
        public double Y { get; set; }
        public TSPiRole()
        {
            
        }
        public TSPiRole(string name)
        {
            Name = name;
        }
    }
}
