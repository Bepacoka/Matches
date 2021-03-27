
namespace LetovoProject
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.N_Label = new System.Windows.Forms.Label();
            this.N_Textbox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.K_Label = new System.Windows.Forms.Label();
            this.K_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Coral;
            this.ExitButton.Location = new System.Drawing.Point(1218, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 50);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // N_Label
            // 
            this.N_Label.Font = new System.Drawing.Font("Gardens CM", 18F);
            this.N_Label.ForeColor = System.Drawing.Color.Coral;
            this.N_Label.Location = new System.Drawing.Point(4, 192);
            this.N_Label.Name = "N_Label";
            this.N_Label.Size = new System.Drawing.Size(1264, 32);
            this.N_Label.TabIndex = 1;
            this.N_Label.Text = "Сколько всего спичек?";
            this.N_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N_Textbox
            // 
            this.N_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.N_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.N_Textbox.Font = new System.Drawing.Font("Gardens CM", 24F);
            this.N_Textbox.ForeColor = System.Drawing.Color.Coral;
            this.N_Textbox.Location = new System.Drawing.Point(12, 265);
            this.N_Textbox.Name = "N_Textbox";
            this.N_Textbox.Size = new System.Drawing.Size(1256, 44);
            this.N_Textbox.TabIndex = 2;
            this.N_Textbox.Text = "25";
            this.N_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Gardens CM", 24F);
            this.StartButton.ForeColor = System.Drawing.Color.Coral;
            this.StartButton.Location = new System.Drawing.Point(515, 540);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(250, 120);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // K_Label
            // 
            this.K_Label.Font = new System.Drawing.Font("Gardens CM", 18F);
            this.K_Label.ForeColor = System.Drawing.Color.Coral;
            this.K_Label.Location = new System.Drawing.Point(12, 344);
            this.K_Label.Name = "K_Label";
            this.K_Label.Size = new System.Drawing.Size(1256, 32);
            this.K_Label.TabIndex = 6;
            this.K_Label.Text = "До скольки можно брать?";
            this.K_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // K_Textbox
            // 
            this.K_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.K_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.K_Textbox.Font = new System.Drawing.Font("Gardens CM", 24F);
            this.K_Textbox.ForeColor = System.Drawing.Color.Coral;
            this.K_Textbox.Location = new System.Drawing.Point(12, 417);
            this.K_Textbox.Name = "K_Textbox";
            this.K_Textbox.Size = new System.Drawing.Size(1256, 44);
            this.K_Textbox.TabIndex = 7;
            this.K_Textbox.Text = "5";
            this.K_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.K_Textbox);
            this.Controls.Add(this.K_Label);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.N_Textbox);
            this.Controls.Add(this.N_Label);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра в спички";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label N_Label;
        private System.Windows.Forms.TextBox N_Textbox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label K_Label;
        private System.Windows.Forms.TextBox K_Textbox;
    }
}