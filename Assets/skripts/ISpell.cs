using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.skripts
{
    public interface ISpell
    {
        int Cd { get; set; }
        int Mana { get; set; }
        int Scaling { get; set; }

        void Cast();
    }
}
