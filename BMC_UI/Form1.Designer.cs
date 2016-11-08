namespace BMC_UI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.load = new System.Windows.Forms.TabPage();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.assert = new System.Windows.Forms.TabPage();
            this.buttonAssert = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.RigMbut = new System.Windows.Forms.Button();
            this.RigSbut = new System.Windows.Forms.Button();
            this.LefSbut = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.LefMbut = new System.Windows.Forms.Button();
            this.EquBut = new System.Windows.Forms.Button();
            this.LessBut = new System.Windows.Forms.Button();
            this.MoreBut = new System.Windows.Forms.Button();
            this.DevBut = new System.Windows.Forms.Button();
            this.MulBut = new System.Windows.Forms.Button();
            this.SubBut = new System.Windows.Forms.Button();
            this.PluBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Ebut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Fbut = new System.Windows.Forms.Button();
            this.Xbut = new System.Windows.Forms.Button();
            this.Ubut = new System.Windows.Forms.Button();
            this.Gbut = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num1But = new System.Windows.Forms.Button();
            this.num0But = new System.Windows.Forms.Button();
            this.num9But = new System.Windows.Forms.Button();
            this.num8But = new System.Windows.Forms.Button();
            this.num7But = new System.Windows.Forms.Button();
            this.num6But = new System.Windows.Forms.Button();
            this.num5But = new System.Windows.Forms.Button();
            this.num4But = new System.Windows.Forms.Button();
            this.num3But = new System.Windows.Forms.Button();
            this.num2But = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.load.SuspendLayout();
            this.assert.SuspendLayout();
            this.edit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.load);
            this.tabControl.Controls.Add(this.assert);
            this.tabControl.Controls.Add(this.edit);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(759, 282);
            this.tabControl.TabIndex = 0;
            // 
            // load
            // 
            this.load.Controls.Add(this.buttonBrowse);
            this.load.Controls.Add(this.textBox1);
            this.load.Controls.Add(this.label1);
            this.load.Controls.Add(this.buttonLoadModel);
            this.load.Location = new System.Drawing.Point(4, 22);
            this.load.Name = "load";
            this.load.Padding = new System.Windows.Forms.Padding(3);
            this.load.Size = new System.Drawing.Size(751, 256);
            this.load.TabIndex = 0;
            this.load.Text = "载入模型";
            this.load.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Enabled = false;
            this.buttonBrowse.Location = new System.Drawing.Point(662, 48);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "浏览";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(85, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(571, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Test STM Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件路径：";
            // 
            // buttonLoadModel
            // 
            this.buttonLoadModel.Location = new System.Drawing.Point(661, 217);
            this.buttonLoadModel.Name = "buttonLoadModel";
            this.buttonLoadModel.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadModel.TabIndex = 0;
            this.buttonLoadModel.Text = "载入模型";
            this.buttonLoadModel.UseVisualStyleBackColor = true;
            this.buttonLoadModel.Click += new System.EventHandler(this.buttonLoadModel_Click);
            // 
            // assert
            // 
            this.assert.Controls.Add(this.buttonAssert);
            this.assert.Location = new System.Drawing.Point(4, 22);
            this.assert.Name = "assert";
            this.assert.Size = new System.Drawing.Size(751, 256);
            this.assert.TabIndex = 3;
            this.assert.Text = "变量赋值";
            this.assert.UseVisualStyleBackColor = true;
            // 
            // buttonAssert
            // 
            this.buttonAssert.Location = new System.Drawing.Point(661, 217);
            this.buttonAssert.Name = "buttonAssert";
            this.buttonAssert.Size = new System.Drawing.Size(75, 23);
            this.buttonAssert.TabIndex = 1;
            this.buttonAssert.Text = "确定";
            this.buttonAssert.UseVisualStyleBackColor = true;
            this.buttonAssert.Click += new System.EventHandler(this.buttonAssert_Click);
            // 
            // edit
            // 
            this.edit.Controls.Add(this.num2But);
            this.edit.Controls.Add(this.num3But);
            this.edit.Controls.Add(this.num4But);
            this.edit.Controls.Add(this.num5But);
            this.edit.Controls.Add(this.num6But);
            this.edit.Controls.Add(this.num7But);
            this.edit.Controls.Add(this.num8But);
            this.edit.Controls.Add(this.num9But);
            this.edit.Controls.Add(this.num0But);
            this.edit.Controls.Add(this.num1But);
            this.edit.Controls.Add(this.label6);
            this.edit.Controls.Add(this.label5);
            this.edit.Controls.Add(this.RigMbut);
            this.edit.Controls.Add(this.RigSbut);
            this.edit.Controls.Add(this.LefSbut);
            this.edit.Controls.Add(this.BackBut);
            this.edit.Controls.Add(this.LefMbut);
            this.edit.Controls.Add(this.EquBut);
            this.edit.Controls.Add(this.LessBut);
            this.edit.Controls.Add(this.MoreBut);
            this.edit.Controls.Add(this.DevBut);
            this.edit.Controls.Add(this.MulBut);
            this.edit.Controls.Add(this.SubBut);
            this.edit.Controls.Add(this.PluBut);
            this.edit.Controls.Add(this.label4);
            this.edit.Controls.Add(this.Ebut);
            this.edit.Controls.Add(this.label3);
            this.edit.Controls.Add(this.Fbut);
            this.edit.Controls.Add(this.Xbut);
            this.edit.Controls.Add(this.Ubut);
            this.edit.Controls.Add(this.Gbut);
            this.edit.Controls.Add(this.Input);
            this.edit.Controls.Add(this.label2);
            this.edit.Controls.Add(this.StartBut);
            this.edit.Location = new System.Drawing.Point(4, 22);
            this.edit.Name = "edit";
            this.edit.Padding = new System.Windows.Forms.Padding(3);
            this.edit.Size = new System.Drawing.Size(751, 256);
            this.edit.TabIndex = 1;
            this.edit.Text = "编辑属性";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "请按照(逻辑运算符)[待验证的前缀表达式]输入需要验证的表达式";
            // 
            // RigMbut
            // 
            this.RigMbut.Location = new System.Drawing.Point(376, 162);
            this.RigMbut.Name = "RigMbut";
            this.RigMbut.Size = new System.Drawing.Size(18, 44);
            this.RigMbut.TabIndex = 23;
            this.RigMbut.Text = "]";
            this.RigMbut.UseVisualStyleBackColor = true;
            this.RigMbut.Click += new System.EventHandler(this.RigMbut_Click);
            // 
            // RigSbut
            // 
            this.RigSbut.Location = new System.Drawing.Point(376, 112);
            this.RigSbut.Name = "RigSbut";
            this.RigSbut.Size = new System.Drawing.Size(18, 44);
            this.RigSbut.TabIndex = 22;
            this.RigSbut.Text = ")";
            this.RigSbut.UseVisualStyleBackColor = true;
            this.RigSbut.Click += new System.EventHandler(this.RigSbut_Click);
            // 
            // LefSbut
            // 
            this.LefSbut.Location = new System.Drawing.Point(338, 112);
            this.LefSbut.Name = "LefSbut";
            this.LefSbut.Size = new System.Drawing.Size(20, 44);
            this.LefSbut.TabIndex = 21;
            this.LefSbut.Text = "(";
            this.LefSbut.UseVisualStyleBackColor = true;
            this.LefSbut.Click += new System.EventHandler(this.LefSbut_Click);
            // 
            // BackBut
            // 
            this.BackBut.Location = new System.Drawing.Point(23, 162);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(46, 44);
            this.BackBut.TabIndex = 20;
            this.BackBut.Text = "撤销";
            this.BackBut.UseVisualStyleBackColor = true;
            // 
            // LefMbut
            // 
            this.LefMbut.Location = new System.Drawing.Point(338, 162);
            this.LefMbut.Name = "LefMbut";
            this.LefMbut.Size = new System.Drawing.Size(20, 44);
            this.LefMbut.TabIndex = 19;
            this.LefMbut.Text = "[";
            this.LefMbut.UseVisualStyleBackColor = true;
            this.LefMbut.Click += new System.EventHandler(this.LefMbut_Click);
            // 
            // EquBut
            // 
            this.EquBut.Location = new System.Drawing.Point(214, 162);
            this.EquBut.Name = "EquBut";
            this.EquBut.Size = new System.Drawing.Size(103, 44);
            this.EquBut.TabIndex = 18;
            this.EquBut.Text = "=";
            this.EquBut.UseVisualStyleBackColor = true;
            this.EquBut.Click += new System.EventHandler(this.EquBut_Click);
            // 
            // LessBut
            // 
            this.LessBut.Location = new System.Drawing.Point(161, 162);
            this.LessBut.Name = "LessBut";
            this.LessBut.Size = new System.Drawing.Size(48, 44);
            this.LessBut.TabIndex = 17;
            this.LessBut.Text = "<";
            this.LessBut.UseVisualStyleBackColor = true;
            this.LessBut.Click += new System.EventHandler(this.LessBut_Click);
            // 
            // MoreBut
            // 
            this.MoreBut.Location = new System.Drawing.Point(107, 162);
            this.MoreBut.Name = "MoreBut";
            this.MoreBut.Size = new System.Drawing.Size(48, 44);
            this.MoreBut.TabIndex = 16;
            this.MoreBut.Text = ">";
            this.MoreBut.UseVisualStyleBackColor = true;
            this.MoreBut.Click += new System.EventHandler(this.MoreBut_Click);
            // 
            // DevBut
            // 
            this.DevBut.Location = new System.Drawing.Point(269, 112);
            this.DevBut.Name = "DevBut";
            this.DevBut.Size = new System.Drawing.Size(48, 44);
            this.DevBut.TabIndex = 15;
            this.DevBut.Text = "/";
            this.DevBut.UseVisualStyleBackColor = true;
            this.DevBut.Click += new System.EventHandler(this.DevBut_Click);
            // 
            // MulBut
            // 
            this.MulBut.Location = new System.Drawing.Point(215, 112);
            this.MulBut.Name = "MulBut";
            this.MulBut.Size = new System.Drawing.Size(48, 44);
            this.MulBut.TabIndex = 14;
            this.MulBut.Text = "*";
            this.MulBut.UseVisualStyleBackColor = true;
            this.MulBut.Click += new System.EventHandler(this.MulBut_Click);
            // 
            // SubBut
            // 
            this.SubBut.Location = new System.Drawing.Point(161, 112);
            this.SubBut.Name = "SubBut";
            this.SubBut.Size = new System.Drawing.Size(48, 44);
            this.SubBut.TabIndex = 13;
            this.SubBut.Text = "-";
            this.SubBut.UseVisualStyleBackColor = true;
            this.SubBut.Click += new System.EventHandler(this.SubBut_Click);
            // 
            // PluBut
            // 
            this.PluBut.Location = new System.Drawing.Point(107, 112);
            this.PluBut.Name = "PluBut";
            this.PluBut.Size = new System.Drawing.Size(48, 44);
            this.PluBut.TabIndex = 12;
            this.PluBut.Text = "+";
            this.PluBut.UseVisualStyleBackColor = true;
            this.PluBut.Click += new System.EventHandler(this.PluBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "运算操作符：";
            // 
            // Ebut
            // 
            this.Ebut.Location = new System.Drawing.Point(473, 60);
            this.Ebut.Name = "Ebut";
            this.Ebut.Size = new System.Drawing.Size(76, 34);
            this.Ebut.TabIndex = 10;
            this.Ebut.Text = "Exist";
            this.Ebut.UseVisualStyleBackColor = true;
            this.Ebut.Click += new System.EventHandler(this.Ebut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "逻辑运算符：";
            // 
            // Fbut
            // 
            this.Fbut.Location = new System.Drawing.Point(338, 60);
            this.Fbut.Name = "Fbut";
            this.Fbut.Size = new System.Drawing.Size(77, 34);
            this.Fbut.TabIndex = 8;
            this.Fbut.Text = "Finally";
            this.Fbut.UseVisualStyleBackColor = true;
            this.Fbut.Click += new System.EventHandler(this.Fbut_Click);
            // 
            // Xbut
            // 
            this.Xbut.Location = new System.Drawing.Point(257, 60);
            this.Xbut.Name = "Xbut";
            this.Xbut.Size = new System.Drawing.Size(75, 34);
            this.Xbut.TabIndex = 7;
            this.Xbut.Text = "neXt";
            this.Xbut.UseVisualStyleBackColor = true;
            this.Xbut.Click += new System.EventHandler(this.Xbut_Click);
            // 
            // Ubut
            // 
            this.Ubut.Location = new System.Drawing.Point(176, 60);
            this.Ubut.Name = "Ubut";
            this.Ubut.Size = new System.Drawing.Size(75, 34);
            this.Ubut.TabIndex = 6;
            this.Ubut.Text = "Untill";
            this.Ubut.UseVisualStyleBackColor = true;
            this.Ubut.Click += new System.EventHandler(this.Ubut_Click);
            // 
            // Gbut
            // 
            this.Gbut.Location = new System.Drawing.Point(107, 60);
            this.Gbut.Name = "Gbut";
            this.Gbut.Size = new System.Drawing.Size(63, 34);
            this.Gbut.TabIndex = 5;
            this.Gbut.Text = "Globle";
            this.Gbut.UseVisualStyleBackColor = true;
            this.Gbut.Click += new System.EventHandler(this.Gbut_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(68, 20);
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            this.Input.Size = new System.Drawing.Size(668, 21);
            this.Input.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "属性：";
            // 
            // StartBut
            // 
            this.StartBut.Location = new System.Drawing.Point(661, 217);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(75, 23);
            this.StartBut.TabIndex = 2;
            this.StartBut.Text = "开始验证";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果输出";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(4, 18);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(741, 223);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "常数：";
            // 
            // num1But
            // 
            this.num1But.Location = new System.Drawing.Point(464, 112);
            this.num1But.Name = "num1But";
            this.num1But.Size = new System.Drawing.Size(32, 28);
            this.num1But.TabIndex = 26;
            this.num1But.Text = "1";
            this.num1But.UseVisualStyleBackColor = true;
            this.num1But.Click += new System.EventHandler(this.num1But_Click);
            // 
            // num0But
            // 
            this.num0But.Location = new System.Drawing.Point(502, 212);
            this.num0But.Name = "num0But";
            this.num0But.Size = new System.Drawing.Size(33, 28);
            this.num0But.TabIndex = 27;
            this.num0But.Text = "0";
            this.num0But.UseVisualStyleBackColor = true;
            this.num0But.Click += new System.EventHandler(this.num0But_Click);
            // 
            // num9But
            // 
            this.num9But.Location = new System.Drawing.Point(541, 178);
            this.num9But.Name = "num9But";
            this.num9But.Size = new System.Drawing.Size(31, 28);
            this.num9But.TabIndex = 28;
            this.num9But.Text = "9";
            this.num9But.UseVisualStyleBackColor = true;
            this.num9But.Click += new System.EventHandler(this.num9But_Click);
            // 
            // num8But
            // 
            this.num8But.Location = new System.Drawing.Point(502, 178);
            this.num8But.Name = "num8But";
            this.num8But.Size = new System.Drawing.Size(33, 28);
            this.num8But.TabIndex = 29;
            this.num8But.Text = "8";
            this.num8But.UseVisualStyleBackColor = true;
            this.num8But.Click += new System.EventHandler(this.num8But_Click);
            // 
            // num7But
            // 
            this.num7But.Location = new System.Drawing.Point(464, 178);
            this.num7But.Name = "num7But";
            this.num7But.Size = new System.Drawing.Size(32, 28);
            this.num7But.TabIndex = 30;
            this.num7But.Text = "7";
            this.num7But.UseVisualStyleBackColor = true;
            this.num7But.Click += new System.EventHandler(this.num7But_Click);
            // 
            // num6But
            // 
            this.num6But.Location = new System.Drawing.Point(541, 146);
            this.num6But.Name = "num6But";
            this.num6But.Size = new System.Drawing.Size(31, 26);
            this.num6But.TabIndex = 31;
            this.num6But.Text = "6";
            this.num6But.UseVisualStyleBackColor = true;
            this.num6But.Click += new System.EventHandler(this.num6But_Click);
            // 
            // num5But
            // 
            this.num5But.Location = new System.Drawing.Point(502, 146);
            this.num5But.Name = "num5But";
            this.num5But.Size = new System.Drawing.Size(33, 26);
            this.num5But.TabIndex = 32;
            this.num5But.Text = "5";
            this.num5But.UseVisualStyleBackColor = true;
            this.num5But.Click += new System.EventHandler(this.num5But_Click);
            // 
            // num4But
            // 
            this.num4But.Location = new System.Drawing.Point(464, 146);
            this.num4But.Name = "num4But";
            this.num4But.Size = new System.Drawing.Size(32, 26);
            this.num4But.TabIndex = 33;
            this.num4But.Text = "4";
            this.num4But.UseVisualStyleBackColor = true;
            this.num4But.Click += new System.EventHandler(this.num4But_Click);
            // 
            // num3But
            // 
            this.num3But.Location = new System.Drawing.Point(541, 112);
            this.num3But.Name = "num3But";
            this.num3But.Size = new System.Drawing.Size(31, 28);
            this.num3But.TabIndex = 34;
            this.num3But.Text = "3";
            this.num3But.UseVisualStyleBackColor = true;
            this.num3But.Click += new System.EventHandler(this.num3But_Click);
            // 
            // num2But
            // 
            this.num2But.Location = new System.Drawing.Point(502, 112);
            this.num2But.Name = "num2But";
            this.num2But.Size = new System.Drawing.Size(33, 28);
            this.num2But.TabIndex = 35;
            this.num2But.Text = "2";
            this.num2But.UseVisualStyleBackColor = true;
            this.num2But.Click += new System.EventHandler(this.num2But_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Bounded model checker";
            this.tabControl.ResumeLayout(false);
            this.load.ResumeLayout(false);
            this.load.PerformLayout();
            this.assert.ResumeLayout(false);
            this.edit.ResumeLayout(false);
            this.edit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage load;
        private System.Windows.Forms.TabPage edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.TabPage assert;
        private System.Windows.Forms.Button buttonLoadModel;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAssert;
        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Fbut;
        private System.Windows.Forms.Button Xbut;
        private System.Windows.Forms.Button Ubut;
        private System.Windows.Forms.Button Gbut;
        private System.Windows.Forms.Button Ebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LefMbut;
        private System.Windows.Forms.Button EquBut;
        private System.Windows.Forms.Button LessBut;
        private System.Windows.Forms.Button MoreBut;
        private System.Windows.Forms.Button DevBut;
        private System.Windows.Forms.Button MulBut;
        private System.Windows.Forms.Button SubBut;
        private System.Windows.Forms.Button PluBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Button RigMbut;
        private System.Windows.Forms.Button RigSbut;
        private System.Windows.Forms.Button LefSbut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button num2But;
        private System.Windows.Forms.Button num3But;
        private System.Windows.Forms.Button num4But;
        private System.Windows.Forms.Button num5But;
        private System.Windows.Forms.Button num6But;
        private System.Windows.Forms.Button num7But;
        private System.Windows.Forms.Button num8But;
        private System.Windows.Forms.Button num9But;
        private System.Windows.Forms.Button num0But;
        private System.Windows.Forms.Button num1But;
        private System.Windows.Forms.Label label6;
    }
}

