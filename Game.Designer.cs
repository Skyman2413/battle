using System.ComponentModel;

namespace Battle
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.defend = new System.Windows.Forms.Button();
            this.attack = new System.Windows.Forms.Button();
            this.player_health = new System.Windows.Forms.Label();
            this.player_move = new System.Windows.Forms.Label();
            this.comp_health = new System.Windows.Forms.Label();
            this.comp_move = new System.Windows.Forms.Label();
            this.saveGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дуэль";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(29, 158);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(113, 52);
            this.run.TabIndex = 1;
            this.run.Text = "Бежать";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // defend
            // 
            this.defend.Location = new System.Drawing.Point(29, 231);
            this.defend.Name = "defend";
            this.defend.Size = new System.Drawing.Size(113, 52);
            this.defend.TabIndex = 2;
            this.defend.Text = "Защищаться";
            this.defend.UseVisualStyleBackColor = true;
            this.defend.Click += new System.EventHandler(this.defend_Click);
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(29, 302);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(113, 52);
            this.attack.TabIndex = 3;
            this.attack.Text = "Атаковать";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.attack_Click);
            // 
            // player_health
            // 
            this.player_health.Location = new System.Drawing.Point(417, 89);
            this.player_health.Name = "player_health";
            this.player_health.Size = new System.Drawing.Size(146, 80);
            this.player_health.TabIndex = 4;
            this.player_health.Text = " Player health: ";
            // 
            // player_move
            // 
            this.player_move.Location = new System.Drawing.Point(787, 89);
            this.player_move.Name = "player_move";
            this.player_move.Size = new System.Drawing.Size(146, 80);
            this.player_move.TabIndex = 5;
            this.player_move.Text = " Player move: ";
            // 
            // comp_health
            // 
            this.comp_health.Location = new System.Drawing.Point(417, 332);
            this.comp_health.Name = "comp_health";
            this.comp_health.Size = new System.Drawing.Size(146, 80);
            this.comp_health.TabIndex = 6;
            this.comp_health.Text = " Comp health: ";
            // 
            // comp_move
            // 
            this.comp_move.Location = new System.Drawing.Point(787, 332);
            this.comp_move.Name = "comp_move";
            this.comp_move.Size = new System.Drawing.Size(146, 80);
            this.comp_move.TabIndex = 7;
            this.comp_move.Text = " Comp move: ";
            // 
            // saveGame
            // 
            this.saveGame.Location = new System.Drawing.Point(29, 533);
            this.saveGame.Name = "saveGame";
            this.saveGame.Size = new System.Drawing.Size(113, 52);
            this.saveGame.TabIndex = 8;
            this.saveGame.Text = "Сохранить игру";
            this.saveGame.UseVisualStyleBackColor = true;
            this.saveGame.Click += new System.EventHandler(this.saveGame_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 621);
            this.Controls.Add(this.saveGame);
            this.Controls.Add(this.comp_move);
            this.Controls.Add(this.comp_health);
            this.Controls.Add(this.player_move);
            this.Controls.Add(this.player_health);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.defend);
            this.Controls.Add(this.run);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button saveGame;

        private System.Windows.Forms.Label comp_health;

        private System.Windows.Forms.Label comp_move;

        private System.Windows.Forms.Label player_move;

        private System.Windows.Forms.Label player_health;

        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.Button defend;
        private System.Windows.Forms.Button run;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}