namespace RandomNumberArray
{
    partial class frmRandomNumberArray
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
            this.btnFind = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblSmallestNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(101, 226);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(76, 65);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstNumbers.TabIndex = 1;
            // 
            // lblSmallestNumber
            // 
            this.lblSmallestNumber.AutoSize = true;
            this.lblSmallestNumber.Location = new System.Drawing.Point(25, 178);
            this.lblSmallestNumber.Name = "lblSmallestNumber";
            this.lblSmallestNumber.Size = new System.Drawing.Size(0, 13);
            this.lblSmallestNumber.TabIndex = 2;
            // 
            // frmRandomNumberArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSmallestNumber);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnFind);
            this.Name = "frmRandomNumberArray";
            this.Text = "RandomNumberArray";
            this.Load += new System.EventHandler(this.frmRandomNumberArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblSmallestNumber;
    }
}

