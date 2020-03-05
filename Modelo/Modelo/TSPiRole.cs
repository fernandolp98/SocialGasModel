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
        public object[,] InteractiveStyles { get; set; }

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
                },
            };
            return roles;
        }
    }
}
