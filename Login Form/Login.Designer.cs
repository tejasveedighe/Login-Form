namespace Login_Form
{
    partial class Login
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
            label1 = new Label();
            label_username = new Label();
            label_password = new Label();
            textBox_userEmail = new TextBox();
            textBox_password = new TextBox();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 19);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_username
            // 
            label_username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_username.Location = new Point(38, 127);
            label_username.Name = "label_username";
            label_username.Size = new Size(117, 30);
            label_username.TabIndex = 1;
            label_username.Text = "User Email";
            // 
            // label_password
            // 
            label_password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_password.Location = new Point(38, 185);
            label_password.Name = "label_password";
            label_password.Size = new Size(117, 30);
            label_password.TabIndex = 2;
            label_password.Text = "Password";
            // 
            // textBox_username
            // 
            textBox_userEmail.Location = new Point(172, 134);
            textBox_userEmail.Name = "textBox_username";
            textBox_userEmail.Size = new Size(194, 23);
            textBox_userEmail.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(172, 192);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(194, 23);
            textBox_password.TabIndex = 4;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(172, 287);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(114, 35);
            btn_submit.TabIndex = 5;
            btn_submit.Text = "Login";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(btn_submit);
            Controls.Add(textBox_password);
            Controls.Add(textBox_userEmail);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_username;
        private Label label_password;
        private TextBox textBox_userEmail;
        private TextBox textBox_password;
        private Button btn_submit;
    }
}
