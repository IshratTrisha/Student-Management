using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StudentManagementForm.DAL
{
    class DALStudent
    {
        static SqlConnection _connection = new DbManager().Connection;
        static SqlCommand _command;
        static SqlDataAdapter _adapter;

        public static List<Student> GetAllStudent() // explain this whole thing
        {
            List<Student> StudentList = new List<Student>();
            DataTable dataTable = new DataTable();

            string query = string.Empty;

            query = "select * from StudentList";

            _adapter = new SqlDataAdapter(query, _connection);

            try
            {
                _connection.Open();
                _adapter.Fill(dataTable);

                IEnumerable<DataRow> rows = dataTable.Rows.Cast<DataRow>();
                foreach (var row in rows)
                {
                    Student Student = MapStudent(row);

                    List<Course> courses = DalCourse.GetByStudentId(Student.StudentID);
                    Student.Courses = courses;
                    StudentList.Add(Student);
                }

                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                throw ex;
            }

            return StudentList;
        }
        static Student MapStudent(DataRow dataRow)
        {
            Student Student = new Student();

            Student.SerialNo = dataRow["SerialNo"] == DBNull.Value ? 0 : Convert.ToInt32(dataRow["SerialNo"]); 
            Student.StudentID = Convert.ToInt32(dataRow["StudentID"]);
            Student.Name = dataRow["Name"].ToString();
            Student.Gender = dataRow["Gender"].ToString();
            Student.Group = dataRow["Group"].ToString();

            return Student;
        }

        public static void Insert(Student Student)
        {
            _command = new SqlCommand("insert into StudentList(StudentID, Name, Gender, [Group]) values(@StudentID, @Name, @Gender, @Group)", _connection);

            _command.Parameters.AddWithValue("@StudentID", Student.StudentID);
            _command.Parameters.AddWithValue("@Name", Student.Name);
            _command.Parameters.AddWithValue("@Gender", Student.Gender);
            _command.Parameters.AddWithValue("@Group", Student.Group);

            try
            {
                _connection.Open();
                _command.ExecuteNonQuery();
                _connection.Close();

                foreach (var course in Student.Courses)
                {
                    course.StudentID = Student.StudentID;
                    DalCourse.Insert(course);
                }
               
            }
            catch (Exception ex)
            {
                _connection.Close();
                throw ex;
            }
        }

        public static void Update(Student Student)
        {
            _command = new SqlCommand("update StudentList set StudentID = @StudentID, Name= @Name, Gender = @Gender, [Group] = @Group where SerialNo=@SerialNo", _connection);

            _command.Parameters.AddWithValue("@StudentID", Student.StudentID);
            _command.Parameters.AddWithValue("@Name", Student.Name);
            _command.Parameters.AddWithValue("@Gender", Student.Gender);
            _command.Parameters.AddWithValue("@Group", Student.Group);
            _command.Parameters.AddWithValue("@SerialNo", Student.SerialNo);
            try
            {
                _connection.Open();
                _command.ExecuteNonQuery();
                _connection.Close();

                DalCourse.Delete(Student.StudentID);
                foreach (var course in Student.Courses)
                {   
                    DalCourse.Insert(course);
                }
            }
            catch (Exception ex)
            {
                _connection.Close();
                throw ex;
            }
        }

        public static void Delete(Student Student)
        {
            _command = new SqlCommand("delete from StudentList where SerialNo=@SerialNo", _connection);

            _command.Parameters.AddWithValue("@SerialNo", Student.SerialNo);

            try
            {
                DalCourse.Delete(Student.StudentID);
                _connection.Open();
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                throw ex;
            }
        }

    }
}
