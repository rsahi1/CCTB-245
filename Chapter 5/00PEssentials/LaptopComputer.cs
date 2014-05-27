using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00PEssentials
{
    public class LaptopComputer : Computer
    {
         public double MonitorSize  { get; set; }

         public override void Purchase()
         {
             Console.Write("A " + MonitorSize + "Laptop ");
             base.Purchase();
         }
    }

public class DesktopComputer : Computer
{
  public string Chassis { get; set; }
}
}
