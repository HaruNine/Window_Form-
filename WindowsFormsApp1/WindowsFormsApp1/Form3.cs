using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            new Team("맨시티", 7, 18, 6);
            new Team("토트넘", 7, 17, 5);
            new Team("아스널", 7, 17, 5);
            new Team("리버풀", 7, 16, 5);
            new Team("애스턴 빌라", 7, 0, 0);

            /*
            List<Team> sortedTeams = Team.teams.OrderByDescending(t => t.win).ToList(); //승리가 높은순으로 정렬

            foreach (Team std in sortedTeams)
            {
                listBox1.Items.Add(std.name);
            }
            */
            List<Team> teams = Team.teams;

            foreach (Team std in teams)
            {
                listBox1.Items.Add(std.name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> selected = new List<int>();

            foreach (int index in listBox1.SelectedIndices)
                selected.Add(index);

            Form4 form4 = new Form4(selected);
            form4.Show();
        }
    }
}
