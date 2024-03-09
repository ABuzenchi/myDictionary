namespace Dictionary
{
    partial class NeexistCateg
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newCategoryBox = new System.Windows.Forms.TextBox();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.newDescriptionBox = new System.Windows.Forms.TextBox();
            this.newPhotoBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PhotoPath";
            // 
            // newCategoryBox
            // 
            this.newCategoryBox.Location = new System.Drawing.Point(178, 86);
            this.newCategoryBox.Name = "newCategoryBox";
            this.newCategoryBox.Size = new System.Drawing.Size(551, 22);
            this.newCategoryBox.TabIndex = 4;
            // 
            // newNameBox
            // 
            this.newNameBox.Location = new System.Drawing.Point(178, 138);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(551, 22);
            this.newNameBox.TabIndex = 5;
            // 
            // newDescriptionBox
            // 
            this.newDescriptionBox.Location = new System.Drawing.Point(178, 191);
            this.newDescriptionBox.Name = "newDescriptionBox";
            this.newDescriptionBox.Size = new System.Drawing.Size(551, 22);
            this.newDescriptionBox.TabIndex = 6;
            // 
            // newPhotoBox
            // 
            this.newPhotoBox.Location = new System.Drawing.Point(178, 250);
            this.newPhotoBox.Name = "newPhotoBox";
            this.newPhotoBox.Size = new System.Drawing.Size(551, 22);
            this.newPhotoBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(246, 321);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(300, 53);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NeexistCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newPhotoBox);
            this.Controls.Add(this.newDescriptionBox);
            this.Controls.Add(this.newNameBox);
            this.Controls.Add(this.newCategoryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NeexistCateg";
            this.Text = "NeexistCateg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newCategoryBox;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.TextBox newDescriptionBox;
        private System.Windows.Forms.TextBox newPhotoBox;
        private System.Windows.Forms.Button addButton;
    }
}