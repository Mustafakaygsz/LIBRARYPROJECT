namespace LİBRARYPROJECT.uye_menu_pages
{
    partial class CardsBook
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(50, 338);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Ödünç Al";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(11, 195);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(17, 230);
            label2.Name = "label2";
            label2.Size = new Size(165, 23);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.TopCenter;
           
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(20, 263);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Location = new Point(20, 298);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 6;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.TopCenter;

            // 
            // CardsBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "CardsBook";
            Size = new Size(200, 381);
            
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
