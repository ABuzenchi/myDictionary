namespace Dictionary
{
    partial class ExistCategory
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
            this.categBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newNBox = new System.Windows.Forms.TextBox();
            this.newDBox = new System.Windows.Forms.TextBox();
            this.newPBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categBox
            // 
            this.categBox.FormattingEnabled = true;
            this.categBox.Location = new System.Drawing.Point(114, 149);
            this.categBox.Name = "categBox";
            this.categBox.Size = new System.Drawing.Size(121, 24);
            this.categBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "photoPath";
            // 
            // newNBox
            // 
            this.newNBox.Location = new System.Drawing.Point(177, 198);
            this.newNBox.Name = "newNBox";
            this.newNBox.Size = new System.Drawing.Size(100, 22);
            this.newNBox.TabIndex = 4;
            // 
            // newDBox
            // 
            this.newDBox.Location = new System.Drawing.Point(185, 243);
            this.newDBox.Name = "newDBox";
            this.newDBox.Size = new System.Drawing.Size(100, 22);
            this.newDBox.TabIndex = 5;
            // 
            // newPBox
            // 
            this.newPBox.Location = new System.Drawing.Point(192, 289);
            this.newPBox.Name = "newPBox";
            this.newPBox.Size = new System.Drawing.Size(100, 22);
            this.newPBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(120, 339);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "adauga";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ExistCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 462);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newPBox);
            this.Controls.Add(this.newDBox);
            this.Controls.Add(this.newNBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categBox);
            this.Name = "ExistCategory";
            this.Text = "ExistCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newNBox;
        private System.Windows.Forms.TextBox newDBox;
        private System.Windows.Forms.TextBox newPBox;
        private System.Windows.Forms.Button addButton;
    }
}