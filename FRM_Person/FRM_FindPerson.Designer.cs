namespace DVLD_Projet.FRM_Person
{
    partial class FRM_FindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_FindPerson));
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShearchPerson = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShearch = new Guna.UI2.WinForms.Guna2Button();
            this.uC_PersoneInfo1 = new DVLD_Projet.UC_PersoneInfo();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPersone = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // comboSearch
            // 
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "ID",
            "National Na"});
            this.comboSearch.Location = new System.Drawing.Point(136, 28);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(156, 21);
            this.comboSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find By  : ";
            // 
            // txtShearchPerson
            // 
            this.txtShearchPerson.BorderColor = System.Drawing.Color.Silver;
            this.txtShearchPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShearchPerson.DefaultText = "";
            this.txtShearchPerson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtShearchPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtShearchPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShearchPerson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShearchPerson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShearchPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtShearchPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShearchPerson.Location = new System.Drawing.Point(323, 25);
            this.txtShearchPerson.Name = "txtShearchPerson";
            this.txtShearchPerson.PasswordChar = '\0';
            this.txtShearchPerson.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtShearchPerson.PlaceholderText = "";
            this.txtShearchPerson.SelectedText = "";
            this.txtShearchPerson.Size = new System.Drawing.Size(222, 26);
            this.txtShearchPerson.TabIndex = 2;
            // 
            // btnShearch
            // 
            this.btnShearch.BorderRadius = 15;
            this.btnShearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShearch.FillColor = System.Drawing.Color.Gray;
            this.btnShearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShearch.ForeColor = System.Drawing.Color.White;
            this.btnShearch.Image = ((System.Drawing.Image)(resources.GetObject("btnShearch.Image")));
            this.btnShearch.Location = new System.Drawing.Point(558, 18);
            this.btnShearch.Name = "btnShearch";
            this.btnShearch.Size = new System.Drawing.Size(41, 38);
            this.btnShearch.TabIndex = 3;
            this.btnShearch.Click += new System.EventHandler(this.btnShearch_Click);
            // 
            // uC_PersoneInfo1
            // 
            this.uC_PersoneInfo1.ForeColor = System.Drawing.Color.Black;
            this.uC_PersoneInfo1.Location = new System.Drawing.Point(7, 75);
            this.uC_PersoneInfo1.Name = "uC_PersoneInfo1";
            this.uC_PersoneInfo1.Size = new System.Drawing.Size(757, 232);
            this.uC_PersoneInfo1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(653, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewPersone
            // 
            this.btnAddNewPersone.BorderRadius = 15;
            this.btnAddNewPersone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPersone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPersone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPersone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPersone.FillColor = System.Drawing.Color.Gray;
            this.btnAddNewPersone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewPersone.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPersone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPersone.Image")));
            this.btnAddNewPersone.Location = new System.Drawing.Point(605, 18);
            this.btnAddNewPersone.Name = "btnAddNewPersone";
            this.btnAddNewPersone.Size = new System.Drawing.Size(41, 38);
            this.btnAddNewPersone.TabIndex = 3;
            this.btnAddNewPersone.Click += new System.EventHandler(this.btnAddNewPersone_Click);
            // 
            // FRM_FindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 367);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.uC_PersoneInfo1);
            this.Controls.Add(this.btnAddNewPersone);
            this.Controls.Add(this.btnShearch);
            this.Controls.Add(this.txtShearchPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_FindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtShearchPerson;
        private Guna.UI2.WinForms.Guna2Button btnShearch;
        private UC_PersoneInfo uC_PersoneInfo1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPersone;
    }
}