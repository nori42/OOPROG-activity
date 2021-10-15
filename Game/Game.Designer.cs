namespace Game
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureLabel = new System.Windows.Forms.PictureBox();
            this.notEnoughMana = new System.Windows.Forms.Label();
            this.valueChangeable2 = new System.Windows.Forms.Label();
            this.valueChangeable = new System.Windows.Forms.Label();
            this.valueArmor = new System.Windows.Forms.Label();
            this.valueBasicDamage = new System.Windows.Forms.Label();
            this.valueHealth = new System.Windows.Forms.Label();
            this.labelChangeable2 = new System.Windows.Forms.Label();
            this.skillButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.labelChangeable = new System.Windows.Forms.Label();
            this.labelArmor = new System.Windows.Forms.Label();
            this.labelBasicDamage = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.logActions = new System.Windows.Forms.ListBox();
            this.basicAttackInfo = new System.Windows.Forms.ToolTip(this.components);
            this.fireBallInfo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNotEnoughMana = new System.Windows.Forms.ToolTip(this.components);
            this.gameBackground = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.Panel();
            this.btnDefaultStart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMagicResistance = new System.Windows.Forms.TextBox();
            this.txtBoxArmor2 = new System.Windows.Forms.TextBox();
            this.txtBoxDamage2 = new System.Windows.Forms.TextBox();
            this.txtBoxHealth2 = new System.Windows.Forms.TextBox();
            this.txtBoxSkillDamage = new System.Windows.Forms.TextBox();
            this.txtBoxArmor = new System.Windows.Forms.TextBox();
            this.txtBoxDamage = new System.Windows.Forms.TextBox();
            this.txtBoxMana = new System.Windows.Forms.TextBox();
            this.txtBoxHealth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlusMana = new System.Windows.Forms.Label();
            this.gameOverScene = new System.Windows.Forms.Panel();
            this.artistName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messageYouWin = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.messageGameOver = new System.Windows.Forms.Label();
            this.characterEnemy = new System.Windows.Forms.PictureBox();
            this.attackSpriteHolder = new System.Windows.Forms.PictureBox();
            this.characterPlayer = new System.Windows.Forms.PictureBox();
            this.damageTaken = new System.Windows.Forms.Label();
            this.healthBarEnemy = new System.Windows.Forms.ProgressBar();
            this.healthBarPlayer = new System.Windows.Forms.ProgressBar();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLabel)).BeginInit();
            this.gameBackground.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.gameOverScene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackSpriteHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.pictureLabel);
            this.panel4.Controls.Add(this.notEnoughMana);
            this.panel4.Controls.Add(this.valueChangeable2);
            this.panel4.Controls.Add(this.valueChangeable);
            this.panel4.Controls.Add(this.valueArmor);
            this.panel4.Controls.Add(this.valueBasicDamage);
            this.panel4.Controls.Add(this.valueHealth);
            this.panel4.Controls.Add(this.labelChangeable2);
            this.panel4.Controls.Add(this.skillButton);
            this.panel4.Controls.Add(this.attackButton);
            this.panel4.Controls.Add(this.labelChangeable);
            this.panel4.Controls.Add(this.labelArmor);
            this.panel4.Controls.Add(this.labelBasicDamage);
            this.panel4.Controls.Add(this.labelHealth);
            this.panel4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(870, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 582);
            this.panel4.TabIndex = 2;
            // 
            // pictureLabel
            // 
            this.pictureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pictureLabel.Image = Properties.Resources.Mage;
            this.pictureLabel.Location = new System.Drawing.Point(98, 48);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(115, 93);
            this.pictureLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLabel.TabIndex = 14;
            this.pictureLabel.TabStop = false;
            // 
            // notEnoughMana
            // 
            this.notEnoughMana.AutoSize = true;
            this.notEnoughMana.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notEnoughMana.ForeColor = System.Drawing.Color.Brown;
            this.notEnoughMana.Location = new System.Drawing.Point(92, 532);
            this.notEnoughMana.Name = "notEnoughMana";
            this.notEnoughMana.Size = new System.Drawing.Size(148, 26);
            this.notEnoughMana.TabIndex = 13;
            this.notEnoughMana.Text = "Not Enough Mana";
            this.notEnoughMana.Visible = false;
            // 
            // valueChangeable2
            // 
            this.valueChangeable2.AutoSize = true;
            this.valueChangeable2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueChangeable2.Location = new System.Drawing.Point(85, 351);
            this.valueChangeable2.Name = "valueChangeable2";
            this.valueChangeable2.Size = new System.Drawing.Size(29, 33);
            this.valueChangeable2.TabIndex = 12;
            this.valueChangeable2.Text = "0";
            // 
            // valueChangeable
            // 
            this.valueChangeable.AutoSize = true;
            this.valueChangeable.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueChangeable.Location = new System.Drawing.Point(85, 198);
            this.valueChangeable.Name = "valueChangeable";
            this.valueChangeable.Size = new System.Drawing.Size(29, 33);
            this.valueChangeable.TabIndex = 11;
            this.valueChangeable.Text = "0";
            // 
            // valueArmor
            // 
            this.valueArmor.AutoSize = true;
            this.valueArmor.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueArmor.Location = new System.Drawing.Point(85, 308);
            this.valueArmor.Name = "valueArmor";
            this.valueArmor.Size = new System.Drawing.Size(29, 33);
            this.valueArmor.TabIndex = 10;
            this.valueArmor.Text = "0";
            // 
            // valueBasicDamage
            // 
            this.valueBasicDamage.AutoSize = true;
            this.valueBasicDamage.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBasicDamage.Location = new System.Drawing.Point(85, 263);
            this.valueBasicDamage.Name = "valueBasicDamage";
            this.valueBasicDamage.Size = new System.Drawing.Size(29, 33);
            this.valueBasicDamage.TabIndex = 9;
            this.valueBasicDamage.Text = "0";
            // 
            // valueHealth
            // 
            this.valueHealth.AutoSize = true;
            this.valueHealth.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueHealth.Location = new System.Drawing.Point(85, 158);
            this.valueHealth.Name = "valueHealth";
            this.valueHealth.Size = new System.Drawing.Size(29, 33);
            this.valueHealth.TabIndex = 8;
            this.valueHealth.Text = "0";
            // 
            // labelChangeable2
            // 
            this.labelChangeable2.AutoSize = true;
            this.labelChangeable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeable2.Location = new System.Drawing.Point(141, 358);
            this.labelChangeable2.Name = "labelChangeable2";
            this.labelChangeable2.Size = new System.Drawing.Size(120, 22);
            this.labelChangeable2.TabIndex = 7;
            this.labelChangeable2.Text = ":Skill Damage";
            // 
            // skillButton
            // 
            this.skillButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.skillButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.skillButton.Enabled = false;
            this.skillButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.skillButton.Location = new System.Drawing.Point(56, 477);
            this.skillButton.Name = "skillButton";
            this.skillButton.Size = new System.Drawing.Size(216, 47);
            this.skillButton.TabIndex = 6;
            this.skillButton.Text = "Fireball";
            this.skillButton.UseVisualStyleBackColor = false;
            this.skillButton.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.attackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.attackButton.Enabled = false;
            this.attackButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.attackButton.Location = new System.Drawing.Point(55, 405);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(216, 47);
            this.attackButton.TabIndex = 5;
            this.attackButton.Text = "Basic Attack";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // labelChangeable
            // 
            this.labelChangeable.AutoSize = true;
            this.labelChangeable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeable.Location = new System.Drawing.Point(141, 206);
            this.labelChangeable.Name = "labelChangeable";
            this.labelChangeable.Size = new System.Drawing.Size(59, 22);
            this.labelChangeable.TabIndex = 4;
            this.labelChangeable.Text = ":Mana";
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArmor.Location = new System.Drawing.Point(141, 316);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(63, 22);
            this.labelArmor.TabIndex = 3;
            this.labelArmor.Text = ":Armor";
            // 
            // labelBasicDamage
            // 
            this.labelBasicDamage.AutoSize = true;
            this.labelBasicDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasicDamage.Location = new System.Drawing.Point(141, 271);
            this.labelBasicDamage.Name = "labelBasicDamage";
            this.labelBasicDamage.Size = new System.Drawing.Size(131, 22);
            this.labelBasicDamage.TabIndex = 2;
            this.labelBasicDamage.Text = ":Basic Damage";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.Location = new System.Drawing.Point(141, 166);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(72, 22);
            this.labelHealth.TabIndex = 1;
            this.labelHealth.Text = ":Health ";
            // 
            // logActions
            // 
            this.logActions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logActions.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logActions.FormattingEnabled = true;
            this.logActions.ItemHeight = 18;
            this.logActions.Location = new System.Drawing.Point(2, 2);
            this.logActions.Name = "logActions";
            this.logActions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.logActions.Size = new System.Drawing.Size(868, 72);
            this.logActions.TabIndex = 8;
            // 
            // gameBackground
            // 
            this.gameBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBackground.Controls.Add(this.mainMenu);
            this.gameBackground.Controls.Add(this.labelPlusMana);
            this.gameBackground.Controls.Add(this.gameOverScene);
            this.gameBackground.Controls.Add(this.characterEnemy);
            this.gameBackground.Controls.Add(this.attackSpriteHolder);
            this.gameBackground.Controls.Add(this.characterPlayer);
            this.gameBackground.Controls.Add(this.damageTaken);
            this.gameBackground.Controls.Add(this.healthBarEnemy);
            this.gameBackground.Controls.Add(this.healthBarPlayer);
            this.gameBackground.Location = new System.Drawing.Point(2, 76);
            this.gameBackground.Name = "gameBackground";
            this.gameBackground.Size = new System.Drawing.Size(868, 508);
            this.gameBackground.TabIndex = 9;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainMenu.Controls.Add(this.btnDefaultStart);
            this.mainMenu.Controls.Add(this.btnStart);
            this.mainMenu.Controls.Add(this.label10);
            this.mainMenu.Controls.Add(this.label9);
            this.mainMenu.Controls.Add(this.label8);
            this.mainMenu.Controls.Add(this.label7);
            this.mainMenu.Controls.Add(this.label6);
            this.mainMenu.Controls.Add(this.label5);
            this.mainMenu.Controls.Add(this.label4);
            this.mainMenu.Controls.Add(this.txtBoxMagicResistance);
            this.mainMenu.Controls.Add(this.txtBoxArmor2);
            this.mainMenu.Controls.Add(this.txtBoxDamage2);
            this.mainMenu.Controls.Add(this.txtBoxHealth2);
            this.mainMenu.Controls.Add(this.txtBoxSkillDamage);
            this.mainMenu.Controls.Add(this.txtBoxArmor);
            this.mainMenu.Controls.Add(this.txtBoxDamage);
            this.mainMenu.Controls.Add(this.txtBoxMana);
            this.mainMenu.Controls.Add(this.txtBoxHealth);
            this.mainMenu.Controls.Add(this.label3);
            this.mainMenu.Controls.Add(this.label2);
            this.mainMenu.Location = new System.Drawing.Point(239, 117);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(358, 282);
            this.mainMenu.TabIndex = 10;
            // 
            // btnDefaultStart
            // 
            this.btnDefaultStart.BackColor = System.Drawing.Color.Green;
            this.btnDefaultStart.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDefaultStart.Location = new System.Drawing.Point(125, 159);
            this.btnDefaultStart.Name = "btnDefaultStart";
            this.btnDefaultStart.Size = new System.Drawing.Size(125, 28);
            this.btnDefaultStart.TabIndex = 19;
            this.btnDefaultStart.Text = "Default Start";
            this.btnDefaultStart.UseVisualStyleBackColor = false;
            this.btnDefaultStart.Click += new System.EventHandler(this.btnDefaultStart_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Location = new System.Drawing.Point(125, 193);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 55);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(161, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Magic Resistance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(215, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Armor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(206, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Damage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(1, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Skill Damage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(36, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Armor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(26, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Damage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(36, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mana";
            // 
            // txtBoxMagicResistance
            // 
            this.txtBoxMagicResistance.Location = new System.Drawing.Point(274, 96);
            this.txtBoxMagicResistance.Name = "txtBoxMagicResistance";
            this.txtBoxMagicResistance.Size = new System.Drawing.Size(58, 20);
            this.txtBoxMagicResistance.TabIndex = 10;
            this.txtBoxMagicResistance.Text = "0";
            // 
            // txtBoxArmor2
            // 
            this.txtBoxArmor2.Location = new System.Drawing.Point(274, 70);
            this.txtBoxArmor2.Name = "txtBoxArmor2";
            this.txtBoxArmor2.Size = new System.Drawing.Size(58, 20);
            this.txtBoxArmor2.TabIndex = 9;
            this.txtBoxArmor2.Text = "0";
            // 
            // txtBoxDamage2
            // 
            this.txtBoxDamage2.Location = new System.Drawing.Point(274, 44);
            this.txtBoxDamage2.Name = "txtBoxDamage2";
            this.txtBoxDamage2.Size = new System.Drawing.Size(58, 20);
            this.txtBoxDamage2.TabIndex = 8;
            this.txtBoxDamage2.Text = "0";
            // 
            // txtBoxHealth2
            // 
            this.txtBoxHealth2.Location = new System.Drawing.Point(274, 18);
            this.txtBoxHealth2.Name = "txtBoxHealth2";
            this.txtBoxHealth2.Size = new System.Drawing.Size(58, 20);
            this.txtBoxHealth2.TabIndex = 7;
            this.txtBoxHealth2.Text = "0";
            // 
            // txtBoxSkillDamage
            // 
            this.txtBoxSkillDamage.Location = new System.Drawing.Point(94, 121);
            this.txtBoxSkillDamage.Name = "txtBoxSkillDamage";
            this.txtBoxSkillDamage.Size = new System.Drawing.Size(58, 20);
            this.txtBoxSkillDamage.TabIndex = 6;
            this.txtBoxSkillDamage.Text = "0";
            // 
            // txtBoxArmor
            // 
            this.txtBoxArmor.Location = new System.Drawing.Point(94, 95);
            this.txtBoxArmor.Name = "txtBoxArmor";
            this.txtBoxArmor.Size = new System.Drawing.Size(58, 20);
            this.txtBoxArmor.TabIndex = 5;
            this.txtBoxArmor.Text = "0";
            // 
            // txtBoxDamage
            // 
            this.txtBoxDamage.Location = new System.Drawing.Point(94, 69);
            this.txtBoxDamage.Name = "txtBoxDamage";
            this.txtBoxDamage.Size = new System.Drawing.Size(58, 20);
            this.txtBoxDamage.TabIndex = 4;
            this.txtBoxDamage.Text = "0";
            // 
            // txtBoxMana
            // 
            this.txtBoxMana.Location = new System.Drawing.Point(94, 43);
            this.txtBoxMana.Name = "txtBoxMana";
            this.txtBoxMana.Size = new System.Drawing.Size(58, 20);
            this.txtBoxMana.TabIndex = 3;
            this.txtBoxMana.Text = "0";
            // 
            // txtBoxHealth
            // 
            this.txtBoxHealth.Location = new System.Drawing.Point(94, 17);
            this.txtBoxHealth.Name = "txtBoxHealth";
            this.txtBoxHealth.Size = new System.Drawing.Size(58, 20);
            this.txtBoxHealth.TabIndex = 2;
            this.txtBoxHealth.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(216, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Health";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(36, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health";
            // 
            // labelPlusMana
            // 
            this.labelPlusMana.AutoSize = true;
            this.labelPlusMana.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlusMana.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelPlusMana.Location = new System.Drawing.Point(197, 377);
            this.labelPlusMana.Name = "labelPlusMana";
            this.labelPlusMana.Size = new System.Drawing.Size(85, 26);
            this.labelPlusMana.TabIndex = 14;
            this.labelPlusMana.Text = "manaPlus";
            this.labelPlusMana.Visible = false;
            // 
            // gameOverScene
            // 
            this.gameOverScene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameOverScene.Controls.Add(this.artistName);
            this.gameOverScene.Controls.Add(this.label1);
            this.gameOverScene.Controls.Add(this.messageYouWin);
            this.gameOverScene.Controls.Add(this.btnRestart);
            this.gameOverScene.Controls.Add(this.messageGameOver);
            this.gameOverScene.Location = new System.Drawing.Point(321, 35);
            this.gameOverScene.Name = "gameOverScene";
            this.gameOverScene.Size = new System.Drawing.Size(202, 271);
            this.gameOverScene.TabIndex = 13;
            this.gameOverScene.Visible = false;
            // 
            // artistName
            // 
            this.artistName.AutoSize = true;
            this.artistName.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistName.ForeColor = System.Drawing.Color.Black;
            this.artistName.Location = new System.Drawing.Point(34, 235);
            this.artistName.Name = "artistName";
            this.artistName.Size = new System.Drawing.Size(143, 13);
            this.artistName.TabIndex = 4;
            this.artistName.Text = "Jade Angelo Piñez";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(65, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artwork By:";
            // 
            // messageYouWin
            // 
            this.messageYouWin.AutoSize = true;
            this.messageYouWin.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageYouWin.Location = new System.Drawing.Point(41, 63);
            this.messageYouWin.Name = "messageYouWin";
            this.messageYouWin.Size = new System.Drawing.Size(123, 31);
            this.messageYouWin.TabIndex = 2;
            this.messageYouWin.Text = "You Won";
            this.messageYouWin.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRestart.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(51, 140);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(102, 61);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // messageGameOver
            // 
            this.messageGameOver.AutoSize = true;
            this.messageGameOver.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageGameOver.Location = new System.Drawing.Point(31, 47);
            this.messageGameOver.Name = "messageGameOver";
            this.messageGameOver.Size = new System.Drawing.Size(147, 31);
            this.messageGameOver.TabIndex = 0;
            this.messageGameOver.Text = "Game Over";
            this.messageGameOver.Visible = false;
            // 
            // characterEnemy
            // 
            this.characterEnemy.BackColor = System.Drawing.Color.Transparent;
            this.characterEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.characterEnemy.Image = global::Game.Properties.Resources.ogre;
            this.characterEnemy.Location = new System.Drawing.Point(609, 162);
            this.characterEnemy.Name = "characterEnemy";
            this.characterEnemy.Size = new System.Drawing.Size(218, 309);
            this.characterEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterEnemy.TabIndex = 12;
            this.characterEnemy.TabStop = false;
            this.characterEnemy.Click += new System.EventHandler(this.characterEnemy_Click);
            // 
            // attackSpriteHolder
            // 
            this.attackSpriteHolder.BackColor = System.Drawing.Color.Transparent;
            this.attackSpriteHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attackSpriteHolder.Image = global::Game.Properties.Resources.rock;
            this.attackSpriteHolder.ImageLocation = "";
            this.attackSpriteHolder.Location = new System.Drawing.Point(739, 18);
            this.attackSpriteHolder.Name = "attackSpriteHolder";
            this.attackSpriteHolder.Size = new System.Drawing.Size(108, 112);
            this.attackSpriteHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attackSpriteHolder.TabIndex = 10;
            this.attackSpriteHolder.TabStop = false;
            this.attackSpriteHolder.Visible = false;
            // 
            // characterPlayer
            // 
            this.characterPlayer.BackColor = System.Drawing.Color.Transparent;
            this.characterPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.characterPlayer.Image = global::Game.Properties.Resources.Mage;
            this.characterPlayer.Location = new System.Drawing.Point(54, 202);
            this.characterPlayer.Name = "characterPlayer";
            this.characterPlayer.Size = new System.Drawing.Size(168, 234);
            this.characterPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterPlayer.TabIndex = 9;
            this.characterPlayer.TabStop = false;
            this.characterPlayer.Click += new System.EventHandler(this.characterPlayer_Click);
            // 
            // damageTaken
            // 
            this.damageTaken.AutoSize = true;
            this.damageTaken.BackColor = System.Drawing.Color.Transparent;
            this.damageTaken.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageTaken.Location = new System.Drawing.Point(565, 206);
            this.damageTaken.Name = "damageTaken";
            this.damageTaken.Size = new System.Drawing.Size(32, 37);
            this.damageTaken.TabIndex = 7;
            this.damageTaken.Text = "0";
            this.damageTaken.Visible = false;
            // 
            // healthBarEnemy
            // 
            this.healthBarEnemy.Location = new System.Drawing.Point(634, 138);
            this.healthBarEnemy.Name = "healthBarEnemy";
            this.healthBarEnemy.Size = new System.Drawing.Size(152, 19);
            this.healthBarEnemy.TabIndex = 6;
            // 
            // healthBarPlayer
            // 
            this.healthBarPlayer.Location = new System.Drawing.Point(54, 177);
            this.healthBarPlayer.Name = "healthBarPlayer";
            this.healthBarPlayer.Size = new System.Drawing.Size(152, 19);
            this.healthBarPlayer.TabIndex = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1192, 584);
            this.Controls.Add(this.gameBackground);
            this.Controls.Add(this.logActions);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "The Mage";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLabel)).EndInit();
            this.gameBackground.ResumeLayout(false);
            this.gameBackground.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.gameOverScene.ResumeLayout(false);
            this.gameOverScene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackSpriteHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button skillButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Label labelChangeable;
        private System.Windows.Forms.Label labelArmor;
        private System.Windows.Forms.Label labelBasicDamage;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelChangeable2;
        private System.Windows.Forms.Label valueHealth;
        private System.Windows.Forms.Label valueChangeable2;
        private System.Windows.Forms.Label valueChangeable;
        private System.Windows.Forms.Label valueArmor;
        private System.Windows.Forms.Label valueBasicDamage;
        private System.Windows.Forms.ListBox logActions;
        private System.Windows.Forms.ProgressBar healthBarPlayer;
        private System.Windows.Forms.ProgressBar healthBarEnemy;
        private System.Windows.Forms.Panel gameBackground;
        private System.Windows.Forms.ToolTip basicAttackInfo;
        private System.Windows.Forms.ToolTip fireBallInfo;
        private System.Windows.Forms.ToolTip toolTipNotEnoughMana;
        private System.Windows.Forms.Label damageTaken;
        private System.Windows.Forms.PictureBox characterPlayer;
        private System.Windows.Forms.PictureBox attackSpriteHolder;
        private System.Windows.Forms.PictureBox characterEnemy;
        private System.Windows.Forms.Label notEnoughMana;
        private System.Windows.Forms.PictureBox pictureLabel;
        private System.Windows.Forms.Panel gameOverScene;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label messageGameOver;
        private System.Windows.Forms.Label messageYouWin;
        private System.Windows.Forms.Label labelPlusMana;
        private System.Windows.Forms.Label artistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.TextBox txtBoxArmor;
        private System.Windows.Forms.TextBox txtBoxDamage;
        private System.Windows.Forms.TextBox txtBoxMana;
        private System.Windows.Forms.TextBox txtBoxHealth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMagicResistance;
        private System.Windows.Forms.TextBox txtBoxArmor2;
        private System.Windows.Forms.TextBox txtBoxDamage2;
        private System.Windows.Forms.TextBox txtBoxHealth2;
        private System.Windows.Forms.TextBox txtBoxSkillDamage;
        private System.Windows.Forms.Button btnDefaultStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }

}


