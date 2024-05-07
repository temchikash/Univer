namespace VUZ
{
    partial class AddForm
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
            CityTextBox = new TextBox();
            NameTextBox = new TextBox();
            label4 = new Label();
            Photo = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddPhotoButton = new Button();
            AddButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            SuspendLayout();
            // 
            // CityTextBox
            // 
            CityTextBox.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CityTextBox.Location = new Point(149, 125);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(258, 33);
            CityTextBox.TabIndex = 20;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(149, 71);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(258, 33);
            NameTextBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(36, 165);
            label4.Name = "label4";
            label4.Size = new Size(61, 29);
            label4.TabIndex = 18;
            label4.Text = "Фото";
            // 
            // Photo
            // 
            Photo.BackColor = SystemColors.ButtonShadow;
            Photo.BackgroundImageLayout = ImageLayout.Stretch;
            Photo.Location = new Point(36, 206);
            Photo.Name = "Photo";
            Photo.Size = new Size(410, 231);
            Photo.TabIndex = 17;
            Photo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(36, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 29);
            label3.TabIndex = 16;
            label3.Text = "Город";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(36, 71);
            label2.Name = "label2";
            label2.Size = new Size(107, 29);
            label2.TabIndex = 15;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 39);
            label1.TabIndex = 14;
            label1.Text = "Университет";
            // 
            // AddPhotoButton
            // 
            AddPhotoButton.Font = new Font("Sitka Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddPhotoButton.Location = new Point(106, 443);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(267, 39);
            AddPhotoButton.TabIndex = 21;
            AddPhotoButton.Text = "Загрузить фото";
            AddPhotoButton.UseVisualStyleBackColor = true;
            AddPhotoButton.Click += AddPhotoButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Sitka Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(106, 516);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(267, 63);
            AddButton.TabIndex = 22;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 591);
            Controls.Add(AddButton);
            Controls.Add(AddPhotoButton);
            Controls.Add(CityTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label4);
            Controls.Add(Photo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "Создать";
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CityTextBox;
        private TextBox NameTextBox;
        private Label label4;
        private PictureBox Photo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button AddPhotoButton;
        private Button AddButton;
        private OpenFileDialog openFileDialog1;
    }
}