
namespace LetovoProject
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.Matches_Image = new System.Windows.Forms.PictureBox();
            this.Take_Label = new System.Windows.Forms.Label();
            this.Take_Textbox = new System.Windows.Forms.TextBox();
            this.Take_Button = new System.Windows.Forms.Button();
            this.Now_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Matches_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Coral;
            this.ExitButton.Location = new System.Drawing.Point(1219, 12);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(51, 50);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Matches_Image
            // 
            this.Matches_Image.Image = ((System.Drawing.Image)(resources.GetObject("Matches_Image.Image")));
            this.Matches_Image.Location = new System.Drawing.Point(12, 12);
            this.Matches_Image.Name = "Matches_Image";
            this.Matches_Image.Size = new System.Drawing.Size(800, 600);
            this.Matches_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Matches_Image.TabIndex = 1;
            this.Matches_Image.TabStop = false;
            // 
            // Take_Label
            // 
            this.Take_Label.Font = new System.Drawing.Font("Gardens CM", 18F);
            this.Take_Label.ForeColor = System.Drawing.Color.Coral;
            this.Take_Label.Location = new System.Drawing.Point(842, 191);
            this.Take_Label.Name = "Take_Label";
            this.Take_Label.Size = new System.Drawing.Size(428, 36);
            this.Take_Label.TabIndex = 2;
            this.Take_Label.Text = "Сколько брать?";
            this.Take_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Take_Textbox
            // 
            this.Take_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Take_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Take_Textbox.Font = new System.Drawing.Font("Gardens CM", 18F);
            this.Take_Textbox.ForeColor = System.Drawing.Color.Coral;
            this.Take_Textbox.Location = new System.Drawing.Point(840, 230);
            this.Take_Textbox.Name = "Take_Textbox";
            this.Take_Textbox.Size = new System.Drawing.Size(430, 33);
            this.Take_Textbox.TabIndex = 3;
            this.Take_Textbox.Text = "5";
            this.Take_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Take_Button
            // 
            this.Take_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Take_Button.Font = new System.Drawing.Font("Gardens CM", 24F);
            this.Take_Button.ForeColor = System.Drawing.Color.Coral;
            this.Take_Button.Location = new System.Drawing.Point(846, 299);
            this.Take_Button.Name = "Take_Button";
            this.Take_Button.Size = new System.Drawing.Size(424, 171);
            this.Take_Button.TabIndex = 4;
            this.Take_Button.Text = "Взять";
            this.Take_Button.UseVisualStyleBackColor = true;
            this.Take_Button.Click += new System.EventHandler(this.Take_Button_Click);
            // 
            // Now_Label
            // 
            this.Now_Label.Font = new System.Drawing.Font("Gardens CM", 18F);
            this.Now_Label.ForeColor = System.Drawing.Color.Coral;
            this.Now_Label.Location = new System.Drawing.Point(842, 137);
            this.Now_Label.Name = "Now_Label";
            this.Now_Label.Size = new System.Drawing.Size(428, 36);
            this.Now_Label.TabIndex = 5;
            this.Now_Label.Text = "Сейчас n лепестков";
            this.Now_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Now_Label);
            this.Controls.Add(this.Take_Button);
            this.Controls.Add(this.Take_Textbox);
            this.Controls.Add(this.Take_Label);
            this.Controls.Add(this.Matches_Image);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра в спички";
            ((System.ComponentModel.ISupportInitialize)(this.Matches_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox Matches_Image;
        private System.Windows.Forms.Label Take_Label;
        private System.Windows.Forms.TextBox Take_Textbox;
        private System.Windows.Forms.Button Take_Button;
        private System.Windows.Forms.Label Now_Label;
    }
}