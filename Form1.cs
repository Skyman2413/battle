using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace Battle
{
    public partial class Form1 : Form
    {
        private List<Hero> _heroes = new List<Hero>();
        public Form1()
        {
            InitializeComponent();
            
        }


        

        private Hero GetHeroFromString(string line)
        {
            var stats = line.Split(',');
            var name = stats[0];
            var isAgil = Convert.ToInt32(stats[1]) == 1;
            var streng = Convert.ToInt32(stats[2]);
            var agility = Convert.ToInt32(stats[3]);
            var armor = Convert.ToInt32(stats[4]);
            var damage = Convert.ToInt32(stats[5]);
            var regen = Convert.ToInt32(stats[6]);
            return new Hero(name,isAgil,streng,agility,armor, damage, regen);
        }

        private void load_Click(object sender, EventArgs e)
        {
            var workbook = new Workbook();  
            workbook.LoadFromFile(@"..\heroes.csv", ",");
            
            var worksheet = workbook.Worksheets[0];  
            var t = worksheet.ExportDataTable();  
            dataGridView1.DataSource = t;
        }


        private void update_Click(object sender, EventArgs e)
        {
            var t = (DataTable) dataGridView1.DataSource;
            var workbook = new Workbook();
            var sheet = workbook.Worksheets[0];
            sheet.InsertDataTable(t, true, 1, 1);
            workbook.SaveToFile(@"..\heroes.csv");
        }

        private void start_Click(object sender, EventArgs e)
        {
            int playerIndex;
            try
            {
                playerIndex = dataGridView1.CurrentRow.Index;
            }
            catch (NullReferenceException r)
            {
                MessageBox.Show("Герой не выбран", " ", MessageBoxButtons.OK);
                return;
            }
            var compIndex = new Random().Next(dataGridView1.Rows.Count);
            
            while(compIndex==playerIndex) compIndex = new Random().Next(dataGridView1.Rows.Count);
            
            var playerStr = (from DataGridViewCell obj in dataGridView1.CurrentRow.Cells
                                        select obj.Value.ToString()).ToList();
            var line = playerStr.Aggregate("", (current, str) => current + (str + ","));
            var playerHero = GetHeroFromString(line);
            var compStr = (from DataGridViewCell obj in dataGridView1.Rows[compIndex].Cells
                select obj.Value.ToString()).ToList();

            line = compStr.Aggregate("", (current, str) => current + (str + ","));
            var compHero = GetHeroFromString(line);
            new Game(playerHero, compHero).Show();
            Hide();
        }

        private void loadGame_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader(@"../save.txt");
            var stats = reader.ReadLine().Split(',');
            if (stats.Length == 0)
            {
                MessageBox.Show("Нет сохранения", " ", MessageBoxButtons.OK);
                return;
            }
            var name = stats[0];
            var isAgil = Convert.ToInt32(stats[1]) == 1;
            var streng = Convert.ToInt32(stats[2]);
            var agility = Convert.ToInt32(stats[3]);
            var armor = Convert.ToInt32(stats[4]);
            var damage = Convert.ToInt32(stats[5]);
            var regen = Convert.ToInt32(stats[6]);
            var currenth = Convert.ToDouble(stats[7]);
            var playerHero =  new Hero(name,isAgil,streng,agility,armor, damage, regen, currenth);
            stats = reader.ReadLine().Split(',');
             name = stats[0];
             isAgil = Convert.ToInt32(stats[1]) == 1;
             streng = Convert.ToInt32(stats[2]);
             agility = Convert.ToInt32(stats[3]);
             armor = Convert.ToInt32(stats[4]);
             damage = Convert.ToInt32(stats[5]);
             regen = Convert.ToInt32(stats[6]);
             currenth = Convert.ToDouble(stats[7]);
            var compHero =  new Hero(name,isAgil,streng,agility,armor, damage, regen, currenth);
            new Game(playerHero, compHero).Show();
            Hide();
        }
    }
}