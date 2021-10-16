using System.Media;

namespace Game.Classes
{
     class Character
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
        public virtual void playDeathSound()
        {
            //Play Soun
            SoundPlayer defaultDeathSound = new SoundPlayer(Properties.Resources.defaultDeathSound);

            defaultDeathSound.Play();
        }
    }
}
