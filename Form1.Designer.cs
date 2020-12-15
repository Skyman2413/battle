using System.Windows.Forms;

namespace Battle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.start = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.load = new System.Windows.Forms.Button();
            this.loadGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(918, 49);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(113, 51);
            this.start.TabIndex = 0;
            this.start.Text = "StartGame";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(919, 129);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 50);
            this.delete.TabIndex = 4;
            this.delete.Text = "Удалить героя";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(920, 286);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 50);
            this.update.TabIndex = 5;
            this.update.Text = "Обновить таблицу";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 496);
            this.dataGridView1.TabIndex = 7;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(919, 216);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(113, 40);
            this.load.TabIndex = 8;
            this.load.Text = "Загрузить таблицу";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // loadGame
            // 
            this.loadGame.Location = new System.Drawing.Point(920, 371);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(112, 50);
            this.loadGame.TabIndex = 9;
            this.loadGame.Text = "Загрузить игру";
            this.loadGame.UseVisualStyleBackColor = true;
            this.loadGame.Click += new System.EventHandler(this.loadGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1061, 638);
            this.Controls.Add(this.loadGame);
            this.Controls.Add(this.load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.start);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button loadGame;

        private System.Windows.Forms.Button load;

        private System.Windows.Forms.Button update;

        private System.Windows.Forms.Button delete;


        private System.Windows.Forms.Button start;

        #endregion

        private DataGridView dataGridView1;
    }
}