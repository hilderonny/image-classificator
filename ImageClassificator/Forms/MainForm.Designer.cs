namespace ImageClassificator.Forms
{
    partial class MainForm
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
            GroupBox groupBox1;
            TableLayoutPanel tableLayoutPanel2;
            Label label1;
            Button buttonHomeChangeSettings;
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            GroupBox groupBox2;
            TableLayoutPanel tableLayoutPanel4;
            GroupBox groupBox3;
            TableLayoutPanel tableLayoutPanel5;
            Label label9;
            Label label10;
            Label label11;
            Button buttonSettingsChooseInputPath;
            Button buttonSettingsChooseProcessingPath;
            Button buttonSettingsChooseOutputPath;
            Label label7;
            Label label8;
            Button buttonSettingsChoosePythonPath;
            GroupBox groupBox4;
            TableLayoutPanel tableLayoutPanel6;
            Label label15;
            labelHomeInputPath = new Label();
            labelHomeProcessingPath = new Label();
            labelHomeOutputPath = new Label();
            labelHomeTagLanguage = new Label();
            labelHomePythonPath = new Label();
            labelHomeMobileNetPath = new Label();
            richTextBoxConsoleOutput = new RichTextBox();
            labelSettingsInputPath = new Label();
            labelSettingsProcessingPath = new Label();
            labelSettingsOutputPath = new Label();
            labelSettingsPythonPath = new Label();
            labelSettingsMobileNetPath = new Label();
            buttonSettingsChooseMobileNetPath = new Button();
            comboBoxSettingsTagLanguage = new ComboBox();
            buttonHomeStart = new Button();
            tabControl = new TabControl();
            tabPageHome = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            tabPageSettings = new TabPage();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            buttonHomeChangeSettings = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            buttonSettingsChooseInputPath = new Button();
            buttonSettingsChooseProcessingPath = new Button();
            buttonSettingsChooseOutputPath = new Button();
            label7 = new Label();
            label8 = new Label();
            buttonSettingsChoosePythonPath = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label15 = new Label();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageHome.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabPageSettings.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aktuelle Einstellungen";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167F));
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonHomeChangeSettings, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 5);
            tableLayoutPanel2.Controls.Add(labelHomeInputPath, 1, 2);
            tableLayoutPanel2.Controls.Add(labelHomeProcessingPath, 1, 3);
            tableLayoutPanel2.Controls.Add(labelHomeOutputPath, 1, 4);
            tableLayoutPanel2.Controls.Add(labelHomeTagLanguage, 1, 5);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(labelHomePythonPath, 1, 0);
            tableLayoutPanel2.Controls.Add(labelHomeMobileNetPath, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(982, 122);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Eingabepfad:";
            // 
            // buttonHomeChangeSettings
            // 
            buttonHomeChangeSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHomeChangeSettings.Location = new Point(832, 3);
            buttonHomeChangeSettings.Name = "buttonHomeChangeSettings";
            tableLayoutPanel2.SetRowSpan(buttonHomeChangeSettings, 6);
            buttonHomeChangeSettings.Size = new Size(147, 23);
            buttonHomeChangeSettings.TabIndex = 0;
            buttonHomeChangeSettings.Text = "Einstellungen ändern";
            buttonHomeChangeSettings.UseVisualStyleBackColor = true;
            buttonHomeChangeSettings.Click += buttonHomeChangeSettings_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Verarbeitungspfad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Ausgabepfad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Sprache der Tags:";
            // 
            // labelHomeInputPath
            // 
            labelHomeInputPath.AutoSize = true;
            labelHomeInputPath.Location = new Point(133, 40);
            labelHomeInputPath.Name = "labelHomeInputPath";
            labelHomeInputPath.Size = new Size(117, 15);
            labelHomeInputPath.TabIndex = 4;
            labelHomeInputPath.Text = "labelHomeInputPath";
            // 
            // labelHomeProcessingPath
            // 
            labelHomeProcessingPath.AutoSize = true;
            labelHomeProcessingPath.Location = new Point(133, 60);
            labelHomeProcessingPath.Name = "labelHomeProcessingPath";
            labelHomeProcessingPath.Size = new Size(146, 15);
            labelHomeProcessingPath.TabIndex = 5;
            labelHomeProcessingPath.Text = "labelHomeProcessingPath";
            // 
            // labelHomeOutputPath
            // 
            labelHomeOutputPath.AutoSize = true;
            labelHomeOutputPath.Location = new Point(133, 80);
            labelHomeOutputPath.Name = "labelHomeOutputPath";
            labelHomeOutputPath.Size = new Size(146, 15);
            labelHomeOutputPath.TabIndex = 6;
            labelHomeOutputPath.Text = "labelHomeProcessingPath";
            // 
            // labelHomeTagLanguage
            // 
            labelHomeTagLanguage.AutoSize = true;
            labelHomeTagLanguage.Location = new Point(133, 100);
            labelHomeTagLanguage.Name = "labelHomeTagLanguage";
            labelHomeTagLanguage.Size = new Size(135, 15);
            labelHomeTagLanguage.TabIndex = 7;
            labelHomeTagLanguage.Text = "labelHomeTagLanguage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Python:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 20);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 9;
            label6.Text = "MobileNet:";
            // 
            // labelHomePythonPath
            // 
            labelHomePythonPath.AutoSize = true;
            labelHomePythonPath.Location = new Point(133, 0);
            labelHomePythonPath.Name = "labelHomePythonPath";
            labelHomePythonPath.Size = new Size(127, 15);
            labelHomePythonPath.TabIndex = 10;
            labelHomePythonPath.Text = "labelHomePythonPath";
            // 
            // labelHomeMobileNetPath
            // 
            labelHomeMobileNetPath.AutoSize = true;
            labelHomeMobileNetPath.Location = new Point(133, 20);
            labelHomeMobileNetPath.Name = "labelHomeMobileNetPath";
            labelHomeMobileNetPath.Size = new Size(145, 15);
            labelHomeMobileNetPath.TabIndex = 11;
            labelHomeMobileNetPath.Text = "labelHomeMobileNetPath";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxConsoleOutput);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(988, 507);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ausgabe";
            // 
            // richTextBoxConsoleOutput
            // 
            richTextBoxConsoleOutput.BackColor = Color.Black;
            richTextBoxConsoleOutput.Dock = DockStyle.Fill;
            richTextBoxConsoleOutput.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxConsoleOutput.ForeColor = Color.White;
            richTextBoxConsoleOutput.Location = new Point(3, 19);
            richTextBoxConsoleOutput.Name = "richTextBoxConsoleOutput";
            richTextBoxConsoleOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxConsoleOutput.Size = new Size(982, 485);
            richTextBoxConsoleOutput.TabIndex = 0;
            richTextBoxConsoleOutput.Text = "";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel4.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(994, 695);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(988, 169);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pfade";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableLayoutPanel5.Controls.Add(label9, 0, 2);
            tableLayoutPanel5.Controls.Add(label10, 0, 3);
            tableLayoutPanel5.Controls.Add(label11, 0, 4);
            tableLayoutPanel5.Controls.Add(labelSettingsInputPath, 1, 2);
            tableLayoutPanel5.Controls.Add(labelSettingsProcessingPath, 1, 3);
            tableLayoutPanel5.Controls.Add(labelSettingsOutputPath, 1, 4);
            tableLayoutPanel5.Controls.Add(buttonSettingsChooseInputPath, 2, 2);
            tableLayoutPanel5.Controls.Add(buttonSettingsChooseProcessingPath, 2, 3);
            tableLayoutPanel5.Controls.Add(buttonSettingsChooseOutputPath, 2, 4);
            tableLayoutPanel5.Controls.Add(label7, 0, 0);
            tableLayoutPanel5.Controls.Add(label8, 0, 1);
            tableLayoutPanel5.Controls.Add(labelSettingsPythonPath, 1, 0);
            tableLayoutPanel5.Controls.Add(labelSettingsMobileNetPath, 1, 1);
            tableLayoutPanel5.Controls.Add(buttonSettingsChoosePythonPath, 2, 0);
            tableLayoutPanel5.Controls.Add(buttonSettingsChooseMobileNetPath, 2, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.Size = new Size(982, 147);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 60);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 0;
            label9.Text = "Eingabepfad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 90);
            label10.Name = "label10";
            label10.Size = new Size(106, 15);
            label10.TabIndex = 1;
            label10.Text = "Verarbeitungspfad:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 120);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 2;
            label11.Text = "Ausgabepfad:";
            // 
            // labelSettingsInputPath
            // 
            labelSettingsInputPath.AutoSize = true;
            labelSettingsInputPath.Location = new Point(127, 60);
            labelSettingsInputPath.Name = "labelSettingsInputPath";
            labelSettingsInputPath.Size = new Size(126, 15);
            labelSettingsInputPath.TabIndex = 3;
            labelSettingsInputPath.Text = "labelSettingsInputPath";
            // 
            // labelSettingsProcessingPath
            // 
            labelSettingsProcessingPath.AutoSize = true;
            labelSettingsProcessingPath.Location = new Point(127, 90);
            labelSettingsProcessingPath.Name = "labelSettingsProcessingPath";
            labelSettingsProcessingPath.Size = new Size(155, 15);
            labelSettingsProcessingPath.TabIndex = 4;
            labelSettingsProcessingPath.Text = "labelSettingsProcessingPath";
            // 
            // labelSettingsOutputPath
            // 
            labelSettingsOutputPath.AutoSize = true;
            labelSettingsOutputPath.Location = new Point(127, 120);
            labelSettingsOutputPath.Name = "labelSettingsOutputPath";
            labelSettingsOutputPath.Size = new Size(136, 15);
            labelSettingsOutputPath.TabIndex = 5;
            labelSettingsOutputPath.Text = "labelSettingsOutputPath";
            // 
            // buttonSettingsChooseInputPath
            // 
            buttonSettingsChooseInputPath.Dock = DockStyle.Top;
            buttonSettingsChooseInputPath.Location = new Point(804, 63);
            buttonSettingsChooseInputPath.Name = "buttonSettingsChooseInputPath";
            buttonSettingsChooseInputPath.Size = new Size(175, 23);
            buttonSettingsChooseInputPath.TabIndex = 6;
            buttonSettingsChooseInputPath.Text = "Eingabepfad wählen ...";
            buttonSettingsChooseInputPath.UseVisualStyleBackColor = true;
            buttonSettingsChooseInputPath.Click += buttonSettingsChooseInputPath_Click;
            // 
            // buttonSettingsChooseProcessingPath
            // 
            buttonSettingsChooseProcessingPath.Dock = DockStyle.Top;
            buttonSettingsChooseProcessingPath.Location = new Point(804, 93);
            buttonSettingsChooseProcessingPath.Name = "buttonSettingsChooseProcessingPath";
            buttonSettingsChooseProcessingPath.Size = new Size(175, 23);
            buttonSettingsChooseProcessingPath.TabIndex = 7;
            buttonSettingsChooseProcessingPath.Text = "Verarbeitungspfad wählen ...";
            buttonSettingsChooseProcessingPath.UseVisualStyleBackColor = true;
            buttonSettingsChooseProcessingPath.Click += buttonSettingsChooseProcessingPath_Click;
            // 
            // buttonSettingsChooseOutputPath
            // 
            buttonSettingsChooseOutputPath.Dock = DockStyle.Top;
            buttonSettingsChooseOutputPath.Location = new Point(804, 123);
            buttonSettingsChooseOutputPath.Name = "buttonSettingsChooseOutputPath";
            buttonSettingsChooseOutputPath.Size = new Size(175, 24);
            buttonSettingsChooseOutputPath.TabIndex = 8;
            buttonSettingsChooseOutputPath.Text = "Ausgabepfad wählen ...";
            buttonSettingsChooseOutputPath.UseVisualStyleBackColor = true;
            buttonSettingsChooseOutputPath.Click += buttonSettingsChooseOutputPath_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 9;
            label7.Text = "Python:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 30);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 10;
            label8.Text = "MobileNet:";
            // 
            // labelSettingsPythonPath
            // 
            labelSettingsPythonPath.AutoSize = true;
            labelSettingsPythonPath.Location = new Point(127, 0);
            labelSettingsPythonPath.Name = "labelSettingsPythonPath";
            labelSettingsPythonPath.Size = new Size(136, 15);
            labelSettingsPythonPath.TabIndex = 11;
            labelSettingsPythonPath.Text = "labelSettingsPythonPath";
            // 
            // labelSettingsMobileNetPath
            // 
            labelSettingsMobileNetPath.AutoSize = true;
            labelSettingsMobileNetPath.Location = new Point(127, 30);
            labelSettingsMobileNetPath.Name = "labelSettingsMobileNetPath";
            labelSettingsMobileNetPath.Size = new Size(154, 15);
            labelSettingsMobileNetPath.TabIndex = 12;
            labelSettingsMobileNetPath.Text = "labelSettingsMobileNetPath";
            // 
            // buttonSettingsChoosePythonPath
            // 
            buttonSettingsChoosePythonPath.Dock = DockStyle.Top;
            buttonSettingsChoosePythonPath.Location = new Point(804, 3);
            buttonSettingsChoosePythonPath.Name = "buttonSettingsChoosePythonPath";
            buttonSettingsChoosePythonPath.Size = new Size(175, 23);
            buttonSettingsChoosePythonPath.TabIndex = 13;
            buttonSettingsChoosePythonPath.Text = "Python-Pfad wählen ...";
            buttonSettingsChoosePythonPath.UseVisualStyleBackColor = true;
            buttonSettingsChoosePythonPath.Click += buttonSettingsChoosePythonPath_Click;
            // 
            // buttonSettingsChooseMobileNetPath
            // 
            buttonSettingsChooseMobileNetPath.Dock = DockStyle.Top;
            buttonSettingsChooseMobileNetPath.Location = new Point(804, 33);
            buttonSettingsChooseMobileNetPath.Name = "buttonSettingsChooseMobileNetPath";
            buttonSettingsChooseMobileNetPath.Size = new Size(175, 23);
            buttonSettingsChooseMobileNetPath.TabIndex = 14;
            buttonSettingsChooseMobileNetPath.Text = "MobileNet-Pfad wählen ...";
            buttonSettingsChooseMobileNetPath.UseVisualStyleBackColor = true;
            buttonSettingsChooseMobileNetPath.Click += buttonSettingsChooseMobileNetPath_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel6);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 178);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(988, 52);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lokalisierung";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label15, 0, 0);
            tableLayoutPanel6.Controls.Add(comboBoxSettingsTagLanguage, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 19);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(982, 30);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(114, 15);
            label15.TabIndex = 0;
            label15.Text = "Sprache der Klassen:";
            // 
            // comboBoxSettingsTagLanguage
            // 
            comboBoxSettingsTagLanguage.FormattingEnabled = true;
            comboBoxSettingsTagLanguage.Items.AddRange(new object[] { "Deutsch", "English" });
            comboBoxSettingsTagLanguage.Location = new Point(129, 3);
            comboBoxSettingsTagLanguage.Name = "comboBoxSettingsTagLanguage";
            comboBoxSettingsTagLanguage.Size = new Size(121, 23);
            comboBoxSettingsTagLanguage.TabIndex = 1;
            comboBoxSettingsTagLanguage.SelectedIndexChanged += comboBoxSettingsTagLanguage_SelectedIndexChanged;
            // 
            // buttonHomeStart
            // 
            buttonHomeStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHomeStart.Location = new Point(916, 153);
            buttonHomeStart.Name = "buttonHomeStart";
            buttonHomeStart.Size = new Size(75, 23);
            buttonHomeStart.TabIndex = 1;
            buttonHomeStart.Text = "Starten";
            buttonHomeStart.UseVisualStyleBackColor = true;
            buttonHomeStart.Click += buttonHomeStart_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageHome);
            tabControl.Controls.Add(tabPageSettings);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1008, 729);
            tabControl.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.Controls.Add(tableLayoutPanel3);
            tabPageHome.Location = new Point(4, 24);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(1000, 701);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Start";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonHomeStart, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(994, 695);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(tableLayoutPanel4);
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(3);
            tabPageSettings.Size = new Size(1000, 701);
            tabPageSettings.TabIndex = 1;
            tabPageSettings.Text = "Einstellungen";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Image Classificator";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageHome;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage tabPageSettings;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelHomeInputPath;
        private Label labelHomeProcessingPath;
        private Label labelHomeOutputPath;
        private Label labelHomeTagLanguage;
        private Button buttonHomeChangeSettings;
        private Button buttonHomeStart;
        private GroupBox groupBox2;
        private RichTextBox richTextBoxConsoleOutput;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelSettingsInputPath;
        private Label labelSettingsProcessingPath;
        private Label labelSettingsOutputPath;
        private Button buttonSettingsChooseInputPath;
        private Button buttonSettingsChooseProcessingPath;
        private Button buttonSettingsChooseOutputPath;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label15;
        private ComboBox comboBoxSettingsTagLanguage;
        private Label labelHomePythonPath;
        private Label labelHomeMobileNetPath;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelSettingsPythonPath;
        private Label labelSettingsMobileNetPath;
        private Button buttonSettingsChooseMobileNetPath;
    }
}