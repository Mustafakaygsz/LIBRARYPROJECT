namespace LİBRARYPROJECT.admin_menu_pages.menu_pages
{
    partial class Kitap_islem
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
            listBox1 = new ListBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 30);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(656, 504);
            listBox1.TabIndex = 0;

            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioButton1.ForeColor = Color.SlateGray;
            radioButton1.Location = new Point(694, 245);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 27);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Üyeler";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioButton2.ForeColor = Color.SlateGray;
            radioButton2.Location = new Point(694, 294);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 27);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kitaplar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioButton3.ForeColor = Color.SlateGray;
            radioButton3.Location = new Point(694, 346);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(163, 27);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Kitap Alan Üyeler";
            radioButton3.UseVisualStyleBackColor = true;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(693, 186);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 6;
            label2.Text = "Listeler";
            // 
            // button2
            // 
            button2.Location = new Point(694, 412);
            button2.Name = "button2";
            button2.Size = new Size(180, 34);
            button2.TabIndex = 15;
            button2.Text = "Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Kitap_islem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(listBox1);
            Name = "Kitap_islem";
            Size = new Size(891, 567);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label2;
        private Button button2;
    }
}
