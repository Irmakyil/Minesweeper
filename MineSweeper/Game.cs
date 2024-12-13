using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public class Game
    {
        public string PlayerName { get; private set; }
        public int GridSize { get; private set; }
        public int NumberOfMines { get; private set; }
        public bool IsValid { get; private set; }
        public int MoveCount { get; private set; }
        private Scoreboard scoreboard;
        private int correctFlags;
        private Stopwatch stopwatch;
        public bool[,] MineGrid { get; private set; }
        private bool isGameOver;
        private List<(string PlayerName, int Score)> scores;
        public int openedCellsCount;
        public int CorrectFlags => correctFlags;
        public TimeSpan ElapsedTime => stopwatch.Elapsed;
        public TimeSpan FinalElapsedTime { get; private set; }


        public Game(string playerName, int gridSize, int numberOfMines)
        {
            PlayerName = playerName;
            GridSize = gridSize;
            NumberOfMines = numberOfMines;
            scoreboard = new Scoreboard();
            correctFlags = 0;
            stopwatch = new Stopwatch();
            MineGrid = new bool[GridSize, GridSize];
            isGameOver = false;
            MoveCount = 0;
            scores = new List<(string PlayerName, int Score)>();


            IsValid = ValidateInputs();
            if (IsValid)
            {
                InitializeGame();
                PlaceMines();
                stopwatch.Start();
            }
        }

        private void InitializeGame()
        {

            MineGrid = new bool[GridSize, GridSize];
            MoveCount = 0;
            isGameOver = false;
            correctFlags = 0;
        }

        //Mayınları rastgele yerleştirme metodu
        private void PlaceMines()
        {
            Random rand = new Random();
            int minesPlaced = 0;

            while (minesPlaced < NumberOfMines)
            {
                int x = rand.Next(GridSize);
                int y = rand.Next(GridSize);

                if (!MineGrid[x, y])
                {
                    MineGrid[x, y] = true;
                    minesPlaced++;
                }
            }
        }

        // Belirli bir hücrenin etrafındaki bitişik mayınları sayma metodu
        public int CountAdjacentMines(int x, int y)
        {
            int mineCount = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;

                    int newX = x + i;
                    int newY = y + j;

                    if (newX >= 0 && newX < GridSize && newY >= 0 && newY < GridSize)
                    {
                        if (MineGrid[newX, newY])
                        {
                            mineCount++;
                        }
                    }
                }
            }
            return mineCount;
        }

        // Komşu hücreleri mayın olmadan açmak için özyinelemeli metot
        public void OpenAdjacentCells(int x, int y, bool[,] visited)
        {
            if (x < 0 || x >= GridSize || y < 0 || y >= GridSize || visited[x, y]) return;

            visited[x, y] = true;

            int adjacentMines = CountAdjacentMines(x, y);

            if (adjacentMines == 0)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i == 0 && j == 0) continue;
                        OpenAdjacentCells(x + i, y + j, visited);
                    }
                }
            }
        }

        // Bir hücreyi açıp içinde mayın içerip içermediğini kontrol etme yöntemi
        public void OpenCell(int x, int y)
        {
            if (isGameOver || MineGrid[x, y])
            {
                isGameOver = true;
                RevealAllMines();
            }
        }

        //Hücrelerdeki tüm mayınları ortaya çıkarma
        private void RevealAllMines()
        {
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    if (MineGrid[i, j])
                    {
                        
                    }
                }
            }
        }

        public void IncrementMoveCount()
        {
            MoveCount++;
        }

        private bool ValidateInputs()
        {
            return (GridSize <= 30 && NumberOfMines >= 10);
        }

        public void EndGame(bool isGameOver, string playerName)
        {
            stopwatch.Stop();
            FinalElapsedTime = stopwatch.Elapsed;
            int finalScore = CalculateScore(isGameOver, playerName);

            SaveScore(playerName, finalScore);
        }

        public int CalculateScore(bool isGameOver, string playerName)
        {
            if (!isGameOver) return 0;
            int timePassedInSeconds = (int)FinalElapsedTime.TotalSeconds;

            return (correctFlags * 1000) / timePassedInSeconds;
        }

        private void SaveScore(string playerName, int score)
        {
            scores.Add((playerName, score));
            scores.Sort((a, b) => b.Score.CompareTo(a.Score));
            if (scores.Count > 10)
            {
                scores.RemoveAt(scores.Count - 1);
            }
        }

        public List<(string PlayerName, int Score)> GetTopScores()
        {
            return scores;
        }

        public bool CheckWinCondition()
        {
            return openedCellsCount == (GridSize * GridSize) - NumberOfMines;
        }

        // // CorrectFlags değerini yalnızca bayrak bir mayına yerleştirildiyse artırma metodu
        public void ToggleFlag(int x, int y)
        {
            if (MineGrid[x, y])
            {
                correctFlags++;
            }

        }
    }
}
