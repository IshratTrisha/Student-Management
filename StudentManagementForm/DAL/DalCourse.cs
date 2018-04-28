using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StudentManagementForm.DAL
{
    public class DalCourse
    {
       static SqlConnection _connection = new DbManager().Connection; // why new sqlConnection name??? _Connection
       static SqlCommand _command;
       static SqlDataAdapter _adapter;

       public static List<Course> GetByStudentId(int? studentId) // why??? what r these called???
       {
           List<Course> courseList = new List<Course>();
           DataTable dataTable = new DataTable(); 

           string query = string.Empty;

           if (studentId.HasValue)
               query = "select * from CourseList where StudentID=@StudentID";
           else
               query = "select * from CourseList where StudentID is null";

           _adapter = new SqlDataAdapter(query, _connection);
           _adapter.SelectCommand.Parameters.AddWithValue("@StudentID", studentId.HasValue ? studentId : (object)DBNull.Value);//explain
           
           try
           {
               _connection.Open();
               _adapter.Fill(dataTable);

               IEnumerable<DataRow> rows = dataTable.Rows.Cast<DataRow>(); //why???

               foreach (var row in rows) //explain row
               {
                   Course course = MapCourse(row);
                   courseList.Add(course);
               }

               _connection.Close();
           }
           catch (Exception ex)
           {
               _connection.Close();
               throw ex;
           }

           return courseList;
       }

       static Course MapCourse(DataRow dataRow) //explain data row and why static
       {
           Course course = new Course(); // same name problem???
          
           course.CourseCode = Convert.ToInt32(dataRow["CourseCode"]);
           course.CourseTitle = dataRow["CourseTitle"].ToString();
           course.CourseTeacher = dataRow["CourseTeacher"].ToString();
           course.CourseID = Convert.ToInt32(dataRow["CourseID"]);
           course.StudentID = dataRow["StudentID"]== DBNull.Value? null: (int?) Convert.ToInt32(dataRow["StudentID"]); //what is DB null, why int?
         
           return course;
       }

        public static void Insert(Course course)
        {
            _command = new SqlCommand("insert into CourseList(CourseCode, CourseTitle, CourseTeacher,StudentID) values(@CourseCode, @CourseTitle, @CourseTeacher, @StudentID)", _connection);

            _command.Parameters.AddWithValue("@CourseCode", course.CourseCode);
            _command.Parameters.AddWithValue("@CourseTitle", course.CourseTitle);
            _command.Parameters.AddWithValue("@CourseTeacher", course.CourseTeacher);
            _command.Parameters.AddWithValue("@StudentID", course.StudentID.HasValue? course.StudentID: (object)DBNull.Value);

            try
            {
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
        
        public static void Update(Course course)
        {
            _command = new SqlCommand("update CourseList set CourseCode = @CourseCode, CourseTitle= @CourseTitle, CourseTeacher = @CourseTeacher where CourseID=@CourseID", _connection);

            _command.Parameters.AddWithValue("@CourseCode", course.CourseCode);
            _command.Parameters.AddWithValue("@CourseTitle", course.CourseTitle);
            _command.Parameters.AddWithValue("@CourseTeacher", course.CourseTeacher);
            _command.Parameters.AddWithValue("@CourseID", course.CourseID);

            try
            {
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
        
        public static void Delete(int studentId)
        {
            _command = new SqlCommand("delete from CourseList where StudentID=@StudentID", _connection);

            _command.Parameters.AddWithValue("@StudentID", studentId);

            try
            {
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
