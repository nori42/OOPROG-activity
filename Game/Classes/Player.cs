using System.Media;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System;

namespace Game.Classes
{
    class Player : Character
    {
        public int Mana { get; set; }
        public int SkillDamage { get; }
        public int ManaRegen { get; } = 20;
        public int SkillManaCost { get; } = 80;

        
        public Player(int _health, int _basicDamage, int _armor, int _mana, int _skillDamage ,PictureBox _characterBox)
        {
            health = _health;
            basicDamage = _basicDamage;
            armor = _armor;
            Mana = _mana;
            SkillDamage = _skillDamage;
            characterBox = _characterBox;
        }

        public Player()
        {
        }
        void channelSkillAnimation(PictureBox attackBox)
        {
            SoundPlayer fireBallSound = new SoundPlayer(Properties.Resources.fireballSound);
            fireBallSound.Play();
            WaitEvent.Wait(200);//Delay to match with sound
            int animationDuration = 1200;
            int miliSecPerFrame;
            int startLocX = characterBox.Location.X + characterBox.Width;
            int startLocY = characterBox.Location.Y;
            Point startLocationSprite = new Point(startLocX, startLocY);
            int frameSprite = 0;
            int timeElapse = 0;

            Bitmap[] fireBallChannelSprite =
            {
                Properties.Resources.fireball_1,
                Properties.Resources.fireball_2,
                Properties.Resources.fireball_3,
                Properties.Resources.fireball_4,
                Properties.Resources.fireball_5,
                Properties.Resources.fireball_6,
                Properties.Resources.fireball_7,
                Properties.Resources.fireball_8
            };

     
            

            attackBox.Location = startLocationSprite;
            attackBox.Visible = true;

            miliSecPerFrame = animationDuration / fireBallChannelSprite.Length;

            while (timeElapse <= animationDuration)
            {
                if (frameSprite > fireBallChannelSprite.Length - 1)
                {
                    break;
                }

                attackBox.Image = fireBallChannelSprite[frameSprite];
                frameSprite++;
                WaitEvent.Wait(miliSecPerFrame);
            }
        }

        public void dealMagicDamageToEnemy(Enemy target, Label damageLabel, ListBox actionLog)
        {
            Random damageRange = new Random();
            int damageDealt;

            if (SkillDamage < 5)
            {
                
                if (SkillDamage > 1)
                {
                    damageDealt = (damageRange.Next(1, SkillDamage)) - target.MagicResistance;
                }
                else
                {
                    damageDealt = 0;
                }
            }
            else
            {
                damageDealt = (damageRange.Next(SkillDamage - 5, SkillDamage)) - target.MagicResistance;
            }
            
            target.Health -= damageDealt - target.MagicResistance;

            if(target.Health < 0)
            {
                target.Health = 0;
            }

            actionLog.Items.Add("Player uses basic attack and deals "+damageDealt+" magic damage");

            damageLabel.Text = damageDealt.ToString();
            damageLabel.ForeColor = Color.Blue;

        }

        public void dealBasicDamage(Enemy target,Label damageLabel,ListBox actionLog)
        {
            Random randNum = new Random();
            int missChance = 20;
            int criticalChance = 30;


            if (randNum.Next(1, 100) > missChance)
            {
                if (randNum.Next(1, 100) <= criticalChance)
                {
                    int damageDealt;
                    if(basicDamage < 5)
                    {
                        

                        if (basicDamage > 1)
                        {
                            damageDealt = randNum.Next(1, basicDamage) * 2 - target.Armor; ;
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

                    actionLog.Items.Add("Player uses basic attack and deals " + damageDealt + " critical damage");

                    damageLabel.ForeColor = Color.Red;
                    damageLabel.Text = damageDealt.ToString();
                }
                else
                {
                    int damageDealt;

                    if(basicDamage < 5)
                    {
                        if (basicDamage > 1)
                        {
                            damageDealt = randNum.Next(1, basicDamage) - target.Armor; ;
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

                    actionLog.Items.Add("Player uses basic attack and deals "+damageDealt+" damage");

                    damageLabel.ForeColor = Color.DarkOrange;
                    damageLabel.Text = damageDealt.ToString();
                }
            }
            else
            { 
                actionLog.Items.Add("Player uses basic attack and miss");
                damageLabel.Text = "Miss";
                damageLabel.ForeColor = Color.DarkGray;
            }

            if (target.Health < 0)
            {
                target.Health = 0;
            }

        }

        void attackMoveAnimation (PictureBox attackBox, PictureBox enemyBox,Bitmap spriteAttack,int _speed)
        {
            int speed = _speed;

            attackBox.Image = spriteAttack;

            attackBox.Visible = true;

            while (attackBox.Location.X < enemyBox.Location.X - attackBox.Width)
            {
                attackBox.Location = new Point(attackBox.Location.X + speed, attackBox.Location.Y);
                WaitEvent.Wait(33);
            }
            attackBox.Visible = false;
        }

        public void useBasicAttack(PictureBox enemyBox, PictureBox attackBox, Enemy target,Label damageLabel,ListBox actionLog)
        {
            int startLocX = characterBox.Location.X + characterBox.Width;
            int startLocY = characterBox.Location.Y;
            Point startLocationSprite = new Point(startLocX, startLocY);

            attackBox.Location = startLocationSprite;

            SoundPlayer basicAttackSound = new SoundPlayer(Properties.Resources.pewSound);
            basicAttackSound.Play();

            attackMoveAnimation(attackBox, enemyBox, Properties.Resources.fireball_4, 15);
            dealBasicDamage(target, damageLabel,actionLog);
        }

        public void UseSkill(PictureBox enemyBox,PictureBox attackBox,Label damageLabel,Enemy enemy, ListBox actionLog)
        {
            
            channelSkillAnimation(attackBox);
            attackMoveAnimation(attackBox, enemyBox,Properties.Resources.fireBallMoving, 8);
            SoundPlayer explodeSound = new SoundPlayer(Properties.Resources.explodeSound);
            explodeSound.Play();
            dealMagicDamageToEnemy(enemy, damageLabel,actionLog);
            WaitEvent.Wait(800);
            Mana += ManaRegen;
        }
  
        public override void playDeathSound()
        {
            SoundPlayer playerDeathSound = new SoundPlayer(Properties.Resources.maleDeathSound);

            playerDeathSound.Play();
        }
    }

}
