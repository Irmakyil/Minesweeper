using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainMenu : Form
    {
        private Scoreboard scoreboard;

        public MainMenu(Scoreboard scoreboard)
        {
            InitializeComponent();
            this.scoreboard = scoreboard;
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            string playerName = playerNameTxt.Text;
            int gridSize;
            int numberOfMines;


            if (!int.TryParse(gridSizeTxt.Text, out gridSize) || gridSize < 1 || gridSize > 30)
            {
                MessageBox.Show("Grid size must be between 1 and 30.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(mineNumberTxt.Text, out numberOfMines) || numberOfMines < 10)
            {
                MessageBox.Show("Number of mines must be at least 10.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Yeni oyun oluşturma
            Game game = new Game(playerName, gridSize, numberOfMines);

            if (!game.IsValid)
            {
                MessageBox.Show("Invalid game configuration. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Form2 gameForm = new Form2(game, scoreboard);
            gameForm.Show();
            this.Hide();

        }
    }
}
