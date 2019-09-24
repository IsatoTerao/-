namespace WorkReport1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出退勤WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出勤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退勤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWorkerName = new System.Windows.Forms.ComboBox();
            this.textBoxDateTimeNow = new System.Windows.Forms.TextBox();
            this.buttonRecordEndTime = new System.Windows.Forms.Button();
            this.buttonRecordStartTime = new System.Windows.Forms.Button();
            this.labelNowTime = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.開始DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.終了DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.勤務時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作業内容DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workReportDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workReportDataSet = new WorkReport1.WorkReportDataSet();
            this.listBoxYM = new System.Windows.Forms.ListBox();
            this.textBoxDbgCsvPath = new System.Windows.Forms.TextBox();
            this.textBoxWorkerName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataTableWorkReportSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workReportSheet1 = new WorkReport1.workReportSheet();
            this.workReportSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workReportSheet = new WorkReport1.workReportSheet();
            this.workReportSheet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workReportSheet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workReportSheet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxdbg1 = new System.Windows.Forms.TextBox();
            this.textBoxdbg2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWorkReportSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(2351, 1182);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューMToolStripMenuItem,
            this.出退勤WToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2351, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューMToolStripMenuItem
            // 
            this.メニューMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存SToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了EToolStripMenuItem});
            this.メニューMToolStripMenuItem.Name = "メニューMToolStripMenuItem";
            this.メニューMToolStripMenuItem.Size = new System.Drawing.Size(137, 44);
            this.メニューMToolStripMenuItem.Text = "メニュー(&M)";
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Enabled = false;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(224, 44);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // 終了EToolStripMenuItem
            // 
            this.終了EToolStripMenuItem.Name = "終了EToolStripMenuItem";
            this.終了EToolStripMenuItem.Size = new System.Drawing.Size(224, 44);
            this.終了EToolStripMenuItem.Text = "終了(&E)";
            this.終了EToolStripMenuItem.Click += new System.EventHandler(this.終了EToolStripMenuItem_Click);
            // 
            // 出退勤WToolStripMenuItem
            // 
            this.出退勤WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.出勤ToolStripMenuItem,
            this.退勤ToolStripMenuItem});
            this.出退勤WToolStripMenuItem.Name = "出退勤WToolStripMenuItem";
            this.出退勤WToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.出退勤WToolStripMenuItem.Size = new System.Drawing.Size(143, 44);
            this.出退勤WToolStripMenuItem.Text = "出退勤(&W)";
            // 
            // 出勤ToolStripMenuItem
            // 
            this.出勤ToolStripMenuItem.Name = "出勤ToolStripMenuItem";
            this.出勤ToolStripMenuItem.Size = new System.Drawing.Size(197, 44);
            this.出勤ToolStripMenuItem.Text = "出勤";
            this.出勤ToolStripMenuItem.Click += new System.EventHandler(this.出勤ToolStripMenuItem_Click);
            // 
            // 退勤ToolStripMenuItem
            // 
            this.退勤ToolStripMenuItem.Name = "退勤ToolStripMenuItem";
            this.退勤ToolStripMenuItem.Size = new System.Drawing.Size(197, 44);
            this.退勤ToolStripMenuItem.Text = "退勤";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(124, 44);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            this.ヘルプHToolStripMenuItem.Click += new System.EventHandler(this.ヘルプHToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2404, 880);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxdbg2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxdbg1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBoxWorkerName);
            this.tabPage1.Controls.Add(this.textBoxDateTimeNow);
            this.tabPage1.Controls.Add(this.buttonRecordEndTime);
            this.tabPage1.Controls.Add(this.buttonRecordStartTime);
            this.tabPage1.Controls.Add(this.labelNowTime);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Size = new System.Drawing.Size(2388, 833);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "出退勤登録";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "作業者";
            // 
            // comboBoxWorkerName
            // 
            this.comboBoxWorkerName.FormattingEnabled = true;
            this.comboBoxWorkerName.Location = new System.Drawing.Point(282, 31);
            this.comboBoxWorkerName.Name = "comboBoxWorkerName";
            this.comboBoxWorkerName.Size = new System.Drawing.Size(1453, 32);
            this.comboBoxWorkerName.TabIndex = 4;
            this.comboBoxWorkerName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxWorkerName_SelectedIndexChanged);
            // 
            // textBoxDateTimeNow
            // 
            this.textBoxDateTimeNow.Location = new System.Drawing.Point(282, 138);
            this.textBoxDateTimeNow.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxDateTimeNow.Name = "textBoxDateTimeNow";
            this.textBoxDateTimeNow.Size = new System.Drawing.Size(442, 31);
            this.textBoxDateTimeNow.TabIndex = 3;
            this.textBoxDateTimeNow.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // buttonRecordEndTime
            // 
            this.buttonRecordEndTime.Location = new System.Drawing.Point(561, 298);
            this.buttonRecordEndTime.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonRecordEndTime.Name = "buttonRecordEndTime";
            this.buttonRecordEndTime.Size = new System.Drawing.Size(423, 98);
            this.buttonRecordEndTime.TabIndex = 2;
            this.buttonRecordEndTime.Text = "退勤登録";
            this.buttonRecordEndTime.UseVisualStyleBackColor = true;
            this.buttonRecordEndTime.Click += new System.EventHandler(this.ButtonRecordEndTime_Click);
            // 
            // buttonRecordStartTime
            // 
            this.buttonRecordStartTime.Location = new System.Drawing.Point(57, 298);
            this.buttonRecordStartTime.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonRecordStartTime.Name = "buttonRecordStartTime";
            this.buttonRecordStartTime.Size = new System.Drawing.Size(423, 98);
            this.buttonRecordStartTime.TabIndex = 1;
            this.buttonRecordStartTime.Text = "出勤登録";
            this.buttonRecordStartTime.UseVisualStyleBackColor = true;
            this.buttonRecordStartTime.Click += new System.EventHandler(this.ButtonRecordStartTime_Click);
            // 
            // labelNowTime
            // 
            this.labelNowTime.AutoSize = true;
            this.labelNowTime.Location = new System.Drawing.Point(86, 138);
            this.labelNowTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNowTime.Name = "labelNowTime";
            this.labelNowTime.Size = new System.Drawing.Size(106, 24);
            this.labelNowTime.TabIndex = 0;
            this.labelNowTime.Text = "現在時刻";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.listBoxYM);
            this.tabPage2.Controls.Add(this.textBoxDbgCsvPath);
            this.tabPage2.Controls.Add(this.textBoxWorkerName);
            this.tabPage2.Controls.Add(this.buttonStart);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.buttonEnd);
            this.tabPage2.Controls.Add(this.buttonEdit);
            this.tabPage2.Controls.Add(this.buttonSave);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Size = new System.Drawing.Size(2388, 833);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "月別勤怠一覧";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "氏名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.開始DataGridViewTextBoxColumn,
            this.終了DataGridViewTextBoxColumn,
            this.勤務時間DataGridViewTextBoxColumn,
            this.作業内容DataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workReportDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1488, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1665, 550);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            this.日付DataGridViewTextBoxColumn.Width = 103;
            // 
            // 開始DataGridViewTextBoxColumn
            // 
            this.開始DataGridViewTextBoxColumn.DataPropertyName = "開始";
            this.開始DataGridViewTextBoxColumn.HeaderText = "開始";
            this.開始DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.開始DataGridViewTextBoxColumn.Name = "開始DataGridViewTextBoxColumn";
            this.開始DataGridViewTextBoxColumn.Width = 103;
            // 
            // 終了DataGridViewTextBoxColumn
            // 
            this.終了DataGridViewTextBoxColumn.DataPropertyName = "終了";
            this.終了DataGridViewTextBoxColumn.HeaderText = "終了";
            this.終了DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.終了DataGridViewTextBoxColumn.Name = "終了DataGridViewTextBoxColumn";
            this.終了DataGridViewTextBoxColumn.Width = 103;
            // 
            // 勤務時間DataGridViewTextBoxColumn
            // 
            this.勤務時間DataGridViewTextBoxColumn.DataPropertyName = "勤務時間";
            this.勤務時間DataGridViewTextBoxColumn.HeaderText = "勤務時間";
            this.勤務時間DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.勤務時間DataGridViewTextBoxColumn.Name = "勤務時間DataGridViewTextBoxColumn";
            this.勤務時間DataGridViewTextBoxColumn.Width = 151;
            // 
            // 作業内容DataGridViewTextBoxColumn
            // 
            this.作業内容DataGridViewTextBoxColumn.DataPropertyName = "作業内容";
            this.作業内容DataGridViewTextBoxColumn.HeaderText = "作業内容";
            this.作業内容DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.作業内容DataGridViewTextBoxColumn.Name = "作業内容DataGridViewTextBoxColumn";
            this.作業内容DataGridViewTextBoxColumn.Width = 151;
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            this.備考DataGridViewTextBoxColumn.Width = 103;
            // 
            // workReportDataTableBindingSource
            // 
            this.workReportDataTableBindingSource.DataMember = "workReportDataTable";
            this.workReportDataTableBindingSource.DataSource = this.workReportDataSet;
            // 
            // workReportDataSet
            // 
            this.workReportDataSet.DataSetName = "WorkReportDataSet";
            this.workReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBoxYM
            // 
            this.listBoxYM.FormattingEnabled = true;
            this.listBoxYM.ItemHeight = 24;
            this.listBoxYM.Location = new System.Drawing.Point(13, 120);
            this.listBoxYM.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.listBoxYM.Name = "listBoxYM";
            this.listBoxYM.Size = new System.Drawing.Size(1408, 676);
            this.listBoxYM.TabIndex = 1;
            this.listBoxYM.SelectedIndexChanged += new System.EventHandler(this.ListBoxYM_SelectedIndexChanged);
            this.listBoxYM.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ListBoxYM_Format);
            // 
            // textBoxDbgCsvPath
            // 
            this.textBoxDbgCsvPath.Location = new System.Drawing.Point(683, 20);
            this.textBoxDbgCsvPath.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxDbgCsvPath.Name = "textBoxDbgCsvPath";
            this.textBoxDbgCsvPath.Size = new System.Drawing.Size(905, 31);
            this.textBoxDbgCsvPath.TabIndex = 9;
            this.textBoxDbgCsvPath.Text = "DebugCSVPath";
            // 
            // textBoxWorkerName
            // 
            this.textBoxWorkerName.Location = new System.Drawing.Point(83, 25);
            this.textBoxWorkerName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxWorkerName.Name = "textBoxWorkerName";
            this.textBoxWorkerName.Size = new System.Drawing.Size(281, 31);
            this.textBoxWorkerName.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(306, 1104);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(163, 46);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "出勤";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "年月";
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(501, 1104);
            this.buttonEnd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(163, 46);
            this.buttonEnd.TabIndex = 4;
            this.buttonEnd.Text = "退勤";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.ButtonEnd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(702, 1104);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(163, 46);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "編集";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1902, 1104);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(163, 46);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(2036, 833);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "編集";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.DataSource = this.workReportDataTableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(315, 134);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.Size = new System.Drawing.Size(1665, 550);
            this.dataGridView2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "日付";
            this.dataGridViewTextBoxColumn1.HeaderText = "日付";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "開始";
            this.dataGridViewTextBoxColumn2.HeaderText = "開始";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "終了";
            this.dataGridViewTextBoxColumn3.HeaderText = "終了";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "勤務時間";
            this.dataGridViewTextBoxColumn4.HeaderText = "勤務時間";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "作業内容";
            this.dataGridViewTextBoxColumn5.HeaderText = "作業内容";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "備考";
            this.dataGridViewTextBoxColumn6.HeaderText = "備考";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(22, 134);
            this.listBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 676);
            this.listBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "年月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "氏名";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(700, 16);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(905, 31);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "DebugCSVPath";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 21);
            this.textBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(281, 31);
            this.textBox3.TabIndex = 11;
            // 
            // dataTableWorkReportSheetBindingSource
            // 
            this.dataTableWorkReportSheetBindingSource.DataMember = "DataTableWorkReportSheet";
            this.dataTableWorkReportSheetBindingSource.DataSource = this.workReportSheet1;
            // 
            // workReportSheet1
            // 
            this.workReportSheet1.DataSetName = "workReportSheet";
            this.workReportSheet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workReportSheetBindingSource
            // 
            this.workReportSheetBindingSource.DataSource = this.workReportSheet;
            this.workReportSheetBindingSource.Position = 0;
            // 
            // workReportSheet
            // 
            this.workReportSheet.DataSetName = "workReportSheet";
            this.workReportSheet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workReportSheet1BindingSource
            // 
            this.workReportSheet1BindingSource.DataSource = this.workReportSheet1;
            this.workReportSheet1BindingSource.Position = 0;
            // 
            // workReportSheet1BindingSource1
            // 
            this.workReportSheet1BindingSource1.DataSource = this.workReportSheet1;
            this.workReportSheet1BindingSource1.Position = 0;
            // 
            // workReportSheet1BindingSource2
            // 
            this.workReportSheet1BindingSource2.DataSource = this.workReportSheet1;
            this.workReportSheet1BindingSource2.Position = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "debug";
            // 
            // textBoxdbg1
            // 
            this.textBoxdbg1.Location = new System.Drawing.Point(282, 514);
            this.textBoxdbg1.Name = "textBoxdbg1";
            this.textBoxdbg1.Size = new System.Drawing.Size(1453, 31);
            this.textBoxdbg1.TabIndex = 7;
            // 
            // textBoxdbg2
            // 
            this.textBoxdbg2.Location = new System.Drawing.Point(282, 583);
            this.textBoxdbg2.Name = "textBoxdbg2";
            this.textBoxdbg2.Size = new System.Drawing.Size(1453, 31);
            this.textBoxdbg2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 586);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "debug2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2351, 1182);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "作業報告書作成";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWorkReportSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workReportSheet1BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource workReportSheetBindingSource;
        private workReportSheet workReportSheet;
        private System.Windows.Forms.BindingSource dataTableWorkReportSheetBindingSource;
        private workReportSheet workReportSheet1;
        private System.Windows.Forms.BindingSource workReportSheet1BindingSource;
        private System.Windows.Forms.BindingSource workReportSheet1BindingSource1;
        private WorkReportDataSet workReportDataSet;
        private System.Windows.Forms.BindingSource workReportSheet1BindingSource2;
        private System.Windows.Forms.BindingSource workReportDataTableBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出退勤WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出勤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退勤ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxDateTimeNow;
        private System.Windows.Forms.Button buttonRecordEndTime;
        private System.Windows.Forms.Button buttonRecordStartTime;
        private System.Windows.Forms.Label labelNowTime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 開始DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 終了DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 勤務時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作業内容DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBoxYM;
        private System.Windows.Forms.TextBox textBoxDbgCsvPath;
        private System.Windows.Forms.TextBox textBoxWorkerName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxWorkerName;
        private System.Windows.Forms.TextBox textBoxdbg1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxdbg2;
        private System.Windows.Forms.Label label7;
    }
}

