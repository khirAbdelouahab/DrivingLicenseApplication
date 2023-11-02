namespace DVLD_Projet.FRMS_Application
{
    partial class UC_AddNewDrivingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddNewDrivingApplication));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFindPerson_Container = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.txtFindPerson = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFindPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.pnlApplication_Container = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.uC_PersoneInfo1 = new DVLD_Projet.UC_PersoneInfo();
            this.pnl_Header.SuspendLayout();
            this.pnlFindPerson_Container.SuspendLayout();
            this.pnlApplication_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.White;
            this.pnl_Header.Controls.Add(this.label1);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1132, 52);
            this.pnl_Header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Local Driving License Application";
            // 
            // pnlFindPerson_Container
            // 
            this.pnlFindPerson_Container.BackColor = System.Drawing.Color.White;
            this.pnlFindPerson_Container.Controls.Add(this.uC_PersoneInfo1);
            this.pnlFindPerson_Container.Controls.Add(this.btnAddNewPerson);
            this.pnlFindPerson_Container.Controls.Add(this.btnFindPerson);
            this.pnlFindPerson_Container.Controls.Add(this.txtFindPerson);
            this.pnlFindPerson_Container.Controls.Add(this.cbFindBy);
            this.pnlFindPerson_Container.Controls.Add(this.label2);
            this.pnlFindPerson_Container.Location = new System.Drawing.Point(85, 63);
            this.pnlFindPerson_Container.Name = "pnlFindPerson_Container";
            this.pnlFindPerson_Container.Size = new System.Drawing.Size(964, 301);
            this.pnlFindPerson_Container.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(98, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Find By : ";
            // 
            // cbFindBy
            // 
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Items.AddRange(new object[] {
            "ID",
            "National Na"});
            this.cbFindBy.Location = new System.Drawing.Point(183, 18);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(161, 21);
            this.cbFindBy.TabIndex = 1;
            // 
            // txtFindPerson
            // 
            this.txtFindPerson.BorderColor = System.Drawing.Color.Gray;
            this.txtFindPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindPerson.DefaultText = "";
            this.txtFindPerson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindPerson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindPerson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindPerson.Location = new System.Drawing.Point(394, 14);
            this.txtFindPerson.Name = "txtFindPerson";
            this.txtFindPerson.PasswordChar = '\0';
            this.txtFindPerson.PlaceholderText = "";
            this.txtFindPerson.SelectedText = "";
            this.txtFindPerson.Size = new System.Drawing.Size(200, 29);
            this.txtFindPerson.TabIndex = 2;
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindPerson.ForeColor = System.Drawing.Color.White;
            this.btnFindPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnFindPerson.Image")));
            this.btnFindPerson.Location = new System.Drawing.Point(613, 14);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(41, 29);
            this.btnFindPerson.TabIndex = 3;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.Image")));
            this.btnAddNewPerson.Location = new System.Drawing.Point(660, 14);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(41, 29);
            this.btnAddNewPerson.TabIndex = 3;
            // 
            // pnlApplication_Container
            // 
            this.pnlApplication_Container.BackColor = System.Drawing.Color.White;
            this.pnlApplication_Container.Controls.Add(this.btnSave);
            this.pnlApplication_Container.Controls.Add(this.cbLicenseClasses);
            this.pnlApplication_Container.Controls.Add(this.lblCreatedBy);
            this.pnlApplication_Container.Controls.Add(this.lblApplicationDate);
            this.pnlApplication_Container.Controls.Add(this.lblApplicationFees);
            this.pnlApplication_Container.Controls.Add(this.lblApplicationId);
            this.pnlApplication_Container.Controls.Add(this.label7);
            this.pnlApplication_Container.Controls.Add(this.label6);
            this.pnlApplication_Container.Controls.Add(this.label5);
            this.pnlApplication_Container.Controls.Add(this.label4);
            this.pnlApplication_Container.Controls.Add(this.label3);
            this.pnlApplication_Container.Location = new System.Drawing.Point(85, 370);
            this.pnlApplication_Container.Name = "pnlApplication_Container";
            this.pnlApplication_Container.Size = new System.Drawing.Size(964, 301);
            this.pnlApplication_Container.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(96, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "D . L Application ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(96, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Application Date : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(96, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "License Class  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(96, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Application Fees  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(96, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Created By : ";
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationId.Location = new System.Drawing.Point(317, 23);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(26, 18);
            this.lblApplicationId.TabIndex = 1;
            this.lblApplicationId.Text = "37";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(318, 77);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(92, 18);
            this.lblApplicationDate.TabIndex = 1;
            this.lblApplicationDate.Text = "2023-10-23";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Lime;
            this.lblApplicationFees.Location = new System.Drawing.Point(318, 186);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(63, 18);
            this.lblApplicationFees.TabIndex = 1;
            this.lblApplicationFees.Text = "30.00 $";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(319, 240);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(82, 18);
            this.lblCreatedBy.TabIndex = 1;
            this.lblCreatedBy.Text = "Msaqer77";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.BackColor = System.Drawing.Color.Transparent;
            this.cbLicenseClasses.BorderColor = System.Drawing.Color.Gray;
            this.cbLicenseClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClasses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLicenseClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLicenseClasses.ItemHeight = 30;
            this.cbLicenseClasses.Location = new System.Drawing.Point(320, 125);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(254, 36);
            this.cbLicenseClasses.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(873, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uC_PersoneInfo1
            // 
            this.uC_PersoneInfo1.ForeColor = System.Drawing.Color.Black;
            this.uC_PersoneInfo1.Location = new System.Drawing.Point(101, 61);
            this.uC_PersoneInfo1.Name = "uC_PersoneInfo1";
            this.uC_PersoneInfo1.Size = new System.Drawing.Size(757, 232);
            this.uC_PersoneInfo1.TabIndex = 4;
            // 
            // UC_AddNewDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlApplication_Container);
            this.Controls.Add(this.pnlFindPerson_Container);
            this.Controls.Add(this.pnl_Header);
            this.Name = "UC_AddNewDrivingApplication";
            this.Size = new System.Drawing.Size(1132, 710);
            this.Load += new System.EventHandler(this.UC_AddNewDrivingApplication_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnlFindPerson_Container.ResumeLayout(false);
            this.pnlFindPerson_Container.PerformLayout();
            this.pnlApplication_Container.ResumeLayout(false);
            this.pnlApplication_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFindPerson_Container;
        private Guna.UI2.WinForms.Guna2Button btnFindPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtFindPerson;
        private System.Windows.Forms.ComboBox cbFindBy;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private UC_PersoneInfo uC_PersoneInfo1;
        private System.Windows.Forms.Panel pnlApplication_Container;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationFees;
        private Guna.UI2.WinForms.Guna2ComboBox cbLicenseClasses;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}
