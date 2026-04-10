using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bandit.Logic; // ОБЯЗАТЕЛЬНО добавь это в самый верх

namespace Bandit.UI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        private Image GetImageBySymbol(SlotSymbol symbol)
        {
            switch (symbol)
            {
                case SlotSymbol.Cherry: return Properties.Resources.Cherry;
                case SlotSymbol.Lemon: return Properties.Resources.Lemon;
                case SlotSymbol.Plum: return Properties.Resources.Plum;
                case SlotSymbol.Bell: return Properties.Resources.Bell;
                case SlotSymbol.Seven: return Properties.Resources.Seven;
                default: return null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Начать игру в НОРМАЛЬНОМ режиме?\n\nНачальный баланс: 3000 руб.", 
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GameForm gameForm = new GameForm(3000);
                    gameForm.FormClosed += (s, args) => this.Show();
                    gameForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске игры:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите начать игру в ЛЕГКОМ режиме?", 
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GameForm gameForm = new GameForm(5000);
                    gameForm.FormClosed += (s, args) => this.Show();
                    gameForm.Show();
                    this.Hide();
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Недостаточно памяти для запуска игры.", 
                    "Ошибка памяти", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске игры:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Начать игру в СЛОЖНОМ режиме?\n\nНачальный баланс: 1000 руб.\nДля опытных игроков!", 
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GameForm gameForm = new GameForm(1000);
                    gameForm.FormClosed += (s, args) => this.Show();
                    gameForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске игры:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomBalance_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Введите начальный баланс (от 100 до 100000 руб.):",
                    "Свой баланс",
                    "5000");

                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (decimal.TryParse(input, out decimal balance))
                {
                    if (balance < 100 || balance > 100000)
                    {
                        MessageBox.Show("Баланс должен быть от 100 до 100000 рублей!", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    GameForm gameForm = new GameForm(balance);
                    gameForm.FormClosed += (s, args) => this.Show();
                    gameForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Введите корректное число!", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuickStart_Click(object sender, EventArgs e)
        {
            try
            {
                GameForm gameForm = new GameForm(5000);
                gameForm.FormClosed += (s, args) => this.Show();
                gameForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске игры:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            try
            {
                string rules = "=== ПРАВИЛА ИГРЫ ===\n\n" +
                    "🎰 ЦЕЛЬ ИГРЫ:\n" +
                    "Собрать 3 одинаковых символа на барабанах\n\n" +
                    "💰 КАК ИГРАТЬ:\n" +
                    "1. Выберите размер ставки\n" +
                    "2. Нажмите кнопку 'КРУТИТЬ'\n" +
                    "3. Дождитесь остановки барабанов\n\n" +
                    "🏆 ВЫИГРЫШИ:\n" +
                    "🍒 Вишня x2\n" +
                    "🍋 Лимон x3\n" +
                    "🍇 Слива x5\n" +
                    "🔔 Колокол x10\n" +
                    "7️⃣ Семёрка x20\n\n" +
                    "📊 УРОВНИ СЛОЖНОСТИ:\n" +
                    "😊 Легкий - 5000 руб.\n" +
                    "⚡ Нормальный - 3000 руб.\n" +
                    "🔥 Сложный - 1000 руб.\n\n" +
                    "Удачи! 🍀";

                MessageBox.Show(rules, "Правила игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", 
                    "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Правила игры:\n1. Выберите ставку.\n2. Нажмите 'Крутить'.\n3. Соберите 3 одинаковых символа для победы!\n\nРазработчик: Груздев Андрей", 
                    "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отображении справки:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
