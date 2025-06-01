namespace TaskFlowApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem усіЗавданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сьогодніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершеноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тегиToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridTasks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            усіЗавданняToolStripMenuItem = new ToolStripMenuItem();
            сьогодніToolStripMenuItem = new ToolStripMenuItem();
            тегиToolStripMenuItem = new ToolStripMenuItem();
            завершеноToolStripMenuItem = new ToolStripMenuItem();
            налаштуванняToolStripMenuItem = new ToolStripMenuItem();
            panelTop = new Panel();
            btnNewTask = new Button();
            txtSearch = new TextBox();
            lblTitle = new Label();
            panelFilter = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            cmbSort = new ComboBox();
            cmbStatus = new ComboBox();
            dataGridTasks = new DataGridView();

            menuStrip1.SuspendLayout();
            panelTop.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTasks).BeginInit();
            SuspendLayout();

            // menuStrip1 - Dark Theme
            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                усіЗавданняToolStripMenuItem,
                сьогодніToolStripMenuItem,
                тегиToolStripMenuItem,
                завершеноToolStripMenuItem,
                налаштуванняToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1167, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            // усіЗавданняToolStripMenuItem
            усіЗавданняToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            усіЗавданняToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            усіЗавданняToolStripMenuItem.Name = "усіЗавданняToolStripMenuItem";
            усіЗавданняToolStripMenuItem.Size = new Size(100, 26);
            усіЗавданняToolStripMenuItem.Text = "Усі завдання";
            усіЗавданняToolStripMenuItem.Click += усіЗавданняToolStripMenuItem_Click;

            // сьогодніToolStripMenuItem
            сьогодніToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            сьогодніToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            сьогодніToolStripMenuItem.Name = "сьогодніToolStripMenuItem";
            сьогодніToolStripMenuItem.Size = new Size(77, 26);
            сьогодніToolStripMenuItem.Text = "Сьогодні";
            сьогодніToolStripMenuItem.Click += сьогодніToolStripMenuItem_Click;

            // тегиToolStripMenuItem
            тегиToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            тегиToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            тегиToolStripMenuItem.Name = "тегиToolStripMenuItem";
            тегиToolStripMenuItem.Size = new Size(48, 26);
            тегиToolStripMenuItem.Text = "Теги";
            тегиToolStripMenuItem.Click += тегиToolStripMenuItem_Click;

            // завершеноToolStripMenuItem
            завершеноToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            завершеноToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            завершеноToolStripMenuItem.Name = "завершеноToolStripMenuItem";
            завершеноToolStripMenuItem.Size = new Size(92, 26);
            завершеноToolStripMenuItem.Text = "Завершено";
            завершеноToolStripMenuItem.Click += завершеноToolStripMenuItem_Click;

            // налаштуванняToolStripMenuItem
            налаштуванняToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            налаштуванняToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            налаштуванняToolStripMenuItem.Size = new Size(113, 26);
            налаштуванняToolStripMenuItem.Text = "Налаштування";
            налаштуванняToolStripMenuItem.Click += налаштуванняToolStripMenuItem_Click;

            // panelTop - Dark Background
            panelTop.BackColor = Color.FromArgb(40, 40, 40);
            panelTop.Controls.Add(btnNewTask);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 30);
            panelTop.Margin = new Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(25, 25, 25, 25);
            panelTop.Size = new Size(1167, 100);
            panelTop.TabIndex = 1;

            // btnNewTask - Modern Styled Button
            btnNewTask.BackColor = Color.FromArgb(70, 130, 180);
            btnNewTask.FlatAppearance.BorderColor = Color.FromArgb(100, 149, 237);
            btnNewTask.FlatAppearance.BorderSize = 2;
            btnNewTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 120, 170);
            btnNewTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 140, 190);
            btnNewTask.FlatStyle = FlatStyle.Flat;
            btnNewTask.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNewTask.ForeColor = Color.White;
            btnNewTask.Location = new Point(900, 28);
            btnNewTask.Margin = new Padding(4, 3, 4, 3);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(150, 44);
            btnNewTask.TabIndex = 2;
            btnNewTask.Text = "Нова задача";
            btnNewTask.UseVisualStyleBackColor = false;
            btnNewTask.Click += btnNewTask_Click;

            // txtSearch - Dark Styled TextBox
            txtSearch.BackColor = Color.FromArgb(60, 60, 60);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.FromArgb(220, 220, 220);
            txtSearch.Location = new Point(450, 32);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(380, 29);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Пошук";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;

            // lblTitle - Modern Title
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(220, 220, 220);
            lblTitle.Location = new Point(25, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Усі завдання";

            // panelFilter - Dark Filter Panel
            panelFilter.BackColor = Color.FromArgb(45, 45, 45);
            panelFilter.Controls.Add(btnDelete);
            panelFilter.Controls.Add(btnCancel);
            panelFilter.Controls.Add(btnSave);
            panelFilter.Controls.Add(cmbSort);
            panelFilter.Controls.Add(cmbStatus);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 130);
            panelFilter.Margin = new Padding(4, 3, 4, 3);
            panelFilter.Name = "panelFilter";
            panelFilter.Padding = new Padding(25, 20, 25, 20);
            panelFilter.Size = new Size(1167, 75);
            panelFilter.TabIndex = 2;

            // btnDelete - Red Styled Button
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 100);
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 43, 59);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 63, 79);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(700, 18);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // btnCancel - Green Styled Button
            btnCancel.BackColor = Color.FromArgb(40, 167, 69);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(70, 197, 99);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 157, 59);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 177, 79);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(980, 18);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Вивантаження";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            // btnSave - Blue Styled Button
            btnSave.BackColor = Color.FromArgb(70, 130, 180);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(100, 149, 237);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 120, 170);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 140, 190);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(840, 18);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // cmbSort - Dark ComboBox
            cmbSort.BackColor = Color.FromArgb(60, 60, 60);
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FlatStyle = FlatStyle.Flat;
            cmbSort.Font = new Font("Segoe UI", 10F);
            cmbSort.ForeColor = Color.FromArgb(220, 220, 220);
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] {
                "Сортувати за датою",
                "Сортувати за назвою",
                "Сортувати за статусом"
            });
            cmbSort.Location = new Point(250, 20);
            cmbSort.Margin = new Padding(4, 3, 4, 3);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(220, 25);
            cmbSort.TabIndex = 1;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;

            // cmbStatus - Dark ComboBox
            cmbStatus.BackColor = Color.FromArgb(60, 60, 60);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.ForeColor = Color.FromArgb(220, 220, 220);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Всі", "До", "В Процесі", "Зроблено" });
            cmbStatus.Location = new Point(25, 20);
            cmbStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(190, 25);
            cmbStatus.TabIndex = 0;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;

            // dataGridTasks - Dark DataGrid
            dataGridTasks.AllowUserToAddRows = false;
            dataGridTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTasks.BackgroundColor = Color.FromArgb(35, 35, 35);
            dataGridTasks.BorderStyle = BorderStyle.None;
            dataGridTasks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridTasks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dataGridTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridTasks.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTasks.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridTasks.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dataGridTasks.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridTasks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 130, 180);
            dataGridTasks.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridTasks.Dock = DockStyle.Fill;
            dataGridTasks.EnableHeadersVisualStyles = false;
            dataGridTasks.GridColor = Color.FromArgb(60, 60, 60);
            dataGridTasks.Location = new Point(0, 205);
            dataGridTasks.Margin = new Padding(4, 3, 4, 3);
            dataGridTasks.MultiSelect = false;
            dataGridTasks.Name = "dataGridTasks";
            dataGridTasks.RowHeadersVisible = false;
            dataGridTasks.RowTemplate.Height = 35;
            dataGridTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTasks.Size = new Size(1167, 545);
            dataGridTasks.TabIndex = 3;

            // MainForm - Dark Theme
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(1167, 750);
            Controls.Add(dataGridTasks);
            Controls.Add(panelFilter);
            Controls.Add(panelTop);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskFlow - Темна тема";
            Load += MainForm_Load;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}