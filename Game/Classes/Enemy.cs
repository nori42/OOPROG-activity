using System.Media;

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
        public override void playDeathSound()
        {
            SoundPlayer enemyDeathSound = new SoundPlayer(Properties.Resources.ogreDeathSound);

            enemyDeathSound.Play();
        }
    }
}
