namespace LİBRARYPROJECT
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button4 = new Button();
            ımageList1 = new ImageList(components);
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 71);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1079, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(1019, 36);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 4;
            label3.Text = "Personel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(1019, 12);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 2;
            label1.Text = "PERSONEL EKRANI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 567);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 2;
            button4.ImageList = ımageList1;
            button4.Location = new Point(12, 165);
            button4.Name = "button4";
            button4.Size = new Size(213, 49);
            button4.TabIndex = 6;
            button4.Text = "Kitap ekleme";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "monitor.png");
            ımageList1.Images.SetKeyName(1, "book.png");
            ımageList1.Images.SetKeyName(2, "book.png");
            ımageList1.Images.SetKeyName(3, "switch.png");
            ımageList1.Images.SetKeyName(4, "list.png");
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 3;
            button1.ImageList = ımageList1;
            button1.Location = new Point(12, 521);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Çıkış Yap";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 4;
            button3.ImageList = ımageList1;
            button3.Location = new Point(12, 86);
            button3.Name = "button3";
            button3.Size = new Size(213, 49);
            button3.TabIndex = 2;
            button3.Text = "Listeler";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 0;
            button2.ImageList = ımageList1;
            button2.Location = new Point(12, 16);
            button2.Name = "button2";
            button2.Size = new Size(213, 49);
            button2.TabIndex = 1;
            button2.Text = "Çalışma Salonu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(249, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(891, 567);
            panel3.TabIndex = 3;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 638);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel_ekranı";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private ImageList ımageList1;
        private Panel panel3;
        private Button button1;
        private Button button4;
    }
}