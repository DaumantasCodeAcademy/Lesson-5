namespace Winforms_globalus_kintamieji
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HeightInputBox = new System.Windows.Forms.TextBox();
            this.WeightInputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PutToArrayButton = new System.Windows.Forms.Button();
            this.ArrayDisplayTextBox = new System.Windows.Forms.TextBox();
            this.ShowArrayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ūgis";
            // 
            // HeightInputBox
            // 
            this.HeightInputBox.Location = new System.Drawing.Point(130, 44);
            this.HeightInputBox.Name = "HeightInputBox";
            this.HeightInputBox.Size = new System.Drawing.Size(100, 23);
            this.HeightInputBox.TabIndex = 1;
            // 
            // WeightInputBox
            // 
            this.WeightInputBox.Location = new System.Drawing.Point(130, 82);
            this.WeightInputBox.Name = "WeightInputBox";
            this.WeightInputBox.Size = new System.Drawing.Size(100, 23);
            this.WeightInputBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Svoris";
            // 
            // PutToArrayButton
            // 
            this.PutToArrayButton.Location = new System.Drawing.Point(81, 128);
            this.PutToArrayButton.Name = "PutToArrayButton";
            this.PutToArrayButton.Size = new System.Drawing.Size(149, 23);
            this.PutToArrayButton.TabIndex = 4;
            this.PutToArrayButton.Text = "Padėti į masyvą";
            this.PutToArrayButton.UseVisualStyleBackColor = true;
            this.PutToArrayButton.Click += new System.EventHandler(this.PutToArrayButton_Click);
            // 
            // ArrayDisplayTextBox
            // 
            this.ArrayDisplayTextBox.Location = new System.Drawing.Point(310, 43);
            this.ArrayDisplayTextBox.Multiline = true;
            this.ArrayDisplayTextBox.Name = "ArrayDisplayTextBox";
            this.ArrayDisplayTextBox.ReadOnly = true;
            this.ArrayDisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArrayDisplayTextBox.Size = new System.Drawing.Size(201, 62);
            this.ArrayDisplayTextBox.TabIndex = 5;
            // 
            // ShowArrayButton
            // 
            this.ShowArrayButton.Location = new System.Drawing.Point(310, 128);
            this.ShowArrayButton.Name = "ShowArrayButton";
            this.ShowArrayButton.Size = new System.Drawing.Size(201, 23);
            this.ShowArrayButton.TabIndex = 6;
            this.ShowArrayButton.Text = "Parodyti masyvą";
            this.ShowArrayButton.UseVisualStyleBackColor = true;
            this.ShowArrayButton.Click += new System.EventHandler(this.ShowArrayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowArrayButton);
            this.Controls.Add(this.ArrayDisplayTextBox);
            this.Controls.Add(this.PutToArrayButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeightInputBox);
            this.Controls.Add(this.HeightInputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HeightInputBox;
        private System.Windows.Forms.TextBox WeightInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PutToArrayButton;
        private System.Windows.Forms.TextBox ArrayDisplayTextBox;
        private System.Windows.Forms.Button ShowArrayButton;
    }
}
