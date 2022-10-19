namespace FileHandling
{
    partial class btnSearch
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.btnSearchText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter word (Case Sensitive):";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(345, 191);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(111, 27);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(345, 100);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(111, 20);
            this.txtInput.TabIndex = 3;
            // 
            // lblOutput2
            // 
            this.lblOutput2.Location = new System.Drawing.Point(104, 232);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(592, 191);
            this.lblOutput2.TabIndex = 4;
            this.lblOutput2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearchText
            // 
            this.btnSearchText.Location = new System.Drawing.Point(345, 138);
            this.btnSearchText.Name = "btnSearchText";
            this.btnSearchText.Size = new System.Drawing.Size(111, 50);
            this.btnSearchText.TabIndex = 5;
            this.btnSearchText.Text = "Search";
            this.btnSearchText.UseVisualStyleBackColor = true;
            this.btnSearchText.Click += new System.EventHandler(this.btnSearchText_Click);
            // 
            // btnSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchText);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Name = "btnSearch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Button btnSearchText;
        private System.Windows.Forms.Label lblOutput;
    }
}

