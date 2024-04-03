using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {

            string query = "SELECT STUDENT_ID, LAST_NAME , FIRST_NAME FROM [STUDENT]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["STUDENT_ID"];
                string lastname = (string)dr["LAST_NAME"];
                string firstname = (string)dr["FIRST_NAME"];

                Student student = new Student(id, lastname, firstname);
                students.Add(student);
            }
            return students;
        }
    }
}