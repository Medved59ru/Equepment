namespace Equepment
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Equepment.Database1DataSet();
            this.usersTableAdapter = new Equepment.Database1DataSetTableAdapters.UsersTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPageADD = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdateDuration = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDurHour = new System.Windows.Forms.Label();
            this.cmbBoxUser = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelDATEADD = new System.Windows.Forms.Label();
            this.cmbBoxEndM = new System.Windows.Forms.ComboBox();
            this.labelEND = new System.Windows.Forms.Label();
            this.cmbBoxBegH = new System.Windows.Forms.ComboBox();
            this.labelBeginTime = new System.Windows.Forms.Label();
            this.datePickAdd = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxEndH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxBegM = new System.Windows.Forms.ComboBox();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.dtPickUpdate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.btnDurUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUpDateDur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxUpDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBxEndHUd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBxBegHUd = new System.Windows.Forms.ComboBox();
            this.cmbBxBegMUd = new System.Windows.Forms.ComboBox();
            this.cmbBxEndMUd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxDelete = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.RBUser = new System.Windows.Forms.RadioButton();
            this.RBDur = new System.Windows.Forms.RadioButton();
            this.RBEnd = new System.Windows.Forms.RadioButton();
            this.RBBegining = new System.Windows.Forms.RadioButton();
            this.RBNote = new System.Windows.Forms.RadioButton();
            this.RBDate = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtPickReport1 = new System.Windows.Forms.DateTimePicker();
            this.dtPickReport2 = new System.Windows.Forms.DateTimePicker();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.ToolBtnAdd = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.tabPageADD.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(878, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMenu);
            this.splitContainer1.Size = new System.Drawing.Size(878, 1011);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Журнал";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(864, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Запись №";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Начало";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Окончание";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Продолжительность";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Оператор";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(870, 380);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Просмотр Отчета";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 30;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(870, 380);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Запись №";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Начало";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Окончание";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Продолжительность";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Оператор";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPageADD);
            this.tabMenu.Controls.Add(this.tabPageUpdate);
            this.tabMenu.Controls.Add(this.tabPageDelete);
            this.tabMenu.Controls.Add(this.tabPageReport);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(878, 594);
            this.tabMenu.TabIndex = 0;
            // 
            // tabPageADD
            // 
            this.tabPageADD.Controls.Add(this.btnInsert);
            this.tabPageADD.Controls.Add(this.panel11);
            this.tabPageADD.Controls.Add(this.panel7);
            this.tabPageADD.Controls.Add(this.panel6);
            this.tabPageADD.Location = new System.Drawing.Point(4, 33);
            this.tabPageADD.Name = "tabPageADD";
            this.tabPageADD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageADD.Size = new System.Drawing.Size(870, 557);
            this.tabPageADD.TabIndex = 0;
            this.tabPageADD.Text = "  Добавить запись";
            this.tabPageADD.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.Enabled = false;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(3, 499);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(864, 55);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "  ДОБАВИТЬ ЗАПИСЬ";
            this.ToolBtnAdd.SetToolTip(this.btnInsert, "Перед нажатием необходимо\r\nпроверить все введенные данные");
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseEnter += new System.EventHandler(this.btnInsert_MouseEnter);
            this.btnInsert.MouseLeave += new System.EventHandler(this.btnInsert_MouseLeave);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.monthCalendar2);
            this.panel11.Location = new System.Drawing.Point(576, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(290, 499);
            this.panel11.TabIndex = 3;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(13, 11);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.btnUpdateDuration);
            this.panel7.Controls.Add(this.lblUser);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.lblDurHour);
            this.panel7.Controls.Add(this.cmbBoxUser);
            this.panel7.Controls.Add(this.lblDuration);
            this.panel7.Location = new System.Drawing.Point(289, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 500);
            this.panel7.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button2);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.comboBox6);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(285, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(288, 500);
            this.panel9.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(51, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 58);
            this.button2.TabIndex = 46;
            this.button2.Text = " Пересчитать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(100, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "Оператор";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(125, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 24);
            this.label13.TabIndex = 43;
            this.label13.Text = "00:00";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.usersBindingSource;
            this.comboBox6.DisplayMember = "Name";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(51, 56);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(206, 32);
            this.comboBox6.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(59, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 48);
            this.label14.TabIndex = 37;
            this.label14.Text = "Продолжительность \r\nиспользования";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateDuration
            // 
            this.btnUpdateDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDuration.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateDuration.Location = new System.Drawing.Point(51, 217);
            this.btnUpdateDuration.Name = "btnUpdateDuration";
            this.btnUpdateDuration.Size = new System.Drawing.Size(206, 58);
            this.btnUpdateDuration.TabIndex = 46;
            this.btnUpdateDuration.Text = " Пересчитать";
            this.ToolBtnAdd.SetToolTip(this.btnUpdateDuration, "Необходимо вычислить \r\nвремя использования.\r\nНажать.");
            this.btnUpdateDuration.UseVisualStyleBackColor = false;
            this.btnUpdateDuration.Click += new System.EventHandler(this.btnUpdateDuration_Click_1);
            this.btnUpdateDuration.MouseEnter += new System.EventHandler(this.btnUpdateDuration_MouseEnter);
            this.btnUpdateDuration.MouseLeave += new System.EventHandler(this.btnUpdateDuration_MouseLeave);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(100, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 24);
            this.lblUser.TabIndex = 36;
            this.lblUser.Text = "Оператор";
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(287, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(288, 500);
            this.panel10.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(289, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(288, 500);
            this.panel8.TabIndex = 3;
            // 
            // lblDurHour
            // 
            this.lblDurHour.AutoSize = true;
            this.lblDurHour.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDurHour.Location = new System.Drawing.Point(114, 175);
            this.lblDurHour.Name = "lblDurHour";
            this.lblDurHour.Size = new System.Drawing.Size(75, 33);
            this.lblDurHour.TabIndex = 43;
            this.lblDurHour.Text = "00:00";
            this.ToolBtnAdd.SetToolTip(this.lblDurHour, "Вычисляется при нажатии\r\nна кнопку \"Пересчитать\"\r\n");
            // 
            // cmbBoxUser
            // 
            this.cmbBoxUser.DataSource = this.usersBindingSource;
            this.cmbBoxUser.DisplayMember = "Name";
            this.cmbBoxUser.FormattingEnabled = true;
            this.cmbBoxUser.Location = new System.Drawing.Point(51, 56);
            this.cmbBoxUser.Name = "cmbBoxUser";
            this.cmbBoxUser.Size = new System.Drawing.Size(206, 32);
            this.cmbBoxUser.TabIndex = 38;
            this.ToolBtnAdd.SetToolTip(this.cmbBoxUser, "Выбирается из списка");
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDuration.Location = new System.Drawing.Point(59, 108);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(183, 48);
            this.lblDuration.TabIndex = 37;
            this.lblDuration.Text = "Продолжительность \r\nиспользования";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelDATEADD);
            this.panel6.Controls.Add(this.cmbBoxEndM);
            this.panel6.Controls.Add(this.labelEND);
            this.panel6.Controls.Add(this.cmbBoxBegH);
            this.panel6.Controls.Add(this.labelBeginTime);
            this.panel6.Controls.Add(this.datePickAdd);
            this.panel6.Controls.Add(this.cmbBoxEndH);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.cmbBoxBegM);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 500);
            this.panel6.TabIndex = 1;
            // 
            // labelDATEADD
            // 
            this.labelDATEADD.AutoSize = true;
            this.labelDATEADD.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDATEADD.Location = new System.Drawing.Point(117, 20);
            this.labelDATEADD.Name = "labelDATEADD";
            this.labelDATEADD.Size = new System.Drawing.Size(48, 24);
            this.labelDATEADD.TabIndex = 33;
            this.labelDATEADD.Text = "Дата";
            // 
            // cmbBoxEndM
            // 
            this.cmbBoxEndM.FormattingEnabled = true;
            this.cmbBoxEndM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbBoxEndM.Location = new System.Drawing.Point(161, 217);
            this.cmbBoxEndM.Name = "cmbBoxEndM";
            this.cmbBoxEndM.Size = new System.Drawing.Size(84, 32);
            this.cmbBoxEndM.TabIndex = 39;
            this.cmbBoxEndM.Text = "00";
            this.ToolBtnAdd.SetToolTip(this.cmbBoxEndM, "Минуты окончания работы");
            // 
            // labelEND
            // 
            this.labelEND.AutoSize = true;
            this.labelEND.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEND.Location = new System.Drawing.Point(115, 184);
            this.labelEND.Name = "labelEND";
            this.labelEND.Size = new System.Drawing.Size(59, 24);
            this.labelEND.TabIndex = 35;
            this.labelEND.Text = "Конец";
            this.ToolBtnAdd.SetToolTip(this.labelEND, "Время окончания работы");
            // 
            // cmbBoxBegH
            // 
            this.cmbBoxBegH.FormattingEnabled = true;
            this.cmbBoxBegH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbBoxBegH.Location = new System.Drawing.Point(45, 136);
            this.cmbBoxBegH.Name = "cmbBoxBegH";
            this.cmbBoxBegH.Size = new System.Drawing.Size(84, 32);
            this.cmbBoxBegH.TabIndex = 42;
            this.cmbBoxBegH.Text = "08";
            this.ToolBtnAdd.SetToolTip(this.cmbBoxBegH, "Час начала работы");
            // 
            // labelBeginTime
            // 
            this.labelBeginTime.AutoSize = true;
            this.labelBeginTime.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBeginTime.Location = new System.Drawing.Point(104, 95);
            this.labelBeginTime.Name = "labelBeginTime";
            this.labelBeginTime.Size = new System.Drawing.Size(70, 24);
            this.labelBeginTime.TabIndex = 34;
            this.labelBeginTime.Text = "Начало";
            this.ToolBtnAdd.SetToolTip(this.labelBeginTime, "Время начала работы");
            // 
            // datePickAdd
            // 
            this.datePickAdd.Location = new System.Drawing.Point(45, 58);
            this.datePickAdd.Name = "datePickAdd";
            this.datePickAdd.Size = new System.Drawing.Size(200, 30);
            this.datePickAdd.TabIndex = 32;
            this.datePickAdd.Value = new System.DateTime(2020, 4, 11, 0, 0, 0, 0);
            // 
            // cmbBoxEndH
            // 
            this.cmbBoxEndH.FormattingEnabled = true;
            this.cmbBoxEndH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbBoxEndH.Location = new System.Drawing.Point(45, 217);
            this.cmbBoxEndH.Name = "cmbBoxEndH";
            this.cmbBoxEndH.Size = new System.Drawing.Size(84, 32);
            this.cmbBoxEndH.TabIndex = 40;
            this.cmbBoxEndH.Text = "18";
            this.ToolBtnAdd.SetToolTip(this.cmbBoxEndH, "Час окончания работы");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(135, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(135, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = ":";
            // 
            // cmbBoxBegM
            // 
            this.cmbBoxBegM.FormattingEnabled = true;
            this.cmbBoxBegM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbBoxBegM.Location = new System.Drawing.Point(161, 133);
            this.cmbBoxBegM.Name = "cmbBoxBegM";
            this.cmbBoxBegM.Size = new System.Drawing.Size(84, 32);
            this.cmbBoxBegM.TabIndex = 41;
            this.cmbBoxBegM.Text = "48";
            this.ToolBtnAdd.SetToolTip(this.cmbBoxBegM, "Минуты начала работы");
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.dtPickUpdate);
            this.tabPageUpdate.Controls.Add(this.panel4);
            this.tabPageUpdate.Controls.Add(this.label1);
            this.tabPageUpdate.Controls.Add(this.btnUpdate);
            this.tabPageUpdate.Controls.Add(this.panel1);
            this.tabPageUpdate.Controls.Add(this.label2);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.cmbBxEndHUd);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.cmbBxBegHUd);
            this.tabPageUpdate.Controls.Add(this.cmbBxBegMUd);
            this.tabPageUpdate.Controls.Add(this.cmbBxEndMUd);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 33);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(870, 557);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "  Изменить запись";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // dtPickUpdate
            // 
            this.dtPickUpdate.Location = new System.Drawing.Point(337, 46);
            this.dtPickUpdate.Name = "dtPickUpdate";
            this.dtPickUpdate.Size = new System.Drawing.Size(200, 30);
            this.dtPickUpdate.TabIndex = 46;
            this.dtPickUpdate.Value = new System.DateTime(2020, 4, 11, 0, 0, 0, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox5);
            this.panel4.Controls.Add(this.btnDurUpdate);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lblUpDateDur);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(577, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 496);
            this.panel4.TabIndex = 52;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.usersBindingSource;
            this.comboBox5.DisplayMember = "Name";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(41, 45);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(206, 32);
            this.comboBox5.TabIndex = 49;
            this.ToolBtnAdd.SetToolTip(this.comboBox5, "Выбирается из списка");
            // 
            // btnDurUpdate
            // 
            this.btnDurUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDurUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDurUpdate.Location = new System.Drawing.Point(41, 212);
            this.btnDurUpdate.Name = "btnDurUpdate";
            this.btnDurUpdate.Size = new System.Drawing.Size(206, 55);
            this.btnDurUpdate.TabIndex = 51;
            this.btnDurUpdate.Text = " Пересчитать";
            this.ToolBtnAdd.SetToolTip(this.btnDurUpdate, "Необходимо вычислить \r\nвремя использования.\r\nНажать.\r\n");
            this.btnDurUpdate.UseVisualStyleBackColor = false;
            this.btnDurUpdate.Click += new System.EventHandler(this.btnDurUpdate_Click);
            this.btnDurUpdate.MouseEnter += new System.EventHandler(this.btnDurUpdate_MouseEnter);
            this.btnDurUpdate.MouseLeave += new System.EventHandler(this.btnDurUpdate_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(58, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 48);
            this.label10.TabIndex = 48;
            this.label10.Text = "Продолжительность\r\nиспользования";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(99, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Оператор";
            // 
            // lblUpDateDur
            // 
            this.lblUpDateDur.AutoSize = true;
            this.lblUpDateDur.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpDateDur.Location = new System.Drawing.Point(113, 169);
            this.lblUpDateDur.Name = "lblUpDateDur";
            this.lblUpDateDur.Size = new System.Drawing.Size(75, 33);
            this.lblUpDateDur.TabIndex = 50;
            this.lblUpDateDur.Text = "00:00";
            this.ToolBtnAdd.SetToolTip(this.lblUpDateDur, "Вычисляется при нажатии\r\nна кнопку \"Пересчитать\"");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(427, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = ":";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 499);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(864, 55);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "ЗАМЕНИТЬ";
            this.ToolBtnAdd.SetToolTip(this.btnUpdate, "Перед нажатием необходимо\r\nпроверить все введенные данные");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxUpDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 502);
            this.panel1.TabIndex = 0;
            // 
            // txtBoxUpDate
            // 
            this.txtBoxUpDate.Location = new System.Drawing.Point(36, 132);
            this.txtBoxUpDate.Name = "txtBoxUpDate";
            this.txtBoxUpDate.Size = new System.Drawing.Size(222, 30);
            this.txtBoxUpDate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 72);
            this.label11.TabIndex = 5;
            this.label11.Text = "Укажите номер записи \r\nиз журнала для\r\nвнесения изменений";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(296, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 500);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(409, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Дата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(396, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "Начало";
            this.ToolBtnAdd.SetToolTip(this.label6, "Время начала работы");
            // 
            // cmbBxEndHUd
            // 
            this.cmbBxEndHUd.FormattingEnabled = true;
            this.cmbBxEndHUd.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbBxEndHUd.Location = new System.Drawing.Point(337, 212);
            this.cmbBxEndHUd.Name = "cmbBxEndHUd";
            this.cmbBxEndHUd.Size = new System.Drawing.Size(84, 32);
            this.cmbBxEndHUd.TabIndex = 51;
            this.cmbBxEndHUd.Text = "18";
            this.ToolBtnAdd.SetToolTip(this.cmbBxEndHUd, "Час окончания работы");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(427, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 54;
            this.label5.Text = ":";
            // 
            // cmbBxBegHUd
            // 
            this.cmbBxBegHUd.FormattingEnabled = true;
            this.cmbBxBegHUd.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbBxBegHUd.Location = new System.Drawing.Point(337, 132);
            this.cmbBxBegHUd.Name = "cmbBxBegHUd";
            this.cmbBxBegHUd.Size = new System.Drawing.Size(84, 32);
            this.cmbBxBegHUd.TabIndex = 53;
            this.cmbBxBegHUd.Text = "08";
            this.ToolBtnAdd.SetToolTip(this.cmbBxBegHUd, "Час начала работы");
            // 
            // cmbBxBegMUd
            // 
            this.cmbBxBegMUd.FormattingEnabled = true;
            this.cmbBxBegMUd.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbBxBegMUd.Location = new System.Drawing.Point(453, 132);
            this.cmbBxBegMUd.Name = "cmbBxBegMUd";
            this.cmbBxBegMUd.Size = new System.Drawing.Size(84, 32);
            this.cmbBxBegMUd.TabIndex = 52;
            this.cmbBxBegMUd.Text = "48";
            this.ToolBtnAdd.SetToolTip(this.cmbBxBegMUd, "Минуты начала работы");
            // 
            // cmbBxEndMUd
            // 
            this.cmbBxEndMUd.FormattingEnabled = true;
            this.cmbBxEndMUd.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbBxEndMUd.Location = new System.Drawing.Point(453, 212);
            this.cmbBxEndMUd.Name = "cmbBxEndMUd";
            this.cmbBxEndMUd.Size = new System.Drawing.Size(84, 32);
            this.cmbBxEndMUd.TabIndex = 50;
            this.cmbBxEndMUd.Text = "00";
            this.ToolBtnAdd.SetToolTip(this.cmbBxEndMUd, "Минуты окончания работы");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(407, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Конец";
            this.ToolBtnAdd.SetToolTip(this.label7, "Время окончания работы");
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.btnDelete);
            this.tabPageDelete.Controls.Add(this.txtBoxDelete);
            this.tabPageDelete.Controls.Add(this.lblDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 33);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(870, 557);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Удалить запись";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(870, 55);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "УДАЛИТЬ";
            this.ToolBtnAdd.SetToolTip(this.btnDelete, "Перед нажатием необходимо\r\nпроверить введенные данные\r\n");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            this.btnDelete.Enter += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtBoxDelete
            // 
            this.txtBoxDelete.Location = new System.Drawing.Point(306, 60);
            this.txtBoxDelete.Name = "txtBoxDelete";
            this.txtBoxDelete.Size = new System.Drawing.Size(222, 30);
            this.txtBoxDelete.TabIndex = 4;
            this.ToolBtnAdd.SetToolTip(this.txtBoxDelete, "Порядковый номер \r\nзаписи в журнале");
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(190, 11);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(495, 24);
            this.lblDelete.TabIndex = 3;
            this.lblDelete.Text = "Укажите номер записи из журнала для удаления";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.panel12);
            this.tabPageReport.Controls.Add(this.label16);
            this.tabPageReport.Controls.Add(this.panel3);
            this.tabPageReport.Controls.Add(this.panel2);
            this.tabPageReport.Controls.Add(this.btnCreateReport);
            this.tabPageReport.Location = new System.Drawing.Point(4, 33);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Size = new System.Drawing.Size(870, 557);
            this.tabPageReport.TabIndex = 3;
            this.tabPageReport.Text = "Сформировать отчет";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.RBUser);
            this.panel12.Controls.Add(this.RBDur);
            this.panel12.Controls.Add(this.RBEnd);
            this.panel12.Controls.Add(this.RBBegining);
            this.panel12.Controls.Add(this.RBNote);
            this.panel12.Controls.Add(this.RBDate);
            this.panel12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel12.Location = new System.Drawing.Point(294, 29);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(275, 241);
            this.panel12.TabIndex = 7;
            // 
            // RBUser
            // 
            this.RBUser.AutoSize = true;
            this.RBUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBUser.Location = new System.Drawing.Point(5, 206);
            this.RBUser.Name = "RBUser";
            this.RBUser.Size = new System.Drawing.Size(120, 23);
            this.RBUser.TabIndex = 10;
            this.RBUser.Text = "ОПЕРАТОР";
            this.RBUser.UseVisualStyleBackColor = true;
            this.RBUser.CheckedChanged += new System.EventHandler(this.RBUser_CheckedChanged);
            // 
            // RBDur
            // 
            this.RBDur.AutoSize = true;
            this.RBDur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBDur.Location = new System.Drawing.Point(5, 168);
            this.RBDur.Name = "RBDur";
            this.RBDur.Size = new System.Drawing.Size(227, 23);
            this.RBDur.TabIndex = 9;
            this.RBDur.Text = "ПРОДОЛЖИТЕЛЬНОСТЬ";
            this.RBDur.UseVisualStyleBackColor = true;
            this.RBDur.CheckedChanged += new System.EventHandler(this.RBDur_CheckedChanged);
            // 
            // RBEnd
            // 
            this.RBEnd.AutoSize = true;
            this.RBEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBEnd.Location = new System.Drawing.Point(5, 112);
            this.RBEnd.Name = "RBEnd";
            this.RBEnd.Size = new System.Drawing.Size(136, 42);
            this.RBEnd.TabIndex = 8;
            this.RBEnd.Text = "ВРЕМЯ \r\nОКОНЧАНИЯ\r\n";
            this.RBEnd.UseVisualStyleBackColor = true;
            this.RBEnd.CheckedChanged += new System.EventHandler(this.RBEnd_CheckedChanged);
            // 
            // RBBegining
            // 
            this.RBBegining.AutoSize = true;
            this.RBBegining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBBegining.Location = new System.Drawing.Point(4, 78);
            this.RBBegining.Name = "RBBegining";
            this.RBBegining.Size = new System.Drawing.Size(161, 23);
            this.RBBegining.TabIndex = 7;
            this.RBBegining.Text = "ВРЕМЯ НАЧАЛА";
            this.RBBegining.UseVisualStyleBackColor = true;
            this.RBBegining.CheckedChanged += new System.EventHandler(this.RBBegining_CheckedChanged);
            // 
            // RBNote
            // 
            this.RBNote.AutoSize = true;
            this.RBNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBNote.Location = new System.Drawing.Point(5, 5);
            this.RBNote.Name = "RBNote";
            this.RBNote.Size = new System.Drawing.Size(123, 23);
            this.RBNote.TabIndex = 0;
            this.RBNote.Text = "№ ЗАПИСИ";
            this.RBNote.UseVisualStyleBackColor = true;
            this.RBNote.CheckedChanged += new System.EventHandler(this.RBNote_CheckedChanged);
            // 
            // RBDate
            // 
            this.RBDate.AutoSize = true;
            this.RBDate.Checked = true;
            this.RBDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBDate.Location = new System.Drawing.Point(5, 41);
            this.RBDate.Name = "RBDate";
            this.RBDate.Size = new System.Drawing.Size(73, 23);
            this.RBDate.TabIndex = 6;
            this.RBDate.TabStop = true;
            this.RBDate.Text = "ДАТА";
            this.RBDate.UseVisualStyleBackColor = true;
            this.RBDate.CheckedChanged += new System.EventHandler(this.RBDate_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(351, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "Сортировка по:";
            this.ToolBtnAdd.SetToolTip(this.label16, "Выбор вида сортировки \r\nпри необходимости");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(567, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 502);
            this.panel3.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(38, 17);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dtPickReport1);
            this.panel2.Controls.Add(this.dtPickReport2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 502);
            this.panel2.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 24);
            this.label15.TabIndex = 3;
            this.label15.Text = "Дата окончания:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Дата начала:";
            // 
            // dtPickReport1
            // 
            this.dtPickReport1.Location = new System.Drawing.Point(45, 52);
            this.dtPickReport1.Name = "dtPickReport1";
            this.dtPickReport1.Size = new System.Drawing.Size(200, 30);
            this.dtPickReport1.TabIndex = 0;
            // 
            // dtPickReport2
            // 
            this.dtPickReport2.Location = new System.Drawing.Point(45, 176);
            this.dtPickReport2.Name = "dtPickReport2";
            this.dtPickReport2.Size = new System.Drawing.Size(200, 30);
            this.dtPickReport2.TabIndex = 1;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateReport.Location = new System.Drawing.Point(0, 502);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(870, 55);
            this.btnCreateReport.TabIndex = 3;
            this.btnCreateReport.Text = "СФОРМИРОВАТЬ ОТЧЕТ";
            this.ToolBtnAdd.SetToolTip(this.btnCreateReport, "Для просмотра отчета необходимо\r\nпереключить вкладку вверхней части \r\nокна \"Просм" +
        "отр Отчета\" ");
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            this.btnCreateReport.MouseEnter += new System.EventHandler(this.btnCreateReport_MouseEnter);
            // 
            // ToolBtnAdd
            // 
            this.ToolBtnAdd.ShowAlways = true;
            this.ToolBtnAdd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolBtnAdd.ToolTipTitle = "ВНИМАНИЕ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 1044);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет работы оборудования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tabPageADD.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            this.tabPageReport.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TabPage tabPageADD;
        private System.Windows.Forms.DateTimePicker datePickAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDATEADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBeginTime;
        private System.Windows.Forms.Label labelEND;
        private System.Windows.Forms.ComboBox cmbBoxEndM;
        private System.Windows.Forms.ComboBox cmbBoxBegH;
        private System.Windows.Forms.ComboBox cmbBoxEndH;
        private System.Windows.Forms.ComboBox cmbBoxBegM;
        private System.Windows.Forms.Button btnUpdateDuration;
        private System.Windows.Forms.Label lblDurHour;
        private System.Windows.Forms.ComboBox cmbBoxUser;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtPickUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBxEndMUd;
        private System.Windows.Forms.ComboBox cmbBxBegHUd;
        private System.Windows.Forms.ComboBox cmbBxEndHUd;
        private System.Windows.Forms.ComboBox cmbBxBegMUd;
        private System.Windows.Forms.Button btnDurUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUpDateDur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtPickReport1;
        private System.Windows.Forms.DateTimePicker dtPickReport2;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBoxDelete;
        private System.Windows.Forms.TextBox txtBoxUpDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.ToolTip ToolBtnAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.RadioButton RBNote;
        private System.Windows.Forms.RadioButton RBDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton RBDur;
        private System.Windows.Forms.RadioButton RBEnd;
        private System.Windows.Forms.RadioButton RBBegining;
        private System.Windows.Forms.RadioButton RBUser;
    }
}

