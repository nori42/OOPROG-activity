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
        //Thread IdleAnimation;


        public Game()
        {
            InitializeComponent();


        }


        private void btnDefaultStart_Click(object sender, EventArgs e)
        {
            player = new Player(120, 28, 10, 200, 68,characterPlayer);

            playerMaxMana = player.Mana;

            enemy = new Enemy(210, 31, 6, 9,characterEnemy);

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
            string basicDamageInfo;
            string skillDamageInfo;
            if (player.BasicDamage < 5)
            {
                basicDamageInfo = "Deals " + player.BasicDamage + " - " + 1 + " damage";
            }
            else
            {
                basicDamageInfo = "Deals " + player.BasicDamage + " - " + (player.BasicDamage - 5) + " damage";
            }

            if (player.SkillDamage < 5)
            {
                skillDamageInfo = "Deals " + player.SkillDamage + " - " + 1 + " damage";
            }
            else
            {
                skillDamageInfo = "Deals " + player.SkillDamage + " - " + (player.SkillDamage - 5) + " damage";
            }

            basicAttackInfo.SetToolTip(attackButton, basicDamageInfo);
            fireBallInfo.SetToolTip(skillButton, skillDamageInfo);

            skillButton.Enabled = true;
            attackButton.Enabled = true;
            mainMenu.Visible = false;
            enemy.StartIdleAnimation();
            player.StartIdleAnimation();
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
                player = new Player(playerHealth, playerDamage, playerArmor, playerMana, playerSkillDamage,characterPlayer);
                enemy = new Enemy(enemyHealth, enemyDamage, enemyArmor, enemyMagicResistance,characterEnemy);
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
            string basicDamageInfo;
            string skillDamageInfo;
            if (player.BasicDamage < 5)
            {
                basicDamageInfo = "Deals " + player.BasicDamage + " - " + 1 + " damage";
            }
            else
            {
                basicDamageInfo = "Deals " + player.BasicDamage + " - " + (player.BasicDamage - 5) + " damage";
            }

            if (player.SkillDamage < 5)
            {
                skillDamageInfo = "Deals " + player.SkillDamage + " - " + 1 + " damage";
            }
            else
            {
                skillDamageInfo = "Deals " + player.SkillDamage + " - " + (player.SkillDamage - 5) + " damage";
            }



            basicAttackInfo.SetToolTip(attackButton, basicDamageInfo);
            fireBallInfo.SetToolTip(skillButton, skillDamageInfo);

            skillButton.Enabled = true;
            attackButton.Enabled = true;
            mainMenu.Visible = false;

            enemy.StartIdleAnimation();
            player.StartIdleAnimation();
        }

        void attackButton_Click(object sender, EventArgs e)
        {
            attackButton.Enabled = false;
            skillButton.Enabled = false;

            player.useBasicAttack(characterEnemy,attackSpriteHolder,enemy,labelDamageDealt,logActions);

            healthBarEnemy.Value = enemy.Health;

            labelDamageDealt.Location = new Point(characterEnemy.Location.X - 50, characterEnemy.Location.Y + 50);
            labelDamageDealt.Visible = true;

            WaitEvent.Wait(600);
            labelDamageDealt.Visible = false;

            //Enemy Turn

            if (enemy.Health <= 0)
            {
                enemy.playDeathSound();
                WaitEvent.Wait(2000);
                gameOverScene.Visible = true;
                messageYouWin.Visible = true;

                return;
            }

            //Enemy Turn
            enemy.useBasicAttack(characterPlayer, characterEnemy, attackSpriteHolder, player, labelDamageDealt, logActions);
            healthBarPlayer.Value = player.Health;
            valueHealth.Text = player.Health.ToString();

            labelDamageDealt.Location = new Point(characterPlayer.Location.X + characterPlayer.Width + 5, characterEnemy.Location.Y + 20);
            labelDamageDealt.Visible = true;

            WaitEvent.Wait(600);
            labelDamageDealt.Visible = false;


            if (player.Health <= 0)
            {
                player.playDeathSound();
                WaitEvent.Wait(2000);
                gameOverScene.Visible = true;
                messageGameOver.Visible = true;
            }
            else
            {
                attackButton.Enabled = true;
                skillButton.Enabled = true;
            }
        }

        private void skillButton_Click(object sender, EventArgs e)
        {
            
            if (player.Mana < player.SkillManaCost)
            {
                notEnoughMana.Visible = true;
                WaitEvent.Wait(1400);
                notEnoughMana.Visible = false;
                return;
            }

            player.Mana -= player.SkillManaCost;
            valueChangeable.Text = player.Mana.ToString();


            attackButton.Enabled = false;
            skillButton.Enabled = false;

            player.UseSkill(characterEnemy, attackSpriteHolder,labelDamageDealt, enemy,logActions);
            healthBarEnemy.Value = enemy.Health;


            labelDamageDealt.Location = new Point(characterEnemy.Location.X - 50, characterEnemy.Location.Y + 50);
            labelDamageDealt.Visible = true;
    
            WaitEvent.Wait(600);
            labelDamageDealt.Visible = false;

            if (enemy.Health <= 0)
            {
                enemy.playDeathSound();
                WaitEvent.Wait(2000);
                gameOverScene.Visible = true;
                messageYouWin.Visible = true;

                return;
            }

            //Enemy Turn
            enemy.useBasicAttack(characterPlayer, characterEnemy, attackSpriteHolder, player, labelDamageDealt, logActions);
            healthBarPlayer.Value = player.Health;
            valueHealth.Text = player.Health.ToString();

            labelDamageDealt.Location = new Point(characterPlayer.Location.X + characterPlayer.Width + 5, characterEnemy.Location.Y + 20);
            labelDamageDealt.Visible = true;

            WaitEvent.Wait(600);
            labelDamageDealt.Visible = false;

            //Regen Mana Label

            if (player.Mana < playerMaxMana && player.Health >= 0)
            {
                labelPlusMana.Text = "+" + player.ManaRegen.ToString() + " Mana";

                labelPlusMana.Visible = true;
                valueChangeable.Text = player.Mana.ToString();
                WaitEvent.Wait(800);
                labelPlusMana.Visible = false;
            }

            //Condition game over
            if (player.Health <= 0)
            {
                player.playDeathSound();
                WaitEvent.Wait(2000);
                gameOverScene.Visible = true;
                messageGameOver.Visible = true;
            }
            else
            {
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
            //valueChangeable2.Text = enemy.MagicResistance.ToString();
            labelChangeable2.Text = ":Magic Resistance";
            valueChangeable2.Text = enemy.MagicResistance.ToString();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            gameOverScene.Visible = false;
            messageGameOver.Visible = false;
            messageYouWin.Visible = false;

            mainMenu.Visible = true;

            logActions.Items.Clear();

            healthBarEnemy.Value = 0;
            healthBarPlayer.Value = 0;

            //IdleAnimation.Abort();
            player.IdleAnimation.Abort();
            enemy.IdleAnimation.Abort();
        }

        private void log_Click(object sender, EventArgs e)
        {

        }
    }
}
