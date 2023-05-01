namespace PC_Kontrol
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramAnalizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemciToolStripMenuItem,
            this.ramToolStripMenuItem,
            this.ekranKartıToolStripMenuItem,
            this.pingToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menü";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // işlemciToolStripMenuItem
            // 
            this.işlemciToolStripMenuItem.Name = "işlemciToolStripMenuItem";
            this.işlemciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.işlemciToolStripMenuItem.Text = "İşlemci";
            this.işlemciToolStripMenuItem.Click += new System.EventHandler(this.işlemciToolStripMenuItem_Click);
            // 
            // ramToolStripMenuItem
            // 
            this.ramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ramTemizleToolStripMenuItem,
            this.ramAnalizToolStripMenuItem});
            this.ramToolStripMenuItem.Name = "ramToolStripMenuItem";
            this.ramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ramToolStripMenuItem.Text = "Ram";
            this.ramToolStripMenuItem.Click += new System.EventHandler(this.ramToolStripMenuItem_Click);
            // 
            // ramTemizleToolStripMenuItem
            // 
            this.ramTemizleToolStripMenuItem.Name = "ramTemizleToolStripMenuItem";
            this.ramTemizleToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.ramTemizleToolStripMenuItem.Text = "Ram temizle";
            this.ramTemizleToolStripMenuItem.Click += new System.EventHandler(this.ramTemizleToolStripMenuItem_Click);
            // 
            // ramAnalizToolStripMenuItem
            // 
            this.ramAnalizToolStripMenuItem.Name = "ramAnalizToolStripMenuItem";
            this.ramAnalizToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.ramAnalizToolStripMenuItem.Text = "Ram Analiz(deneme aşamasında)";
            this.ramAnalizToolStripMenuItem.Click += new System.EventHandler(this.ramAnalizToolStripMenuItem_Click);
            // 
            // ekranKartıToolStripMenuItem
            // 
            this.ekranKartıToolStripMenuItem.Name = "ekranKartıToolStripMenuItem";
            this.ekranKartıToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ekranKartıToolStripMenuItem.Text = "Ekran Kartı";
            this.ekranKartıToolStripMenuItem.Click += new System.EventHandler(this.ekranKartıToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(299, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(459, 392);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(206, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Temizle";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranKartıToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ramTemizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramAnalizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
    }
}

