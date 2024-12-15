namespace Luxury_House
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePickerArrive = new DateTimePicker();
            dateTimePickerDepart = new DateTimePicker();
            buttonNext = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(477, 723);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(771, 70);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(533, 394);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(533, 464);
            label2.Name = "label2";
            label2.Size = new Size(253, 46);
            label2.TabIndex = 7;
            label2.Text = "Phone number";
            label2.Click += label2_Click;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.White;
            textBoxName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(887, 402);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(353, 38);
            textBoxName.TabIndex = 8;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.White;
            textBoxPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(887, 472);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(353, 38);
            textBoxPhone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(533, 611);
            label4.Name = "label4";
            label4.Size = new Size(315, 46);
            label4.TabIndex = 10;
            label4.Text = "Date of departure ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(533, 535);
            label3.Name = "label3";
            label3.Size = new Size(245, 46);
            label3.TabIndex = 11;
            label3.Text = "Date of arrival";
            // 
            // dateTimePickerArrive
            // 
            dateTimePickerArrive.CalendarMonthBackground = Color.White;
            dateTimePickerArrive.CalendarTitleBackColor = Color.Linen;
            dateTimePickerArrive.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerArrive.Format = DateTimePickerFormat.Short;
            dateTimePickerArrive.Location = new Point(887, 541);
            dateTimePickerArrive.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dateTimePickerArrive.MinDate = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            dateTimePickerArrive.Name = "dateTimePickerArrive";
            dateTimePickerArrive.Size = new Size(353, 38);
            dateTimePickerArrive.TabIndex = 12;
            dateTimePickerArrive.ValueChanged += dateTimePickerArrive_ValueChanged;
            // 
            // dateTimePickerDepart
            // 
            dateTimePickerDepart.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDepart.Format = DateTimePickerFormat.Short;
            dateTimePickerDepart.Location = new Point(887, 617);
            dateTimePickerDepart.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dateTimePickerDepart.MinDate = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            dateTimePickerDepart.Name = "dateTimePickerDepart";
            dateTimePickerDepart.Size = new Size(353, 38);
            dateTimePickerDepart.TabIndex = 13;
            dateTimePickerDepart.ValueChanged += dateTimePickerDepart_ValueChanged;
            // 
            // buttonNext
            // 
            buttonNext.AutoSize = true;
            buttonNext.BackColor = Color.Moccasin;
            buttonNext.FlatStyle = FlatStyle.Popup;
            buttonNext.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext.ForeColor = Color.FromArgb(50, 83, 90);
            buttonNext.Location = new Point(1379, 750);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(110, 60);
            buttonNext.TabIndex = 14;
            buttonNext.Text = "Next";
            buttonNext.TextAlign = ContentAlignment.TopLeft;
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 64.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Moccasin;
            label5.Location = new Point(433, 109);
            label5.Name = "label5";
            label5.Size = new Size(908, 146);
            label5.TabIndex = 15;
            label5.Text = "LUXURY HOUSE";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 34.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Moccasin;
            label6.Location = new Point(657, 278);
            label6.Name = "label6";
            label6.Size = new Size(426, 77);
            label6.TabIndex = 19;
            label6.Text = "Book A Room";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 83, 90);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Simplified Arabic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(746, 661);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(494, 38);
            textBox1.TabIndex = 16;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Moccasin;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(50, 83, 90);
            button1.Location = new Point(805, 853);
            button1.Name = "button1";
            button1.Size = new Size(144, 56);
            button1.TabIndex = 20;
            button1.Text = "Logout";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 83, 90);
            ClientSize = new Size(1898, 1029);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(buttonNext);
            Controls.Add(dateTimePickerDepart);
            Controls.Add(dateTimePickerArrive);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Alpha;
            Name = "Form9";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUXURY HOUSE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxPhone;
        private Label label4;
        private Label label3;
        private Button buttonNext;
        private Label label5;
        public DateTimePicker dateTimePickerArrive;
        public DateTimePicker dateTimePickerDepart;
        private Label label6;
        private TextBox textBox1;
        private Button button1;
    }
}