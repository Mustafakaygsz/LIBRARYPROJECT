namespace LİBRARYPROJECT
{
    partial class Giris
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(20, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 0;

            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(20, 245);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 1;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(227, 23);
            label3.TabIndex = 6;
            label3.Text = "lütfen giriş bilgilerinizi giriniz";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(145, 339);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 23);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "hesap oluştur";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(20, 159);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 7;
            label4.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(20, 345);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 3;
            label1.Text = "HESABINIZ YOK MU?";

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(21, 222);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 8;
            label5.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(36, 49);
            label2.Name = "label2";
            label2.Size = new Size(208, 40);
            label2.TabIndex = 5;
            label2.Text = "HOŞGELDİNİZ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(20, 302);
            button1.Name = "button1";
            button1.Size = new Size(231, 34);
            button1.TabIndex = 17;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveBorder;
            label6.Location = new Point(20, 377);
            label6.Name = "label6";
            label6.Size = new Size(231, 2);
            label6.TabIndex = 18;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(20, 398);
            button2.Name = "button2";
            button2.Size = new Size(231, 29);
            button2.TabIndex = 19;
            button2.Text = "şifremi unuttum";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(21, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 449);
            panel1.TabIndex = 9;

            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 494);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KUTUPHANE SİSTEMİ";
            Load += Giris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label2;
        private Button button1;
        private Label label6;
        private Button button2;
        private Panel panel1;
    }
}