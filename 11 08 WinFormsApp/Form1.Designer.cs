namespace _11_08_WinFormsApp
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
            this.buttonUpper = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonLower = new System.Windows.Forms.Button();
            this.buttonTextShifter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUpper
            // 
            this.buttonUpper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpper.Location = new System.Drawing.Point(1132, 406);
            this.buttonUpper.Name = "buttonUpper";
            this.buttonUpper.Size = new System.Drawing.Size(218, 65);
            this.buttonUpper.TabIndex = 0;
            this.buttonUpper.Text = "Upper";
            this.buttonUpper.UseVisualStyleBackColor = true;
            this.buttonUpper.Click += new System.EventHandler(this.buttonUpper_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(1338, 388);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.Text = "hi im here";
            // 
            // buttonLower
            // 
            this.buttonLower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLower.Location = new System.Drawing.Point(908, 406);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(218, 65);
            this.buttonLower.TabIndex = 2;
            this.buttonLower.Text = "Lower";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Click += new System.EventHandler(this.buttonLower_Click);
            // 
            // buttonTextShifter
            // 
            this.buttonTextShifter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTextShifter.Location = new System.Drawing.Point(663, 406);
            this.buttonTextShifter.Name = "buttonTextShifter";
            this.buttonTextShifter.Size = new System.Drawing.Size(218, 65);
            this.buttonTextShifter.TabIndex = 3;
            this.buttonTextShifter.Text = " ";
            this.buttonTextShifter.UseVisualStyleBackColor = true;
            this.buttonTextShifter.Click += new System.EventHandler(this.buttonTextShifter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 483);
            this.Controls.Add(this.buttonTextShifter);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonUpper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpper;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonLower;
        private System.Windows.Forms.Button buttonTextShifter;
    }
}
