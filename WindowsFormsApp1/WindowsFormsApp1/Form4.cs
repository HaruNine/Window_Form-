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
    public partial class Form4 : Form
    {
        public Form4(List<int> selected)
        {
            InitializeComponent();

            listView1.Columns.Add("팀명");
            listView1.Columns.Add("승");
            listView1.Columns.Add("무");
            listView1.Columns.Add("패");

            foreach (int index in selected)
            {
                Team std = Team.teams[index];

                string[] str = new string[] { std.name, std.win.ToString(), std.draw.ToString(), std.lose.ToString() };
                ListViewItem item = new ListViewItem(str);

                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
