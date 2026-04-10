using System;
using System.Drawing;
using System.Windows.Forms;
using Bandit.Logic; // Подключаем твою логику

namespace Bandit.UI
{
    public partial class GameForm : Form
    {
        private Player _player;
        private SlotMachine _machine = new SlotMachine();
        private FileManager _logger = new FileManager();
        private GameStatistics _statistics = new GameStatistics();
        private GameHistory _history = new GameHistory();
        private int _animationTicks = 0;
        private SlotSymbol[] _lastResult;
        private string _difficultyLevel;

        public GameForm(decimal balance)
        {
            try
            {
                InitializeComponent();
                
                if (balance < 0)
                {
                    throw new ArgumentException("Баланс не может быть отрицательным.");
                }
                
                _player = new Player(balance);
                lblBalance.Text = $"Баланс: {_player.Balance:F2} руб.";
                
                // Определяем уровень сложности
                if (balance >= 5000)
                    _difficultyLevel = "😊 Легкий";
                else if (balance >= 3000)
                    _difficultyLevel = "⚡ Нормальный";
                else if (balance >= 1000)
                    _difficultyLevel = "🔥 Сложный";
                else
                    _difficultyLevel = "💰 Свой баланс";
                
                this.Text = $"Однорукий бандит - {_difficultyLevel}";
                lblDifficulty.Text = _difficultyLevel;
                
                // Устанавливаем начальные символы 777
                pbSlot1.Image = GetImageBySymbol(SlotSymbol.Seven);
                pbSlot2.Image = GetImageBySymbol(SlotSymbol.Seven);
                pbSlot3.Image = GetImageBySymbol(SlotSymbol.Seven);
                
                UpdateStatisticsDisplay();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка инициализации игры:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неожиданная ошибка при создании игры:\n{ex.Message}", 
                    "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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

        private void btnSpin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBet.Text))
                {
                    MessageBox.Show("Введите ставку.", "Ошибка ввода", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal bet;
                if (!decimal.TryParse(txtBet.Text, out bet))
                {
                    MessageBox.Show("Ставка должна быть числом.", "Ошибка ввода", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bet <= 0)
                {
                    MessageBox.Show("Ставка должна быть больше нуля.", "Ошибка ввода", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bet > _player.Balance)
                {
                    MessageBox.Show($"Недостаточно средств!\n\nВаш баланс: {_player.Balance:F2} руб.\nВаша ставка: {bet:F2} руб.\nНехватает: {(bet - _player.Balance):F2} руб.", 
                        "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _player.Withdraw(bet);
                lblBalance.Text = $"Баланс: {_player.Balance:F2} руб.";

                _animationTicks = 30;
                btnSpin.Enabled = false;
                txtBet.Enabled = false;
                timerAnimation.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ставки. Введите корректное число.", 
                    "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Слишком большое значение ставки.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, 
                    "Ошибка операции", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSpin.Enabled = true;
                txtBet.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неожиданная ошибка:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSpin.Enabled = true;
                txtBet.Enabled = true;
            }
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_animationTicks > 0)
                {
                    SlotSymbol[] temp = _machine.Spin();
                    pbSlot1.Image = GetImageBySymbol(temp[0]);
                    pbSlot2.Image = GetImageBySymbol(temp[1]);
                    pbSlot3.Image = GetImageBySymbol(temp[2]);
                    _animationTicks--;
                }
                else
                {
                    timerAnimation.Stop();
                    btnSpin.Enabled = true;
                    txtBet.Enabled = true;

                    SlotSymbol[] final = _machine.Spin();
                    pbSlot1.Image = GetImageBySymbol(final[0]);
                    pbSlot2.Image = GetImageBySymbol(final[1]);
                    pbSlot3.Image = GetImageBySymbol(final[2]);
                    
                    _lastResult = final;

                    decimal bet = decimal.Parse(txtBet.Text);
                    int mult = _machine.CalculateWin(final);
                    decimal win = bet * mult;

                    if (win > 0)
                    {
                        _player.Deposit(win);
                    }

                    _statistics.RecordGame(bet, win);
                    _history.AddRecord(bet, win, _player.Balance, final);

                    try
                    {
                        _logger.SaveResult(bet, win, _player.Balance);
                    }
                    catch (System.IO.IOException ioEx)
                    {
                        MessageBox.Show($"Ошибка записи в файл:\n{ioEx.Message}\nИгра продолжится без сохранения.", 
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Нет доступа для записи результатов. Проверьте права доступа.", 
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    lblBalance.Text = $"Баланс: {_player.Balance:F2} руб.";
                    UpdateStatisticsDisplay();

                    if (win > 0)
                    {
                        MessageBox.Show($"Поздравляем!\n\nВыигрыш: {win:F2} руб.\nВаш баланс: {_player.Balance:F2} руб.", 
                            "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"К сожалению, вы проиграли.\n\nПотеря: {bet:F2} руб.\nВаш баланс: {_player.Balance:F2} руб.", 
                            "Проигрыш", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (_player.Balance <= 0)
                    {
                        MessageBox.Show("Ваш баланс исчерпан!\n\nВы ушли в ноль. Игра окончена.", 
                            "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.Close();
                    }
                    else if (_player.Balance < 10)
                    {
                        MessageBox.Show($"Внимание!\n\nУ вас осталось всего {_player.Balance:F2} руб.\nРекомендуем делать небольшие ставки.", 
                            "Низкий баланс", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (NullReferenceException)
            {
                timerAnimation.Stop();
                btnSpin.Enabled = true;
                txtBet.Enabled = true;
                MessageBox.Show("Ошибка: отсутствуют необходимые данные игры.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                timerAnimation.Stop();
                btnSpin.Enabled = true;
                txtBet.Enabled = true;
                MessageBox.Show($"Ошибка во время игры:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbSlot1_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateStatisticsDisplay()
        {
            lblTotalGames.Text = $"Игр: {_statistics.TotalGames}";
            lblWins.Text = $"Выигрышей: {_statistics.Wins} ({_statistics.WinRate:F1}%)";
            lblLastWin.Text = _statistics.LastWin > 0 
                ? $"Последний выигрыш: {_statistics.LastWin:F2} руб." 
                : "Последний выигрыш: -";
        }

        private void btnBet10_Click(object sender, EventArgs e)
        {
            txtBet.Text = "10";
        }

        private void btnBet50_Click(object sender, EventArgs e)
        {
            txtBet.Text = "50";
        }

        private void btnBet100_Click(object sender, EventArgs e)
        {
            txtBet.Text = "100";
        }

        private void btnBet500_Click(object sender, EventArgs e)
        {
            txtBet.Text = "500";
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            try
            {
                string stats = $"=== СТАТИСТИКА ИГРЫ ===\n\n" +
                    $"Всего игр: {_statistics.TotalGames}\n" +
                    $"Выигрышей: {_statistics.Wins}\n" +
                    $"Проигрышей: {_statistics.Losses}\n" +
                    $"Процент побед: {_statistics.WinRate:F2}%\n\n" +
                    $"Всего выиграно: {_statistics.TotalWinnings:F2} руб.\n" +
                    $"Всего проиграно: {_statistics.TotalLosses:F2} руб.\n" +
                    $"Чистая прибыль: {_statistics.NetProfit:F2} руб.\n\n" +
                    $"Максимальный выигрыш: {_statistics.MaxWin:F2} руб.\n" +
                    $"Последний выигрыш: {_statistics.LastWin:F2} руб.\n\n" +
                    $"Время игры: {_statistics.PlayTime.Hours}ч {_statistics.PlayTime.Minutes}м {_statistics.PlayTime.Seconds}с";

                MessageBox.Show(stats, "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отображении статистики:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                var records = _history.GetRecords();
                
                if (records.Count == 0)
                {
                    MessageBox.Show("История игр пуста. Сыграйте несколько раундов!", 
                        "История", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string history = "=== ИСТОРИЯ ИГР (последние 20) ===\n\n";
                int count = Math.Min(20, records.Count);
                
                for (int i = 0; i < count; i++)
                {
                    var record = records[i];
                    string result = record.IsWin ? "ВЫИГРЫШ" : "проигрыш";
                    string symbols = $"{record.Symbols[0]} {record.Symbols[1]} {record.Symbols[2]}";
                    
                    history += $"{i + 1}. {record.Time:HH:mm:ss} | {symbols}\n" +
                        $"   Ставка: {record.Bet:F2} | {result}: {record.Win:F2} | Баланс: {record.BalanceAfter:F2}\n\n";
                }

                MessageBox.Show(history, "История игр", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отображении истории:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    $"Вернуться в главное меню?\n\nТекущий баланс: {_player.Balance:F2} руб.\nВся статистика будет сброшена.", 
                    "Подтверждение", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n{ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}