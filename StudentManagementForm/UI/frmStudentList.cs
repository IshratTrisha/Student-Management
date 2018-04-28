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
    public partial class frmStudentList : Form
    {
        List<Student> StudentList = new List<Student>();
        Student _theStudent;

        public frmStudentList()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frmStudentDetail studentForm = new frmStudentDetail();

            try
            {
                if (buttonAdd.Text == "Add")
                {
                    studentForm.TheStudent = new Student();
                    studentForm.ShowDialog();
                    
                    RefreshStudentList();
                }
                else if (buttonAdd.Text == "Edit")
                {
                    studentForm.TheStudent = _theStudent;
                    studentForm.OpenForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefreshStudentList();
        }
        
        public void RefreshStudentList()
        {
            try
            {
                StudentList = DALStudent.GetAllStudent();

                var bindList = new BindingList<Student>(StudentList); //what is var?
                dataGridViewStudentFile.DataSource = bindList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    
        Student MapObjectFromridView(DataGridViewRow GridViewRow)
        {
            Student Student = new Student();

            int id = Convert.ToInt32(GridViewRow.Cells["StudentID"].Value);

            Student= StudentList.Where(x => x.StudentID == id).FirstOrDefault();

            return Student;
        }
        
        private void dataGridViewStudentFile_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _theStudent = MapObjectFromridView((dataGridViewStudentFile.Rows[e.RowIndex]));

            buttonAdd.Text = "Edit";
            buttonCancel.Visible = true;
            buttonDelete.Visible = true;
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            RefreshStudentList();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAdd.Text = "Add";
            buttonCancel.Visible = false;
            buttonDelete.Visible = false;
            RefreshStudentList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DALStudent.Delete(_theStudent);
                RefreshStudentList();
                MessageBox.Show("Record Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
