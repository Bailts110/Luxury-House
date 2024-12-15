namespace Luxury_House
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            buttonNext = new Button();
            radioButtonStudio = new RadioButton();
            radioButtonVIP = new RadioButton();
            radioButtonSR = new RadioButton();
            radioButtonDR = new RadioButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonStudioDetail = new Button();
            buttonSingleRoomDetails = new Button();
            buttonVipDetails = new Button();
            buttonDoubleRoomDetails = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(766, 718);
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
            buttonNext.Location = new Point(1468, 745);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(110, 60);
            buttonNext.TabIndex = 15;
            buttonNext.Text = "Next";
            buttonNext.TextAlign = ContentAlignment.TopLeft;
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // radioButtonStudio
            // 
            radioButtonStudio.AutoSize = true;
            radioButtonStudio.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            radioButtonStudio.FlatAppearance.BorderSize = 0;
            radioButtonStudio.FlatAppearance.CheckedBackColor = Color.Black;
            radioButtonStudio.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonStudio.ForeColor = Color.Moccasin;
            radioButtonStudio.Location = new Point(432, 159);
            radioButtonStudio.Name = "radioButtonStudio";
            radioButtonStudio.Size = new Size(176, 64);
            radioButtonStudio.TabIndex = 16;
            radioButtonStudio.TabStop = true;
            radioButtonStudio.Text = "Studio";
            radioButtonStudio.UseVisualStyleBackColor = true;
            // 
            // radioButtonVIP
            // 
            radioButtonVIP.AutoSize = true;
            radioButtonVIP.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            radioButtonVIP.FlatAppearance.BorderSize = 0;
            radioButtonVIP.FlatAppearance.CheckedBackColor = Color.Black;
            radioButtonVIP.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonVIP.ForeColor = Color.Moccasin;
            radioButtonVIP.Location = new Point(991, 159);
            radioButtonVIP.Name = "radioButtonVIP";
            radioButtonVIP.Size = new Size(221, 64);
            radioButtonVIP.TabIndex = 17;
            radioButtonVIP.TabStop = true;
            radioButtonVIP.Text = "VIP suite";
            radioButtonVIP.UseVisualStyleBackColor = true;
            // 
            // radioButtonSR
            // 
            radioButtonSR.AutoSize = true;
            radioButtonSR.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            radioButtonSR.FlatAppearance.BorderSize = 0;
            radioButtonSR.FlatAppearance.CheckedBackColor = Color.Black;
            radioButtonSR.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonSR.ForeColor = Color.Moccasin;
            radioButtonSR.Location = new Point(991, 423);
            radioButtonSR.Name = "radioButtonSR";
            radioButtonSR.Size = new Size(470, 64);
            radioButtonSR.TabIndex = 18;
            radioButtonSR.TabStop = true;
            radioButtonSR.Text = "Deluxe Double Room";
            radioButtonSR.UseVisualStyleBackColor = true;
            // 
            // radioButtonDR
            // 
            radioButtonDR.AutoSize = true;
            radioButtonDR.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            radioButtonDR.FlatAppearance.BorderSize = 0;
            radioButtonDR.FlatAppearance.CheckedBackColor = Color.Black;
            radioButtonDR.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonDR.ForeColor = Color.Moccasin;
            radioButtonDR.Location = new Point(432, 423);
            radioButtonDR.Name = "radioButtonDR";
            radioButtonDR.Size = new Size(448, 64);
            radioButtonDR.TabIndex = 19;
            radioButtonDR.TabStop = true;
            radioButtonDR.Text = "Deluxe Single Room";
            radioButtonDR.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1139, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(382, 235);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(536, 201);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(382, 235);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1139, 493);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(382, 235);
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(536, 493);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(382, 235);
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Moccasin;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(50, 83, 90);
            button1.Location = new Point(381, 745);
            button1.Name = "button1";
            button1.Size = new Size(110, 60);
            button1.TabIndex = 24;
            button1.Text = "Back";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(432, 226);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 25;
            label1.Text = "Start from 30 $";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Moccasin;
            label2.Location = new Point(991, 226);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 26;
            label2.Text = "Start from 130 $";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Moccasin;
            label3.Location = new Point(432, 504);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 27;
            label3.Text = "Start from 45 $";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Moccasin;
            label4.Location = new Point(991, 490);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 28;
            label4.Text = "Start from 60 $";
            // 
            // buttonStudioDetail
            // 
            buttonStudioDetail.AutoSize = true;
            buttonStudioDetail.BackColor = Color.Moccasin;
            buttonStudioDetail.FlatStyle = FlatStyle.Popup;
            buttonStudioDetail.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudioDetail.ForeColor = Color.FromArgb(50, 83, 90);
            buttonStudioDetail.Location = new Point(442, 268);
            buttonStudioDetail.Name = "buttonStudioDetail";
            buttonStudioDetail.Size = new Size(102, 42);
            buttonStudioDetail.TabIndex = 29;
            buttonStudioDetail.Text = "Details";
            buttonStudioDetail.TextAlign = ContentAlignment.TopLeft;
            buttonStudioDetail.UseVisualStyleBackColor = false;
            buttonStudioDetail.Click += buttonStudioDetail_Click;
            // 
            // buttonSingleRoomDetails
            // 
            buttonSingleRoomDetails.AutoSize = true;
            buttonSingleRoomDetails.BackColor = Color.Moccasin;
            buttonSingleRoomDetails.FlatStyle = FlatStyle.Popup;
            buttonSingleRoomDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSingleRoomDetails.ForeColor = Color.FromArgb(50, 83, 90);
            buttonSingleRoomDetails.Location = new Point(442, 548);
            buttonSingleRoomDetails.Name = "buttonSingleRoomDetails";
            buttonSingleRoomDetails.Size = new Size(102, 42);
            buttonSingleRoomDetails.TabIndex = 30;
            buttonSingleRoomDetails.Text = "Details";
            buttonSingleRoomDetails.TextAlign = ContentAlignment.TopLeft;
            buttonSingleRoomDetails.UseVisualStyleBackColor = false;
            buttonSingleRoomDetails.Click += buttonSingleRoomDetails_Click;
            // 
            // buttonVipDetails
            // 
            buttonVipDetails.AutoSize = true;
            buttonVipDetails.BackColor = Color.Moccasin;
            buttonVipDetails.FlatStyle = FlatStyle.Popup;
            buttonVipDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVipDetails.ForeColor = Color.FromArgb(50, 83, 90);
            buttonVipDetails.Location = new Point(1012, 268);
            buttonVipDetails.Name = "buttonVipDetails";
            buttonVipDetails.Size = new Size(102, 42);
            buttonVipDetails.TabIndex = 31;
            buttonVipDetails.Text = "Details";
            buttonVipDetails.TextAlign = ContentAlignment.TopLeft;
            buttonVipDetails.UseVisualStyleBackColor = false;
            buttonVipDetails.Click += buttonVipDetails_Click;
            // 
            // buttonDoubleRoomDetails
            // 
            buttonDoubleRoomDetails.AutoSize = true;
            buttonDoubleRoomDetails.BackColor = Color.Moccasin;
            buttonDoubleRoomDetails.FlatStyle = FlatStyle.Popup;
            buttonDoubleRoomDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDoubleRoomDetails.ForeColor = Color.FromArgb(50, 83, 90);
            buttonDoubleRoomDetails.Location = new Point(1012, 548);
            buttonDoubleRoomDetails.Name = "buttonDoubleRoomDetails";
            buttonDoubleRoomDetails.Size = new Size(102, 42);
            buttonDoubleRoomDetails.TabIndex = 32;
            buttonDoubleRoomDetails.Text = "Details";
            buttonDoubleRoomDetails.TextAlign = ContentAlignment.TopLeft;
            buttonDoubleRoomDetails.UseVisualStyleBackColor = false;
            buttonDoubleRoomDetails.Click += buttonDoubleRoomDetails_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 83, 90);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(1139, 817);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 32);
            textBox1.TabIndex = 33;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 83, 90);
            ClientSize = new Size(1898, 1029);
            Controls.Add(textBox1);
            Controls.Add(buttonDoubleRoomDetails);
            Controls.Add(buttonVipDetails);
            Controls.Add(buttonSingleRoomDetails);
            Controls.Add(buttonStudioDetail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(radioButtonStudio);
            Controls.Add(pictureBox3);
            Controls.Add(radioButtonDR);
            Controls.Add(radioButtonVIP);
            Controls.Add(buttonNext);
            Controls.Add(pictureBox2);
            Controls.Add(radioButtonSR);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Alpha;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUXURY HOUSE";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonNext;
        private RadioButton radioButtonStudio;
        private RadioButton radioButtonVIP;
        private RadioButton radioButtonSR;
        private RadioButton radioButtonDR;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonStudioDetail;
        private Button buttonSingleRoomDetails;
        private Button buttonVipDetails;
        private Button buttonDoubleRoomDetails;
        private TextBox textBox1;
    }
}