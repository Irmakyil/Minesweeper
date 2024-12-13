using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MineSweeper
{
    public partial class Form2 : Form
    {
        private Button[,] gridButtons; // 2D array for grid buttons
        private Game game;
        private Scoreboard scoreboard;


        public Form2(Game game, Scoreboard scoreboard)
        {
            InitializeComponent();
            this.game = game;
            this.scoreboard = scoreboard;
            InitializeGrid();

            moveCountLbl.Text = $"Moves: {game.MoveCount}";
        }

        private void EndGameAndUpdateScoreboard()
        {
            // Oyunu sonlandır ve mevcut oyuncunun puanını hesaplar
            game.EndGame(true, game.PlayerName);

            // Son puanı hesaplayıp puan tablosuna ekler
            double score = game.CalculateScore(true, game.PlayerName);
            scoreboard.AddScore(game.PlayerName, score);

            Form4 form4 = new Form4(scoreboard);
            form4.Show();
            this.Hide();
        }

        private void InitializeGrid()
        {
            gridButtons = new Button[game.GridSize, game.GridSize];
            for (int i = 0; i < game.GridSize; i++)
            {
                for (int j = 0; j < game.GridSize; j++)
                {
                    gridButtons[i, j] = new Button();
                    gridButtons[i, j].Size = new System.Drawing.Size(30, 30); // Buton boyutunu ayarlar.
                    gridButtons[i, j].Location = new System.Drawing.Point(i * 30, j * 30);// Butonun konumlandırılmasını sağlar.
                    gridButtons[i, j].MouseDown += new MouseEventHandler(Cell_MouseDown);
                    panelGrid.Controls.Add(gridButtons[i, j]);
                }
            }
        }
        private void Cell_MouseDown(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;
            int x = clickedButton.Location.X / clickedButton.Width;
            int y = clickedButton.Location.Y / clickedButton.Height;

            if (e.Button == MouseButtons.Left)
            {
                // Sol tıklama: Hücreyi açma
                OpenCell(x, y);
            }
            else if (e.Button == MouseButtons.Right)
            {

                // Sağ tıklama: Bir bayrak yerleştirme
                PlaceFlag(x, y);
            }
        }
        private void OpenCell(int x, int y)
        {
            game.IncrementMoveCount();
            moveCountLbl.Text = $"Moves: {game.MoveCount}";

            if (game.MineGrid[x, y])
            {
                game.OpenCell(x, y);
                ShowMines();
                timer1.Stop();

                MessageBox.Show("Game Over! You hit a mine. \n\n", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                EndGameAndUpdateScoreboard();

            }
            else
            {
                game.openedCellsCount++;
                int adjacentMines = game.CountAdjacentMines(x, y);
                gridButtons[x, y].Text = adjacentMines == 0 ? "" : adjacentMines.ToString();
                gridButtons[x, y].Enabled = false;

                if (adjacentMines == 0)
                {
                    bool[,] visited = new bool[game.GridSize, game.GridSize];
                    game.OpenAdjacentCells(x, y, visited);

                    for (int i = 0; i < game.GridSize; i++)
                    {
                        for (int j = 0; j < game.GridSize; j++)
                        {
                            if (visited[i, j] && !game.MineGrid[i, j])
                            {
                                game.openedCellsCount++;
                                int adjMines = game.CountAdjacentMines(i, j);
                                gridButtons[i, j].Text = adjMines == 0 ? "" : adjMines.ToString();
                                gridButtons[i, j].Enabled = false;
                            }
                        }
                    }
                }

                // Oyunun doğru bittiğinin kontrolü yapılıyor.
                if (game.CheckWinCondition())
                {
                    ShowMines();
                    timer1.Stop();
                    MessageBox.Show("Congratulations! You won the game. \n\n", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EndGameAndUpdateScoreboard();
                }
            }
        }
        // Hücrelere bayrak yerleştirme veya kaldırma metodu
        private void PlaceFlag(int x, int y)
        {

            if (gridButtons[x, y].Enabled)
            {
                if (gridButtons[x, y].Text == "🚩")
                {
                    gridButtons[x, y].Text = "";
                    game.ToggleFlag(x, y);
                }
                else
                {
                    gridButtons[x, y].Text = "🚩";
                    game.ToggleFlag(x, y);
                }
            }
        }

        private void ShowMines()
        {
            for (int i = 0; i < game.GridSize; i++)
            {
                for (int j = 0; j < game.GridSize; j++)
                {
                    if (game.MineGrid[i, j])
                    {
                        gridButtons[i, j].Text = "💣";
                        gridButtons[i, j].BackColor = Color.DarkRed;
                    }
                }
            }
        }

        
        private int i = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Zamanlayıcı aralığını 1 saniyeye ayarlar.
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++; 
            timerLbl.Text = i.ToString(); 

        }

    }
}
