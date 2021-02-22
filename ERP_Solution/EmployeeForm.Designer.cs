
namespace ERP_Solution
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbInactiveSearch = new System.Windows.Forms.RadioButton();
            this.rbActiveSearch = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMaleSearch = new System.Windows.Forms.RadioButton();
            this.rbFemaleSearch = new System.Windows.Forms.RadioButton();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btNew = new System.Windows.Forms.Button();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.btListAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLastPage = new System.Windows.Forms.Button();
            this.btFirstPage = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblPagesTotal = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.lblEmployeeTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrevious = new System.Windows.Forms.Button();
            this.GridEmployee = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.gbSearch);
            this.panel1.Controls.Add(this.gbDetail);
            this.panel1.Controls.Add(this.btLastPage);
            this.panel1.Controls.Add(this.btFirstPage);
            this.panel1.Controls.Add(this.lblEmployees);
            this.panel1.Controls.Add(this.lblPagesTotal);
            this.panel1.Controls.Add(this.lblCurrentPage);
            this.panel1.Controls.Add(this.lblEmployeeTotal);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Controls.Add(this.btPrevious);
            this.panel1.Controls.Add(this.GridEmployee);
            this.panel1.Location = new System.Drawing.Point(2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 458);
            this.panel1.TabIndex = 20;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.groupBox2);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.txtSearchId);
            this.gbSearch.Controls.Add(this.groupBox1);
            this.gbSearch.Controls.Add(this.txtSearchEmail);
            this.gbSearch.Controls.Add(this.lblEmail);
            this.gbSearch.Controls.Add(this.label6);
            this.gbSearch.Controls.Add(this.txtSearchName);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Location = new System.Drawing.Point(446, 10);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(339, 148);
            this.gbSearch.TabIndex = 15;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbInactiveSearch);
            this.groupBox2.Controls.Add(this.rbActiveSearch);
            this.groupBox2.Location = new System.Drawing.Point(180, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 40);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // rbInactiveSearch
            // 
            this.rbInactiveSearch.AutoSize = true;
            this.rbInactiveSearch.Location = new System.Drawing.Point(68, 19);
            this.rbInactiveSearch.Name = "rbInactiveSearch";
            this.rbInactiveSearch.Size = new System.Drawing.Size(63, 17);
            this.rbInactiveSearch.TabIndex = 1;
            this.rbInactiveSearch.TabStop = true;
            this.rbInactiveSearch.Text = "Inactive";
            this.rbInactiveSearch.UseVisualStyleBackColor = true;
            // 
            // rbActiveSearch
            // 
            this.rbActiveSearch.AutoSize = true;
            this.rbActiveSearch.Location = new System.Drawing.Point(7, 19);
            this.rbActiveSearch.Name = "rbActiveSearch";
            this.rbActiveSearch.Size = new System.Drawing.Size(55, 17);
            this.rbActiveSearch.TabIndex = 0;
            this.rbActiveSearch.TabStop = true;
            this.rbActiveSearch.Text = "Active";
            this.rbActiveSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Id";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(43, 19);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(58, 20);
            this.txtSearchId.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMaleSearch);
            this.groupBox1.Controls.Add(this.rbFemaleSearch);
            this.groupBox1.Location = new System.Drawing.Point(43, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 40);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbMaleSearch
            // 
            this.rbMaleSearch.AutoSize = true;
            this.rbMaleSearch.Location = new System.Drawing.Point(71, 19);
            this.rbMaleSearch.Name = "rbMaleSearch";
            this.rbMaleSearch.Size = new System.Drawing.Size(48, 17);
            this.rbMaleSearch.TabIndex = 1;
            this.rbMaleSearch.TabStop = true;
            this.rbMaleSearch.Text = "Male";
            this.rbMaleSearch.UseVisualStyleBackColor = true;
            // 
            // rbFemaleSearch
            // 
            this.rbFemaleSearch.AutoSize = true;
            this.rbFemaleSearch.Location = new System.Drawing.Point(6, 19);
            this.rbFemaleSearch.Name = "rbFemaleSearch";
            this.rbFemaleSearch.Size = new System.Drawing.Size(59, 17);
            this.rbFemaleSearch.TabIndex = 0;
            this.rbFemaleSearch.TabStop = true;
            this.rbFemaleSearch.Text = "Female";
            this.rbFemaleSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(43, 66);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(264, 20);
            this.txtSearchEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(43, 42);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(264, 20);
            this.txtSearchName.TabIndex = 11;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(243, 13);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(64, 23);
            this.btSearch.TabIndex = 15;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.pBar1);
            this.gbDetail.Controls.Add(this.button1);
            this.gbDetail.Controls.Add(this.gbStatus);
            this.gbDetail.Controls.Add(this.btNew);
            this.gbDetail.Controls.Add(this.gbGender);
            this.gbDetail.Controls.Add(this.btUpdate);
            this.gbDetail.Controls.Add(this.btCreate);
            this.gbDetail.Controls.Add(this.txtId);
            this.gbDetail.Controls.Add(this.txtName);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.btDelete);
            this.gbDetail.Controls.Add(this.TxtEmail);
            this.gbDetail.Controls.Add(this.btListAll);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Location = new System.Drawing.Point(9, 10);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(431, 148);
            this.gbDetail.TabIndex = 31;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Details";
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(291, 134);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(139, 11);
            this.pBar1.TabIndex = 36;
            this.pBar1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Export All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInactive);
            this.gbStatus.Controls.Add(this.rbActive);
            this.gbStatus.Location = new System.Drawing.Point(291, 65);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(133, 40);
            this.gbStatus.TabIndex = 31;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(68, 19);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(63, 17);
            this.rbInactive.TabIndex = 1;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(7, 19);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(55, 17);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // btNew
            // 
            this.btNew.Enabled = false;
            this.btNew.Location = new System.Drawing.Point(122, 20);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 5;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Location = new System.Drawing.Point(291, 19);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(131, 40);
            this.gbGender.TabIndex = 16;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(71, 19);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(6, 19);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Enabled = false;
            this.btUpdate.Location = new System.Drawing.Point(87, 111);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(6, 111);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 6;
            this.btCreate.Text = "Save";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(49, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(49, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 20);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id";
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(168, 111);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(49, 80);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(234, 20);
            this.TxtEmail.TabIndex = 2;
            // 
            // btListAll
            // 
            this.btListAll.Location = new System.Drawing.Point(249, 111);
            this.btListAll.Name = "btListAll";
            this.btListAll.Size = new System.Drawing.Size(75, 23);
            this.btListAll.TabIndex = 9;
            this.btListAll.Text = "List All";
            this.btListAll.UseVisualStyleBackColor = true;
            this.btListAll.Click += new System.EventHandler(this.btListAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // btLastPage
            // 
            this.btLastPage.Location = new System.Drawing.Point(484, 429);
            this.btLastPage.Name = "btLastPage";
            this.btLastPage.Size = new System.Drawing.Size(75, 23);
            this.btLastPage.TabIndex = 28;
            this.btLastPage.Text = "Last >";
            this.btLastPage.UseVisualStyleBackColor = true;
            this.btLastPage.Click += new System.EventHandler(this.btLastPage_Click);
            // 
            // btFirstPage
            // 
            this.btFirstPage.Location = new System.Drawing.Point(245, 429);
            this.btFirstPage.Name = "btFirstPage";
            this.btFirstPage.Size = new System.Drawing.Size(75, 23);
            this.btFirstPage.TabIndex = 27;
            this.btFirstPage.Text = "< First";
            this.btFirstPage.UseVisualStyleBackColor = true;
            this.btFirstPage.Click += new System.EventHandler(this.btFirstPage_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(32, 429);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(57, 13);
            this.lblEmployees.TabIndex = 26;
            this.lblEmployees.Text = "employees";
            // 
            // lblPagesTotal
            // 
            this.lblPagesTotal.AutoSize = true;
            this.lblPagesTotal.Location = new System.Drawing.Point(772, 429);
            this.lblPagesTotal.Name = "lblPagesTotal";
            this.lblPagesTotal.Size = new System.Drawing.Size(13, 13);
            this.lblPagesTotal.TabIndex = 25;
            this.lblPagesTotal.Text = "0";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(735, 429);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentPage.TabIndex = 24;
            this.lblCurrentPage.Text = "0";
            // 
            // lblEmployeeTotal
            // 
            this.lblEmployeeTotal.AutoSize = true;
            this.lblEmployeeTotal.Location = new System.Drawing.Point(5, 429);
            this.lblEmployeeTotal.Name = "lblEmployeeTotal";
            this.lblEmployeeTotal.Size = new System.Drawing.Size(13, 13);
            this.lblEmployeeTotal.TabIndex = 23;
            this.lblEmployeeTotal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(706, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Page";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(754, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "of";
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(403, 429);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 18;
            this.btNext.Text = "Next >>";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrevious
            // 
            this.btPrevious.Location = new System.Drawing.Point(326, 429);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(71, 23);
            this.btPrevious.TabIndex = 17;
            this.btPrevious.Text = "<< Previous";
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // GridEmployee
            // 
            this.GridEmployee.AllowUserToAddRows = false;
            this.GridEmployee.AllowUserToDeleteRows = false;
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployee.Location = new System.Drawing.Point(0, 177);
            this.GridEmployee.MultiSelect = false;
            this.GridEmployee.Name = "GridEmployee";
            this.GridEmployee.ReadOnly = true;
            this.GridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmployee.Size = new System.Drawing.Size(785, 246);
            this.GridEmployee.TabIndex = 16;
            this.GridEmployee.SelectionChanged += new System.EventHandler(this.GridEmployee_SelectionChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.Sort = "";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbInactiveSearch;
        private System.Windows.Forms.RadioButton rbActiveSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMaleSearch;
        private System.Windows.Forms.RadioButton rbFemaleSearch;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button btListAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLastPage;
        private System.Windows.Forms.Button btFirstPage;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblPagesTotal;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label lblEmployeeTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.DataGridView GridEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}