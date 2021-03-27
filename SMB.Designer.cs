
namespace LetovoProject
{
    partial class SMB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMB));
            this.MessageBoxText = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.MessageBoxH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageBoxText
            // 
            this.MessageBoxText.Font = new System.Drawing.Font("Gardens CM", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageBoxText.ForeColor = System.Drawing.Color.Coral;
            this.MessageBoxText.Location = new System.Drawing.Point(12, 59);
            this.MessageBoxText.Name = "MessageBoxText";
            this.MessageBoxText.Size = new System.Drawing.Size(634, 213);
            this.MessageBoxText.TabIndex = 0;
            this.MessageBoxText.Text = "Я всё равно текст передаю в аргументах.\r\nА вообще молодцы, что смотрите!\r\n";
            // 
            // OK_Button
            // 
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Button.Font = new System.Drawing.Font("Gardens CM", 16F);
            this.OK_Button.ForeColor = System.Drawing.Color.Coral;
            this.OK_Button.Location = new System.Drawing.Point(12, 275);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(634, 52);
            this.OK_Button.TabIndex = 2;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // MessageBoxH
            // 
            this.MessageBoxH.Font = new System.Drawing.Font("Gardens CM", 24F);
            this.MessageBoxH.ForeColor = System.Drawing.Color.Coral;
            this.MessageBoxH.Location = new System.Drawing.Point(12, 13);
            this.MessageBoxH.Name = "MessageBoxH";
            this.MessageBoxH.Size = new System.Drawing.Size(634, 43);
            this.MessageBoxH.TabIndex = 3;
            this.MessageBoxH.Text = "Зачем?";
            this.MessageBoxH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(658, 339);
            this.Controls.Add(this.MessageBoxH);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.MessageBoxText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра в спички";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageBoxText;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Label MessageBoxH;
    }
}