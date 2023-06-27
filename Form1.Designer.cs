namespace winFileAccess
{
    partial class Form1
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
            btnReadText = new System.Windows.Forms.Button();
            btnReadWordDoc = new System.Windows.Forms.Button();
            btnReadExcel = new System.Windows.Forms.Button();
            btnReadPDF = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnReadText
            // 
            btnReadText.Location = new System.Drawing.Point(316, 80);
            btnReadText.Name = "btnReadText";
            btnReadText.Size = new System.Drawing.Size(97, 23);
            btnReadText.TabIndex = 0;
            btnReadText.Text = "Read Text File";
            btnReadText.UseVisualStyleBackColor = true;
            // 
            // btnReadWordDoc
            // 
            btnReadWordDoc.Location = new System.Drawing.Point(316, 124);
            btnReadWordDoc.Name = "btnReadWordDoc";
            btnReadWordDoc.Size = new System.Drawing.Size(97, 23);
            btnReadWordDoc.TabIndex = 1;
            btnReadWordDoc.Text = "Read Word Doc";
            btnReadWordDoc.UseVisualStyleBackColor = true;
            // 
            // btnReadExcel
            // 
            btnReadExcel.Location = new System.Drawing.Point(316, 168);
            btnReadExcel.Name = "btnReadExcel";
            btnReadExcel.Size = new System.Drawing.Size(97, 23);
            btnReadExcel.TabIndex = 2;
            btnReadExcel.Text = "Read Excel File";
            btnReadExcel.UseVisualStyleBackColor = true;
            // 
            // btnReadPDF
            // 
            btnReadPDF.Location = new System.Drawing.Point(316, 212);
            btnReadPDF.Name = "btnReadPDF";
            btnReadPDF.Size = new System.Drawing.Size(97, 23);
            btnReadPDF.TabIndex = 3;
            btnReadPDF.Text = "Read PDF File";
            btnReadPDF.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(316, 256);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(97, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnReadPDF);
            Controls.Add(btnReadExcel);
            Controls.Add(btnReadWordDoc);
            Controls.Add(btnReadText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnReadText;
        private System.Windows.Forms.Button btnReadWordDoc;
        private System.Windows.Forms.Button btnReadExcel;
        private System.Windows.Forms.Button btnReadPDF;
        private System.Windows.Forms.Button btnExit;
    }
}

