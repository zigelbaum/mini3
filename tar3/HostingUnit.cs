using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tar3
{
   public class HostingUnit
    {
        private string UnitName;
        private int Rooms;
        private bool IsSwimmingPool;
        public List <DateTime> AllOrders { get; set; }
        public List <string> Uris { get; set; }

        public string UnitName1 { get => UnitName; set => UnitName = value; }
        public int Rooms1 { get => Rooms; set => Rooms = value; }
        public bool IsSwimmingPool1 { get => IsSwimmingPool; set => IsSwimmingPool = value; }
    }
}
