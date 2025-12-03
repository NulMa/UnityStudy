using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityStudy
{
    class Wizard {
        int mp;
        int intell;

        public Wizard() {
            this.mp = 50;
            this.intell = 20;
            Console.WriteLine($"Wizard's MP: {this.mp}\nStat\nINT: {this.intell}");
        }
    }

}
