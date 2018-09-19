namespace PAYEManagement
{
    partial class ctlEmployee
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lstEm = new System.Windows.Forms.ListBox();
            this.txtIRD = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblIRD = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddIRD = new System.Windows.Forms.TextBox();
            this.txtAddLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddFirst = new System.Windows.Forms.TextBox();
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddNum = new System.Windows.Forms.TextBox();
            this.txtAddNick = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstEm
            // 
            this.lstEm.FormattingEnabled = true;
            this.lstEm.Location = new System.Drawing.Point(142, 86);
            this.lstEm.Name = "lstEm";
            this.lstEm.Size = new System.Drawing.Size(121, 277);
            this.lstEm.TabIndex = 57;
            this.lstEm.SelectedIndexChanged += new System.EventHandler(this.showSelectItem);
            // 
            // txtIRD
            // 
            this.txtIRD.Location = new System.Drawing.Point(451, 237);
            this.txtIRD.Name = "txtIRD";
            this.txtIRD.ReadOnly = true;
            this.txtIRD.Size = new System.Drawing.Size(100, 20);
            this.txtIRD.TabIndex = 66;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(276, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(451, 162);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 65;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(322, 86);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(108, 20);
            this.lblID.TabIndex = 58;
            this.lblID.Text = "Employee ID :";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(451, 199);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 67;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(382, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(451, 88);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 64;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(336, 160);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(94, 20);
            this.lblLast.TabIndex = 59;
            this.lblLast.Text = "Last Name :";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(451, 278);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 68;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(165, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(309, 314);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(121, 20);
            this.lblNumber.TabIndex = 63;
            this.lblNumber.Text = "Phone number :";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(336, 197);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(94, 20);
            this.lblFirst.TabIndex = 60;
            this.lblFirst.Text = "First Name :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(451, 316);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 69;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(451, 126);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(100, 20);
            this.txtNick.TabIndex = 71;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(346, 276);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(84, 20);
            this.lblTax.TabIndex = 62;
            this.lblTax.Text = "Tax Code :";
            // 
            // lblIRD
            // 
            this.lblIRD.AutoSize = true;
            this.lblIRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRD.Location = new System.Drawing.Point(326, 235);
            this.lblIRD.Name = "lblIRD";
            this.lblIRD.Size = new System.Drawing.Size(104, 20);
            this.lblIRD.TabIndex = 61;
            this.lblIRD.Text = "IRD number :";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNick.Location = new System.Drawing.Point(339, 124);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(91, 20);
            this.lblNick.TabIndex = 70;
            this.lblNick.Text = "Nick name :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(54, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 23);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Add  Employee";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddIRD
            // 
            this.txtAddIRD.Location = new System.Drawing.Point(192, 168);
            this.txtAddIRD.Name = "txtAddIRD";
            this.txtAddIRD.Size = new System.Drawing.Size(100, 20);
            this.txtAddIRD.TabIndex = 61;
            // 
            // txtAddLast
            // 
            this.txtAddLast.Location = new System.Drawing.Point(192, 93);
            this.txtAddLast.Name = "txtAddLast";
            this.txtAddLast.Size = new System.Drawing.Size(100, 20);
            this.txtAddLast.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Employee ID :";
            // 
            // txtAddFirst
            // 
            this.txtAddFirst.Location = new System.Drawing.Point(192, 130);
            this.txtAddFirst.Name = "txtAddFirst";
            this.txtAddFirst.Size = new System.Drawing.Size(100, 20);
            this.txtAddFirst.TabIndex = 62;
            // 
            // txtAddID
            // 
            this.txtAddID.Location = new System.Drawing.Point(192, 19);
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(100, 20);
            this.txtAddID.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Last Name :";
            // 
            // txtAddCode
            // 
            this.txtAddCode.Location = new System.Drawing.Point(192, 209);
            this.txtAddCode.Name = "txtAddCode";
            this.txtAddCode.Size = new System.Drawing.Size(100, 20);
            this.txtAddCode.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Phone number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "First Name :";
            // 
            // txtAddNum
            // 
            this.txtAddNum.Location = new System.Drawing.Point(192, 247);
            this.txtAddNum.Name = "txtAddNum";
            this.txtAddNum.Size = new System.Drawing.Size(100, 20);
            this.txtAddNum.TabIndex = 64;
            // 
            // txtAddNick
            // 
            this.txtAddNick.Location = new System.Drawing.Point(192, 57);
            this.txtAddNick.Name = "txtAddNick";
            this.txtAddNick.Size = new System.Drawing.Size(100, 20);
            this.txtAddNick.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tax Code :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "IRD number :";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnCancel);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.txtAddIRD);
            this.pnlAdd.Controls.Add(this.txtAddLast);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.txtAddFirst);
            this.pnlAdd.Controls.Add(this.txtAddID);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.txtAddCode);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.txtAddNum);
            this.pnlAdd.Controls.Add(this.txtAddNick);
            this.pnlAdd.Controls.Add(this.label5);
            this.pnlAdd.Controls.Add(this.label6);
            this.pnlAdd.Controls.Add(this.label7);
            this.pnlAdd.Location = new System.Drawing.Point(269, 68);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(342, 341);
            this.pnlAdd.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Nick name :";
            // 
            // ctlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstEm);
            this.Controls.Add(this.txtIRD);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblIRD);
            this.Controls.Add(this.lblNick);
            this.Name = "ctlEmployee";
            this.Size = new System.Drawing.Size(715, 494);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstEm;
        private System.Windows.Forms.TextBox txtIRD;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblIRD;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddIRD;
        private System.Windows.Forms.TextBox txtAddLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddFirst;
        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddNum;
        private System.Windows.Forms.TextBox txtAddNick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label7;
    }
}
