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
            System.Windows.Forms.ColumnHeader Letter;
            System.Windows.Forms.ColumnHeader Count;
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.lbResults = new System.Windows.Forms.ListView();
            Letter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.AccessibleName = "btnAnalyze";
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.Location = new System.Drawing.Point(134, 320);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(95, 38);
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
            this.lblResults.Location = new System.Drawing.Point(486, -213);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(70, 21);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results:";
            // 
            // lblText
            // 
            this.lblText.AccessibleName = "lblText";
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Yu Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(13, 9);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(273, 35);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Enter your text here:";
            // 
            // txtInput
            // 
            this.txtInput.AccessibleDescription = "";
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(13, 48);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(363, 264);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "";
            // 
            // lbResults
            // 
            this.lbResults.AccessibleName = "lbResults";
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Letter,
            Count});
            this.lbResults.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.Location = new System.Drawing.Point(397, 48);
            this.lbResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(163, 310);
            this.lbResults.TabIndex = 4;
            this.lbResults.UseCompatibleStateImageBehavior = false;
            this.lbResults.View = System.Windows.Forms.View.Details;
            // 
            // Letter
            // 
            Letter.Text = "Letter";
            Letter.Width = 65;
            // 
            // Count
            // 
            Count.Text = "Count";
            Count.Width = 65;
            // 
            // Analyzer
            // 
            this.AccessibleDescription = "frmAnalyzer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 371);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnAnalyze);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

