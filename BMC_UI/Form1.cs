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

        private void Gbut_Click(object sender, EventArgs e)
        {
            Input.AppendText("G");
        }

        private void Ubut_Click(object sender, EventArgs e)
        {
            Input.AppendText("U");
        }

        private void Xbut_Click(object sender, EventArgs e)
        {
            Input.AppendText("X");
        }

        private void Fbut_Click(object sender, EventArgs e)
        {
            Input.AppendText("F");
        }

        private void Ebut_Click(object sender, EventArgs e)
        {
            Input.AppendText("E");
        }

        private void PluBut_Click(object sender, EventArgs e)
        {
            Input.AppendText("+");
        }

        private void SubBut_Click(object sender, EventArgs e)
        {
            Input.AppendText("-");
        }

        private void MulBut_Click(object sender, EventArgs e)
        {
            Input.AppendText("*");
        }

        private void DevBut_Click(object sender, EventArgs e)
        {
            Input.AppendText("/");
        }

        private void MoreBut_Click(object sender, EventArgs e)
        {
            Input.AppendText(">");
        }

        private void LessBut_Click(object sender, EventArgs e)
        {
            Input.AppendText("<");
        }

        private void EquBut_Click(object sender, EventArgs e)
        {
            Input.AppendText("=");
        }

        private void LefSbut_Click(object sender, EventArgs e)
        {
            Input.AppendText("(");
        }

        private void RigSbut_Click(object sender, EventArgs e)
        {
            Input.AppendText(")");
        }

        private void LefMbut_Click(object sender, EventArgs e)
        {
            Input.AppendText("[");
        }

        private void RigMbut_Click(object sender, EventArgs e)
        {
            Input.AppendText("]");
        }

        private void num1But_Click(object sender, EventArgs e)
        {
            Input.AppendText("1");
        }

        private void num2But_Click(object sender, EventArgs e)
        {
            Input.AppendText("2");
        }

        private void num3But_Click(object sender, EventArgs e)
        {
            Input.AppendText("3");
        }

        private void num4But_Click(object sender, EventArgs e)
        {
            Input.AppendText("4");
        }

        private void num5But_Click(object sender, EventArgs e)
        {
            Input.AppendText("5");
        }

        private void num6But_Click(object sender, EventArgs e)
        {
            Input.AppendText("6");
        }

        private void num7But_Click(object sender, EventArgs e)
        {
            Input.AppendText("7");
        }

        private void num8But_Click(object sender, EventArgs e)
        {
            Input.AppendText("8");
        }

        private void num9But_Click(object sender, EventArgs e)
        {
            Input.AppendText("9");
        }

        private void num0But_Click(object sender, EventArgs e)
        {
            Input.AppendText("0");
        }
    }
}
