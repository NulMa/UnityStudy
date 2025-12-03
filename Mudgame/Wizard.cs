using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityStudy
{

    abstract class Player {
        public int hp;
        public int mp;
        public int jobStat;

        public abstract void useSkill();
    }
    class Wizard : Player {

        public override void useSkill() {
            Console.WriteLine("마법사가 스킬을 사용합니다.");
        }

        public Wizard() {
            hp = 50;
            mp = 50;
            
            Console.WriteLine($"Wizard's MP: {mp}");
        }
    }

}
