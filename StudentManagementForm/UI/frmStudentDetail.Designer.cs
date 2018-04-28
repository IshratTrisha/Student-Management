namespace StudentManagementForm
{
    partial class frmStudentDetail
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
            this.lbId = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCourseCode = new System.Windows.Forms.TextBox();
            this.dataGridViewCourseList = new System.Windows.Forms.DataGridView();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.textBoxCourseTitle = new System.Windows.Forms.TextBox();
            this.textBoxCourseTeacher = new System.Windows.Forms.TextBox();
            this.lblCourseTeacher = new System.Windows.Forms.Label();
            this.lblIDErr = new System.Windows.Forms.Label();
            this.lblGenderErr = new System.Windows.Forms.Label();
            this.lblNameErr = new System.Windows.Forms.Label();
            this.lblGroupErr = new System.Windows.Forms.Label();
            this.lblCourseCodeErr = new System.Windows.Forms.Label();
            this.lblCourseTitleErr = new System.Windows.Forms.Label();
            this.lblTeacherErr = new System.Windows.Forms.Label();
            this.btnCancelC = new System.Windows.Forms.Button();
            this.btnDeleteC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(68, 38);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(62, 121);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(68, 162);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 3;
            this.lblGroup.Text = "Group";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(431, 41);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(68, 13);
            this.lblCourseCode.TabIndex = 4;
            this.lblCourseCode.Text = "Course Code";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(143, 38);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxCourseCode
            // 
            this.textBoxCourseCode.Location = new System.Drawing.Point(541, 41);
            this.textBoxCourseCode.Name = "textBoxCourseCode";
            this.textBoxCourseCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourseCode.TabIndex = 9;
            this.textBoxCourseCode.TextChanged += new System.EventHandler(this.textBoxCourseCode_TextChanged);
            // 
            // dataGridViewCourseList
            // 
            this.dataGridViewCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseList.Location = new System.Drawing.Point(49, 314);
            this.dataGridViewCourseList.Name = "dataGridViewCourseList";
            this.dataGridViewCourseList.Size = new System.Drawing.Size(676, 246);
            this.dataGridViewCourseList.TabIndex = 10;
            this.dataGridViewCourseList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCourseList_RowHeaderMouseClick);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(451, 170);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 11;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(512, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "Science",
            "Business Studies",
            "Arts"});
            this.comboBoxGroup.Location = new System.Drawing.Point(143, 162);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGroup.TabIndex = 13;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(143, 121);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGender.TabIndex = 14;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Location = new System.Drawing.Point(431, 80);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(63, 13);
            this.lblCourseTitle.TabIndex = 15;
            this.lblCourseTitle.Text = "Course Title";
            // 
            // textBoxCourseTitle
            // 
            this.textBoxCourseTitle.Location = new System.Drawing.Point(541, 80);
            this.textBoxCourseTitle.Name = "textBoxCourseTitle";
            this.textBoxCourseTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourseTitle.TabIndex = 16;
            this.textBoxCourseTitle.TextChanged += new System.EventHandler(this.textBoxCourseTitle_TextChanged);
            // 
            // textBoxCourseTeacher
            // 
            this.textBoxCourseTeacher.Location = new System.Drawing.Point(541, 126);
            this.textBoxCourseTeacher.Name = "textBoxCourseTeacher";
            this.textBoxCourseTeacher.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourseTeacher.TabIndex = 17;
            this.textBoxCourseTeacher.TextChanged += new System.EventHandler(this.textBoxCourseTeacher_TextChanged);
            // 
            // lblCourseTeacher
            // 
            this.lblCourseTeacher.AutoSize = true;
            this.lblCourseTeacher.Location = new System.Drawing.Point(431, 121);
            this.lblCourseTeacher.Name = "lblCourseTeacher";
            this.lblCourseTeacher.Size = new System.Drawing.Size(83, 13);
            this.lblCourseTeacher.TabIndex = 18;
            this.lblCourseTeacher.Text = "Course Teacher";
            // 
            // lblIDErr
            // 
            this.lblIDErr.AutoSize = true;
            this.lblIDErr.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDErr.ForeColor = System.Drawing.Color.Red;
            this.lblIDErr.Location = new System.Drawing.Point(267, 41);
            this.lblIDErr.Name = "lblIDErr";
            this.lblIDErr.Size = new System.Drawing.Size(90, 13);
            this.lblIDErr.TabIndex = 19;
            this.lblIDErr.Text = "*Only Numbers";
            this.lblIDErr.Visible = false;
            // 
            // lblGenderErr
            // 
            this.lblGenderErr.AutoSize = true;
            this.lblGenderErr.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderErr.ForeColor = System.Drawing.Color.Red;
            this.lblGenderErr.Location = new System.Drawing.Point(267, 124);
            this.lblGenderErr.Name = "lblGenderErr";
            this.lblGenderErr.Size = new System.Drawing.Size(149, 13);
            this.lblGenderErr.TabIndex = 20;
            this.lblGenderErr.Text = "*Must Choose from Option";
            this.lblGenderErr.Visible = false;
            // 
            // lblNameErr
            // 
            this.lblNameErr.AutoSize = true;
            this.lblNameErr.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblNameErr.Location = new System.Drawing.Point(267, 83);
            this.lblNameErr.Name = "lblNameErr";
            this.lblNameErr.Size = new System.Drawing.Size(101, 13);
            this.lblNameErr.TabIndex = 21;
            this.lblNameErr.Text = "*Only Characters";
            this.lblNameErr.Visible = false;
            // 
            // lblGroupErr
            // 
            this.lblGroupErr.AutoSize = true;
            this.lblGroupErr.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupErr.ForeColor = System.Drawing.Color.Red;
            this.lblGroupErr.Location = new System.Drawing.Point(267, 170);
            this.lblGroupErr.Name = "lblGroupErr";
            this.lblGroupErr.Size = new System.Drawing.Size(149, 13);
            this.lblGroupErr.TabIndex = 22;
            this.lblGroupErr.Text = "*Must Choose from Option";
            this.lblGroupErr.Visible = false;
            // 
            // lblCourseCodeErr
            // 
            this.lblCourseCodeErr.AutoSize = true;
            this.lblCourseCodeErr.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCodeErr.ForeColor = System.Drawing.Color.Red;
            this.lblCourseCodeErr.Location = new System.Drawing.Point(661, 41);
            this.lblCourseCodeErr.Name = "lblCourseCodeErr";
            this.lblCourseCodeErr.Size = new System.Drawing.Size(90, 13);
            this.lblCourseCodeErr.TabIndex = 23;
            this.lblCourseCodeErr.Text = "*Only Numbers";
            this.lblCourseCodeErr.Visible = false;
            // 
            // lblCourseTitleErr
            // 
            this.lblCourseTitleErr.AutoSize = true;
            this.lblCourseTitleErr.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTitleErr.ForeColor = System.Drawing.Color.Red;
            this.lblCourseTitleErr.Location = new System.Drawing.Point(661, 83);
            this.lblCourseTitleErr.Name = "lblCourseTitleErr";
            this.lblCourseTitleErr.Size = new System.Drawing.Size(101, 13);
            this.lblCourseTitleErr.TabIndex = 24;
            this.lblCourseTitleErr.Text = "*Only Characters";
            this.lblCourseTitleErr.Visible = false;
            // 
            // lblTeacherErr
            // 
            this.lblTeacherErr.AutoSize = true;
            this.lblTeacherErr.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherErr.ForeColor = System.Drawing.Color.Red;
            this.lblTeacherErr.Location = new System.Drawing.Point(661, 133);
            this.lblTeacherErr.Name = "lblTeacherErr";
            this.lblTeacherErr.Size = new System.Drawing.Size(101, 13);
            this.lblTeacherErr.TabIndex = 25;
            this.lblTeacherErr.Text = "*Only Characters";
            this.lblTeacherErr.Visible = false;
            // 
            // btnCancelC
            // 
            this.btnCancelC.Location = new System.Drawing.Point(558, 170);
            this.btnCancelC.Name = "btnCancelC";
            this.btnCancelC.Size = new System.Drawing.Size(75, 23);
            this.btnCancelC.TabIndex = 26;
            this.btnCancelC.Text = "Cancel";
            this.btnCancelC.UseVisualStyleBackColor = true;
            this.btnCancelC.Visible = false;
            this.btnCancelC.Click += new System.EventHandler(this.btnCancelC_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Location = new System.Drawing.Point(664, 170);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteC.TabIndex = 27;
            this.btnDeleteC.Text = "Delete";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            this.btnDeleteC.Visible = false;
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // frmStudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 572);
            this.Controls.Add(this.btnDeleteC);
            this.Controls.Add(this.btnCancelC);
            this.Controls.Add(this.lblTeacherErr);
            this.Controls.Add(this.lblCourseTitleErr);
            this.Controls.Add(this.lblCourseCodeErr);
            this.Controls.Add(this.lblGroupErr);
            this.Controls.Add(this.lblNameErr);
            this.Controls.Add(this.lblGenderErr);
            this.Controls.Add(this.lblIDErr);
            this.Controls.Add(this.lblCourseTeacher);
            this.Controls.Add(this.textBoxCourseTeacher);
            this.Controls.Add(this.textBoxCourseTitle);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.dataGridViewCourseList);
            this.Controls.Add(this.textBoxCourseCode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lbId);
            this.Name = "frmStudentDetail";
            this.Text = "Student Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCourseCode;
        private System.Windows.Forms.DataGridView dataGridViewCourseList;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.TextBox textBoxCourseTitle;
        private System.Windows.Forms.TextBox textBoxCourseTeacher;
        private System.Windows.Forms.Label lblCourseTeacher;
        private System.Windows.Forms.Label lblIDErr;
        private System.Windows.Forms.Label lblGenderErr;
        private System.Windows.Forms.Label lblNameErr;
        private System.Windows.Forms.Label lblGroupErr;
        private System.Windows.Forms.Label lblCourseCodeErr;
        private System.Windows.Forms.Label lblCourseTitleErr;
        private System.Windows.Forms.Label lblTeacherErr;
        private System.Windows.Forms.Button btnCancelC;
        private System.Windows.Forms.Button btnDeleteC;
    }
}