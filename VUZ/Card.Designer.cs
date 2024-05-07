namespace VUZ
{
    partial class Card
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
            ChangeButton = new Button();
            AddPhotoButton = new Button();
            CloseButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            SuspendLayout();
            // 
            // CityTextBox
            // 
            CityTextBox.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CityTextBox.Location = new Point(149, 125);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.ReadOnly = true;
            CityTextBox.Size = new Size(258, 33);
            CityTextBox.TabIndex = 13;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(149, 71);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(258, 33);
            NameTextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(36, 165);
            label4.Name = "label4";
            label4.Size = new Size(61, 29);
            label4.TabIndex = 11;
            label4.Text = "Фото";
            // 
            // Photo
            // 
            Photo.BackColor = SystemColors.ButtonShadow;
            Photo.BackgroundImageLayout = ImageLayout.Stretch;
            Photo.Location = new Point(36, 206);
            Photo.Name = "Photo";
            Photo.Size = new Size(410, 231);
            Photo.TabIndex = 10;
            Photo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(36, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 29);
            label3.TabIndex = 9;
            label3.Text = "Город";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(36, 71);
            label2.Name = "label2";
            label2.Size = new Size(107, 29);
            label2.TabIndex = 8;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(149, 16);
            label1.Name = "label1";
            label1.Size = new Size(186, 39);
            label1.TabIndex = 7;
            label1.Text = "Университет";
            // 
            // ChangeButton
            // 
            ChangeButton.Font = new Font("Sitka Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangeButton.Location = new Point(36, 516);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(196, 63);
            ChangeButton.TabIndex = 24;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // AddPhotoButton
            // 
            AddPhotoButton.Font = new Font("Sitka Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddPhotoButton.Location = new Point(108, 443);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(267, 39);
            AddPhotoButton.TabIndex = 23;
            AddPhotoButton.Text = "Изменить фото";
            AddPhotoButton.UseVisualStyleBackColor = true;
            AddPhotoButton.Click += AddPhotoButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("Sitka Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(250, 516);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(196, 63);
            CloseButton.TabIndex = 25;
            CloseButton.Text = "Закрыть";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 591);
            Controls.Add(CloseButton);
            Controls.Add(ChangeButton);
            Controls.Add(AddPhotoButton);
            Controls.Add(CityTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label4);
            Controls.Add(Photo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Card";
            Text = "Card";
            Load += Card_Load;
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
        private Button ChangeButton;
        private Button AddPhotoButton;
        private Button CloseButton;
        private OpenFileDialog openFileDialog1;
    }
}