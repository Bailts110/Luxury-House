namespace Luxury_House
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            buttonNext = new Button();
            button1 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Moccasin;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 42F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(50, 83, 90);
            label1.Location = new Point(381, 189);
            label1.Name = "label1";
            label1.Size = new Size(246, 95);
            label1.TabIndex = 26;
            label1.Text = "Studio";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(766, 697);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonNext
            // 
            buttonNext.AutoSize = true;
            buttonNext.BackColor = Color.Moccasin;
            buttonNext.FlatStyle = FlatStyle.Popup;
            buttonNext.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext.ForeColor = Color.FromArgb(50, 83, 90);
            buttonNext.Location = new Point(1468, 724);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(110, 60);
            buttonNext.TabIndex = 16;
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
            button1.Location = new Point(381, 724);
            button1.Name = "button1";
            button1.Size = new Size(110, 60);
            button1.TabIndex = 25;
            button1.Text = "Back";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Moccasin;
            label2.Location = new Point(661, 189);
            label2.Name = "label2";
            label2.Size = new Size(666, 126);
            label2.TabIndex = 27;
            label2.Text = "The Studio room offers a comfortable and versatile living space suitable for both business and leisure travelers. It is equipped with modern amenities and a stylish decor.";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(50, 83, 90);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Moccasin;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Items.AddRange(new object[] { "Services:", "\t.Queen-sized bed or twin beds.", "\t.En-suite bathroom with a shower.", "\t.Work desk and chair.", "\t.Mini kitchenette with a microwave and refrigerator.", "\t.High-speed Wi-Fi.", "\t.Flat-screen TV with cable channels.", "\t.In-room safe." });
            listBox1.Location = new Point(864, 337);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(691, 248);
            listBox1.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(381, 337);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(461, 326);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 83, 90);
            ClientSize = new Size(1898, 1029);
            Controls.Add(pictureBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonNext);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Alpha;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUXURY HOUSE";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonNext;
        private Button button1;

        private Label label2;
        private ListBox listBox1;
        private PictureBox pictureBox2;
    }
}