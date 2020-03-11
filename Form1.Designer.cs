namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actorName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frameNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frameStep = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Animation1 = new System.Windows.Forms.TextBox();
            this.Animation2 = new System.Windows.Forms.TextBox();
            this.Animation3 = new System.Windows.Forms.TextBox();
            this.Animation4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ScaleZTextBox = new System.Windows.Forms.TextBox();
            this.ScaleXTextBox = new System.Windows.Forms.TextBox();
            this.ScaleYTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.OffsetXTextBox = new System.Windows.Forms.TextBox();
            this.OffsetYTextBox = new System.Windows.Forms.TextBox();
            this.OffsetZTextBox = new System.Windows.Forms.TextBox();
            this.ScaleYLabel = new System.Windows.Forms.Label();
            this.ScaleZLabel = new System.Windows.Forms.Label();
            this.OffsetXLabel = new System.Windows.Forms.Label();
            this.OffsetYLabel = new System.Windows.Forms.Label();
            this.OffsetZLabel = new System.Windows.Forms.Label();
            this.ScaleXLabel = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.AngleOffsetTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inheritanceTextBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mapInfoTextBox = new System.Windows.Forms.TextBox();
            this.MapinfoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // actorName
            // 
            this.actorName.Location = new System.Drawing.Point(90, 32);
            this.actorName.Name = "actorName";
            this.actorName.Size = new System.Drawing.Size(81, 20);
            this.actorName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "3D Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Texture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Files (*.*)|*.*|Quake 3 models (*.md3)|*.md3|Quake 2 models (*.md2)| *.md2|St" +
    "atic OBJ models (*.obj) | *.obj";
            this.openFileDialog1.Title = "3D model";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Title = "Texture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actor name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of frames";
            // 
            // frameNumber
            // 
            this.frameNumber.Location = new System.Drawing.Point(99, 3);
            this.frameNumber.Name = "frameNumber";
            this.frameNumber.Size = new System.Drawing.Size(100, 20);
            this.frameNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Frame step";
            // 
            // frameStep
            // 
            this.frameStep.Location = new System.Drawing.Point(99, 29);
            this.frameStep.Name = "frameStep";
            this.frameStep.Size = new System.Drawing.Size(100, 20);
            this.frameStep.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(425, 13);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(359, 191);
            this.textBox4.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Animated";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 216);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(359, 182);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Modeldef";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ZScript";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Create PK3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Animation1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Animation2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Animation3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Animation4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox14, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 248);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 170);
            this.tableLayoutPanel1.TabIndex = 16;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Animation name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "To";
            // 
            // Animation1
            // 
            this.Animation1.BackColor = System.Drawing.Color.RoyalBlue;
            this.Animation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animation1.Location = new System.Drawing.Point(3, 37);
            this.Animation1.Name = "Animation1";
            this.Animation1.Size = new System.Drawing.Size(100, 20);
            this.Animation1.TabIndex = 3;
            // 
            // Animation2
            // 
            this.Animation2.BackColor = System.Drawing.Color.RoyalBlue;
            this.Animation2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animation2.Location = new System.Drawing.Point(3, 71);
            this.Animation2.Name = "Animation2";
            this.Animation2.Size = new System.Drawing.Size(100, 20);
            this.Animation2.TabIndex = 4;
            // 
            // Animation3
            // 
            this.Animation3.BackColor = System.Drawing.Color.RoyalBlue;
            this.Animation3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animation3.Location = new System.Drawing.Point(3, 105);
            this.Animation3.Name = "Animation3";
            this.Animation3.Size = new System.Drawing.Size(100, 20);
            this.Animation3.TabIndex = 5;
            // 
            // Animation4
            // 
            this.Animation4.BackColor = System.Drawing.Color.RoyalBlue;
            this.Animation4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animation4.Location = new System.Drawing.Point(3, 139);
            this.Animation4.Name = "Animation4";
            this.Animation4.Size = new System.Drawing.Size(100, 20);
            this.Animation4.TabIndex = 6;
            this.Animation4.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox7.Location = new System.Drawing.Point(109, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(40, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox8.Location = new System.Drawing.Point(155, 37);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(40, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox9.Location = new System.Drawing.Point(109, 71);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(40, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox10.Location = new System.Drawing.Point(155, 71);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(40, 20);
            this.textBox10.TabIndex = 10;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox11.Location = new System.Drawing.Point(109, 105);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(40, 20);
            this.textBox11.TabIndex = 11;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox12.Location = new System.Drawing.Point(155, 105);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(40, 20);
            this.textBox12.TabIndex = 12;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox13.Location = new System.Drawing.Point(109, 139);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(40, 20);
            this.textBox13.TabIndex = 13;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox14.Location = new System.Drawing.Point(155, 139);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(40, 20);
            this.textBox14.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "From";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.frameNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.frameStep, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Enabled = false;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 187);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 56);
            this.tableLayoutPanel2.TabIndex = 17;
            this.tableLayoutPanel2.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.actorName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(174, 59);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // ScaleZTextBox
            // 
            this.ScaleZTextBox.Location = new System.Drawing.Point(54, 55);
            this.ScaleZTextBox.Name = "ScaleZTextBox";
            this.ScaleZTextBox.Size = new System.Drawing.Size(41, 20);
            this.ScaleZTextBox.TabIndex = 19;
            // 
            // ScaleXTextBox
            // 
            this.ScaleXTextBox.Location = new System.Drawing.Point(54, 3);
            this.ScaleXTextBox.Name = "ScaleXTextBox";
            this.ScaleXTextBox.Size = new System.Drawing.Size(41, 20);
            this.ScaleXTextBox.TabIndex = 20;
            // 
            // ScaleYTextBox
            // 
            this.ScaleYTextBox.Location = new System.Drawing.Point(54, 29);
            this.ScaleYTextBox.Name = "ScaleYTextBox";
            this.ScaleYTextBox.Size = new System.Drawing.Size(41, 20);
            this.ScaleYTextBox.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.ScaleZTextBox, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.ScaleYTextBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.ScaleXTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.OffsetXTextBox, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.OffsetYTextBox, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.OffsetZTextBox, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.ScaleYLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ScaleZLabel, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.OffsetXLabel, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.OffsetYLabel, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.OffsetZLabel, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.ScaleXLabel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(260, 10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(102, 158);
            this.tableLayoutPanel4.TabIndex = 22;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // OffsetXTextBox
            // 
            this.OffsetXTextBox.Location = new System.Drawing.Point(54, 81);
            this.OffsetXTextBox.Name = "OffsetXTextBox";
            this.OffsetXTextBox.Size = new System.Drawing.Size(41, 20);
            this.OffsetXTextBox.TabIndex = 22;
            // 
            // OffsetYTextBox
            // 
            this.OffsetYTextBox.Location = new System.Drawing.Point(54, 107);
            this.OffsetYTextBox.Name = "OffsetYTextBox";
            this.OffsetYTextBox.Size = new System.Drawing.Size(41, 20);
            this.OffsetYTextBox.TabIndex = 23;
            // 
            // OffsetZTextBox
            // 
            this.OffsetZTextBox.Location = new System.Drawing.Point(54, 133);
            this.OffsetZTextBox.Name = "OffsetZTextBox";
            this.OffsetZTextBox.Size = new System.Drawing.Size(41, 20);
            this.OffsetZTextBox.TabIndex = 24;
            // 
            // ScaleYLabel
            // 
            this.ScaleYLabel.AutoSize = true;
            this.ScaleYLabel.Location = new System.Drawing.Point(3, 26);
            this.ScaleYLabel.Name = "ScaleYLabel";
            this.ScaleYLabel.Size = new System.Drawing.Size(44, 13);
            this.ScaleYLabel.TabIndex = 26;
            this.ScaleYLabel.Text = "Scale Y";
            // 
            // ScaleZLabel
            // 
            this.ScaleZLabel.AutoSize = true;
            this.ScaleZLabel.Location = new System.Drawing.Point(3, 52);
            this.ScaleZLabel.Name = "ScaleZLabel";
            this.ScaleZLabel.Size = new System.Drawing.Size(44, 13);
            this.ScaleZLabel.TabIndex = 27;
            this.ScaleZLabel.Text = "Scale Z";
            this.ScaleZLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // OffsetXLabel
            // 
            this.OffsetXLabel.AutoSize = true;
            this.OffsetXLabel.Location = new System.Drawing.Point(3, 78);
            this.OffsetXLabel.Name = "OffsetXLabel";
            this.OffsetXLabel.Size = new System.Drawing.Size(45, 13);
            this.OffsetXLabel.TabIndex = 28;
            this.OffsetXLabel.Text = "Offset X";
            // 
            // OffsetYLabel
            // 
            this.OffsetYLabel.AutoSize = true;
            this.OffsetYLabel.Location = new System.Drawing.Point(3, 104);
            this.OffsetYLabel.Name = "OffsetYLabel";
            this.OffsetYLabel.Size = new System.Drawing.Size(45, 13);
            this.OffsetYLabel.TabIndex = 29;
            this.OffsetYLabel.Text = "Offset Y";
            // 
            // OffsetZLabel
            // 
            this.OffsetZLabel.AutoSize = true;
            this.OffsetZLabel.Location = new System.Drawing.Point(3, 130);
            this.OffsetZLabel.Name = "OffsetZLabel";
            this.OffsetZLabel.Size = new System.Drawing.Size(45, 13);
            this.OffsetZLabel.TabIndex = 30;
            this.OffsetZLabel.Text = "Offset Z";
            // 
            // ScaleXLabel
            // 
            this.ScaleXLabel.AutoSize = true;
            this.ScaleXLabel.Location = new System.Drawing.Point(3, 0);
            this.ScaleXLabel.Name = "ScaleXLabel";
            this.ScaleXLabel.Size = new System.Drawing.Size(44, 13);
            this.ScaleXLabel.TabIndex = 25;
            this.ScaleXLabel.Text = "Scale X";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(93, 164);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Rotating";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "AngleOffset";
            // 
            // AngleOffsetTextBox
            // 
            this.AngleOffsetTextBox.Location = new System.Drawing.Point(93, 72);
            this.AngleOffsetTextBox.Name = "AngleOffsetTextBox";
            this.AngleOffsetTextBox.Size = new System.Drawing.Size(42, 20);
            this.AngleOffsetTextBox.TabIndex = 25;
            this.AngleOffsetTextBox.Text = "0";
            this.AngleOffsetTextBox.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(344, 395);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.AngleOffsetTextBox);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modeldef";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.inheritanceTextBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tableLayoutPanel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ZScript";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.healthTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.radiusTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.heightTextBox, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.massTextBox, 1, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(11, 47);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(150, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Health";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Radius";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Height";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mass";
            // 
            // healthTextBox
            // 
            this.healthTextBox.Location = new System.Drawing.Point(78, 3);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(39, 20);
            this.healthTextBox.TabIndex = 4;
            this.healthTextBox.Text = "100";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(78, 28);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(39, 20);
            this.radiusTextBox.TabIndex = 5;
            this.radiusTextBox.Text = "26";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(78, 53);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(39, 20);
            this.heightTextBox.TabIndex = 6;
            this.heightTextBox.Text = "30";
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(78, 78);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(39, 20);
            this.massTextBox.TabIndex = 7;
            this.massTextBox.Text = "1000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "inheritance";
            // 
            // inheritanceTextBox
            // 
            this.inheritanceTextBox.Location = new System.Drawing.Point(73, 21);
            this.inheritanceTextBox.Name = "inheritanceTextBox";
            this.inheritanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.inheritanceTextBox.TabIndex = 2;
            this.inheritanceTextBox.Text = "Actor";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "MONSTER;",
            "PROJECTILE;",
            "+SOLID",
            "+SHOOTABLE",
            "+NOBLOOD",
            "+NOFRICTIONBOUNCE",
            "+ACTLIKEBRIDGE",
            "+CLIENTSIDEONLY",
            "+NOINTERACTION",
            "+FRIENDLY",
            "+NOGRAVITY",
            "-NOGRAVITY",
            "+NOFRICTION",
            "+RANDOMIZE"});
            this.checkedListBox1.Location = new System.Drawing.Point(607, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 394);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage3.Controls.Add(this.MapinfoLabel);
            this.tabPage3.Controls.Add(this.mapInfoTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mapinfo";
            // 
            // mapInfoTextBox
            // 
            this.mapInfoTextBox.Location = new System.Drawing.Point(8, 53);
            this.mapInfoTextBox.Multiline = true;
            this.mapInfoTextBox.Name = "mapInfoTextBox";
            this.mapInfoTextBox.ReadOnly = true;
            this.mapInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mapInfoTextBox.Size = new System.Drawing.Size(759, 363);
            this.mapInfoTextBox.TabIndex = 0;
            // 
            // MapinfoLabel
            // 
            this.MapinfoLabel.AutoSize = true;
            this.MapinfoLabel.Location = new System.Drawing.Point(8, 37);
            this.MapinfoLabel.Name = "MapinfoLabel";
            this.MapinfoLabel.Size = new System.Drawing.Size(45, 13);
            this.MapinfoLabel.TabIndex = 1;
            this.MapinfoLabel.Text = "Mapinfo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Modeldef generator for GZDoom - by Gelle Szebasztián";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox actorName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frameNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox frameStep;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Animation1;
        private System.Windows.Forms.TextBox Animation2;
        private System.Windows.Forms.TextBox Animation3;
        private System.Windows.Forms.TextBox Animation4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox ScaleZTextBox;
        private System.Windows.Forms.TextBox ScaleXTextBox;
        private System.Windows.Forms.TextBox ScaleYTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox OffsetXTextBox;
        private System.Windows.Forms.TextBox OffsetYTextBox;
        private System.Windows.Forms.TextBox OffsetZTextBox;
        private System.Windows.Forms.Label ScaleXLabel;
        private System.Windows.Forms.Label ScaleYLabel;
        private System.Windows.Forms.Label ScaleZLabel;
        private System.Windows.Forms.Label OffsetXLabel;
        private System.Windows.Forms.Label OffsetYLabel;
        private System.Windows.Forms.Label OffsetZLabel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AngleOffsetTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.TextBox inheritanceTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label MapinfoLabel;
        private System.Windows.Forms.TextBox mapInfoTextBox;
    }
}

