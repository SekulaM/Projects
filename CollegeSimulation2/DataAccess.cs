using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CollegeSimulation2
{
    //used to connect to MSSQL database
    public class DataAccess
    {
        public List<Student> LoadStudentList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal("Students")))
            {
                var output = connection.Query<Student>("select * from Students").ToList();
                return output;
            }
        }

        public List<Subject> LoadSubjectList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal("Students")))
            {
                var output = connection.Query<Subject>("select * from Subjects").ToList();
                return output;
            }
        }
    }
}
