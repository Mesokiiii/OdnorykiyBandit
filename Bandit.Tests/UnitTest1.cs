using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bandit.Logic;

namespace Bandit.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Player_InitialBalance_ShouldBeSet()
        {
            // Arrange & Act
            var player = new Player(1000m);

            // Assert
            Assert.AreEqual(1000m, player.Balance);
        }

        [TestMethod]
        public void Player_Deposit_ShouldIncreaseBalance()
        {
            // Arrange
            var player = new Player(100m);

            // Act
            player.Deposit(50m);

            // Assert
            Assert.AreEqual(150m, player.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Player_DepositNegative_ShouldThrowException()
        {
            // Arrange
            var player = new Player(100m);

            // Act
            player.Deposit(-50m);
        }

        [TestMethod]
        public void Player_Withdraw_ShouldDecreaseBalance()
        {
            // Arrange
            var player = new Player(100m);

            // Act
            player.Withdraw(30m);

            // Assert
            Assert.AreEqual(70m, player.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Player_WithdrawMoreThanBalance_ShouldThrowException()
        {
            // Arrange
            var player = new Player(100m);

            // Act
            player.Withdraw(150m);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Player_WithdrawNegative_ShouldThrowException()
        {
            // Arrange
            var player = new Player(100m);

            // Act
            player.Withdraw(-50m);
        }
    }

    [TestClass]
    public class SlotMachineTests
    {
        [TestMethod]
        public void SlotMachine_Spin_ShouldReturnThreeSymbols()
        {
            // Arrange
            var machine = new SlotMachine();

            // Act
            var result = machine.Spin();

            // Assert
            Assert.AreEqual(3, result.Length);
        }

        [TestMethod]
        public void SlotMachine_Spin_ShouldReturnValidSymbols()
        {
            // Arrange
            var machine = new SlotMachine();

            // Act
            var result = machine.Spin();

            // Assert
            foreach (var symbol in result)
            {
                Assert.IsTrue(Enum.IsDefined(typeof(SlotSymbol), symbol));
            }
        }

        [TestMethod]
        public void SlotMachine_ThreeSevens_ShouldReturn10()
        {
            // Arrange
            var machine = new SlotMachine();
            var symbols = new[] { SlotSymbol.Seven, SlotSymbol.Seven, SlotSymbol.Seven };

            // Act
            var win = machine.CalculateWin(symbols);

            // Assert
            Assert.AreEqual(10, win);
        }

        [TestMethod]
        public void SlotMachine_ThreeIdentical_ShouldReturn5()
        {
            // Arrange
            var machine = new SlotMachine();
            var symbols = new[] { SlotSymbol.Cherry, SlotSymbol.Cherry, SlotSymbol.Cherry };

            // Act
            var win = machine.CalculateWin(symbols);

            // Assert
            Assert.AreEqual(5, win);
        }

        [TestMethod]
        public void SlotMachine_TwoIdentical_ShouldReturn2()
        {
            // Arrange
            var machine = new SlotMachine();
            var symbols = new[] { SlotSymbol.Lemon, SlotSymbol.Lemon, SlotSymbol.Cherry };

            // Act
            var win = machine.CalculateWin(symbols);

            // Assert
            Assert.AreEqual(2, win);
        }

        [TestMethod]
        public void SlotMachine_NoMatch_ShouldReturn0()
        {
            // Arrange
            var machine = new SlotMachine();
            var symbols = new[] { SlotSymbol.Cherry, SlotSymbol.Lemon, SlotSymbol.Bell };

            // Act
            var win = machine.CalculateWin(symbols);

            // Assert
            Assert.AreEqual(0, win);
        }

        [TestMethod]
        public void SlotMachine_PairAtEnd_ShouldReturn2()
        {
            // Arrange
            var machine = new SlotMachine();
            var symbols = new[] { SlotSymbol.Cherry, SlotSymbol.Lemon, SlotSymbol.Lemon };

            // Act
            var win = machine.CalculateWin(symbols);

            // Assert
            Assert.AreEqual(2, win);
        }

        [TestMethod]
        public void SlotMachine_PairAtEdges_ShouldReturn2()
        {
            // Arrange
            var machine = new SlotMachine();
            var symbols = new[] { SlotSymbol.Bell, SlotSymbol.Cherry, SlotSymbol.Bell };

            // Act
            var win = machine.CalculateWin(symbols);

            // Assert
            Assert.AreEqual(2, win);
        }
    }

    [TestClass]
    public class GameStatisticsTests
    {
        [TestMethod]
        public void GameStatistics_Initial_ShouldBeZero()
        {
            // Arrange & Act
            var stats = new GameStatistics();

            // Assert
            Assert.AreEqual(0, stats.TotalGames);
            Assert.AreEqual(0, stats.Wins);
            Assert.AreEqual(0, stats.Losses);
            Assert.AreEqual(0m, stats.TotalWinnings);
            Assert.AreEqual(0m, stats.TotalLosses);
        }

        [TestMethod]
        public void GameStatistics_RecordWin_ShouldUpdateStats()
        {
            // Arrange
            var stats = new GameStatistics();

            // Act
            stats.RecordGame(10m, 50m);

            // Assert
            Assert.AreEqual(1, stats.TotalGames);
            Assert.AreEqual(1, stats.Wins);
            Assert.AreEqual(0, stats.Losses);
            Assert.AreEqual(50m, stats.TotalWinnings);
            Assert.AreEqual(50m, stats.LastWin);
        }

        [TestMethod]
        public void GameStatistics_RecordLoss_ShouldUpdateStats()
        {
            // Arrange
            var stats = new GameStatistics();

            // Act
            stats.RecordGame(10m, 0m);

            // Assert
            Assert.AreEqual(1, stats.TotalGames);
            Assert.AreEqual(0, stats.Wins);
            Assert.AreEqual(1, stats.Losses);
            Assert.AreEqual(10m, stats.TotalLosses);
        }

        [TestMethod]
        public void GameStatistics_MaxWin_ShouldTrackHighest()
        {
            // Arrange
            var stats = new GameStatistics();

            // Act
            stats.RecordGame(10m, 20m);
            stats.RecordGame(10m, 50m);
            stats.RecordGame(10m, 30m);

            // Assert
            Assert.AreEqual(50m, stats.MaxWin);
        }

        [TestMethod]
        public void GameStatistics_WinRate_ShouldCalculateCorrectly()
        {
            // Arrange
            var stats = new GameStatistics();

            // Act
            stats.RecordGame(10m, 50m); // Win
            stats.RecordGame(10m, 0m);  // Loss
            stats.RecordGame(10m, 20m); // Win

            // Assert
            Assert.AreEqual(66.666666666666671, stats.WinRate, 0.0001);
        }

        [TestMethod]
        public void GameStatistics_NetProfit_ShouldCalculateCorrectly()
        {
            // Arrange
            var stats = new GameStatistics();

            // Act
            stats.RecordGame(10m, 50m); // +50
            stats.RecordGame(10m, 0m);  // -10
            stats.RecordGame(10m, 20m); // +20

            // Assert
            Assert.AreEqual(60m, stats.NetProfit); // 50 + 20 - 10
        }
    }

    [TestClass]
    public class GameHistoryTests
    {
        [TestMethod]
        public void GameHistory_Initial_ShouldBeEmpty()
        {
            // Arrange & Act
            var history = new GameHistory();

            // Assert
            Assert.AreEqual(0, history.Count);
        }

        [TestMethod]
        public void GameHistory_AddRecord_ShouldIncreaseCount()
        {
            // Arrange
            var history = new GameHistory();
            var symbols = new[] { SlotSymbol.Cherry, SlotSymbol.Cherry, SlotSymbol.Cherry };

            // Act
            history.AddRecord(10m, 50m, 1050m, symbols);

            // Assert
            Assert.AreEqual(1, history.Count);
        }

        [TestMethod]
        public void GameHistory_GetRecords_ShouldReturnInReverseOrder()
        {
            // Arrange
            var history = new GameHistory();
            var symbols = new[] { SlotSymbol.Cherry, SlotSymbol.Cherry, SlotSymbol.Cherry };

            // Act
            history.AddRecord(10m, 50m, 1050m, symbols);
            history.AddRecord(20m, 0m, 1030m, symbols);
            var records = history.GetRecords();

            // Assert
            Assert.AreEqual(20m, records[0].Bet); // Последняя запись первая
            Assert.AreEqual(10m, records[1].Bet);
        }

        [TestMethod]
        public void GameHistory_MaxRecords_ShouldLimitTo50()
        {
            // Arrange
            var history = new GameHistory();
            var symbols = new[] { SlotSymbol.Cherry, SlotSymbol.Cherry, SlotSymbol.Cherry };

            // Act
            for (int i = 0; i < 60; i++)
            {
                history.AddRecord(10m, 0m, 1000m, symbols);
            }

            // Assert
            Assert.AreEqual(50, history.Count);
        }

        [TestMethod]
        public void GameRecord_IsWin_ShouldReturnTrueForWin()
        {
            // Arrange
            var record = new GameRecord
            {
                Bet = 10m,
                Win = 50m
            };

            // Assert
            Assert.IsTrue(record.IsWin);
        }

        [TestMethod]
        public void GameRecord_IsWin_ShouldReturnFalseForLoss()
        {
            // Arrange
            var record = new GameRecord
            {
                Bet = 10m,
                Win = 0m
            };

            // Assert
            Assert.IsFalse(record.IsWin);
        }
    }
}
