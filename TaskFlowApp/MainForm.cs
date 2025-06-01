using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TaskFlowApp
{
    public partial class MainForm : Form
    {
        private List<Task> tasks;
        private List<Task> filteredTasks;

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGrid();
            LoadTasks();
        }

        private void InitializeDataGrid()
        {
            // ������������ DataGridView
            dataGridTasks.AutoGenerateColumns = false;
            dataGridTasks.AllowUserToAddRows = false;
            dataGridTasks.AllowUserToDeleteRows = false;
            dataGridTasks.ReadOnly = true;
            dataGridTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTasks.MultiSelect = false;

            // ��������� �������
            dataGridTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "�����",
                DataPropertyName = "Name",
                Width = 200
            });

            dataGridTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "����",
                DataPropertyName = "Description",
                Width = 300
            });

            dataGridTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "������",
                DataPropertyName = "Status",
                Width = 100
            });

            dataGridTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DueDate",
                HeaderText = "�����",
                DataPropertyName = "DueDate",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
            });

            dataGridTasks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tag",
                HeaderText = "���",
                DataPropertyName = "Tag",
                Width = 100
            });

            // ��䳿 ��� ��������� ���� (�����������)
            dataGridTasks.CellDoubleClick += DataGridTasks_CellDoubleClick;
        }

        private void LoadTasks()
        {
            try
            {
                tasks = XmlManager.LoadTasks();
                filteredTasks = new List<Task>(tasks);
                UpdateDataGrid();
                cmbStatus.SelectedIndex = 0; // "��"
                cmbSort.SelectedIndex = 0; // "��������� �� �����"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ������������ �������: {ex.Message}",
                    "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGrid()
        {
            dataGridTasks.DataSource = null;
            dataGridTasks.DataSource = filteredTasks;
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            int totalTasks = filteredTasks.Count;
            int completedTasks = filteredTasks.Count(t => t.Status == "��������");
            lblTitle.Text = $"�������� ({completedTasks}/{totalTasks})";
        }

        private void FilterTasks()
        {
            filteredTasks = new List<Task>(tasks);

            // Գ���� �� ��������
            if (cmbStatus.SelectedIndex > 0)
            {
                string selectedStatus = cmbStatus.SelectedItem.ToString();
                filteredTasks = filteredTasks.Where(t => t.Status == selectedStatus).ToList();
            }

            // Գ���� �� �������
            if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text != "�����")
            {
                string searchText = txtSearch.Text.ToLower();
                filteredTasks = filteredTasks.Where(t =>
                    t.Name.ToLower().Contains(searchText) ||
                    t.Description.ToLower().Contains(searchText) ||
                    t.Tag.ToLower().Contains(searchText)).ToList();
            }

            // ����������
            if (cmbSort.SelectedIndex >= 0)
            {
                switch (cmbSort.SelectedIndex)
                {
                    case 0: // �� �����
                        filteredTasks = filteredTasks.OrderBy(t => t.DueDate).ToList();
                        break;
                    case 1: // �� ������
                        filteredTasks = filteredTasks.OrderBy(t => t.Name).ToList();
                        break;
                    case 2: // �� ��������
                        filteredTasks = filteredTasks.OrderBy(t => t.Status).ToList();
                        break;
                }
            }

            UpdateDataGrid();
        }

        private void SaveTasks()
        {
            try
            {
                XmlManager.SaveTasks(tasks);
                MessageBox.Show("�������� ��������� ������!", "����������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ����������: {ex.Message}",
                    "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ��䳿 ������
        private void btnNewTask_Click(object sender, EventArgs e)
        {
            using (TaskForm taskForm = new TaskForm())
            {
                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    tasks.Add(taskForm.Task);
                    FilterTasks();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTasks();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // ��������������� ������������
            MessageBox.Show("������� ������������ ���� ���������� �����",
                "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ���� ����ֲ�����Ͳ��� ���������
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("���� �����, ������ �������� ��� ���������.",
                    "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTask = (Task)dataGridTasks.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"�� �������, �� ������ �������� �������� \"{selectedTask.Name}\"?",
                "ϳ����������� ���������",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // ��������� � ��������� ������
                    tasks.Remove(selectedTask);

                    // ��������� �����������
                    FilterTasks();

                    MessageBox.Show("�������� �������� ������!",
                        "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������� ��� �������� ��������: {ex.Message}",
                        "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ��䳿 �������
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTasks();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTasks();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterTasks();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "�����")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "�����";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        // �������� ��� ��� �����������
        private void DataGridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < filteredTasks.Count)
            {
                Task selectedTask = filteredTasks[e.RowIndex];
                using (TaskForm taskForm = new TaskForm(selectedTask))
                {
                    if (taskForm.ShowDialog() == DialogResult.OK)
                    {
                        // ��������� ���������� �������� � ��������� ������ � ��������� ����
                        int originalIndex = tasks.FindIndex(t => t == selectedTask);
                        if (originalIndex >= 0)
                        {
                            tasks[originalIndex] = taskForm.Task;
                            FilterTasks();
                        }
                    }
                }
            }
        }

        // ��䳿 ����
        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            lblTitle.Text = "�� ��������";
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Գ���� ������� �� �������
            DateTime today = DateTime.Today;
            filteredTasks = tasks.Where(t => t.DueDate.Date == today).ToList();
            UpdateDataGrid();
            lblTitle.Text = "�������";
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filteredTasks = tasks.Where(t => t.Status == "��������").ToList();
            UpdateDataGrid();
            lblTitle.Text = "���������";
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� ��������� ������ ���� ���������� �����",
                "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� ����������� ���� ���������� �����",
                "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ����� �����������
        }
    }
}