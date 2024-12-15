namespace Luxury_House
{
    partial class Form1
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
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxUserLogin = new TextBox();
            textBoxPassLogin = new TextBox();
            label3 = new Label();
            buttonLogin = new Button();
            textBox1 = new TextBox();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 64.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Moccasin;
            label5.Location = new Point(465, 78);
            label5.Name = "label5";
            label5.Size = new Size(908, 146);
            label5.TabIndex = 16;
            label5.Text = "LUXURY HOUSE";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(534, 401);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 17;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(534, 534);
            label2.Name = "label2";
            label2.Size = new Size(169, 46);
            label2.TabIndex = 18;
            label2.Text = "Password";
            // 
            // textBoxUserLogin
            // 
            textBoxUserLogin.BackColor = Color.White;
            textBoxUserLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserLogin.Location = new Point(820, 409);
            textBoxUserLogin.Name = "textBoxUserLogin";
            textBoxUserLogin.Size = new Size(353, 38);
            textBoxUserLogin.TabIndex = 19;
            // 
            // textBoxPassLogin
            // 
            textBoxPassLogin.BackColor = Color.White;
            textBoxPassLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassLogin.Location = new Point(820, 542);
            textBoxPassLogin.Name = "textBoxPassLogin";
            textBoxPassLogin.PasswordChar = '*';
            textBoxPassLogin.Size = new Size(353, 38);
            textBoxPassLogin.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 34.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Moccasin;
            label3.Location = new Point(729, 261);
            label3.Name = "label3";
            label3.Size = new Size(336, 77);
            label3.TabIndex = 21;
            label3.Text = "User Login";
            // 
            // buttonLogin
            // 
            buttonLogin.AutoSize = true;
            buttonLogin.BackColor = Color.Moccasin;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.FromArgb(50, 83, 90);
            buttonLogin.Location = new Point(779, 657);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(232, 60);
            buttonLogin.TabIndex = 22;
            buttonLogin.Text = "Login";
            buttonLogin.TextAlign = ContentAlignment.TopCenter;
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonNext_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 83, 90);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(501, 602);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(999, 34);
            textBox1.TabIndex = 23;
            // 
            // buttonRegister
            // 
            buttonRegister.AutoSize = true;
            buttonRegister.BackColor = Color.Moccasin;
            buttonRegister.FlatStyle = FlatStyle.Popup;
            buttonRegister.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.FromArgb(50, 83, 90);
            buttonRegister.Location = new Point(779, 780);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(232, 60);
            buttonRegister.TabIndex = 24;
            buttonRegister.Text = "REGISTER";
            buttonRegister.TextAlign = ContentAlignment.TopCenter;
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 83, 90);
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonRegister);
            Controls.Add(textBox1);
            Controls.Add(buttonLogin);
            Controls.Add(label3);
            Controls.Add(textBoxPassLogin);
            Controls.Add(textBoxUserLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Form1";
            Text = "LUXURY HOUSE";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private Label label2;
        private TextBox textBoxUserLogin;
        private TextBox textBoxPassLogin;
        private Label label3;
        private Button buttonLogin;
        private TextBox textBox1;
        private Button buttonRegister;
    }
}