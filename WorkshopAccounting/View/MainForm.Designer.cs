
namespace WorkshopAccounting.View
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
            this.components = new System.ComponentModel.Container();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tab_Tasks = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Tasks = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_TaskName = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.textBox_TaskId = new System.Windows.Forms.TextBox();
            this.button_TaskSave = new System.Windows.Forms.Button();
            this.button_TaskDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.textBox_Hours = new System.Windows.Forms.TextBox();
            this.textBox_Workshop = new System.Windows.Forms.TextBox();
            this.comboBox_State = new System.Windows.Forms.ComboBox();
            this.comboBox_Employee = new System.Windows.Forms.ComboBox();
            this.checkBox_DateEnd = new System.Windows.Forms.CheckBox();
            this.tab_Employees = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Empl = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Employee = new System.Windows.Forms.TextBox();
            this.textBox_Position = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Employ = new System.Windows.Forms.DateTimePicker();
            this.textBox_EmplId = new System.Windows.Forms.TextBox();
            this.button_EmplSave = new System.Windows.Forms.Button();
            this.button_EmplDelete = new System.Windows.Forms.Button();
            this.dataGridView_EmplTasks = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tasks = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Employees = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_SaveTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AddEmployee = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl_Main.SuspendLayout();
            this.tab_Tasks.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tasks)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tab_Employees.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Empl)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmplTasks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Main.Controls.Add(this.tab_Tasks);
            this.tabControl_Main.Controls.Add(this.tab_Employees);
            this.tabControl_Main.Location = new System.Drawing.Point(0, 56);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1395, 603);
            this.tabControl_Main.TabIndex = 1;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.tabControl_Main_SelectedIndexChanged);
            // 
            // tab_Tasks
            // 
            this.tab_Tasks.Controls.Add(this.tableLayoutPanel1);
            this.tab_Tasks.Location = new System.Drawing.Point(4, 29);
            this.tab_Tasks.Name = "tab_Tasks";
            this.tab_Tasks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tasks.Size = new System.Drawing.Size(1387, 570);
            this.tab_Tasks.TabIndex = 0;
            this.tab_Tasks.Text = "Задачи";
            this.tab_Tasks.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Tasks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1381, 564);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView_Tasks
            // 
            this.dataGridView_Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Tasks.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Tasks.Name = "dataGridView_Tasks";
            this.dataGridView_Tasks.ReadOnly = true;
            this.dataGridView_Tasks.RowHeadersWidth = 51;
            this.dataGridView_Tasks.RowTemplate.Height = 29;
            this.dataGridView_Tasks.Size = new System.Drawing.Size(960, 558);
            this.dataGridView_Tasks.TabIndex = 0;
            this.dataGridView_Tasks.SelectionChanged += new System.EventHandler(this.dataGridView_Tasks_SelectionChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(969, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 558F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 558F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 558F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(409, 558);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.textBox_TaskName, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.textBox_Description, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.dateTimePicker_Start, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.textBox_TaskId, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.button_TaskSave, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_TaskDelete, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.label13, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.label14, 0, 9);
            this.tableLayoutPanel6.Controls.Add(this.dateTimePicker_End, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.textBox_Hours, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.textBox_Workshop, 1, 9);
            this.tableLayoutPanel6.Controls.Add(this.comboBox_State, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.comboBox_Employee, 1, 8);
            this.tableLayoutPanel6.Controls.Add(this.checkBox_DateEnd, 2, 5);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 10;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(403, 552);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 55);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 55);
            this.label7.TabIndex = 1;
            this.label7.Text = "Название";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 55);
            this.label8.TabIndex = 2;
            this.label8.Text = "Описание задачи";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 55);
            this.label9.TabIndex = 3;
            this.label9.Text = "Дата и время начала выполнения задачи";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_TaskName
            // 
            this.textBox_TaskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TaskName.Location = new System.Drawing.Point(184, 113);
            this.textBox_TaskName.Multiline = true;
            this.textBox_TaskName.Name = "textBox_TaskName";
            this.textBox_TaskName.Size = new System.Drawing.Size(175, 49);
            this.textBox_TaskName.TabIndex = 5;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Description.Location = new System.Drawing.Point(184, 168);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(175, 49);
            this.textBox_Description.TabIndex = 6;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(184, 223);
            this.dateTimePicker_Start.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Start.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(175, 27);
            this.dateTimePicker_Start.TabIndex = 7;
            this.dateTimePicker_Start.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // textBox_TaskId
            // 
            this.textBox_TaskId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TaskId.Enabled = false;
            this.textBox_TaskId.Location = new System.Drawing.Point(184, 58);
            this.textBox_TaskId.Name = "textBox_TaskId";
            this.textBox_TaskId.Size = new System.Drawing.Size(175, 27);
            this.textBox_TaskId.TabIndex = 8;
            // 
            // button_TaskSave
            // 
            this.button_TaskSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_TaskSave.Location = new System.Drawing.Point(3, 3);
            this.button_TaskSave.Name = "button_TaskSave";
            this.button_TaskSave.Size = new System.Drawing.Size(175, 49);
            this.button_TaskSave.TabIndex = 9;
            this.button_TaskSave.Text = "Сохранить";
            this.button_TaskSave.UseVisualStyleBackColor = true;
            this.button_TaskSave.Click += new System.EventHandler(this.button_TaskSave_Click);
            // 
            // button_TaskDelete
            // 
            this.button_TaskDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_TaskDelete.Location = new System.Drawing.Point(184, 3);
            this.button_TaskDelete.Name = "button_TaskDelete";
            this.button_TaskDelete.Size = new System.Drawing.Size(175, 49);
            this.button_TaskDelete.TabIndex = 10;
            this.button_TaskDelete.Text = "Удалить";
            this.button_TaskDelete.UseVisualStyleBackColor = true;
            this.button_TaskDelete.Click += new System.EventHandler(this.button_TaskDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 55);
            this.label10.TabIndex = 11;
            this.label10.Text = "Дата и время окончания выполнения задачи";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 55);
            this.label11.TabIndex = 12;
            this.label11.Text = "Затраченное количество часов";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 55);
            this.label12.TabIndex = 13;
            this.label12.Text = "Состояние задачи";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 55);
            this.label13.TabIndex = 14;
            this.label13.Text = "Сотрудник-исполнитель";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 57);
            this.label14.TabIndex = 15;
            this.label14.Text = "Номер цеха";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_End.Location = new System.Drawing.Point(184, 278);
            this.dateTimePicker_End.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_End.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(175, 27);
            this.dateTimePicker_End.TabIndex = 16;
            // 
            // textBox_Hours
            // 
            this.textBox_Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Hours.Location = new System.Drawing.Point(184, 333);
            this.textBox_Hours.Name = "textBox_Hours";
            this.textBox_Hours.Size = new System.Drawing.Size(175, 27);
            this.textBox_Hours.TabIndex = 17;
            // 
            // textBox_Workshop
            // 
            this.textBox_Workshop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Workshop.Location = new System.Drawing.Point(184, 498);
            this.textBox_Workshop.Name = "textBox_Workshop";
            this.textBox_Workshop.Size = new System.Drawing.Size(175, 27);
            this.textBox_Workshop.TabIndex = 20;
            // 
            // comboBox_State
            // 
            this.comboBox_State.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_State.FormattingEnabled = true;
            this.comboBox_State.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
            this.comboBox_State.Location = new System.Drawing.Point(184, 388);
            this.comboBox_State.Name = "comboBox_State";
            this.comboBox_State.Size = new System.Drawing.Size(175, 28);
            this.comboBox_State.TabIndex = 21;
            // 
            // comboBox_Employee
            // 
            this.comboBox_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Employee.FormattingEnabled = true;
            this.comboBox_Employee.Location = new System.Drawing.Point(184, 443);
            this.comboBox_Employee.Name = "comboBox_Employee";
            this.comboBox_Employee.Size = new System.Drawing.Size(175, 28);
            this.comboBox_Employee.TabIndex = 22;
            // 
            // checkBox_DateEnd
            // 
            this.checkBox_DateEnd.AutoSize = true;
            this.checkBox_DateEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_DateEnd.Location = new System.Drawing.Point(365, 278);
            this.checkBox_DateEnd.Name = "checkBox_DateEnd";
            this.checkBox_DateEnd.Size = new System.Drawing.Size(35, 49);
            this.checkBox_DateEnd.TabIndex = 23;
            this.checkBox_DateEnd.Tag = "123";
            this.toolTip1.SetToolTip(this.checkBox_DateEnd, "У задачи есть дата окончания");
            this.checkBox_DateEnd.UseVisualStyleBackColor = true;
            // 
            // tab_Employees
            // 
            this.tab_Employees.Controls.Add(this.tableLayoutPanel2);
            this.tab_Employees.Location = new System.Drawing.Point(4, 29);
            this.tab_Employees.Name = "tab_Employees";
            this.tab_Employees.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Employees.Size = new System.Drawing.Size(1387, 570);
            this.tab_Employees.TabIndex = 1;
            this.tab_Employees.Text = "Сотрудники";
            this.tab_Employees.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_Empl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1381, 564);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dataGridView_Empl
            // 
            this.dataGridView_Empl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Empl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Empl.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Empl.Name = "dataGridView_Empl";
            this.dataGridView_Empl.ReadOnly = true;
            this.dataGridView_Empl.RowHeadersWidth = 51;
            this.dataGridView_Empl.RowTemplate.Height = 29;
            this.dataGridView_Empl.Size = new System.Drawing.Size(960, 558);
            this.dataGridView_Empl.TabIndex = 0;
            this.dataGridView_Empl.SelectionChanged += new System.EventHandler(this.dataGridView_Empl_SelectionChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView_EmplTasks, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(969, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(409, 558);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.textBox_Employee, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox_Position, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker_Employ, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.textBox_EmplId, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.button_EmplSave, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_EmplDelete, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(403, 194);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Табельный номер";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата трудоустройства";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Employee
            // 
            this.textBox_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Employee.Location = new System.Drawing.Point(204, 79);
            this.textBox_Employee.Name = "textBox_Employee";
            this.textBox_Employee.Size = new System.Drawing.Size(196, 27);
            this.textBox_Employee.TabIndex = 5;
            // 
            // textBox_Position
            // 
            this.textBox_Position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Position.Location = new System.Drawing.Point(204, 117);
            this.textBox_Position.Name = "textBox_Position";
            this.textBox_Position.Size = new System.Drawing.Size(196, 27);
            this.textBox_Position.TabIndex = 6;
            // 
            // dateTimePicker_Employ
            // 
            this.dateTimePicker_Employ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_Employ.Location = new System.Drawing.Point(204, 155);
            this.dateTimePicker_Employ.Name = "dateTimePicker_Employ";
            this.dateTimePicker_Employ.Size = new System.Drawing.Size(196, 27);
            this.dateTimePicker_Employ.TabIndex = 7;
            this.dateTimePicker_Employ.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // textBox_EmplId
            // 
            this.textBox_EmplId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_EmplId.Enabled = false;
            this.textBox_EmplId.Location = new System.Drawing.Point(204, 41);
            this.textBox_EmplId.Name = "textBox_EmplId";
            this.textBox_EmplId.Size = new System.Drawing.Size(196, 27);
            this.textBox_EmplId.TabIndex = 8;
            // 
            // button_EmplSave
            // 
            this.button_EmplSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EmplSave.Location = new System.Drawing.Point(3, 3);
            this.button_EmplSave.Name = "button_EmplSave";
            this.button_EmplSave.Size = new System.Drawing.Size(195, 32);
            this.button_EmplSave.TabIndex = 9;
            this.button_EmplSave.Text = "Сохранить";
            this.button_EmplSave.UseVisualStyleBackColor = true;
            this.button_EmplSave.Click += new System.EventHandler(this.button_EmplSave_Click);
            // 
            // button_EmplDelete
            // 
            this.button_EmplDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EmplDelete.Location = new System.Drawing.Point(204, 3);
            this.button_EmplDelete.Name = "button_EmplDelete";
            this.button_EmplDelete.Size = new System.Drawing.Size(196, 32);
            this.button_EmplDelete.TabIndex = 10;
            this.button_EmplDelete.Text = "Удалить";
            this.button_EmplDelete.UseVisualStyleBackColor = true;
            this.button_EmplDelete.Click += new System.EventHandler(this.button_EmplDelete_Click);
            // 
            // dataGridView_EmplTasks
            // 
            this.dataGridView_EmplTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmplTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_EmplTasks.Location = new System.Drawing.Point(3, 233);
            this.dataGridView_EmplTasks.Name = "dataGridView_EmplTasks";
            this.dataGridView_EmplTasks.ReadOnly = true;
            this.dataGridView_EmplTasks.RowHeadersWidth = 51;
            this.dataGridView_EmplTasks.RowTemplate.Height = 29;
            this.dataGridView_EmplTasks.Size = new System.Drawing.Size(403, 322);
            this.dataGridView_EmplTasks.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Задачи сотрудника";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Windows,
            this.Menu_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1395, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(59, 24);
            this.Menu_File.Text = "Файл";
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Name = "Menu_Exit";
            this.Menu_Exit.Size = new System.Drawing.Size(136, 26);
            this.Menu_Exit.Text = "Выход";
            this.Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // Menu_Windows
            // 
            this.Menu_Windows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Tasks,
            this.Menu_Employees});
            this.Menu_Windows.Name = "Menu_Windows";
            this.Menu_Windows.Size = new System.Drawing.Size(58, 24);
            this.Menu_Windows.Text = "Окна";
            // 
            // Menu_Tasks
            // 
            this.Menu_Tasks.Name = "Menu_Tasks";
            this.Menu_Tasks.Size = new System.Drawing.Size(174, 26);
            this.Menu_Tasks.Text = "Задачи";
            this.Menu_Tasks.Click += new System.EventHandler(this.Menu_Tasks_Click);
            // 
            // Menu_Employees
            // 
            this.Menu_Employees.Name = "Menu_Employees";
            this.Menu_Employees.Size = new System.Drawing.Size(174, 26);
            this.Menu_Employees.Text = "Сотрудники";
            this.Menu_Employees.Click += new System.EventHandler(this.Menu_Employees_Click);
            // 
            // Menu_Help
            // 
            this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_About});
            this.Menu_Help.Name = "Menu_Help";
            this.Menu_Help.Size = new System.Drawing.Size(81, 24);
            this.Menu_Help.Text = "Справка";
            // 
            // Menu_About
            // 
            this.Menu_About.Name = "Menu_About";
            this.Menu_About.Size = new System.Drawing.Size(187, 26);
            this.Menu_About.Text = "О программе";
            this.Menu_About.Click += new System.EventHandler(this.Menu_About_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1395, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 20);
            this.toolStripStatusLabel1.Text = "Строка состояния";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_SaveTask,
            this.toolStripButton_AddEmployee});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1395, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_SaveTask
            // 
            this.toolStripButton_SaveTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_SaveTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SaveTask.Name = "toolStripButton_SaveTask";
            this.toolStripButton_SaveTask.Size = new System.Drawing.Size(130, 24);
            this.toolStripButton_SaveTask.Text = "Добавить задачу";
            this.toolStripButton_SaveTask.Click += new System.EventHandler(this.toolStripButton_AddTask_Click);
            // 
            // toolStripButton_AddEmployee
            // 
            this.toolStripButton_AddEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_AddEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddEmployee.Name = "toolStripButton_AddEmployee";
            this.toolStripButton_AddEmployee.Size = new System.Drawing.Size(163, 24);
            this.toolStripButton_AddEmployee.Text = "Добавить сотрудника";
            this.toolStripButton_AddEmployee.Click += new System.EventHandler(this.toolStripButton_AddEmployee_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 690);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tab_Tasks.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tasks)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tab_Employees.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Empl)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmplTasks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tab_Tasks;
        private System.Windows.Forms.TabPage tab_Employees;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_Windows;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Employees;
        private System.Windows.Forms.ToolStripMenuItem Menu_About;
        private System.Windows.Forms.DataGridView dataGridView_Empl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Employee;
        private System.Windows.Forms.TextBox textBox_Position;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Employ;
        private System.Windows.Forms.DataGridView dataGridView_EmplTasks;
        private System.Windows.Forms.TextBox textBox_EmplId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton toolStripButton_SaveTask;
        private System.Windows.Forms.ToolStripButton toolStripButton_AddEmployee;
        private System.Windows.Forms.Button button_EmplSave;
        private System.Windows.Forms.Button button_EmplDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_Tasks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_TaskName;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.TextBox textBox_TaskId;
        private System.Windows.Forms.Button button_TaskSave;
        private System.Windows.Forms.Button button_TaskDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.TextBox textBox_Hours;
        private System.Windows.Forms.TextBox textBox_Workshop;
        private System.Windows.Forms.ComboBox comboBox_State;
        private System.Windows.Forms.ComboBox comboBox_Employee;
        private System.Windows.Forms.CheckBox checkBox_DateEnd;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tasks;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}