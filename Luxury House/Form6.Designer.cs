namespace Luxury_House
{
    partial class Form6
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
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            pictureBox1 = new PictureBox();
            buttonNext = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Moccasin;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 42F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(50, 83, 90);
            label1.Location = new Point(333, 186);
            label1.Name = "label1";
            label1.Size = new Size(679, 95);
            label1.TabIndex = 39;
            label1.Text = "Deluxe Single Room";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(728, 706);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 70);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonNext
            // 
            buttonNext.AutoSize = true;
            buttonNext.BackColor = Color.Moccasin;
            buttonNext.FlatStyle = FlatStyle.Popup;
            buttonNext.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext.ForeColor = Color.FromArgb(50, 83, 90);
            buttonNext.Location = new Point(1430, 733);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(110, 60);
            buttonNext.TabIndex = 17;
            buttonNext.Text = "Next";
            buttonNext.TextAlign = ContentAlignment.TopLeft;
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Moccasin;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(50, 83, 90);
            button1.Location = new Point(343, 733);
            button1.Name = "button1";
            button1.Size = new Size(110, 60);
            button1.TabIndex = 25;
            button1.Text = "Back";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(50, 83, 90);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Moccasin;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Items.AddRange(new object[] { "Services", "\t.Single bed.", "\t..Private bathroom with a shower.", "\t.Writing desk.", "\t.Basic toiletries.", "\t.Wi-Fi access.", "\t.Television with local and international channels.", "\t.Room service." });
            listBox1.Location = new Point(911, 421);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(617, 279);
            listBox1.TabIndex = 41;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Moccasin;
            label2.Location = new Point(797, 292);
            label2.Name = "label2";
            label2.Size = new Size(737, 126);
            label2.TabIndex = 40;
            label2.Text = "The Single Room is designed for solo travelers seeking a cozy and private accommodation option. It provides a serene environment for a restful stay.";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(333, 388);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(458, 312);
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 83, 90);
            ClientSize = new Size(1898, 1029);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(buttonNext);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Alpha;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUXURY HOUSE";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonNext;
        private Button button1;
        private ListBox listBox1;
        private Label label2;
        private PictureBox pictureBox3;
    }
}