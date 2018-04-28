using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentManagementForm.DAL;

namespace StudentManagementForm
{

    public partial class frmStudentDetail : Form
    {
        List<Course> _courseList = new List<Course>();

        public Student TheStudent { get; set; }
        Course _selectedCourse;

        public void OpenForm()
        {
            populateUIFromStudent(TheStudent);
            this.ShowDialog();
            
        }

        public frmStudentDetail()
        {
            InitializeComponent();
        }

        Course createCourseFromUI(int courseId = 0, int? studentId = null)
        {
            Course course = new Course();
            course.CourseID = courseId;
            course.StudentID = studentId;
            course.CourseCode = Convert.ToInt32(textBoxCourseCode.Text);
            course.CourseTitle = textBoxCourseTitle.Text;
            course.CourseTeacher = textBoxCourseTeacher.Text;
            course.StudentID = Convert.ToInt32(textBoxID.Text);

            return course;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (!validateCourse()) return;
            try
            {
                if (btnAddCourse.Text == "Add Course")
                {
                    Course course = createCourseFromUI();
                    _courseList.Add(course);
                }
                else if (btnAddCourse.Text == "Edit Course")
                {
                    Course updatedCourse = createCourseFromUI(_selectedCourse.CourseID, _selectedCourse.StudentID);

                    Course existingCourse = _courseList.Where(x=>x.CourseID==_selectedCourse.CourseID).FirstOrDefault();

                    _courseList.Remove(existingCourse);
                    _courseList.Add(updatedCourse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefreshCourseList();
        }

        public void RefreshCourseList()
        {
            try
            {   
                var bindList = new BindingList<Course>(_courseList);
                dataGridViewCourseList.DataSource = bindList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool validateStudent()
        {
            bool IsItValid = true;
            int N = 0;

            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                lblIDErr.Visible = true;
                IsItValid = false;
            }

            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                lblNameErr.Visible = true;
                IsItValid = false;
            }

            if (int.TryParse(textBoxName.Text, out N))
            {
                lblNameErr.Visible = true;
                IsItValid = false;
            }

            if (string.IsNullOrEmpty(comboBoxGender.Text))
            {
                lblGenderErr.Visible = true;
                IsItValid = false;
            }

            if (string.IsNullOrEmpty(comboBoxGroup.Text))
            {
                lblGroupErr.Visible = true;
                IsItValid = false;
            }
            return IsItValid;

        }

        bool validateCourse()
        {
            bool isValid = true;
            int Num = 0;

            if (!int.TryParse(textBoxCourseCode.Text, out Num))
            {
                lblCourseCodeErr.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrEmpty(textBoxCourseTitle.Text))
            {
                lblCourseTitleErr.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrEmpty(textBoxCourseTeacher.Text))
            {
                lblTeacherErr.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        private void textBoxCourseCode_TextChanged(object sender, EventArgs e)
        {
            lblCourseCodeErr.Visible = false;
        }

        private void textBoxCourseTitle_TextChanged(object sender, EventArgs e)
        {
            lblCourseTitleErr.Visible = false;
        }

        private void textBoxCourseTeacher_TextChanged(object sender, EventArgs e)
        {
            lblTeacherErr.Visible = false;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            lblIDErr.Visible = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            lblNameErr.Visible = false;
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGenderErr.Visible = false;
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGroupErr.Visible = false;
        }

        private void dataGridViewCourseList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                _selectedCourse = mapObjectFromGrid(dataGridViewCourseList.Rows[e.RowIndex]);
                populateUIFromCourse(_selectedCourse);

                btnAddCourse.Text = "Edit Course";
                btnCancelC.Visible = true;
                btnDeleteC.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void populateUIFromCourse(Course course)
        {
            textBoxCourseCode.Text = course.CourseCode.ToString();
            textBoxCourseTitle.Text = course.CourseTitle;
            textBoxCourseTeacher.Text = course.CourseTeacher;
        }

        Course mapObjectFromGrid(DataGridViewRow gridViewRow)
        {
            Course course = new Course();

            course.CourseID = Convert.ToInt32(gridViewRow.Cells["CourseID"].Value);
            course.StudentID = (gridViewRow.Cells["StudentID"].Value == null) ? (int?)null : Convert.ToInt32(gridViewRow.Cells["StudentID"].Value);
            course.CourseCode = Convert.ToInt32(gridViewRow.Cells["CourseCode"].Value);
            course.CourseTitle = gridViewRow.Cells["CourseTitle"].Value.ToString();
            course.CourseTeacher = gridViewRow.Cells["CourseTeacher"].Value.ToString();

            return course;
        }

        public void ClearCourse()
        {
            textBoxCourseCode.Text = string.Empty;
            textBoxCourseTitle.Text = string.Empty;
            textBoxCourseTeacher.Text = string.Empty;
        }

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            ClearCourse();
            btnAddCourse.Text = "Add Course";
            btnCancelC.Visible = false;
            btnDeleteC.Visible = false;
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = _courseList.Where(x => x.CourseID == _selectedCourse.CourseID).FirstOrDefault();
                _courseList.Remove(course);
                RefreshCourseList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateStudent()) return;
            string message = string.Empty;
            
            TheStudent.StudentID = Convert.ToInt32(textBoxID.Text);
            TheStudent.Name = textBoxName.Text;
            TheStudent.Gender = comboBoxGender.Text;
            TheStudent.Group = comboBoxGroup.Text;
            TheStudent.Courses = _courseList;

            try
            {
                if (TheStudent.SerialNo > 0)
                {
                    DALStudent.Update(TheStudent);
                }
                else 
                {
                    DALStudent.Insert(TheStudent);
                }
                
                MessageBox.Show("Record Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void populateUIFromStudent(Student Student)
        {

            TheStudent.SerialNo = Student.SerialNo;
            textBoxID.Text = Student.StudentID.ToString();
            textBoxName.Text = Student.Name;
            comboBoxGender.Text = TheStudent.Gender;
            comboBoxGroup.Text = TheStudent.Group;

            _courseList = Student.Courses;
            RefreshCourseList();
        }

    }
}
