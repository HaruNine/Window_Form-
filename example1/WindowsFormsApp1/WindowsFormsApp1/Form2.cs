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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = radioButton1.Text;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = radioButton2.Text;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = radioButton3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string dDay = CalculateDDay(dateTimePicker1.Value.Date);
            label7.Text = dDay;
        }

        private string CalculateDDay(DateTime eventDate)
        {
            TimeSpan timeUntilEvent = eventDate.Date - DateTime.Now.Date;
            return $"D{(timeUntilEvent.Days >= 0 ? "+" : "-")}{Math.Abs(timeUntilEvent.Days)}";
        }
    }
}
