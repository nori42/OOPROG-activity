using System.Media;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System;

namespace Game.Classes
{
    class Enemy : Character
    {
        int magicResistance;
        public int MagicResistance { get { return magicResistance; } }
        public Enemy(int _health, int _basicDamage, int _armor, int _magicResistance, PictureBox _characterBox)
        {
            health = _health;
            basicDamage = _basicDamage;
            armor = _armor;
            magicResistance = _magicResistance;
            characterBox = _characterBox;
        }
        public Enemy()
        {
        }

        public void dealBasicDamage(Player target, Label damageLabel, ListBox actionLog)
        {
            Random randNum = new Random();
            int missChance = 20;
            int criticalChance = 30;


            if (randNum.Next(1, 100) > missChance)
            {
                if (randNum.Next(1, 100) <= criticalChance)
                {
                    int damageDealt;
                    if (basicDamage < 5)
                    {
                        if (basicDamage > 1)
                        {
                            damageDealt = randNum.Next(1, basicDamage) - target.Armor;
                        }
                        else
                        {
                            damageDealt = 0;
                        }

                    }
                    else
                    {
                        damageDealt = randNum.Next(basicDamage - 5, basicDamage) * 2 - target.Armor;
                    }
                    target.Health -= damageDealt;

                    actionLog.Items.Add("Enemy uses basic attack and deals " + damageDealt + " critical damage");

                    damageLabel.ForeColor = Color.Red;
                    damageLabel.Text = damageDealt.ToString();
                }
                else
                {
                    int damageDealt;
                    if (basicDamage < 5)
                    {
                        if(basicDamage > 1)
                        {
                            damageDealt = randNum.Next(1, basicDamage) - target.Armor;
                        }
                        else
                        {
                            damageDealt = 0;
                        }
                    }
                    else
                    {
                        damageDealt = randNum.Next(basicDamage - 5, basicDamage) - target.Armor;
                    }
                    target.Health -= damageDealt;

                    actionLog.Items.Add("Enemy uses basic attack and deals " + damageDealt + " damage");

                    damageLabel.ForeColor = Color.DarkOrange;
                    damageLabel.Text = damageDealt.ToString();
                }
            }
            else
            {
                actionLog.Items.Add("Enemy uses basic attack and miss");
                damageLabel.Text = "Miss";
                damageLabel.ForeColor = Color.DarkGray;
            }

            if (target.Health < 0)
            {
                target.Health = 0;
            }

        }

        void attackMoveAnimation(PictureBox attackBox, PictureBox playerBox, Bitmap spriteAttack, int _speed)
        {
            int speed = _speed;

            attackBox.Image = spriteAttack;

            attackBox.Visible = true;

            while (attackBox.Location.X >= playerBox.Location.X + playerBox.Width)
            {
                attackBox.Location = new Point(attackBox.Location.X - speed, attackBox.Location.Y);
                WaitEvent.Wait(33);
            }
            attackBox.Visible = false;
        }

        public void useBasicAttack(PictureBox playerBox, PictureBox enemyBox, PictureBox attackBox,Player target, Label damageLabel, ListBox actionLog)
        {
            int startLocX = enemyBox.Location.X - attackBox.Width;
            int startLocY = enemyBox.Location.Y;
            Point startLocationSprite = new Point(startLocX, startLocY);

            attackBox.Location = startLocationSprite;

            SoundPlayer basicAttackSound = new SoundPlayer(Properties.Resources.rockSound);
            basicAttackSound.Play();

            attackMoveAnimation(attackBox, playerBox, Properties.Resources.rock, 12);
            dealBasicDamage(target, damageLabel, actionLog);
        }

        public override void playDeathSound()
        {
            SoundPlayer enemyDeathSound = new SoundPlayer(Properties.Resources.ogreDeathSound);

            enemyDeathSound.Play();
        }
    }
}
