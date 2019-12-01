using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tar3
{
    public class Host
    {
        private string HostName;
        private List<HostingUnit> Units;

        public string HostName1 { get => HostName; set => HostName = value; }
        internal List<HostingUnit> Units1 { get => Units; set => Units = value; }
    }
}
