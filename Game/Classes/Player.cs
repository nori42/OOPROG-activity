using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    class Player : Character
    {

        int manaCost = 80;
        int manaRegen = 20;
        public int Mana { get; set; }
        public int SkillDamage { get; set; }
        public int SkillManaCost { get { return manaCost; } }
        public int ManaRegen { get { return manaRegen; } set { manaRegen = value; } }

        public Player(int _health, int _basicDamage, int _armor, int _mana, int _skillDamage)
        {
            health = _health;
            basicDamage = _basicDamage;
            armor = _armor;
            Mana = _mana;
            SkillDamage = _skillDamage;
        }

        public Player()
        {
        }
        public override void BasicAttackLog()
        {

        }

        public void UseSkill()
        {
            Mana -= 60;
        }
    }
}
