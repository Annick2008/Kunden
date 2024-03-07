using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunden;

public class Vip : Kunde
{
    public override double GetRabatt()
    {
        // Was bedeutet das?
        // return base.GetRabatt() + 5;
        return 5;
    }
}
