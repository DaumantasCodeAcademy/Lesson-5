namespace Winforms_KMI_skaiciuokle
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
            this.label2 = new System.Windows.Forms.Label();
            this.BodyMassTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculatedKmiTextBox = new System.Windows.Forms.TextBox();
            this.CalculateKmiButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConclusionsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mase (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ugis (m)";
            // 
            // BodyMassTextBox
            // 
            this.BodyMassTextBox.Location = new System.Drawing.Point(155, 35);
            this.BodyMassTextBox.Name = "BodyMassTextBox";
            this.BodyMassTextBox.Size = new System.Drawing.Size(100, 23);
            this.BodyMassTextBox.TabIndex = 2;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(155, 64);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.HeightTextBox.TabIndex = 3;
            // 
            // CalculatedKmiTextBox
            // 
            this.CalculatedKmiTextBox.Location = new System.Drawing.Point(392, 30);
            this.CalculatedKmiTextBox.Name = "CalculatedKmiTextBox";
            this.CalculatedKmiTextBox.ReadOnly = true;
            this.CalculatedKmiTextBox.Size = new System.Drawing.Size(209, 23);
            this.CalculatedKmiTextBox.TabIndex = 4;
            // 
            // CalculateKmiButton
            // 
            this.CalculateKmiButton.Location = new System.Drawing.Point(155, 102);
            this.CalculateKmiButton.Name = "CalculateKmiButton";
            this.CalculateKmiButton.Size = new System.Drawing.Size(100, 23);
            this.CalculateKmiButton.TabIndex = 5;
            this.CalculateKmiButton.Text = "Calculate KMI";
            this.CalculateKmiButton.UseVisualStyleBackColor = true;
            this.CalculateKmiButton.Click += new System.EventHandler(this.CalculateKmiButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "KMI";
            // 
            // ConclusionsTextBox
            // 
            this.ConclusionsTextBox.Location = new System.Drawing.Point(392, 59);
            this.ConclusionsTextBox.Multiline = true;
            this.ConclusionsTextBox.Name = "ConclusionsTextBox";
            this.ConclusionsTextBox.ReadOnly = true;
            this.ConclusionsTextBox.Size = new System.Drawing.Size(209, 66);
            this.ConclusionsTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Isvados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConclusionsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalculateKmiButton);
            this.Controls.Add(this.CalculatedKmiTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.BodyMassTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BodyMassTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox CalculatedKmiTextBox;
        private System.Windows.Forms.Button CalculateKmiButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConclusionsTextBox;
        private System.Windows.Forms.Label label4;
    }
}
