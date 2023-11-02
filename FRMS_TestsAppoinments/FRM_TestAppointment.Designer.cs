namespace DVLD_Projet.FRMS_TestsAppoinments
{
    partial class FRM_TestAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TestAppointment));
            this.Image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainerLocalApp = new System.Windows.Forms.Panel();
            this.pnlContainerApp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_L_D_L_AppID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.linkLblShowLicense = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAppId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblStatusDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.pnlContainerLocalApp.SuspendLayout();
            this.pnlContainerApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
            this.Image.ImageRotate = 0F;
            this.Image.Location = new System.Drawing.Point(343, 3);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(167, 106);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(298, 112);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Vesion Test Appointment";
            // 
            // pnlContainerLocalApp
            // 
            this.pnlContainerLocalApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainerLocalApp.Controls.Add(this.linkLblShowLicense);
            this.pnlContainerLocalApp.Controls.Add(this.lblPassedTests);
            this.pnlContainerLocalApp.Controls.Add(this.lblClassName);
            this.pnlContainerLocalApp.Controls.Add(this.label3);
            this.pnlContainerLocalApp.Controls.Add(this.label2);
            this.pnlContainerLocalApp.Controls.Add(this.lbl_L_D_L_AppID);
            this.pnlContainerLocalApp.Controls.Add(this.label1);
            this.pnlContainerLocalApp.Location = new System.Drawing.Point(53, 143);
            this.pnlContainerLocalApp.Name = "pnlContainerLocalApp";
            this.pnlContainerLocalApp.Size = new System.Drawing.Size(739, 85);
            this.pnlContainerLocalApp.TabIndex = 2;
            // 
            // pnlContainerApp
            // 
            this.pnlContainerApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainerApp.Controls.Add(this.lblCreatedBy);
            this.pnlContainerApp.Controls.Add(this.lblStatusDate);
            this.pnlContainerApp.Controls.Add(this.lblDate);
            this.pnlContainerApp.Controls.Add(this.label11);
            this.pnlContainerApp.Controls.Add(this.label13);
            this.pnlContainerApp.Controls.Add(this.label14);
            this.pnlContainerApp.Controls.Add(this.lblApplicant);
            this.pnlContainerApp.Controls.Add(this.label12);
            this.pnlContainerApp.Controls.Add(this.lblType);
            this.pnlContainerApp.Controls.Add(this.lblFees);
            this.pnlContainerApp.Controls.Add(this.lblStatus);
            this.pnlContainerApp.Controls.Add(this.lblAppId);
            this.pnlContainerApp.Controls.Add(this.label9);
            this.pnlContainerApp.Controls.Add(this.label7);
            this.pnlContainerApp.Controls.Add(this.label5);
            this.pnlContainerApp.Controls.Add(this.label4);
            this.pnlContainerApp.Location = new System.Drawing.Point(53, 240);
            this.pnlContainerApp.Name = "pnlContainerApp";
            this.pnlContainerApp.Size = new System.Drawing.Size(739, 145);
            this.pnlContainerApp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "L.D.L App ID : ";
            // 
            // lbl_L_D_L_AppID
            // 
            this.lbl_L_D_L_AppID.AutoSize = true;
            this.lbl_L_D_L_AppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_L_D_L_AppID.ForeColor = System.Drawing.Color.Black;
            this.lbl_L_D_L_AppID.Location = new System.Drawing.Point(126, 9);
            this.lbl_L_D_L_AppID.Name = "lbl_L_D_L_AppID";
            this.lbl_L_D_L_AppID.Size = new System.Drawing.Size(23, 16);
            this.lbl_L_D_L_AppID.TabIndex = 0;
            this.lbl_L_D_L_AppID.Text = "31";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Applied For License  : ";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Black;
            this.lblClassName.Location = new System.Drawing.Point(460, 9);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(23, 16);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "31";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(289, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Passed Tests  : ";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTests.ForeColor = System.Drawing.Color.Black;
            this.lblPassedTests.Location = new System.Drawing.Point(417, 42);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(23, 16);
            this.lblPassedTests.TabIndex = 1;
            this.lblPassedTests.Text = "31";
            // 
            // linkLblShowLicense
            // 
            this.linkLblShowLicense.AutoSize = true;
            this.linkLblShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblShowLicense.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLblShowLicense.Location = new System.Drawing.Point(34, 45);
            this.linkLblShowLicense.Name = "linkLblShowLicense";
            this.linkLblShowLicense.Size = new System.Drawing.Size(114, 16);
            this.linkLblShowLicense.TabIndex = 2;
            this.linkLblShowLicense.TabStop = true;
            this.linkLblShowLicense.Text = "Show License Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "App ID : ";
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppId.ForeColor = System.Drawing.Color.Black;
            this.lblAppId.Location = new System.Drawing.Point(134, 13);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(23, 16);
            this.lblAppId.TabIndex = 0;
            this.lblAppId.Text = "31";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status  : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(135, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(23, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "31";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(15, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fees : ";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Black;
            this.lblFees.Location = new System.Drawing.Point(135, 79);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(23, 16);
            this.lblFees.TabIndex = 0;
            this.lblFees.Text = "31";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(15, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Type : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(135, 112);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(23, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "31";
            // 
            // lblApplicant
            // 
            this.lblApplicant.AutoSize = true;
            this.lblApplicant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicant.ForeColor = System.Drawing.Color.Black;
            this.lblApplicant.Location = new System.Drawing.Point(483, 13);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(23, 16);
            this.lblApplicant.TabIndex = 1;
            this.lblApplicant.Text = "31";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(363, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Applicant  : ";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(483, 112);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(23, 16);
            this.lblCreatedBy.TabIndex = 3;
            this.lblCreatedBy.Text = "31";
            // 
            // lblStatusDate
            // 
            this.lblStatusDate.AutoSize = true;
            this.lblStatusDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDate.ForeColor = System.Drawing.Color.Black;
            this.lblStatusDate.Location = new System.Drawing.Point(483, 79);
            this.lblStatusDate.Name = "lblStatusDate";
            this.lblStatusDate.Size = new System.Drawing.Size(23, 16);
            this.lblStatusDate.TabIndex = 4;
            this.lblStatusDate.Text = "31";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(483, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(23, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "31";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(363, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Cretaed by : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(363, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Status Date: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(363, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Date  : ";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAppointment.Image")));
            this.btnAddAppointment.Location = new System.Drawing.Point(817, 396);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(47, 37);
            this.btnAddAppointment.TabIndex = 3;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // FRM_TestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 585);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.pnlContainerApp);
            this.Controls.Add(this.pnlContainerLocalApp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_TestAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.pnlContainerLocalApp.ResumeLayout(false);
            this.pnlContainerLocalApp.PerformLayout();
            this.pnlContainerApp.ResumeLayout(false);
            this.pnlContainerApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox Image;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainerLocalApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContainerApp;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_L_D_L_AppID;
        private System.Windows.Forms.LinkLabel linkLblShowLicense;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblStatusDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddAppointment;
    }
}