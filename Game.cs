using System;
using System.IO;
using System.Windows.Forms;

namespace Battle
{
    public partial class Game : Form
    {
        Hero playerHero;
        Hero compHero;

        private string[] doings =
        {
            "Бежит",
            "Защищается",
            "Атакует"
        };
        public Game(Hero playerHero, Hero compHero)
        {
            this.playerHero = playerHero;
            this.compHero = compHero;
            InitializeComponent();
            UpdateLabels();

        }

        private void UpdateLabels()
        {
            player_health.Text = $@"Player health: {playerHero.currentHealth}";
            comp_health.Text = $@"Comp health: {compHero.currentHealth}";
        }

        private void run_Click(object sender, EventArgs e)
        {
            var move = new Random().Next(3);
            var isSecondRun = move == 0;
            if (move == 1)
            {
                playerHero.Run(true);
                player_move.Text = $@"{playerHero.name} убегает";
                comp_move.Text = $@"{compHero.name} защищается";
                return;
            }
            if (isSecondRun)
            {
                
                compHero.Run(true);
                playerHero.Run(true);
                player_move.Text = $@"{playerHero.name} убегает";
                comp_move.Text = $@"{compHero.name} убегает";
            }
            else
            {
                if (playerHero.currentHealth < 2)
                {
                    MessageBox.Show("Вы не можете бежать", " ", MessageBoxButtons.OK);
                    return;
                }
                playerHero.Run(false);
                player_move.Text = $@"{playerHero.name} убегает";
                comp_move.Text = $@"{compHero.name} атакует";
            }
            UpdateLabels();
            CheckEndGame();
        }

        private void CheckEndGame()
        {
            var plH = playerHero.currentHealth;
            var cH = compHero.currentHealth;

            if (plH <= 0 && cH <= 0)
            {
                MessageBox.Show("Ничья! Дуэлянты прикончили друг друга", "", MessageBoxButtons.OK);

                Application.OpenForms[0].Show();
                Close();
                return;
            }

            if (plH <= 0)
            {
                MessageBox.Show("Вы проиграли!", " ", MessageBoxButtons.OK);
                Application.OpenForms[0].Show();
                Close();
                return;
            }

            if (cH <= 0)
            {
                MessageBox.Show("Вы выиграли!", " ", MessageBoxButtons.OK);
                Application.OpenForms[0].Show();
                Close();
                return;
            }
        }

        private void defend_Click(object sender, EventArgs e)
        {
            var move = new Random().Next(3);
            if (move == 1)
            {
                player_move.Text = $@"{playerHero.name} защищается";
                comp_move.Text = $@"{compHero.name} защищается";
                return;
                
            }

            if (move == 0)
            {
                compHero.Run(true);
                player_move.Text = $@"{playerHero.name} защищается";
                comp_move.Text = $@"{compHero.name} убегает";
                return;
            }
            compHero.Attack(playerHero);
            player_move.Text = $@"{playerHero.name} защищается";
            comp_move.Text = $@"{compHero.name} атакует";
            UpdateLabels();
            CheckEndGame();
        }

        private void attack_Click(object sender, EventArgs e)
        {
            var move = new Random().Next(3);
            if(compHero.currentHealth < 2) move = new Random().Next(1, 3);
            if (move == 0)
            {
                compHero.Run(false);
                playerHero.Attack(compHero);
                player_move.Text = $@"{playerHero.name} атакует";
                comp_move.Text = $@"{compHero.name} убегает";
            }

            if (move == 1)
            {
                playerHero.Attack(compHero);
                player_move.Text = $@"{playerHero.name} атакует";
                comp_move.Text = $@"{compHero.name} защищается";
            }

            if (move == 2)
            {
                var i = 0;
                if(Math.Abs(playerHero.currentHealth - compHero.currentHealth) < 0.1) i = new Random().Next(-1, 2);
                if (playerHero.currentHealth + i > compHero.currentHealth)
                {
                    playerHero.Attack(compHero);
                    player_move.Text = $@"{playerHero.name} атакует";
                    comp_move.Text = $@"{compHero.name} защищается, так как у него меньше очков";
                }
                else
                {
                    compHero.Attack(playerHero);
                    player_move.Text = $@"{playerHero.name} защищается так как у него меньше очков";
                    comp_move.Text = $@"{compHero.name} атакует";
                }
                
            }
            UpdateLabels();
            CheckEndGame();
            
        }


        private void saveGame_Click(object sender, EventArgs e)
        {
            
            var writer = new StreamWriter(@"../save.txt");
            writer.WriteLine(playerHero.ToString());
            writer.WriteLine(compHero.ToString());
            writer.Close();
            Close();
        }
    }
}