namespace csapat_jegy_05_27 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beolvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nevekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyümölcsökToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritokKiírásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.names_listBox = new System.Windows.Forms.ListBox();
            this.fruits_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.names_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fruits_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.favourits_listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beolvasToolStripMenuItem,
            this.favoritokKiírásaToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.kilépToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beolvasToolStripMenuItem
            // 
            this.beolvasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nevekToolStripMenuItem,
            this.gyümölcsökToolStripMenuItem});
            this.beolvasToolStripMenuItem.Name = "beolvasToolStripMenuItem";
            this.beolvasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.beolvasToolStripMenuItem.Text = "Beolvas";
            // 
            // nevekToolStripMenuItem
            // 
            this.nevekToolStripMenuItem.Name = "nevekToolStripMenuItem";
            this.nevekToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.nevekToolStripMenuItem.Text = "Nevek";
            this.nevekToolStripMenuItem.Click += new System.EventHandler(this.beolvasHandler);
            // 
            // gyümölcsökToolStripMenuItem
            // 
            this.gyümölcsökToolStripMenuItem.Name = "gyümölcsökToolStripMenuItem";
            this.gyümölcsökToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.gyümölcsökToolStripMenuItem.Text = "Gyümölcsök";
            this.gyümölcsökToolStripMenuItem.Click += new System.EventHandler(this.beolvasHandler);
            // 
            // favoritokKiírásaToolStripMenuItem
            // 
            this.favoritokKiírásaToolStripMenuItem.Name = "favoritokKiírásaToolStripMenuItem";
            this.favoritokKiírásaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.favoritokKiírásaToolStripMenuItem.Text = "Favoritok kiírása";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // kilépToolStripMenuItem
            // 
            this.kilépToolStripMenuItem.Name = "kilépToolStripMenuItem";
            this.kilépToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kilépToolStripMenuItem.Text = "Kilép";
            this.kilépToolStripMenuItem.Click += new System.EventHandler(this.kilépToolStripMenuItem_Click);
            // 
            // names_listBox
            // 
            this.names_listBox.FormattingEnabled = true;
            this.names_listBox.Location = new System.Drawing.Point(13, 94);
            this.names_listBox.Name = "names_listBox";
            this.names_listBox.Size = new System.Drawing.Size(260, 264);
            this.names_listBox.TabIndex = 1;
            // 
            // fruits_listBox
            // 
            this.fruits_listBox.FormattingEnabled = true;
            this.fruits_listBox.Location = new System.Drawing.Point(337, 94);
            this.fruits_listBox.Name = "fruits_listBox";
            this.fruits_listBox.Size = new System.Drawing.Size(260, 264);
            this.fruits_listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nevek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(333, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gyümölcsök";
            // 
            // names_textBox
            // 
            this.names_textBox.Location = new System.Drawing.Point(16, 384);
            this.names_textBox.Name = "names_textBox";
            this.names_textBox.Size = new System.Drawing.Size(100, 20);
            this.names_textBox.TabIndex = 5;
            this.names_textBox.TextChanged += new System.EventHandler(this.names_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Szűrés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Szűrés";
            // 
            // fruits_textBox
            // 
            this.fruits_textBox.Location = new System.Drawing.Point(337, 384);
            this.fruits_textBox.Name = "fruits_textBox";
            this.fruits_textBox.Size = new System.Drawing.Size(100, 20);
            this.fruits_textBox.TabIndex = 8;
            this.fruits_textBox.TextChanged += new System.EventHandler(this.fruits_textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Felvisz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(647, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Favoritok";
            // 
            // favourits_listBox
            // 
            this.favourits_listBox.FormattingEnabled = true;
            this.favourits_listBox.Location = new System.Drawing.Point(651, 94);
            this.favourits_listBox.Name = "favourits_listBox";
            this.favourits_listBox.Size = new System.Drawing.Size(260, 264);
            this.favourits_listBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.favourits_listBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fruits_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.names_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fruits_listBox);
            this.Controls.Add(this.names_listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gyümölcsválasztó";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beolvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nevekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyümölcsökToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritokKiírásaToolStripMenuItem;
        private System.Windows.Forms.ListBox names_listBox;
        private System.Windows.Forms.ListBox fruits_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox names_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fruits_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox favourits_listBox;
    }
}

