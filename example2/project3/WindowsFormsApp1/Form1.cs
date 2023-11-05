using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                StreamReader reader = new StreamReader(path);
                
                string columnTitle = reader.ReadLine();
                
                string[] colums = columnTitle.Split(',');

                foreach (string column in colums)
                {
                    dt.Columns.Add(column);
                }

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] instance = line.Split(',');
                    
                    DataRow row = dt.NewRow();

                    for (int i = 0; i < instance.Length; i++)
                    {
                        row[dt.Columns[i]] = instance[i];
                    }
                    dt.Rows.Add(row);
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            chart1.DataSource = dt;

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                Series s = new Series();

                s.ChartType = SeriesChartType.Line;
                s.LegendText = dt.Columns[i].ColumnName;
                s.XValueMember = dt.Columns[0].ColumnName;
                s.YValueMembers = dt.Columns[i].ColumnName;

                chart1.Series.Add(s);
            }
        }
    }
}
