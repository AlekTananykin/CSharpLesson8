namespace Task4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenDb = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewDb = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveDb = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAsDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExitDb = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNativeWord = new System.Windows.Forms.TextBox();
            this.tbForeignWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bnSaveInDb = new System.Windows.Forms.ToolStripButton();
            this.bnDeleteFromDb = new System.Windows.Forms.ToolStripButton();
            this.bnAddToDb = new System.Windows.Forms.ToolStripButton();
            this.nmWordNumber = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmWordNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenDb,
            this.miNewDb,
            this.miSaveDb,
            this.miSaveAsDb,
            this.toolStripSeparator1,
            this.miExitDb});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miOpenDb
            // 
            this.miOpenDb.Name = "miOpenDb";
            this.miOpenDb.Size = new System.Drawing.Size(173, 34);
            this.miOpenDb.Text = "Open";
            this.miOpenDb.Click += new System.EventHandler(this.miOpenDb_Click);
            // 
            // miNewDb
            // 
            this.miNewDb.Name = "miNewDb";
            this.miNewDb.Size = new System.Drawing.Size(173, 34);
            this.miNewDb.Text = "New";
            this.miNewDb.Click += new System.EventHandler(this.miNewDb_Click);
            // 
            // miSaveDb
            // 
            this.miSaveDb.Name = "miSaveDb";
            this.miSaveDb.Size = new System.Drawing.Size(173, 34);
            this.miSaveDb.Text = "Save";
            this.miSaveDb.Click += new System.EventHandler(this.miSaveDb_Click);
            // 
            // miSaveAsDb
            // 
            this.miSaveAsDb.Name = "miSaveAsDb";
            this.miSaveAsDb.Size = new System.Drawing.Size(173, 34);
            this.miSaveAsDb.Text = "Save as";
            this.miSaveAsDb.Click += new System.EventHandler(this.miSaveAsDb_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // miExitDb
            // 
            this.miExitDb.Name = "miExitDb";
            this.miExitDb.Size = new System.Drawing.Size(173, 34);
            this.miExitDb.Text = "Exit";
            this.miExitDb.Click += new System.EventHandler(this.miExitDb_Click);
            // 
            // tbNativeWord
            // 
            this.tbNativeWord.Enabled = false;
            this.tbNativeWord.Location = new System.Drawing.Point(24, 90);
            this.tbNativeWord.Name = "tbNativeWord";
            this.tbNativeWord.Size = new System.Drawing.Size(392, 26);
            this.tbNativeWord.TabIndex = 1;
            // 
            // tbForeignWord
            // 
            this.tbForeignWord.Enabled = false;
            this.tbForeignWord.Location = new System.Drawing.Point(433, 90);
            this.tbForeignWord.Multiline = true;
            this.tbForeignWord.Name = "tbForeignWord";
            this.tbForeignWord.Size = new System.Drawing.Size(332, 220);
            this.tbForeignWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Слово на русском";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Перевод слова";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnSaveInDb,
            this.bnDeleteFromDb,
            this.bnAddToDb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 327);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 34);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bnSaveInDb
            // 
            this.bnSaveInDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnSaveInDb.Enabled = false;
            this.bnSaveInDb.Image = ((System.Drawing.Image)(resources.GetObject("bnSaveInDb.Image")));
            this.bnSaveInDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnSaveInDb.Name = "bnSaveInDb";
            this.bnSaveInDb.Size = new System.Drawing.Size(102, 29);
            this.bnSaveInDb.Text = "Сохранить";
            this.bnSaveInDb.Click += new System.EventHandler(this.bnSaveInDb_Click);
            // 
            // bnDeleteFromDb
            // 
            this.bnDeleteFromDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnDeleteFromDb.Enabled = false;
            this.bnDeleteFromDb.Image = ((System.Drawing.Image)(resources.GetObject("bnDeleteFromDb.Image")));
            this.bnDeleteFromDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnDeleteFromDb.Name = "bnDeleteFromDb";
            this.bnDeleteFromDb.Size = new System.Drawing.Size(80, 29);
            this.bnDeleteFromDb.Text = "Удалить";
            this.bnDeleteFromDb.Click += new System.EventHandler(this.bnDeleteFromDb_Click);
            // 
            // bnAddToDb
            // 
            this.bnAddToDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnAddToDb.Enabled = false;
            this.bnAddToDb.Image = ((System.Drawing.Image)(resources.GetObject("bnAddToDb.Image")));
            this.bnAddToDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnAddToDb.Name = "bnAddToDb";
            this.bnAddToDb.Size = new System.Drawing.Size(94, 29);
            this.bnAddToDb.Text = "Добавить";
            this.bnAddToDb.Click += new System.EventHandler(this.bnAddToDb_Click);
            // 
            // nmWordNumber
            // 
            this.nmWordNumber.Enabled = false;
            this.nmWordNumber.Location = new System.Drawing.Point(420, 335);
            this.nmWordNumber.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmWordNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmWordNumber.Name = "nmWordNumber";
            this.nmWordNumber.Size = new System.Drawing.Size(120, 26);
            this.nmWordNumber.TabIndex = 9;
            this.nmWordNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmWordNumber.ValueChanged += new System.EventHandler(this.nmWordNumber_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 361);
            this.Controls.Add(this.nmWordNumber);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbForeignWord);
            this.Controls.Add(this.tbNativeWord);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Требуется загрузить или сохранить новую базу данных";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmWordNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpenDb;
        private System.Windows.Forms.ToolStripMenuItem miNewDb;
        private System.Windows.Forms.ToolStripMenuItem miSaveDb;
        private System.Windows.Forms.ToolStripMenuItem miSaveAsDb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExitDb;
        private System.Windows.Forms.TextBox tbNativeWord;
        private System.Windows.Forms.TextBox tbForeignWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bnSaveInDb;
        private System.Windows.Forms.ToolStripButton bnDeleteFromDb;
        private System.Windows.Forms.ToolStripButton bnAddToDb;
        private System.Windows.Forms.NumericUpDown nmWordNumber;
    }
}

