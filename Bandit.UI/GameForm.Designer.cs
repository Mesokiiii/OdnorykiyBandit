namespace Bandit.UI
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.lblBalance = new System.Windows.Forms.Label();
            this.pbSlot3 = new System.Windows.Forms.PictureBox();
            this.pbSlot2 = new System.Windows.Forms.PictureBox();
            this.pbSlot1 = new System.Windows.Forms.PictureBox();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnBet10 = new System.Windows.Forms.Button();
            this.btnBet50 = new System.Windows.Forms.Button();
            this.btnBet100 = new System.Windows.Forms.Button();
            this.btnBet500 = new System.Windows.Forms.Button();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLastWin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.ForeColor = System.Drawing.Color.Gold;
            this.lblBalance.Location = new System.Drawing.Point(457, 16);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(83, 25);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Баланс";
            // 
            // pbSlot3
            // 
            this.pbSlot3.Location = new System.Drawing.Point(572, 245);
            this.pbSlot3.Name = "pbSlot3";
            this.pbSlot3.Size = new System.Drawing.Size(111, 160);
            this.pbSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlot3.TabIndex = 1;
            this.pbSlot3.TabStop = false;
            // 
            // pbSlot2
            // 
            this.pbSlot2.Location = new System.Drawing.Point(425, 240);
            this.pbSlot2.Name = "pbSlot2";
            this.pbSlot2.Size = new System.Drawing.Size(115, 165);
            this.pbSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlot2.TabIndex = 2;
            this.pbSlot2.TabStop = false;
            // 
            // pbSlot1
            // 
            this.pbSlot1.Location = new System.Drawing.Point(299, 240);
            this.pbSlot1.Name = "pbSlot1";
            this.pbSlot1.Size = new System.Drawing.Size(93, 160);
            this.pbSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlot1.TabIndex = 3;
            this.pbSlot1.TabStop = false;
            this.pbSlot1.Click += new System.EventHandler(this.pbSlot1_Click);
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBet.Location = new System.Drawing.Point(164, 15);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(179, 26);
            this.txtBet.TabIndex = 4;
            this.txtBet.TextChanged += new System.EventHandler(this.txtBet_TextChanged);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Crimson;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpin.ForeColor = System.Drawing.Color.White;
            this.btnSpin.Location = new System.Drawing.Point(416, 432);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(153, 70);
            this.btnSpin.TabIndex = 5;
            this.btnSpin.Text = "КРУТИТЬ";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 50;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(12, 563);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(146, 40);
            this.btnStatistics.TabIndex = 6;
            this.btnStatistics.Text = "Статистика";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(12, 504);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(120, 40);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "История";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnBet10
            // 
            this.btnBet10.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBet10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBet10.ForeColor = System.Drawing.Color.White;
            this.btnBet10.Location = new System.Drawing.Point(12, 60);
            this.btnBet10.Name = "btnBet10";
            this.btnBet10.Size = new System.Drawing.Size(70, 35);
            this.btnBet10.TabIndex = 8;
            this.btnBet10.Text = "10";
            this.btnBet10.UseVisualStyleBackColor = false;
            this.btnBet10.Click += new System.EventHandler(this.btnBet10_Click);
            // 
            // btnBet50
            // 
            this.btnBet50.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBet50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBet50.ForeColor = System.Drawing.Color.White;
            this.btnBet50.Location = new System.Drawing.Point(88, 60);
            this.btnBet50.Name = "btnBet50";
            this.btnBet50.Size = new System.Drawing.Size(70, 35);
            this.btnBet50.TabIndex = 9;
            this.btnBet50.Text = "50";
            this.btnBet50.UseVisualStyleBackColor = false;
            this.btnBet50.Click += new System.EventHandler(this.btnBet50_Click);
            // 
            // btnBet100
            // 
            this.btnBet100.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBet100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBet100.ForeColor = System.Drawing.Color.White;
            this.btnBet100.Location = new System.Drawing.Point(12, 114);
            this.btnBet100.Name = "btnBet100";
            this.btnBet100.Size = new System.Drawing.Size(70, 35);
            this.btnBet100.TabIndex = 10;
            this.btnBet100.Text = "100";
            this.btnBet100.UseVisualStyleBackColor = false;
            this.btnBet100.Click += new System.EventHandler(this.btnBet100_Click);
            // 
            // btnBet500
            // 
            this.btnBet500.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBet500.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBet500.ForeColor = System.Drawing.Color.White;
            this.btnBet500.Location = new System.Drawing.Point(88, 114);
            this.btnBet500.Name = "btnBet500";
            this.btnBet500.Size = new System.Drawing.Size(70, 35);
            this.btnBet500.TabIndex = 11;
            this.btnBet500.Text = "500";
            this.btnBet500.UseVisualStyleBackColor = false;
            this.btnBet500.Click += new System.EventHandler(this.btnBet500_Click);
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.AutoSize = true;
            this.lblTotalGames.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalGames.ForeColor = System.Drawing.Color.White;
            this.lblTotalGames.Location = new System.Drawing.Point(780, 129);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(57, 20);
            this.lblTotalGames.TabIndex = 12;
            this.lblTotalGames.Text = "Игр: 0";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.BackColor = System.Drawing.Color.Transparent;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWins.ForeColor = System.Drawing.Color.White;
            this.lblWins.Location = new System.Drawing.Point(780, 160);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(126, 20);
            this.lblWins.TabIndex = 13;
            this.lblWins.Text = "Выигрышей: 0";
            // 
            // lblLastWin
            // 
            this.lblLastWin.AutoSize = true;
            this.lblLastWin.BackColor = System.Drawing.Color.Transparent;
            this.lblLastWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastWin.ForeColor = System.Drawing.Color.LightGreen;
            this.lblLastWin.Location = new System.Drawing.Point(780, 100);
            this.lblLastWin.Name = "lblLastWin";
            this.lblLastWin.Size = new System.Drawing.Size(200, 20);
            this.lblLastWin.TabIndex = 14;
            this.lblLastWin.Text = "Последний выигрыш: -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ваша ставка:";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 618);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(180, 40);
            this.btnBackToMenu.TabIndex = 16;
            this.btnBackToMenu.Text = "🏠 Главное меню";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.Yellow;
            this.lblDifficulty.Location = new System.Drawing.Point(732, 13);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(120, 29);
            this.lblDifficulty.TabIndex = 17;
            this.lblDifficulty.Text = "Уровень";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 695);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastWin);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblTotalGames);
            this.Controls.Add(this.btnBet500);
            this.Controls.Add(this.btnBet100);
            this.Controls.Add(this.btnBet50);
            this.Controls.Add(this.btnBet10);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.pbSlot1);
            this.Controls.Add(this.pbSlot2);
            this.Controls.Add(this.pbSlot3);
            this.Controls.Add(this.lblBalance);
            this.Name = "GameForm";
            this.Text = "Однорукий бандит - Игра";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.PictureBox pbSlot3;
        private System.Windows.Forms.PictureBox pbSlot2;
        private System.Windows.Forms.PictureBox pbSlot1;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnBet10;
        private System.Windows.Forms.Button btnBet50;
        private System.Windows.Forms.Button btnBet100;
        private System.Windows.Forms.Button btnBet500;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLastWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label lblDifficulty;
    }
}