namespace Test
{
    partial class PAYEForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAYEForm));
            this.prtInvoice = new System.Drawing.Printing.PrintDocument();
            this.prtPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.ctlPAYE1 = new PAYEManagement.ctlPAYE();
            this.SuspendLayout();
            // 
            // prtInvoice
            // 
            this.prtInvoice.DocumentName = "";
            // 
            // prtPreview
            // 
            this.prtPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prtPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prtPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.prtPreview.Document = this.prtInvoice;
            this.prtPreview.Enabled = true;
            this.prtPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("prtPreview.Icon")));
            this.prtPreview.Name = "prtPreview";
            this.prtPreview.Visible = false;
            // 
            // ctlPAYE1
            // 
            this.ctlPAYE1.Location = new System.Drawing.Point(39, 12);
            this.ctlPAYE1.Name = "ctlPAYE1";
            this.ctlPAYE1.Size = new System.Drawing.Size(1082, 454);
            this.ctlPAYE1.TabIndex = 0;
            // 
            // PAYEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 451);
            this.Controls.Add(this.ctlPAYE1);
            this.Name = "PAYEForm";
            this.Text = "PAYEForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument prtInvoice;
        private System.Windows.Forms.PrintPreviewDialog prtPreview;
        private PAYEManagement.ctlPAYE ctlPAYE1;
    }
}