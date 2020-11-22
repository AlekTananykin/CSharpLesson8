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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenDb = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewDb = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveDb = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAsDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExitDb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
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
            this.miOpenDb.Size = new System.Drawing.Size(270, 34);
            this.miOpenDb.Text = "Open";
            this.miOpenDb.Click += new System.EventHandler(this.miOpenDb_Click);
            // 
            // miNewDb
            // 
            this.miNewDb.Name = "miNewDb";
            this.miNewDb.Size = new System.Drawing.Size(270, 34);
            this.miNewDb.Text = "New";
            this.miNewDb.Click += new System.EventHandler(this.miNewDb_Click);
            // 
            // miSaveDb
            // 
            this.miSaveDb.Name = "miSaveDb";
            this.miSaveDb.Size = new System.Drawing.Size(270, 34);
            this.miSaveDb.Text = "Save";
            this.miSaveDb.Click += new System.EventHandler(this.miSaveDb_Click);
            // 
            // miSaveAsDb
            // 
            this.miSaveAsDb.Name = "miSaveAsDb";
            this.miSaveAsDb.Size = new System.Drawing.Size(270, 34);
            this.miSaveAsDb.Text = "Save as";
            this.miSaveAsDb.Click += new System.EventHandler(this.miSaveAsDb_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // miExitDb
            // 
            this.miExitDb.Name = "miExitDb";
            this.miExitDb.Size = new System.Drawing.Size(270, 34);
            this.miExitDb.Text = "Exit";
            this.miExitDb.Click += new System.EventHandler(this.miExitDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

