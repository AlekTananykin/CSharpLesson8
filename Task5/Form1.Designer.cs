namespace Task5
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
            this.components = new System.ComponentModel.Container();
            this.tbCsvFilePath = new System.Windows.Forms.TextBox();
            this.tbXmlFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnTransform = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbCsvFilePath
            // 
            this.tbCsvFilePath.BackColor = System.Drawing.Color.White;
            this.tbCsvFilePath.Location = new System.Drawing.Point(236, 93);
            this.tbCsvFilePath.Name = "tbCsvFilePath";
            this.tbCsvFilePath.ReadOnly = true;
            this.tbCsvFilePath.Size = new System.Drawing.Size(364, 26);
            this.tbCsvFilePath.TabIndex = 0;
            this.tbCsvFilePath.DoubleClick += new System.EventHandler(this.tbCsvFilePath_DoubleClick);
            // 
            // tbXmlFilePath
            // 
            this.tbXmlFilePath.BackColor = System.Drawing.Color.White;
            this.tbXmlFilePath.Location = new System.Drawing.Point(236, 142);
            this.tbXmlFilePath.Name = "tbXmlFilePath";
            this.tbXmlFilePath.ReadOnly = true;
            this.tbXmlFilePath.Size = new System.Drawing.Size(364, 26);
            this.tbXmlFilePath.TabIndex = 1;
            this.tbXmlFilePath.DoubleClick += new System.EventHandler(this.tbXmlFilePath_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файл в формате CSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Файл в формате XML";
            // 
            // bnTransform
            // 
            this.bnTransform.Location = new System.Drawing.Point(420, 199);
            this.bnTransform.Name = "bnTransform";
            this.bnTransform.Size = new System.Drawing.Size(180, 53);
            this.bnTransform.TabIndex = 4;
            this.bnTransform.Text = "Преобразовать";
            this.bnTransform.UseVisualStyleBackColor = true;
            this.bnTransform.Click += new System.EventHandler(this.bnTransform_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Преобразование файла со студентами из формата CSV в формат  XML";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnTransform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbXmlFilePath);
            this.Controls.Add(this.tbCsvFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = this._applicationName;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCsvFilePath;
        private System.Windows.Forms.TextBox tbXmlFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnTransform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;

        private readonly string _applicationName =
            "Программа конвертирования списка студентов";
    }
}

