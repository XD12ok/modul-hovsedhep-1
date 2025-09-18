using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace mdul_HOVSEDEP_18_9_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetbtn()
        {
            TableSeatingBtn.BackColor = SystemColors.ControlDark;
            MenuBtn.BackColor = SystemColors.ControlDark;
            HistoryBtn.BackColor = SystemColors.ControlDark;
        }

        private void loadUc(UserControl UC)
        {
            mainPanel.Controls.Clear();
            UC.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(UC);
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            resetbtn();
            MenuBtn.BackColor = SystemColors.Highlight;
            loadUc(new Menu());
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            resetbtn();
            HistoryBtn.BackColor = SystemColors.Highlight;
            loadUc(new HistoryUC());
        }

        private void TableSeatingBtn_Click(object sender, EventArgs e)
        {
            resetbtn();
            TableSeatingBtn.BackColor= SystemColors.Highlight;
            loadUc(new TableSeating());
        }
    }
}
