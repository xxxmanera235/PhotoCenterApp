namespace КП_Савинская
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            loginBox = new TextBox();
            passBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(410, 27);
            label1.Name = "label1";
            label1.Size = new Size(114, 56);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(101, 320);
            label2.Name = "label2";
            label2.Size = new Size(161, 56);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(101, 165);
            label3.Name = "label3";
            label3.Size = new Size(137, 56);
            label3.TabIndex = 2;
            label3.Text = "Логин";
            // 
            // loginBox
            // 
            loginBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox.Location = new Point(369, 165);
            loginBox.Multiline = true;
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(195, 52);
            loginBox.TabIndex = 3;
            // 
            // passBox
            // 
            passBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passBox.Location = new Point(369, 320);
            passBox.Multiline = true;
            passBox.Name = "passBox";
            passBox.Size = new Size(195, 52);
            passBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(402, 434);
            label4.Name = "label4";
            label4.Size = new Size(149, 56);
            label4.TabIndex = 5;
            label4.Text = "Войти";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(895, 9);
            label5.Name = "label5";
            label5.Size = new Size(51, 56);
            label5.TabIndex = 6;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(635, 433);
            label6.Name = "label6";
            label6.Size = new Size(266, 56);
            label6.TabIndex = 7;
            label6.Text = "Регистрация";
            label6.Click += Зарегистрироваться;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(958, 552);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(passBox);
            Controls.Add(loginBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            MouseDown += Login_MouseDown;
            MouseMove += Login_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox loginBox;
        private TextBox passBox;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}