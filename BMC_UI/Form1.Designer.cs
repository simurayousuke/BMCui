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
            this.edit = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.assert = new System.Windows.Forms.TabPage();
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonAssert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.load.SuspendLayout();
            this.edit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.assert.SuspendLayout();
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
            // edit
            // 
            this.edit.Controls.Add(this.textBox2);
            this.edit.Controls.Add(this.label2);
            this.edit.Controls.Add(this.button1);
            this.edit.Location = new System.Drawing.Point(4, 22);
            this.edit.Name = "edit";
            this.edit.Padding = new System.Windows.Forms.Padding(3);
            this.edit.Size = new System.Drawing.Size(751, 256);
            this.edit.TabIndex = 1;
            this.edit.Text = "编辑属性";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件路径：";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始验证";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(668, 21);
            this.textBox2.TabIndex = 4;
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
            this.edit.ResumeLayout(false);
            this.edit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.assert.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

