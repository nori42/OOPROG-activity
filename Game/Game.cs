using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Game.Classes;
using System.Media;

namespace Game
{
    public partial class Game : Form
    {
        Player player = new Player();
        Enemy enemy = new Enemy();
        public const int FRAME_PER_SEC = 30;
        int playerMaxMana;
        Thread IdleAnimation2;
        Thread IdleAnimation;
        public void WaitEvent(int milliseconds)
        {
            var waitTimer = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            waitTimer.Interval = milliseconds;
            waitTimer.Enabled = true;
            waitTimer.Start();

            waitTimer.Tick += (s, e) =>
            {
                waitTimer.Enabled = false;
                waitTimer.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (waitTimer.Enabled)
            {
                Application.DoEvents();
            }
        }

        void UpdatePlayerSize(int h)
        {
            characterPlayer.Size = new Size(characterPlayer.Width, characterPlayer.Height - h);
            characterPlayer.Location = new Point(characterPlayer.Location.X, characterPlayer.Location.Y + h);
        }
        void UpdateEnemySize(int h)
        {
            characterEnemy.Size = new Size(characterEnemy.Width, characterEnemy.Height - h);
            characterEnemy.Location = new Point(characterEnemy.Location.X, characterEnemy.Location.Y + h);
        }

        delegate void UpdateSizeDelagate(int h);
        void StartIdleCharacterAnimation()
        {
            //Seperating the animation thread from the main thread for background animation
            IdleAnimation = new Thread(() => {
                int frame = 1;
                int maxFrame = 6; // Count frames of the animation

                while (true)
                {
                    if (frame > maxFrame)
                    {
                        frame = 1;
                    }

                    //Change the size every 200ms

                    if (IsHandleCreated)
                    {
                        if (frame <= 3)
                        {
                            characterPlayer.BeginInvoke(new UpdateSizeDelagate(UpdatePlayerSize), 2);
                            WaitEvent(200);
                        }
                        else
                        {
                            characterPlayer.BeginInvoke(new UpdateSizeDelagate(UpdatePlayerSize), -2);
                            WaitEvent(200);
                        }
                        frame++;
                    }
                }
            });

            IdleAnimation2 = new Thread(() => {
                int frame = 1;
                int maxFrame = 8; // Count frames of the animation

                while (true)
                {
                    if (frame > maxFrame)
                    {
                        frame = 1;
                    }

                    if (IsHandleCreated)
                    {
                        //Change the size every 200ms
                        if (frame <= 4)
                        {
                            characterEnemy.BeginInvoke(new UpdateSizeDelagate(UpdateEnemySize), 2);
                            WaitEvent(200);
                        }
                        else
                        {
                            characterEnemy.BeginInvoke(new UpdateSizeDelagate(UpdateEnemySize), -2);
                            WaitEvent(200);
                        }
                    }

                    frame++;
                }
            });

            IdleAnimation2.IsBackground = true;
            IdleAnimation.IsBackground = true;
            IdleAnimation2.Start();
            IdleAnimation.Start();

        }

        public Game()
        {
            InitializeComponent();


        }


        private void btnDefaultStart_Click(object sender, EventArgs e)
        {
            player = new Player(120, 28, 10, 200, 68);

            playerMaxMana = player.Mana;

            enemy = new Enemy(210, 31, 6, 9);

            //Initialize the stats
            healthBarPlayer.Maximum = player.Health;
            healthBarPlayer.Value = player.Health;
            healthBarEnemy.Maximum = enemy.Health;
            healthBarEnemy.Value = enemy.Health;

            valueHealth.Text = player.Health.ToString();
            valueArmor.Text = player.Armor.ToString();
            valueBasicDamage.Text = player.BasicDamage.ToString();
            valueChangeable.Text = player.Mana.ToString();
            valueChangeable2.Text = player.SkillDamage.ToString();


            //Info on attacks and skill
            string basicDamageInfo = "Deals " + player.BasicDamage + " - " + (player.BasicDamage - 5) + " damage";
            string skillDamageInfo = "Deals " + player.SkillDamage + " - " + (player.SkillDamage - 5) + " magic damage and cost 80 mana in use";

            basicAttackInfo.SetToolTip(attackButton, basicDamageInfo);
            fireBallInfo.SetToolTip(skillButton, skillDamageInfo);

            skillButton.Enabled = true;
            attackButton.Enabled = true;
            mainMenu.Visible = false;
            StartIdleCharacterAnimation();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int playerHealth = Convert.ToInt32(txtBoxHealth.Text);
                int playerMana = Convert.ToInt32(txtBoxMana.Text);
                int playerDamage = Convert.ToInt32(txtBoxDamage.Text);
                int playerArmor = Convert.ToInt32(txtBoxArmor.Text);
                int playerSkillDamage = Convert.ToInt32(txtBoxSkillDamage.Text);

                int enemyHealth = Convert.ToInt32(txtBoxHealth2.Text);
                int enemyDamage = Convert.ToInt32(txtBoxDamage2.Text);
                int enemyArmor = Convert.ToInt32(txtBoxArmor2.Text);
                int enemyMagicResistance = Convert.ToInt32(txtBoxMagicResistance.Text);
                player = new Player(playerHealth, playerDamage, playerArmor, playerMana, playerSkillDamage);
                enemy = new Enemy(enemyHealth, enemyDamage, enemyArmor, enemyMagicResistance);
            }
            catch
            {
                MessageBox.Show("Input must be an integer and not empty");
                return;
            }

            if (player.Health == 0 || enemy.Health == 0)
            {
                MessageBox.Show("Health must not equal to 0");
                return;
            }

            //Initialize the stats
            healthBarPlayer.Maximum = player.Health;
            healthBarPlayer.Value = player.Health;
            healthBarEnemy.Maximum = enemy.Health;
            healthBarEnemy.Value = enemy.Health;

            valueHealth.Text = player.Health.ToString();
            valueArmor.Text = player.Armor.ToString();
            valueBasicDamage.Text = player.BasicDamage.ToString();
            valueChangeable.Text = player.Mana.ToString();
            valueChangeable2.Text = player.SkillDamage.ToString();


            //Info on attacks and skill
            string basicDamageInfo = "Deals " + player.BasicDamage + " - " + (player.BasicDamage - 5) + " damage";
            string skillDamageInfo = "Deals " + player.SkillDamage + " - " + (player.SkillDamage - 5) + " magic damage and cost 80 mana in use";

            basicAttackInfo.SetToolTip(attackButton, basicDamageInfo);
            fireBallInfo.SetToolTip(skillButton, skillDamageInfo);

            skillButton.Enabled = true;
            attackButton.Enabled = true;
            mainMenu.Visible = false;
            StartIdleCharacterAnimation();

        }

        //Moves the projectile in the screem
        void AnimateAttackV2(Bitmap sprite, Point location, int animationDuration, int projectileSpeed, int distanceTarget, bool isRight)
        {
            int miliSecPerFrame = animationDuration / FRAME_PER_SEC;
            //int spriteFrame = 0;
            int distanceT = 0;

            attackSpriteHolder.Location = location;
            attackSpriteHolder.Image = sprite;
            attackSpriteHolder.Visible = true;

            while (distanceT <= distanceTarget)
            {
                //spriteFrame++;

                //if (spriteFrame > sprite.Length - 1)
                //{
                //    spriteFrame = 0;
                //}

                if (isRight)
                {
                    attackSpriteHolder.Location = new Point(attackSpriteHolder.Location.X + projectileSpeed, attackSpriteHolder.Location.Y);
                }
                else
                {
                    attackSpriteHolder.Location = new Point(attackSpriteHolder.Location.X - projectileSpeed, attackSpriteHolder.Location.Y);
                }

                //attackSpriteHolder.Image = sprite[spriteFrame];

                distanceT += projectileSpeed;

                WaitEvent(miliSecPerFrame);
            }

            attackSpriteHolder.Visible = false;
        }

        void dealMagicDamage()
        {
            Random randomNum = new Random();
            int damageDealt = randomNum.Next(player.SkillDamage - 5, player.SkillDamage);
            damageTaken.ForeColor = Color.Blue;

            damageDealt -= enemy.MagicResistance;

            logActions.Items.Add("Player uses fireball and deals " + damageDealt + " magic damage.");

            damageTaken.Text = damageDealt.ToString();
            damageTaken.Visible = true;

            WaitEvent(400);

            damageTaken.Visible = false;
            enemy.Health -= damageDealt;

            if (enemy.Health < 0)
            {
                enemy.Health = 0;
            }

            healthBarEnemy.Value = enemy.Health;
        }
        void dealBasicDamage(bool isPlayerHealth)
        {
            Random randomNum = new Random();
            int criticalChance = 40;
            int missChance = 20;

            if (randomNum.Next(1, 100) <= missChance)
            {

                damageTaken.Text = "Miss";
                damageTaken.ForeColor = Color.DarkGray;
                damageTaken.Visible = true;
                if (isPlayerHealth)
                {
                    logActions.Items.Add("Enemy uses basic attack and missed");
                }
                else
                {
                    logActions.Items.Add("Player uses basic attack and missed");
                }
                WaitEvent(400);
                damageTaken.Visible = false;
                return;
            }

            bool isCritical()
            {
                if (randomNum.Next(1, 100) <= criticalChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (isPlayerHealth)
            {
                int damageDealt = randomNum.Next(enemy.BasicDamage - 5, enemy.BasicDamage) - player.Armor;

                if (isCritical())
                {
                    damageTaken.ForeColor = Color.Red;
                    damageDealt *= 2;
                    logActions.Items.Add("Enemy uses basic attack and deals " + damageDealt + " critical damage.");
                }
                else
                {
                    damageTaken.ForeColor = Color.DarkOrange;
                    logActions.Items.Add("Enemy uses basic attack and deals " + damageDealt + " damage.");
                }

                damageTaken.Text = damageDealt.ToString();
                damageTaken.Visible = true;

                WaitEvent(400);

                damageTaken.Visible = false;
                player.Health -= damageDealt;

                ;
                if (player.Health < 0)
                {
                    player.Health = 0;
                }
                valueHealth.Text = player.Health.ToString();

                if (player.Health > healthBarPlayer.Value)
                {
                    player.Health = healthBarPlayer.Value;
                }

                healthBarPlayer.Value = player.Health;
            }
            else
            {
                int damageDealt = randomNum.Next(player.BasicDamage - 5, player.BasicDamage) - enemy.Armor;

                if (isCritical())
                {
                    damageTaken.ForeColor = Color.Red;
                    damageDealt *= 2;
                    logActions.Items.Add("Player uses basic attack and deals " + damageDealt + " critical damage.");
                }
                else
                {
                    damageTaken.ForeColor = Color.DarkOrange;
                    logActions.Items.Add("Player uses basic attack and deals " + damageDealt + " damage.");
                }

                damageTaken.Text = damageDealt.ToString();
                damageTaken.Visible = true;

                WaitEvent(400);

                damageTaken.Visible = false;

                enemy.Health -= damageDealt;


                if (enemy.Health < 0)
                {
                    enemy.Health = 0;
                }


                if (enemy.Health > healthBarEnemy.Value)
                {
                    enemy.Health = healthBarEnemy.Value;
                }
                healthBarEnemy.Value = enemy.Health;

            }
        }
        void EnemyAttack()
        {
            int MAXDISTANCE = (characterEnemy.Location.X - 2) - (characterPlayer.Location.X + characterPlayer.Width) - attackSpriteHolder.Width;

            int startLocX = characterEnemy.Location.X - 90;
            int startLocY = characterEnemy.Location.Y + 50;
            Point startLocationSprite = new Point(startLocX, startLocY);

            Bitmap rockSprite = Properties.Resources.rock;

            int projectileSpeed = 10;
            int animateTime = (MAXDISTANCE / projectileSpeed * FRAME_PER_SEC);

            damageTaken.Location = new Point(characterPlayer.Location.X + characterPlayer.Width + 15, characterPlayer.Location.Y);

            SoundPlayer rockThrowSound = new SoundPlayer(Properties.Resources.rockSound);


            rockThrowSound.Play();
            WaitEvent(600);//Delay to match the sound on throw

            AnimateAttackV2(rockSprite, startLocationSprite, animateTime, projectileSpeed, MAXDISTANCE, false);

            dealBasicDamage(true);

            //If player health is 0 show game over
            if (player.Health <= 0)
            {
                attackButton.Enabled = false;
                skillButton.Enabled = false;
                gameOverScene.Visible = true;

                messageYouWin.Visible = false;
                messageGameOver.Visible = true;
            }

            if (player.Mana < playerMaxMana)
            {
                player.Mana += player.ManaRegen;
                labelPlusMana.Text = "+" + player.ManaRegen.ToString() + " Mana";

                labelPlusMana.Visible = true;
                valueChangeable.Text = player.Mana.ToString();
                WaitEvent(800);
                labelPlusMana.Visible = false;
            }
        }

        void attackButton_Click(object sender, EventArgs e)
        {
            attackButton.Enabled = false;
            skillButton.Enabled = false;

            int MAXDISTANCE = (characterEnemy.Location.X - 2) - (characterPlayer.Location.X + characterPlayer.Width) - attackSpriteHolder.Width;

            int startLocX = characterPlayer.Location.X + characterPlayer.Width;
            int startLocY = characterPlayer.Location.Y + 5;
            Point startLocationSprite = new Point(startLocX, startLocY);

            Bitmap mageAttackSprite = Properties.Resources.fireball_4;

            int projectileSpeed = 15;
            int animateTime = (MAXDISTANCE / projectileSpeed * FRAME_PER_SEC);

            damageTaken.Location = new Point(characterEnemy.Location.X - 55, characterEnemy.Location.Y + 50);

            SoundPlayer pewSound = new SoundPlayer(Properties.Resources.pewSound);

            pewSound.Play();
            WaitEvent(150);
            AnimateAttackV2(mageAttackSprite, startLocationSprite, animateTime, projectileSpeed, MAXDISTANCE, true);
            dealBasicDamage(false);

            //if Enemy Health is 0 you win
            if (enemy.Health <= 0)
            {
                gameOverScene.Visible = true;
                messageGameOver.Visible = false;
                messageYouWin.Visible = true;
            }
            else
            {
                EnemyAttack();
                attackButton.Enabled = true;
                skillButton.Enabled = true;
            }
        }

        void skillChannel()
        {
            int animationDuration = 1200;
            int miliSecPerFrame;
            int startLocX = characterPlayer.Location.X + characterPlayer.Width;
            int startLocY = characterPlayer.Location.Y + 5;
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

            attackSpriteHolder.Location = startLocationSprite;
            attackSpriteHolder.Visible = true;

            miliSecPerFrame = animationDuration / fireBallChannelSprite.Length;

            while (timeElapse <= animationDuration)
            {
                if (frameSprite > fireBallChannelSprite.Length - 1)
                {
                    break;
                }

                attackSpriteHolder.Image = fireBallChannelSprite[frameSprite];
                frameSprite++;
                WaitEvent(miliSecPerFrame);
            }
        }

        private void skillButton_Click(object sender, EventArgs e)
        {
            if (player.Mana < player.SkillManaCost)
            {
                notEnoughMana.Visible = true;
                WaitEvent(1400);
                notEnoughMana.Visible = false;
                return;
            }

            player.Mana -= player.SkillManaCost;
            valueChangeable.Text = player.Mana.ToString();

            attackButton.Enabled = false;
            skillButton.Enabled = false;

            int MAXDISTANCE = (characterEnemy.Location.X - 2) - (characterPlayer.Location.X + characterPlayer.Width) - attackSpriteHolder.Width;
            int startLocX = characterPlayer.Location.X + characterPlayer.Width;
            int startLocY = characterPlayer.Location.Y + 5;
            Point startLocationSprite = new Point(startLocX, startLocY);

            Bitmap fireballSprite = Properties.Resources.fireBallMoving;

            int projectileSpeed = 10;
            int animateTime = (MAXDISTANCE / projectileSpeed * FRAME_PER_SEC);

            damageTaken.Location = new Point(characterEnemy.Location.X - 55, characterEnemy.Location.Y + 50);


            SoundPlayer fireBallSound = new SoundPlayer(Properties.Resources.fireballSound);
            SoundPlayer explodeSound = new SoundPlayer(Properties.Resources.explodeSound);

            fireBallSound.Play();
            skillChannel();
            AnimateAttackV2(fireballSprite, startLocationSprite, animateTime, projectileSpeed, MAXDISTANCE, true);

            WaitEvent(animateTime - (animateTime - 100));

            explodeSound.Play();
            dealMagicDamage();
            WaitEvent(500);

            if (enemy.Health <= 0)
            {
                gameOverScene.Visible = true;
                messageYouWin.Visible = true;
            }
            else
            {
                EnemyAttack();
                attackButton.Enabled = true;
                skillButton.Enabled = true;
            }
        }
        private void characterPlayer_Click(object sender, EventArgs e)
        {
            pictureLabel.Image = Properties.Resources.Mage;
            attackButton.Visible = true;
            skillButton.Visible = true;
            valueChangeable.Visible = true;
            labelChangeable.Visible = true;

            valueHealth.Text = player.Health.ToString();
            valueBasicDamage.Text = player.BasicDamage.ToString();
            valueArmor.Text = player.Armor.ToString();
            valueChangeable2.Text = player.SkillDamage.ToString();
            labelChangeable2.Text = ":Skill Damage";
            valueChangeable.Text = player.Mana.ToString();
        }

        private void characterEnemy_Click(object sender, EventArgs e)
        {
            pictureLabel.Image = Properties.Resources.ogre;
            attackButton.Visible = false;
            skillButton.Visible = false;
            valueChangeable.Visible = false;
            labelChangeable.Visible = false;

            valueHealth.Text = enemy.Health.ToString();
            valueBasicDamage.Text = enemy.BasicDamage.ToString();
            valueArmor.Text = enemy.Armor.ToString();
            valueChangeable2.Text = enemy.MagicResistance.ToString();
            labelChangeable2.Text = ":Magic Resistance";

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            gameOverScene.Visible = false;
            mainMenu.Visible = true;

            logActions.Items.Clear();

            healthBarEnemy.Value = 0;
            healthBarPlayer.Value = 0;

            IdleAnimation.Abort();
            IdleAnimation2.Abort();
        }
    }
}
