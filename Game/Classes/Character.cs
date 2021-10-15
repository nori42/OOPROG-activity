using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    abstract class Character
    {
        protected int health;
        protected int basicDamage;
        protected int armor;

        public int Health {
            get { return health; }
            set { health = value; }
        }

        public int BasicDamage {
            get { return basicDamage; }
            set { basicDamage = value; }
        }

        public int Armor {
            get { return armor; }
            set { armor = value; }
        }
        public bool Turn { get; set; }

        public abstract void BasicAttackLog();
    }
}
