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
    public partial class Form4 : Form
    {
        private Scoreboard scoreboard;
        public Form4(Scoreboard scoreboard)
        {
            InitializeComponent();
            this.scoreboard = scoreboard;
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(scoreboard);
            mainMenu.Show(this);

            this.Hide();
        }

        private void scoreboardBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(scoreboard);
            form3.Show();

            this.Hide();
        }
    }
}
