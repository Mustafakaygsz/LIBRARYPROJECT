namespace LİBRARYPROJECT.uye_menu_pages
{
    partial class Page_tablo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_tablo));
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button11 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 118);
            panel2.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(286, 40);
            label1.TabIndex = 38;
            label1.Text = "Kütüphaneyi Keşfet\r\n";
            // 
            // button11
            // 
            button11.Location = new Point(169, 72);
            button11.Name = "button11";
            button11.Size = new Size(94, 33);
            button11.TabIndex = 37;
            button11.Text = "ARA";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 118);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(870, 449);
            flowLayoutPanel1.TabIndex = 36;
            
            // 
            // Page_tablo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Menu;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "Page_tablo";
            Size = new Size(870, 567);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button11;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}
