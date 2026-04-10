using System;
using System.Windows.Forms;

namespace Bandit.UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Начать игру?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Открываем НОВУЮ форму игры
                GameForm game = new GameForm(5000);
                game.Show();
                this.Hide(); // Прячем розовый экран
            }
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomBalance = new System.Windows.Forms.Button();
            this.btnQuickStart = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSelectDifficulty = new System.Windows.Forms.Label();
            this.panelDifficulty = new System.Windows.Forms.Panel();
            this.panelDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(746, 72);
            this.label2.TabIndex = 2;
            this.label2.Text = "🎰 Однорукий бандит 🎰";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(10, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "⚡ Нормальный\n(3000 руб.)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(10, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(276, 65);
            this.button4.TabIndex = 7;
            this.button4.Text = "😊 Легкий\n(5000 руб.)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(10, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 65);
            this.button5.TabIndex = 8;
            this.button5.Text = "🔥 Сложный\n(1000 руб.)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(60, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "ℹ️ Об игре";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Груздев Андрей Б.ПИН.ИИ.25.16";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnCustomBalance
            // 
            this.btnCustomBalance.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCustomBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustomBalance.ForeColor = System.Drawing.Color.White;
            this.btnCustomBalance.Location = new System.Drawing.Point(550, 220);
            this.btnCustomBalance.Name = "btnCustomBalance";
            this.btnCustomBalance.Size = new System.Drawing.Size(200, 70);
            this.btnCustomBalance.TabIndex = 11;
            this.btnCustomBalance.Text = "💰 Свой баланс";
            this.btnCustomBalance.UseVisualStyleBackColor = false;
            this.btnCustomBalance.Click += new System.EventHandler(this.btnCustomBalance_Click);
            // 
            // btnQuickStart
            // 
            this.btnQuickStart.BackColor = System.Drawing.Color.Gold;
            this.btnQuickStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuickStart.ForeColor = System.Drawing.Color.DarkRed;
            this.btnQuickStart.Location = new System.Drawing.Point(550, 310);
            this.btnQuickStart.Name = "btnQuickStart";
            this.btnQuickStart.Size = new System.Drawing.Size(200, 70);
            this.btnQuickStart.TabIndex = 12;
            this.btnQuickStart.Text = "⚡ Быстрый\nстарт";
            this.btnQuickStart.UseVisualStyleBackColor = false;
            this.btnQuickStart.Click += new System.EventHandler(this.btnQuickStart_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Teal;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRules.ForeColor = System.Drawing.Color.White;
            this.btnRules.Location = new System.Drawing.Point(231, 450);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(150, 50);
            this.btnRules.TabIndex = 13;
            this.btnRules.Text = "📜 Правила";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(405, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "❌ Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(250, 100);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(415, 31);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Добро пожаловать в казино! 🎲";
            // 
            // lblSelectDifficulty
            // 
            this.lblSelectDifficulty.AutoSize = true;
            this.lblSelectDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectDifficulty.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblSelectDifficulty.Location = new System.Drawing.Point(50, 150);
            this.lblSelectDifficulty.Name = "lblSelectDifficulty";
            this.lblSelectDifficulty.Size = new System.Drawing.Size(240, 27);
            this.lblSelectDifficulty.TabIndex = 16;
            this.lblSelectDifficulty.Text = "Выберите сложность:";
            // 
            // panelDifficulty
            // 
            this.panelDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.panelDifficulty.Controls.Add(this.button4);
            this.panelDifficulty.Controls.Add(this.button2);
            this.panelDifficulty.Controls.Add(this.button5);
            this.panelDifficulty.Location = new System.Drawing.Point(50, 190);
            this.panelDifficulty.Name = "panelDifficulty";
            this.panelDifficulty.Size = new System.Drawing.Size(289, 254);
            this.panelDifficulty.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 579);
            this.Controls.Add(this.panelDifficulty);
            this.Controls.Add(this.lblSelectDifficulty);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnQuickStart);
            this.Controls.Add(this.btnCustomBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Однорукий бандит - Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDifficulty.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomBalance;
        private System.Windows.Forms.Button btnQuickStart;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelectDifficulty;
        private System.Windows.Forms.Panel panelDifficulty;
    }
}

