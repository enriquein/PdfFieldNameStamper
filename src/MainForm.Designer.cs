namespace PdfFieldNameStamper
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputPdf = new System.Windows.Forms.TextBox();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputPdf = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnBeginProcess = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOwnerPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input PDF";
            // 
            // txtInputPdf
            // 
            this.txtInputPdf.AllowDrop = true;
            this.txtInputPdf.Location = new System.Drawing.Point(18, 26);
            this.txtInputPdf.Name = "txtInputPdf";
            this.txtInputPdf.Size = new System.Drawing.Size(505, 20);
            this.txtInputPdf.TabIndex = 1;
            this.txtInputPdf.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtInputPdf_OnDragDrop);
            this.txtInputPdf.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtInputPdf_OnDragEnter);
            this.txtInputPdf.DragOver += new System.Windows.Forms.DragEventHandler(this.txtInputPdf_OnDragOver);
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(526, 24);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseInput.TabIndex = 2;
            this.btnBrowseInput.Text = "...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output PDF";
            // 
            // txtOutputPdf
            // 
            this.txtOutputPdf.AllowDrop = true;
            this.txtOutputPdf.Location = new System.Drawing.Point(18, 72);
            this.txtOutputPdf.Name = "txtOutputPdf";
            this.txtOutputPdf.Size = new System.Drawing.Size(505, 20);
            this.txtOutputPdf.TabIndex = 4;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(526, 70);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnBeginProcess
            // 
            this.btnBeginProcess.Location = new System.Drawing.Point(463, 103);
            this.btnBeginProcess.Name = "btnBeginProcess";
            this.btnBeginProcess.Size = new System.Drawing.Size(93, 33);
            this.btnBeginProcess.TabIndex = 6;
            this.btnBeginProcess.Text = "Process";
            this.btnBeginProcess.UseVisualStyleBackColor = true;
            this.btnBeginProcess.Click += new System.EventHandler(this.btnBeginProcess_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(0, 142);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(568, 136);
            this.txtStatus.TabIndex = 7;
            // 
            // fileDialog
            // 
            this.fileDialog.SupportMultiDottedExtensions = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Owner/encryption password (if any)";
            // 
            // txtOwnerPassword
            // 
            this.txtOwnerPassword.Location = new System.Drawing.Point(18, 116);
            this.txtOwnerPassword.Name = "txtOwnerPassword";
            this.txtOwnerPassword.PasswordChar = '*';
            this.txtOwnerPassword.Size = new System.Drawing.Size(120, 20);
            this.txtOwnerPassword.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 278);
            this.Controls.Add(this.txtOwnerPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnBeginProcess);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtOutputPdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtInputPdf);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Fieldname Stamper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputPdf;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputPdf;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Button btnBeginProcess;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOwnerPassword;
    }
}

