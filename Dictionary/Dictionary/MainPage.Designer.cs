namespace Dictionary
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Dictionary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(642, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hey, nice to see you! Are you a standard user or an admin today?";
            // 
            // userButton
            // 
            this.userButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userButton.Location = new System.Drawing.Point(147, 273);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(143, 40);
            this.userButton.TabIndex = 2;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(510, 273);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(106, 43);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button adminButton;
    }
}

