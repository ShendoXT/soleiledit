namespace SoleilEdit
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.CoinsNumeric = new System.Windows.Forms.NumericUpDown();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.HealthNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxHealthNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxHealthLabel = new System.Windows.Forms.Label();
            this.AbilityGroupbox = new System.Windows.Forms.GroupBox();
            this.StrenghtCheck = new System.Windows.Forms.CheckBox();
            this.SwordThrowCheck = new System.Windows.Forms.CheckBox();
            this.JumpCheck = new System.Windows.Forms.CheckBox();
            this.AnimalTalkCheck = new System.Windows.Forms.CheckBox();
            this.AnimalsGroupbox = new System.Windows.Forms.GroupBox();
            this.EggCheck = new System.Windows.Forms.CheckBox();
            this.BatCheck = new System.Windows.Forms.CheckBox();
            this.ArmadilloCheck = new System.Windows.Forms.CheckBox();
            this.CaterpillarCheck = new System.Windows.Forms.CheckBox();
            this.CielCheck = new System.Windows.Forms.CheckBox();
            this.RaccoonCheck = new System.Windows.Forms.CheckBox();
            this.LeviathanCheck = new System.Windows.Forms.CheckBox();
            this.DodoCheck = new System.Windows.Forms.CheckBox();
            this.DinosaurCheck = new System.Windows.Forms.CheckBox();
            this.CharlieCheck = new System.Windows.Forms.CheckBox();
            this.PenguyCheck = new System.Windows.Forms.CheckBox();
            this.LionCheck = new System.Windows.Forms.CheckBox();
            this.MoaCheck = new System.Windows.Forms.CheckBox();
            this.JohnnyCheck = new System.Windows.Forms.CheckBox();
            this.KittyCheck = new System.Windows.Forms.CheckBox();
            this.InventoryGroupbox = new System.Windows.Forms.GroupBox();
            this.HornCheck = new System.Windows.Forms.CheckBox();
            this.PowderCheck = new System.Windows.Forms.CheckBox();
            this.ShoesCheck = new System.Windows.Forms.CheckBox();
            this.PlantCheck = new System.Windows.Forms.CheckBox();
            this.HolyCheck = new System.Windows.Forms.CheckBox();
            this.GoldCheck = new System.Windows.Forms.CheckBox();
            this.SilverCheck = new System.Windows.Forms.CheckBox();
            this.BronzeCheck = new System.Windows.Forms.CheckBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.ActiveLabel = new System.Windows.Forms.Label();
            this.SecretGroup = new System.Windows.Forms.GroupBox();
            this.ResetCheck = new System.Windows.Forms.CheckBox();
            this.AbilitiesCheck = new System.Windows.Forms.CheckBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.SlotTextbox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenuItem = new System.Windows.Forms.MenuItem();
            this.OpenMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.SaveMenuItem = new System.Windows.Forms.MenuItem();
            this.SaveAsManuItem = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.QuitMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.ReadMeMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.AboutMenuItem = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CoinsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHealthNumeric)).BeginInit();
            this.AbilityGroupbox.SuspendLayout();
            this.AnimalsGroupbox.SuspendLayout();
            this.InventoryGroupbox.SuspendLayout();
            this.SecretGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.AutoSize = true;
            this.CoinsLabel.Location = new System.Drawing.Point(300, 32);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(40, 13);
            this.CoinsLabel.TabIndex = 0;
            this.CoinsLabel.Text = "Malins:";
            // 
            // CoinsNumeric
            // 
            this.CoinsNumeric.Location = new System.Drawing.Point(300, 48);
            this.CoinsNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.CoinsNumeric.Name = "CoinsNumeric";
            this.CoinsNumeric.Size = new System.Drawing.Size(76, 20);
            this.CoinsNumeric.TabIndex = 6;
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Location = new System.Drawing.Point(140, 32);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(41, 13);
            this.HealthLabel.TabIndex = 2;
            this.HealthLabel.Text = "Health:";
            // 
            // HealthNumeric
            // 
            this.HealthNumeric.Location = new System.Drawing.Point(140, 48);
            this.HealthNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.HealthNumeric.Name = "HealthNumeric";
            this.HealthNumeric.Size = new System.Drawing.Size(76, 20);
            this.HealthNumeric.TabIndex = 4;
            // 
            // MaxHealthNumeric
            // 
            this.MaxHealthNumeric.Location = new System.Drawing.Point(220, 48);
            this.MaxHealthNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.MaxHealthNumeric.Name = "MaxHealthNumeric";
            this.MaxHealthNumeric.Size = new System.Drawing.Size(76, 20);
            this.MaxHealthNumeric.TabIndex = 5;
            // 
            // MaxHealthLabel
            // 
            this.MaxHealthLabel.AutoSize = true;
            this.MaxHealthLabel.Location = new System.Drawing.Point(220, 32);
            this.MaxHealthLabel.Name = "MaxHealthLabel";
            this.MaxHealthLabel.Size = new System.Drawing.Size(64, 13);
            this.MaxHealthLabel.TabIndex = 4;
            this.MaxHealthLabel.Text = "Max Health:";
            // 
            // AbilityGroupbox
            // 
            this.AbilityGroupbox.Controls.Add(this.StrenghtCheck);
            this.AbilityGroupbox.Controls.Add(this.SwordThrowCheck);
            this.AbilityGroupbox.Controls.Add(this.JumpCheck);
            this.AbilityGroupbox.Controls.Add(this.AnimalTalkCheck);
            this.AbilityGroupbox.Location = new System.Drawing.Point(4, 72);
            this.AbilityGroupbox.Name = "AbilityGroupbox";
            this.AbilityGroupbox.Size = new System.Drawing.Size(132, 96);
            this.AbilityGroupbox.TabIndex = 7;
            this.AbilityGroupbox.TabStop = false;
            this.AbilityGroupbox.Text = "Abilities";
            // 
            // StrenghtCheck
            // 
            this.StrenghtCheck.AutoSize = true;
            this.StrenghtCheck.Location = new System.Drawing.Point(4, 76);
            this.StrenghtCheck.Name = "StrenghtCheck";
            this.StrenghtCheck.Size = new System.Drawing.Size(77, 17);
            this.StrenghtCheck.TabIndex = 10;
            this.StrenghtCheck.Text = "Lift objects";
            this.StrenghtCheck.UseVisualStyleBackColor = true;
            // 
            // SwordThrowCheck
            // 
            this.SwordThrowCheck.AutoSize = true;
            this.SwordThrowCheck.Location = new System.Drawing.Point(4, 56);
            this.SwordThrowCheck.Name = "SwordThrowCheck";
            this.SwordThrowCheck.Size = new System.Drawing.Size(85, 17);
            this.SwordThrowCheck.TabIndex = 9;
            this.SwordThrowCheck.Text = "Sword throw";
            this.SwordThrowCheck.UseVisualStyleBackColor = true;
            // 
            // JumpCheck
            // 
            this.JumpCheck.AutoSize = true;
            this.JumpCheck.Location = new System.Drawing.Point(4, 36);
            this.JumpCheck.Name = "JumpCheck";
            this.JumpCheck.Size = new System.Drawing.Size(51, 17);
            this.JumpCheck.TabIndex = 8;
            this.JumpCheck.Text = "Jump";
            this.JumpCheck.UseVisualStyleBackColor = true;
            // 
            // AnimalTalkCheck
            // 
            this.AnimalTalkCheck.AutoSize = true;
            this.AnimalTalkCheck.Location = new System.Drawing.Point(4, 16);
            this.AnimalTalkCheck.Name = "AnimalTalkCheck";
            this.AnimalTalkCheck.Size = new System.Drawing.Size(107, 17);
            this.AnimalTalkCheck.TabIndex = 7;
            this.AnimalTalkCheck.Text = "Talk with animals";
            this.AnimalTalkCheck.UseVisualStyleBackColor = true;
            // 
            // AnimalsGroupbox
            // 
            this.AnimalsGroupbox.Controls.Add(this.EggCheck);
            this.AnimalsGroupbox.Controls.Add(this.BatCheck);
            this.AnimalsGroupbox.Controls.Add(this.ArmadilloCheck);
            this.AnimalsGroupbox.Controls.Add(this.CaterpillarCheck);
            this.AnimalsGroupbox.Controls.Add(this.CielCheck);
            this.AnimalsGroupbox.Controls.Add(this.RaccoonCheck);
            this.AnimalsGroupbox.Controls.Add(this.LeviathanCheck);
            this.AnimalsGroupbox.Controls.Add(this.DodoCheck);
            this.AnimalsGroupbox.Controls.Add(this.DinosaurCheck);
            this.AnimalsGroupbox.Controls.Add(this.CharlieCheck);
            this.AnimalsGroupbox.Controls.Add(this.PenguyCheck);
            this.AnimalsGroupbox.Controls.Add(this.LionCheck);
            this.AnimalsGroupbox.Controls.Add(this.MoaCheck);
            this.AnimalsGroupbox.Controls.Add(this.JohnnyCheck);
            this.AnimalsGroupbox.Controls.Add(this.KittyCheck);
            this.AnimalsGroupbox.Location = new System.Drawing.Point(4, 172);
            this.AnimalsGroupbox.Name = "AnimalsGroupbox";
            this.AnimalsGroupbox.Size = new System.Drawing.Size(516, 84);
            this.AnimalsGroupbox.TabIndex = 10;
            this.AnimalsGroupbox.TabStop = false;
            this.AnimalsGroupbox.Text = "Animals";
            // 
            // EggCheck
            // 
            this.EggCheck.AutoSize = true;
            this.EggCheck.Location = new System.Drawing.Point(380, 56);
            this.EggCheck.Name = "EggCheck";
            this.EggCheck.Size = new System.Drawing.Size(78, 17);
            this.EggCheck.TabIndex = 36;
            this.EggCheck.Text = "Egg/Edgar";
            this.EggCheck.UseVisualStyleBackColor = true;
            // 
            // BatCheck
            // 
            this.BatCheck.AutoSize = true;
            this.BatCheck.Location = new System.Drawing.Point(296, 56);
            this.BatCheck.Name = "BatCheck";
            this.BatCheck.Size = new System.Drawing.Size(71, 17);
            this.BatCheck.TabIndex = 33;
            this.BatCheck.Text = "Bat/Batty";
            this.BatCheck.UseVisualStyleBackColor = true;
            // 
            // ArmadilloCheck
            // 
            this.ArmadilloCheck.AutoSize = true;
            this.ArmadilloCheck.Location = new System.Drawing.Point(204, 56);
            this.ArmadilloCheck.Name = "ArmadilloCheck";
            this.ArmadilloCheck.Size = new System.Drawing.Size(89, 17);
            this.ArmadilloCheck.TabIndex = 30;
            this.ArmadilloCheck.Text = "Armadillo/Rio";
            this.ArmadilloCheck.UseVisualStyleBackColor = true;
            // 
            // CaterpillarCheck
            // 
            this.CaterpillarCheck.AutoSize = true;
            this.CaterpillarCheck.Location = new System.Drawing.Point(92, 56);
            this.CaterpillarCheck.Name = "CaterpillarCheck";
            this.CaterpillarCheck.Size = new System.Drawing.Size(109, 17);
            this.CaterpillarCheck.TabIndex = 27;
            this.CaterpillarCheck.Text = "Caterpillar/Pieces";
            this.CaterpillarCheck.UseVisualStyleBackColor = true;
            // 
            // CielCheck
            // 
            this.CielCheck.AutoSize = true;
            this.CielCheck.Location = new System.Drawing.Point(4, 56);
            this.CielCheck.Name = "CielCheck";
            this.CielCheck.Size = new System.Drawing.Size(71, 17);
            this.CielCheck.TabIndex = 24;
            this.CielCheck.Text = "Ciel/Cecil";
            this.CielCheck.UseVisualStyleBackColor = true;
            // 
            // RaccoonCheck
            // 
            this.RaccoonCheck.AutoSize = true;
            this.RaccoonCheck.Location = new System.Drawing.Point(380, 36);
            this.RaccoonCheck.Name = "RaccoonCheck";
            this.RaccoonCheck.Size = new System.Drawing.Size(124, 17);
            this.RaccoonCheck.TabIndex = 35;
            this.RaccoonCheck.Text = "RaccoonDog/Wong";
            this.RaccoonCheck.UseVisualStyleBackColor = true;
            // 
            // LeviathanCheck
            // 
            this.LeviathanCheck.AutoSize = true;
            this.LeviathanCheck.Location = new System.Drawing.Point(296, 36);
            this.LeviathanCheck.Name = "LeviathanCheck";
            this.LeviathanCheck.Size = new System.Drawing.Size(73, 17);
            this.LeviathanCheck.TabIndex = 32;
            this.LeviathanCheck.Text = "Leviathan";
            this.LeviathanCheck.UseVisualStyleBackColor = true;
            // 
            // DodoCheck
            // 
            this.DodoCheck.AutoSize = true;
            this.DodoCheck.Location = new System.Drawing.Point(204, 36);
            this.DodoCheck.Name = "DodoCheck";
            this.DodoCheck.Size = new System.Drawing.Size(52, 17);
            this.DodoCheck.TabIndex = 29;
            this.DodoCheck.Text = "Dodo";
            this.DodoCheck.UseVisualStyleBackColor = true;
            // 
            // DinosaurCheck
            // 
            this.DinosaurCheck.AutoSize = true;
            this.DinosaurCheck.Location = new System.Drawing.Point(92, 36);
            this.DinosaurCheck.Name = "DinosaurCheck";
            this.DinosaurCheck.Size = new System.Drawing.Size(100, 17);
            this.DinosaurCheck.TabIndex = 26;
            this.DinosaurCheck.Text = "Dinosaur/Dippy";
            this.DinosaurCheck.UseVisualStyleBackColor = true;
            // 
            // CharlieCheck
            // 
            this.CharlieCheck.AutoSize = true;
            this.CharlieCheck.Location = new System.Drawing.Point(4, 36);
            this.CharlieCheck.Name = "CharlieCheck";
            this.CharlieCheck.Size = new System.Drawing.Size(88, 17);
            this.CharlieCheck.TabIndex = 23;
            this.CharlieCheck.Text = "Charlie/Flash";
            this.CharlieCheck.UseVisualStyleBackColor = true;
            // 
            // PenguyCheck
            // 
            this.PenguyCheck.AutoSize = true;
            this.PenguyCheck.Location = new System.Drawing.Point(380, 16);
            this.PenguyCheck.Name = "PenguyCheck";
            this.PenguyCheck.Size = new System.Drawing.Size(91, 17);
            this.PenguyCheck.TabIndex = 34;
            this.PenguyCheck.Text = "Penguy/Chilly";
            this.PenguyCheck.UseVisualStyleBackColor = true;
            // 
            // LionCheck
            // 
            this.LionCheck.AutoSize = true;
            this.LionCheck.Location = new System.Drawing.Point(296, 16);
            this.LionCheck.Name = "LionCheck";
            this.LionCheck.Size = new System.Drawing.Size(84, 17);
            this.LionCheck.TabIndex = 31;
            this.LionCheck.Text = "Lion/Inferno";
            this.LionCheck.UseVisualStyleBackColor = true;
            // 
            // MoaCheck
            // 
            this.MoaCheck.AutoSize = true;
            this.MoaCheck.Location = new System.Drawing.Point(204, 16);
            this.MoaCheck.Name = "MoaCheck";
            this.MoaCheck.Size = new System.Drawing.Size(47, 17);
            this.MoaCheck.TabIndex = 28;
            this.MoaCheck.Text = "Moa";
            this.MoaCheck.UseVisualStyleBackColor = true;
            // 
            // JohnnyCheck
            // 
            this.JohnnyCheck.AutoSize = true;
            this.JohnnyCheck.Location = new System.Drawing.Point(92, 16);
            this.JohnnyCheck.Name = "JohnnyCheck";
            this.JohnnyCheck.Size = new System.Drawing.Size(86, 17);
            this.JohnnyCheck.TabIndex = 25;
            this.JohnnyCheck.Text = "Johnny/Mac";
            this.JohnnyCheck.UseVisualStyleBackColor = true;
            // 
            // KittyCheck
            // 
            this.KittyCheck.AutoSize = true;
            this.KittyCheck.Location = new System.Drawing.Point(4, 16);
            this.KittyCheck.Name = "KittyCheck";
            this.KittyCheck.Size = new System.Drawing.Size(46, 17);
            this.KittyCheck.TabIndex = 22;
            this.KittyCheck.Text = "Kitty";
            this.KittyCheck.UseVisualStyleBackColor = true;
            // 
            // InventoryGroupbox
            // 
            this.InventoryGroupbox.Controls.Add(this.HornCheck);
            this.InventoryGroupbox.Controls.Add(this.PowderCheck);
            this.InventoryGroupbox.Controls.Add(this.ShoesCheck);
            this.InventoryGroupbox.Controls.Add(this.PlantCheck);
            this.InventoryGroupbox.Controls.Add(this.HolyCheck);
            this.InventoryGroupbox.Controls.Add(this.GoldCheck);
            this.InventoryGroupbox.Controls.Add(this.SilverCheck);
            this.InventoryGroupbox.Controls.Add(this.BronzeCheck);
            this.InventoryGroupbox.Location = new System.Drawing.Point(140, 72);
            this.InventoryGroupbox.Name = "InventoryGroupbox";
            this.InventoryGroupbox.Size = new System.Drawing.Size(236, 96);
            this.InventoryGroupbox.TabIndex = 8;
            this.InventoryGroupbox.TabStop = false;
            this.InventoryGroupbox.Text = "Inventory";
            // 
            // HornCheck
            // 
            this.HornCheck.AutoSize = true;
            this.HornCheck.Location = new System.Drawing.Point(108, 76);
            this.HornCheck.Name = "HornCheck";
            this.HornCheck.Size = new System.Drawing.Size(123, 17);
            this.HornCheck.TabIndex = 18;
            this.HornCheck.Text = "Mother monster horn";
            this.HornCheck.UseVisualStyleBackColor = true;
            // 
            // PowderCheck
            // 
            this.PowderCheck.AutoSize = true;
            this.PowderCheck.Location = new System.Drawing.Point(108, 56);
            this.PowderCheck.Name = "PowderCheck";
            this.PowderCheck.Size = new System.Drawing.Size(117, 17);
            this.PowderCheck.TabIndex = 17;
            this.PowderCheck.Text = "Awakening powder";
            this.PowderCheck.UseVisualStyleBackColor = true;
            // 
            // ShoesCheck
            // 
            this.ShoesCheck.AutoSize = true;
            this.ShoesCheck.Location = new System.Drawing.Point(108, 36);
            this.ShoesCheck.Name = "ShoesCheck";
            this.ShoesCheck.Size = new System.Drawing.Size(86, 17);
            this.ShoesCheck.TabIndex = 16;
            this.ShoesCheck.Text = "Magic shoes";
            this.ShoesCheck.UseVisualStyleBackColor = true;
            // 
            // PlantCheck
            // 
            this.PlantCheck.AutoSize = true;
            this.PlantCheck.Location = new System.Drawing.Point(108, 16);
            this.PlantCheck.Name = "PlantCheck";
            this.PlantCheck.Size = new System.Drawing.Size(103, 17);
            this.PlantCheck.TabIndex = 15;
            this.PlantCheck.Text = "Giant plant seed";
            this.PlantCheck.UseVisualStyleBackColor = true;
            // 
            // HolyCheck
            // 
            this.HolyCheck.AutoSize = true;
            this.HolyCheck.Location = new System.Drawing.Point(4, 76);
            this.HolyCheck.Name = "HolyCheck";
            this.HolyCheck.Size = new System.Drawing.Size(78, 17);
            this.HolyCheck.TabIndex = 14;
            this.HolyCheck.Text = "Holy sword";
            this.HolyCheck.UseVisualStyleBackColor = true;
            // 
            // GoldCheck
            // 
            this.GoldCheck.AutoSize = true;
            this.GoldCheck.Location = new System.Drawing.Point(4, 56);
            this.GoldCheck.Name = "GoldCheck";
            this.GoldCheck.Size = new System.Drawing.Size(79, 17);
            this.GoldCheck.TabIndex = 13;
            this.GoldCheck.Text = "Gold medal";
            this.GoldCheck.UseVisualStyleBackColor = true;
            // 
            // SilverCheck
            // 
            this.SilverCheck.AutoSize = true;
            this.SilverCheck.Location = new System.Drawing.Point(4, 36);
            this.SilverCheck.Name = "SilverCheck";
            this.SilverCheck.Size = new System.Drawing.Size(83, 17);
            this.SilverCheck.TabIndex = 12;
            this.SilverCheck.Text = "Silver medal";
            this.SilverCheck.UseVisualStyleBackColor = true;
            // 
            // BronzeCheck
            // 
            this.BronzeCheck.AutoSize = true;
            this.BronzeCheck.Location = new System.Drawing.Point(4, 16);
            this.BronzeCheck.Name = "BronzeCheck";
            this.BronzeCheck.Size = new System.Drawing.Size(90, 17);
            this.BronzeCheck.TabIndex = 11;
            this.BronzeCheck.Text = "Bronze medal";
            this.BronzeCheck.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(4, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(4, 48);
            this.NameTextbox.MaxLength = 10;
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(132, 20);
            this.NameTextbox.TabIndex = 3;
            // 
            // ActiveLabel
            // 
            this.ActiveLabel.AutoSize = true;
            this.ActiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.ActiveLabel.ForeColor = System.Drawing.Color.White;
            this.ActiveLabel.Location = new System.Drawing.Point(264, 8);
            this.ActiveLabel.Name = "ActiveLabel";
            this.ActiveLabel.Size = new System.Drawing.Size(177, 13);
            this.ActiveLabel.TabIndex = 14;
            this.ActiveLabel.Text = "Active info should be displayed here";
            // 
            // SecretGroup
            // 
            this.SecretGroup.Controls.Add(this.ResetCheck);
            this.SecretGroup.Controls.Add(this.AbilitiesCheck);
            this.SecretGroup.Location = new System.Drawing.Point(380, 72);
            this.SecretGroup.Name = "SecretGroup";
            this.SecretGroup.Size = new System.Drawing.Size(140, 96);
            this.SecretGroup.TabIndex = 9;
            this.SecretGroup.TabStop = false;
            this.SecretGroup.Text = "Secret menu items";
            // 
            // ResetCheck
            // 
            this.ResetCheck.AutoSize = true;
            this.ResetCheck.Location = new System.Drawing.Point(4, 36);
            this.ResetCheck.Name = "ResetCheck";
            this.ResetCheck.Size = new System.Drawing.Size(71, 17);
            this.ResetCheck.TabIndex = 20;
            this.ResetCheck.Text = "Soft reset";
            this.ResetCheck.UseVisualStyleBackColor = true;
            // 
            // AbilitiesCheck
            // 
            this.AbilitiesCheck.AutoSize = true;
            this.AbilitiesCheck.Location = new System.Drawing.Point(4, 16);
            this.AbilitiesCheck.Name = "AbilitiesCheck";
            this.AbilitiesCheck.Size = new System.Drawing.Size(120, 17);
            this.AbilitiesCheck.TabIndex = 19;
            this.AbilitiesCheck.Text = "Get abilities/animals";
            this.AbilitiesCheck.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(108, 3);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 1;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // SlotTextbox
            // 
            this.SlotTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.SlotTextbox.Location = new System.Drawing.Point(4, 4);
            this.SlotTextbox.Name = "SlotTextbox";
            this.SlotTextbox.ReadOnly = true;
            this.SlotTextbox.Size = new System.Drawing.Size(100, 20);
            this.SlotTextbox.TabIndex = 0;
            this.SlotTextbox.Text = "Save slot info";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(184, 3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenuItem,
            this.menuItem7});
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Index = 0;
            this.FileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OpenMenuItem,
            this.menuItem3,
            this.SaveMenuItem,
            this.SaveAsManuItem,
            this.menuItem5,
            this.QuitMenuItem});
            this.FileMenuItem.Text = "File";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Index = 0;
            this.OpenMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.OpenMenuItem.Text = "Open...";
            this.OpenMenuItem.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Enabled = false;
            this.SaveMenuItem.Index = 2;
            this.SaveMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsManuItem
            // 
            this.SaveAsManuItem.Enabled = false;
            this.SaveAsManuItem.Index = 3;
            this.SaveAsManuItem.Text = "Save as...";
            this.SaveAsManuItem.Click += new System.EventHandler(this.SaveAsManuItem_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            // 
            // QuitMenuItem
            // 
            this.QuitMenuItem.Index = 5;
            this.QuitMenuItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.QuitMenuItem.Text = "Quit";
            this.QuitMenuItem.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ReadMeMenuItem,
            this.menuItem11,
            this.AboutMenuItem});
            this.menuItem7.Text = "Help";
            // 
            // ReadMeMenuItem
            // 
            this.ReadMeMenuItem.Index = 0;
            this.ReadMeMenuItem.Text = "ReadMe";
            this.ReadMeMenuItem.Click += new System.EventHandler(this.ReadMeMenuItem_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 1;
            this.menuItem11.Text = "-";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Index = 2;
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 261);
            this.Controls.Add(this.AbilityGroupbox);
            this.Controls.Add(this.InventoryGroupbox);
            this.Controls.Add(this.SecretGroup);
            this.Controls.Add(this.AnimalsGroupbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.MaxHealthLabel);
            this.Controls.Add(this.CoinsNumeric);
            this.Controls.Add(this.SlotTextbox);
            this.Controls.Add(this.ActiveLabel);
            this.Controls.Add(this.MaxHealthNumeric);
            this.Controls.Add(this.CoinsLabel);
            this.Controls.Add(this.HealthNumeric);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.MainMenu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.CoinsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHealthNumeric)).EndInit();
            this.AbilityGroupbox.ResumeLayout(false);
            this.AbilityGroupbox.PerformLayout();
            this.AnimalsGroupbox.ResumeLayout(false);
            this.AnimalsGroupbox.PerformLayout();
            this.InventoryGroupbox.ResumeLayout(false);
            this.InventoryGroupbox.PerformLayout();
            this.SecretGroup.ResumeLayout(false);
            this.SecretGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoinsLabel;
        private System.Windows.Forms.NumericUpDown CoinsNumeric;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.NumericUpDown HealthNumeric;
        private System.Windows.Forms.NumericUpDown MaxHealthNumeric;
        private System.Windows.Forms.Label MaxHealthLabel;
        private System.Windows.Forms.GroupBox AbilityGroupbox;
        private System.Windows.Forms.CheckBox SwordThrowCheck;
        private System.Windows.Forms.CheckBox JumpCheck;
        private System.Windows.Forms.CheckBox AnimalTalkCheck;
        private System.Windows.Forms.GroupBox AnimalsGroupbox;
        private System.Windows.Forms.CheckBox EggCheck;
        private System.Windows.Forms.CheckBox BatCheck;
        private System.Windows.Forms.CheckBox ArmadilloCheck;
        private System.Windows.Forms.CheckBox CaterpillarCheck;
        private System.Windows.Forms.CheckBox CielCheck;
        private System.Windows.Forms.CheckBox RaccoonCheck;
        private System.Windows.Forms.CheckBox LeviathanCheck;
        private System.Windows.Forms.CheckBox DodoCheck;
        private System.Windows.Forms.CheckBox DinosaurCheck;
        private System.Windows.Forms.CheckBox CharlieCheck;
        private System.Windows.Forms.CheckBox PenguyCheck;
        private System.Windows.Forms.CheckBox LionCheck;
        private System.Windows.Forms.CheckBox MoaCheck;
        private System.Windows.Forms.CheckBox JohnnyCheck;
        private System.Windows.Forms.CheckBox KittyCheck;
        private System.Windows.Forms.GroupBox InventoryGroupbox;
        private System.Windows.Forms.CheckBox GoldCheck;
        private System.Windows.Forms.CheckBox SilverCheck;
        private System.Windows.Forms.CheckBox BronzeCheck;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.CheckBox HolyCheck;
        private System.Windows.Forms.CheckBox HornCheck;
        private System.Windows.Forms.CheckBox PowderCheck;
        private System.Windows.Forms.CheckBox ShoesCheck;
        private System.Windows.Forms.CheckBox PlantCheck;
        private System.Windows.Forms.CheckBox StrenghtCheck;
        private System.Windows.Forms.Label ActiveLabel;
        private System.Windows.Forms.GroupBox SecretGroup;
        private System.Windows.Forms.CheckBox ResetCheck;
        private System.Windows.Forms.CheckBox AbilitiesCheck;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.TextBox SlotTextbox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem FileMenuItem;
        private System.Windows.Forms.MenuItem OpenMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem SaveMenuItem;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem QuitMenuItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem AboutMenuItem;
        private System.Windows.Forms.MenuItem SaveAsManuItem;
        private System.Windows.Forms.MenuItem ReadMeMenuItem;
        private System.Windows.Forms.MenuItem menuItem11;
    }
}