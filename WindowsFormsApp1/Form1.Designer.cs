namespace WindowsFormsApp1
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
            this.FileNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FileText = new System.Windows.Forms.RichTextBox();
            this.EncryptedText = new System.Windows.Forms.RichTextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileNameText
            // 
            this.FileNameText.Location = new System.Drawing.Point(56, 45);
            this.FileNameText.Multiline = true;
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(540, 42);
            this.FileNameText.TabIndex = 0;
            this.FileNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "AES Encryption";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.Location = new System.Drawing.Point(621, 45);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(92, 42);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text to Encrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text Decrypt ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FileText
            // 
            this.FileText.Location = new System.Drawing.Point(56, 141);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(257, 217);
            this.FileText.TabIndex = 5;
            this.FileText.Text = "";
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(456, 141);
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.Size = new System.Drawing.Size(257, 217);
            this.EncryptedText.TabIndex = 6;
            this.EncryptedText.Text = "";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(221, 364);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(92, 42);
            this.EncryptButton.TabIndex = 7;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.EncryptedText);
            this.Controls.Add(this.FileText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileNameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox FileText;
        private System.Windows.Forms.RichTextBox EncryptedText;
        private System.Windows.Forms.Button EncryptButton;
    }
}

