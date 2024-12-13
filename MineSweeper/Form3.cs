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
    public partial class Form3 : Form
    {
        private Scoreboard scoreboard;
        public Form3(Scoreboard scoreboard)
        {
            InitializeComponent();
            this.scoreboard = scoreboard;
            DisplayTopScores();
        }
        // Skor tablosunda en iyi 10 değeri gösterme metodu
        private void DisplayTopScores()
        {

            var topScores = scoreboard.GetTopScores();

            string scoresText = "Top 10 Scores:\n\n";

            for (int i = 0; i < topScores.Count; i++)
            {
                scoresText += $"{i + 1}. {topScores[i].PlayerName} - {topScores[i].Score}\n";
            }

            lblTopScores.Text = scoresText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(scoreboard);
            form4.Show();
            this.Hide();
        }

    }
}
