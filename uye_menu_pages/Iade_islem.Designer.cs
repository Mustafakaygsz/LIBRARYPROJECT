namespace LİBRARYPROJECT.uye_menu_pages
{
    partial class Iade_islem
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
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 84);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(701, 11);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 5;
            label1.Text = "Alınan kitapları listele\r\n\r\n";
           
            // 
            // button2
            // 
            button2.Location = new Point(735, 39);
            button2.Name = "button2";
            button2.Size = new Size(121, 30);
            button2.TabIndex = 4;
            button2.Text = "Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(228, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 3;
            button1.Text = "İade Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(297, 284);
            listBox1.TabIndex = 3;
            // 
            // Iade_islem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Iade_islem";
            Size = new Size(870, 449);
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
        private Button button2;
    }
}
