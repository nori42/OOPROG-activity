using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    class Enemy : Character
    {
        public int MagicResistance { get; set; }
        public Enemy(int _health, int _basicDamage, int _armor, int _magicResistance)
        {
            health = _health;
            basicDamage = _basicDamage;
            armor = _armor;
            MagicResistance = _magicResistance;
        }

        public Enemy()
        {
        }
        public override void BasicAttackLog()
        {

        }
    }
}
