namespace КП_Савинская
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(347, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 56);
            label1.TabIndex = 0;
            label1.Text = "Услуги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Italic);
            label2.Location = new Point(43, 282);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 1;
            label2.Text = "Печать фото";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Italic);
            label3.Location = new Point(43, 328);
            label3.Name = "label3";
            label3.Size = new Size(255, 27);
            label3.TabIndex = 2;
            label3.Text = "Фотография на документы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Italic);
            label4.Location = new Point(43, 355);
            label4.Name = "label4";
            label4.Size = new Size(177, 27);
            label4.TabIndex = 3;
            label4.Text = "Услуги фотографа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Italic);
            label5.Location = new Point(43, 467);
            label5.Name = "label5";
            label5.Size = new Size(95, 27);
            label5.TabIndex = 4;
            label5.Text = "Сувениры";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Italic);
            label6.Location = new Point(43, 392);
            label6.Name = "label6";
            label6.Size = new Size(169, 27);
            label6.TabIndex = 5;
            label6.Text = "Печать на холсте";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Italic);
            label7.Location = new Point(43, 428);
            label7.Name = "label7";
            label7.Size = new Size(174, 27);
            label7.TabIndex = 6;
            label7.Text = "Создание альбомов";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 423);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(228, 499);
            label8.Name = "label8";
            label8.Size = new Size(91, 37);
            label8.TabIndex = 8;
            label8.Text = "Назад";
            label8.Click += label8_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Печать фото", "Печать на холсте", "Услуги фотографа", "Создание альбома" });
            comboBox1.Location = new Point(116, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(147, 223);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 10;
            button1.Text = "Забронировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "28.01.2024", "29.01.2024", "30.01.2024", "31.01.2024", "01.01.2024" });
            comboBox2.Location = new Point(116, 108);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 28);
            comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" });
            comboBox3.Location = new Point(116, 159);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 28);
            comboBox3.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Monotype Corsiva", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label9.Location = new Point(147, 9);
            label9.Name = "label9";
            label9.Size = new Size(108, 45);
            label9.TabIndex = 13;
            label9.Text = "Бронь";
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(895, 574);
            Controls.Add(label9);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Services";
            Text = "AboutUs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label9;
    }
}