namespace TextAnalyzer
{
    partial class Analyzer
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
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.lbResults = new System.Windows.Forms.ListView();
            this.Letter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.AccessibleName = "btnAnalyze";
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Location = new System.Drawing.Point(53, 297);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(283, 23);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblResults
            // 
            this.lblResults.AccessibleName = "";
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(324, -27);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results:";
            // 
            // lblText
            // 
            this.lblText.AccessibleName = "lblText";
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(13, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(102, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Enter your text here:";
            // 
            // txtInput
            // 
            this.txtInput.AccessibleDescription = "";
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(13, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(354, 263);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "";
            // 
            // lbResults
            // 
            this.lbResults.AccessibleName = "lbResults";
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Letter,
            this.Count});
            this.lbResults.Location = new System.Drawing.Point(407, 30);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(201, 290);
            this.lbResults.TabIndex = 4;
            this.lbResults.UseCompatibleStateImageBehavior = false;
            this.lbResults.View = System.Windows.Forms.View.List;
            // 
            // Letter
            // 
            this.Letter.DisplayIndex = 1;
            this.Letter.Text = "Letter";
            // 
            // Count
            // 
            this.Count.DisplayIndex = 0;
            this.Count.Text = "Count";
            // 
            // Analyzer
            // 
            this.AccessibleDescription = "frmAnalyzer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 334);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnAnalyze);
            this.Name = "Analyzer";
            this.Text = "Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.ListView lbResults;
        private System.Windows.Forms.ColumnHeader Letter;
        private System.Windows.Forms.ColumnHeader Count;
    }
}

