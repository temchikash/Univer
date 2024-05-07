namespace VUZ
{
    partial class VUZER
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Strip = new MenuStrip();
            Add = new ToolStripMenuItem();
            Delete = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            CityBox = new ComboBox();
            UniversTable = new DataGridView();
            IdGrid = new DataGridViewTextBoxColumn();
            NameGrid = new DataGridViewTextBoxColumn();
            CityGrid = new DataGridViewTextBoxColumn();
            vUZBindingSource1 = new BindingSource(components);
            vUZBindingSource = new BindingSource(components);
            Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UniversTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vUZBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vUZBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Strip
            // 
            Strip.BackColor = Color.Silver;
            Strip.ImageScalingSize = new Size(20, 20);
            Strip.Items.AddRange(new ToolStripItem[] { Add, Delete, Exit });
            Strip.Location = new Point(0, 0);
            Strip.Name = "Strip";
            Strip.Size = new Size(682, 32);
            Strip.TabIndex = 1;
            Strip.Text = "menuStrip1";
            // 
            // Add
            // 
            Add.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Add.Name = "Add";
            Add.Size = new Size(102, 28);
            Add.Text = "Добавить";
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Delete.Name = "Delete";
            Delete.Size = new Size(92, 28);
            Delete.Text = "Удалить";
            Delete.Click += Delete_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Exit.Name = "Exit";
            Exit.Size = new Size(80, 28);
            Exit.Text = "Выйти";
            Exit.Click += Exit_Click;
            // 
            // CityBox
            // 
            CityBox.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CityBox.FormattingEnabled = true;
            CityBox.Location = new Point(12, 35);
            CityBox.Name = "CityBox";
            CityBox.Size = new Size(151, 32);
            CityBox.TabIndex = 2;
            CityBox.SelectedIndexChanged += CityBox_SelectedIndexChanged_1;
            // 
            // UniversTable
            // 
            UniversTable.AutoGenerateColumns = false;
            UniversTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UniversTable.Columns.AddRange(new DataGridViewColumn[] { IdGrid, NameGrid, CityGrid });
            UniversTable.DataSource = vUZBindingSource1;
            UniversTable.Location = new Point(0, 73);
            UniversTable.Name = "UniversTable";
            UniversTable.RowHeadersWidth = 51;
            UniversTable.Size = new Size(683, 484);
            UniversTable.TabIndex = 3;
            UniversTable.CellContentClick += UniversTable_CellContentClick;
            UniversTable.CellDoubleClick += UniversTable_CellContentClick;
            // 
            // IdGrid
            // 
            IdGrid.DataPropertyName = "Id";
            IdGrid.HeaderText = "Id";
            IdGrid.MinimumWidth = 6;
            IdGrid.Name = "IdGrid";
            IdGrid.Width = 125;
            // 
            // NameGrid
            // 
            NameGrid.DataPropertyName = "Name";
            NameGrid.HeaderText = "Название";
            NameGrid.MinimumWidth = 6;
            NameGrid.Name = "NameGrid";
            NameGrid.Width = 125;
            // 
            // CityGrid
            // 
            CityGrid.DataPropertyName = "City";
            CityGrid.HeaderText = "Город";
            CityGrid.MinimumWidth = 6;
            CityGrid.Name = "CityGrid";
            CityGrid.Width = 125;
            // 
            // vUZBindingSource1
            // 
            vUZBindingSource1.DataSource = typeof(VUZ);
            // 
            // vUZBindingSource
            // 
            vUZBindingSource.DataSource = typeof(VUZ);
            // 
            // VUZER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 553);
            Controls.Add(UniversTable);
            Controls.Add(CityBox);
            Controls.Add(Strip);
            MaximizeBox = false;
            Name = "VUZER";
            Text = "Универы";
            Load += VUZER_Load;
            Strip.ResumeLayout(false);
            Strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UniversTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)vUZBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vUZBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Strip;
        private ToolStripMenuItem Add;
        private ToolStripMenuItem Delete;
        private ToolStripMenuItem Exit;
        private ComboBox CityBox;
        private DataGridView UniversTable;
        private BindingSource vUZBindingSource;
        private DataGridViewTextBoxColumn IdGrid;
        private DataGridViewTextBoxColumn NameGrid;
        private DataGridViewTextBoxColumn CityGrid;
        private BindingSource vUZBindingSource1;
    }
}
