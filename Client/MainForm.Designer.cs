namespace Client
{
    partial class MainForm
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
            this.input = new System.Windows.Forms.TextBox();
            this.output1 = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.output2 = new System.Windows.Forms.RichTextBox();
            this.output3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(28, 26);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(210, 31);
            this.input.TabIndex = 0;
            // 
            // output1
            // 
            this.output1.Location = new System.Drawing.Point(28, 80);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(471, 776);
            this.output1.TabIndex = 1;
            this.output1.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(262, 26);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(205, 48);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // output2
            // 
            this.output2.Location = new System.Drawing.Point(505, 80);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(471, 776);
            this.output2.TabIndex = 5;
            this.output2.Text = "";
            // 
            // output3
            // 
            this.output3.Location = new System.Drawing.Point(982, 80);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(471, 776);
            this.output3.TabIndex = 6;
            this.output3.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 872);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.input);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox output2;
        private System.Windows.Forms.RichTextBox output3;

        private System.Windows.Forms.Button sendButton;

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.RichTextBox output1;

        #endregion
    }
}