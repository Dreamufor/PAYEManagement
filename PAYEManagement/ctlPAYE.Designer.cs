namespace PAYEManagement
{
    partial class ctlPAYE
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlPAYE));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvPAYE = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPAYE = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtKW = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIRD = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblIRD = new System.Windows.Forms.Label();
            this.lstEm = new System.Windows.Forms.ListBox();
            this.pnlAddRecord = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.prtPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.prtInvoice = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPAYE)).BeginInit();
            this.pnlAddRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(879, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 52);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(585, 346);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 52);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(318, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 52);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(40, 343);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 52);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create New PAYE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvPAYE
            // 
            this.dgvPAYE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPAYE.Location = new System.Drawing.Point(40, 33);
            this.dgvPAYE.Name = "dgvPAYE";
            this.dgvPAYE.Size = new System.Drawing.Size(1039, 281);
            this.dgvPAYE.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(231, 304);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(108, 23);
            this.btnAddRecord.TabIndex = 74;
            this.btnAddRecord.Text = "Add To Sheet";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Net Pay :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Kiwisaver :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Student Loan :";
            // 
            // txtPAYE
            // 
            this.txtPAYE.Location = new System.Drawing.Point(352, 178);
            this.txtPAYE.Name = "txtPAYE";
            this.txtPAYE.Size = new System.Drawing.Size(100, 20);
            this.txtPAYE.TabIndex = 70;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(352, 204);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 20);
            this.txtSL.TabIndex = 69;
            // 
            // txtKW
            // 
            this.txtKW.Location = new System.Drawing.Point(352, 230);
            this.txtKW.Name = "txtKW";
            this.txtKW.Size = new System.Drawing.Size(100, 20);
            this.txtKW.TabIndex = 68;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(352, 256);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(100, 20);
            this.txtNet.TabIndex = 67;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(352, 152);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "PAYE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Hours :";
            // 
            // txtIRD
            // 
            this.txtIRD.Location = new System.Drawing.Point(352, 100);
            this.txtIRD.Name = "txtIRD";
            this.txtIRD.ReadOnly = true;
            this.txtIRD.Size = new System.Drawing.Size(100, 20);
            this.txtIRD.TabIndex = 57;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(352, 48);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 56;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(223, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(108, 20);
            this.lblID.TabIndex = 50;
            this.lblID.Text = "Employee ID :";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(352, 74);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 58;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(352, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 55;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(237, 46);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(94, 20);
            this.lblLast.TabIndex = 51;
            this.lblLast.Text = "Last Name :";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(352, 126);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 59;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(237, 74);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(94, 20);
            this.lblFirst.TabIndex = 52;
            this.lblFirst.Text = "First Name :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(247, 126);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(84, 20);
            this.lblTax.TabIndex = 54;
            this.lblTax.Text = "Tax Code :";
            // 
            // lblIRD
            // 
            this.lblIRD.AutoSize = true;
            this.lblIRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRD.Location = new System.Drawing.Point(227, 100);
            this.lblIRD.Name = "lblIRD";
            this.lblIRD.Size = new System.Drawing.Size(104, 20);
            this.lblIRD.TabIndex = 53;
            this.lblIRD.Text = "IRD number :";
            // 
            // lstEm
            // 
            this.lstEm.FormattingEnabled = true;
            this.lstEm.Location = new System.Drawing.Point(20, 16);
            this.lstEm.Name = "lstEm";
            this.lstEm.Size = new System.Drawing.Size(191, 329);
            this.lstEm.TabIndex = 0;
            this.lstEm.SelectedIndexChanged += new System.EventHandler(this.lstEm_SelectedIndexChanged);
            // 
            // pnlAddRecord
            // 
            this.pnlAddRecord.Controls.Add(this.btnCancel);
            this.pnlAddRecord.Controls.Add(this.btnAddRecord);
            this.pnlAddRecord.Controls.Add(this.label3);
            this.pnlAddRecord.Controls.Add(this.label5);
            this.pnlAddRecord.Controls.Add(this.label6);
            this.pnlAddRecord.Controls.Add(this.txtPAYE);
            this.pnlAddRecord.Controls.Add(this.txtSL);
            this.pnlAddRecord.Controls.Add(this.txtKW);
            this.pnlAddRecord.Controls.Add(this.txtNet);
            this.pnlAddRecord.Controls.Add(this.txtHours);
            this.pnlAddRecord.Controls.Add(this.label4);
            this.pnlAddRecord.Controls.Add(this.label2);
            this.pnlAddRecord.Controls.Add(this.label1);
            this.pnlAddRecord.Controls.Add(this.txtIRD);
            this.pnlAddRecord.Controls.Add(this.txtLast);
            this.pnlAddRecord.Controls.Add(this.lblID);
            this.pnlAddRecord.Controls.Add(this.txtFirst);
            this.pnlAddRecord.Controls.Add(this.txtID);
            this.pnlAddRecord.Controls.Add(this.lblLast);
            this.pnlAddRecord.Controls.Add(this.txtCode);
            this.pnlAddRecord.Controls.Add(this.lblFirst);
            this.pnlAddRecord.Controls.Add(this.lblTax);
            this.pnlAddRecord.Controls.Add(this.lblIRD);
            this.pnlAddRecord.Controls.Add(this.lstEm);
            this.pnlAddRecord.Location = new System.Drawing.Point(310, 16);
            this.pnlAddRecord.Name = "pnlAddRecord";
            this.pnlAddRecord.Size = new System.Drawing.Size(475, 382);
            this.pnlAddRecord.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 63;
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
            // prtInvoice
            // 
            this.prtInvoice.DocumentName = "";
            this.prtInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoice);
            // 
            // ctlPAYE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAddRecord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvPAYE);
            this.Controls.Add(this.btnDelete);
            this.Name = "ctlPAYE";
            this.Size = new System.Drawing.Size(1128, 454);
            this.Click += new System.EventHandler(this.btnCancel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPAYE)).EndInit();
            this.pnlAddRecord.ResumeLayout(false);
            this.pnlAddRecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvPAYE;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPAYE;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtKW;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIRD;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblIRD;
        private System.Windows.Forms.ListBox lstEm;
        private System.Windows.Forms.Panel pnlAddRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintPreviewDialog prtPreview;
        private System.Drawing.Printing.PrintDocument prtInvoice;
    }
}
