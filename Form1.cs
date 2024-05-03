using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendario_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPegarData_Click(object sender, EventArgs e)
        {
            textBoxDatainicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBoxDataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxDataAtual.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxAutoinicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBoxAutoFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxAutoHoje.Text = monthCalendar1.TodayDate.ToShortDateString();
        }
    }
}
