using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace StudentManagementForm.DAL
{
    public class DbManager
    {
        string _connetionString = @"Data Source=TRISHA-PC\SQLEXPRESS;Initial Catalog=StudentManagementForm;User ID=sa;Password=123";

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connetionString);
            }
        }
    }
}
