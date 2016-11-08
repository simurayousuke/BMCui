using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMC_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoadModel_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void buttonAssert_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.Enabled = false;
        }
    }
}
