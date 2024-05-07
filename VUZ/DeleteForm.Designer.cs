namespace VUZ
{
    partial class DeleteForm
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
            label1 = new Label();
            DeleteButton = new Button();
            NameBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(108, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 39);
            label1.TabIndex = 15;
            label1.Text = "Выберите институт";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Sitka Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.Location = new Point(108, 178);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(267, 63);
            DeleteButton.TabIndex = 23;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Sitka Text", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameBox.FormattingEnabled = true;
            NameBox.Location = new Point(108, 69);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(267, 32);
            NameBox.TabIndex = 24;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(NameBox);
            Controls.Add(DeleteButton);
            Controls.Add(label1);
            Name = "DeleteForm";
            Text = "Удалить";
            Load += DeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button DeleteButton;
        private ComboBox NameBox;
    }
}