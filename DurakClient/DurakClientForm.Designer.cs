namespace DurakClient
{
    partial class DurakClientForm
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
            this.lblGameDeck = new System.Windows.Forms.Label();
            this.lblComputerAttacking = new System.Windows.Forms.Label();
            this.lblHumanAttacking = new System.Windows.Forms.Label();
            this.lblTrumpCard = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.flpComputerHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRiver = new System.Windows.Forms.FlowLayoutPanel();
            this.flpHumanHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTrumpCard = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCeaseAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameDeck
            // 
            this.lblGameDeck.AutoSize = true;
            this.lblGameDeck.BackColor = System.Drawing.Color.Green;
            this.lblGameDeck.Location = new System.Drawing.Point(890, 90);
            this.lblGameDeck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameDeck.Name = "lblGameDeck";
            this.lblGameDeck.Size = new System.Drawing.Size(90, 13);
            this.lblGameDeck.TabIndex = 0;
            this.lblGameDeck.Text = "Игровая Колода";
            // 
            // lblComputerAttacking
            // 
            this.lblComputerAttacking.AutoEllipsis = true;
            this.lblComputerAttacking.AutoSize = true;
            this.lblComputerAttacking.BackColor = System.Drawing.Color.Red;
            this.lblComputerAttacking.Location = new System.Drawing.Point(160, 50);
            this.lblComputerAttacking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComputerAttacking.Name = "lblComputerAttacking";
            this.lblComputerAttacking.Size = new System.Drawing.Size(93, 13);
            this.lblComputerAttacking.TabIndex = 4;
            this.lblComputerAttacking.Text = "Ход Компьютера";
            // 
            // lblHumanAttacking
            // 
            this.lblHumanAttacking.BackColor = System.Drawing.Color.Red;
            this.lblHumanAttacking.Location = new System.Drawing.Point(160, 465);
            this.lblHumanAttacking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHumanAttacking.Name = "lblHumanAttacking";
            this.lblHumanAttacking.Size = new System.Drawing.Size(54, 13);
            this.lblHumanAttacking.TabIndex = 5;
            this.lblHumanAttacking.Text = "Ваш Ход";
            // 
            // lblTrumpCard
            // 
            this.lblTrumpCard.AutoSize = true;
            this.lblTrumpCard.BackColor = System.Drawing.Color.Green;
            this.lblTrumpCard.Location = new System.Drawing.Point(909, 356);
            this.lblTrumpCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrumpCard.Name = "lblTrumpCard";
            this.lblTrumpCard.Size = new System.Drawing.Size(46, 13);
            this.lblTrumpCard.TabIndex = 6;
            this.lblTrumpCard.Text = "Козырь";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(32, 196);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(142, 78);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Новая Игра";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnPickUp
            // 
            this.btnPickUp.Location = new System.Drawing.Point(881, 465);
            this.btnPickUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(56, 52);
            this.btnPickUp.TabIndex = 8;
            this.btnPickUp.Text = "Взять";
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // flpComputerHand
            // 
            this.flpComputerHand.BackColor = System.Drawing.Color.Transparent;
            this.flpComputerHand.Location = new System.Drawing.Point(270, 17);
            this.flpComputerHand.Margin = new System.Windows.Forms.Padding(2);
            this.flpComputerHand.Name = "flpComputerHand";
            this.flpComputerHand.Size = new System.Drawing.Size(555, 197);
            this.flpComputerHand.TabIndex = 9;
            // 
            // flpRiver
            // 
            this.flpRiver.BackColor = System.Drawing.Color.Transparent;
            this.flpRiver.Location = new System.Drawing.Point(270, 219);
            this.flpRiver.Margin = new System.Windows.Forms.Padding(2);
            this.flpRiver.Name = "flpRiver";
            this.flpRiver.Size = new System.Drawing.Size(555, 222);
            this.flpRiver.TabIndex = 10;
            // 
            // flpHumanHand
            // 
            this.flpHumanHand.BackColor = System.Drawing.Color.Transparent;
            this.flpHumanHand.Location = new System.Drawing.Point(270, 445);
            this.flpHumanHand.Margin = new System.Windows.Forms.Padding(2);
            this.flpHumanHand.Name = "flpHumanHand";
            this.flpHumanHand.Size = new System.Drawing.Size(555, 214);
            this.flpHumanHand.TabIndex = 11;
            // 
            // flpDeck
            // 
            this.flpDeck.BackColor = System.Drawing.Color.Transparent;
            this.flpDeck.Location = new System.Drawing.Point(881, 118);
            this.flpDeck.Margin = new System.Windows.Forms.Padding(2);
            this.flpDeck.Name = "flpDeck";
            this.flpDeck.Size = new System.Drawing.Size(99, 121);
            this.flpDeck.TabIndex = 12;
            // 
            // flpTrumpCard
            // 
            this.flpTrumpCard.BackColor = System.Drawing.Color.Transparent;
            this.flpTrumpCard.Location = new System.Drawing.Point(881, 243);
            this.flpTrumpCard.Margin = new System.Windows.Forms.Padding(2);
            this.flpTrumpCard.Name = "flpTrumpCard";
            this.flpTrumpCard.Size = new System.Drawing.Size(99, 111);
            this.flpTrumpCard.TabIndex = 13;
            // 
            // btnCeaseAttack
            // 
            this.btnCeaseAttack.Location = new System.Drawing.Point(941, 465);
            this.btnCeaseAttack.Margin = new System.Windows.Forms.Padding(2);
            this.btnCeaseAttack.Name = "btnCeaseAttack";
            this.btnCeaseAttack.Size = new System.Drawing.Size(59, 52);
            this.btnCeaseAttack.TabIndex = 19;
            this.btnCeaseAttack.Text = "Бито";
            this.btnCeaseAttack.UseVisualStyleBackColor = true;
            this.btnCeaseAttack.Click += new System.EventHandler(this.btnCeaseAttack_Click);
            // 
            // DurakClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakClient.Properties.Resources.image03_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 790);
            this.Controls.Add(this.btnCeaseAttack);
            this.Controls.Add(this.flpDeck);
            this.Controls.Add(this.flpHumanHand);
            this.Controls.Add(this.flpRiver);
            this.Controls.Add(this.flpComputerHand);
            this.Controls.Add(this.btnPickUp);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblTrumpCard);
            this.Controls.Add(this.lblHumanAttacking);
            this.Controls.Add(this.lblComputerAttacking);
            this.Controls.Add(this.lblGameDeck);
            this.Controls.Add(this.flpTrumpCard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DurakClientForm";
            this.Text = "DurakClient";
            this.Load += new System.EventHandler(this.DurakClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameDeck;
        private System.Windows.Forms.Label lblComputerAttacking;
        private System.Windows.Forms.Label lblHumanAttacking;
        private System.Windows.Forms.Label lblTrumpCard;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.FlowLayoutPanel flpComputerHand;
        private System.Windows.Forms.FlowLayoutPanel flpRiver;
        private System.Windows.Forms.FlowLayoutPanel flpHumanHand;
        private System.Windows.Forms.FlowLayoutPanel flpDeck;
        private System.Windows.Forms.FlowLayoutPanel flpTrumpCard;
        private System.Windows.Forms.Button btnCeaseAttack;
    }
}