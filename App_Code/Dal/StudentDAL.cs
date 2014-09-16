using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for StudentDAL
/// </summary>
public class StudentDAL
{
    public static void CreateStudent(StudentInfo _Student)
    {
        SqlConnection Con = ConnectionHelper.GetConnection();
        string Sp = "USP_Create_Student";
        SqlCommand cmd = new SqlCommand(Sp, Con);
        cmd.Parameters.Add(new SqlParameter("@BatchID", _Student.BatchID));
        cmd.Parameters.Add(new SqlParameter("@FirstName", _Student.FirstName));
        cmd.Parameters.Add(new SqlParameter("@LastName", _Student.LastName));
        cmd.Parameters.Add(new SqlParameter("@Address",_Student.LocalAddress));
        cmd.Parameters.Add(new SqlParameter("@CollegeRoll", _Student.CollegeRoll));
        cmd.Parameters.Add(new SqlParameter("@ContactNo", _Student.ContactNo));
        cmd.Parameters.Add(new SqlParameter("@Email", _Student.Email));
        cmd.Parameters.Add(new SqlParameter("@status", _Student.AccountStatus));
        cmd.CommandType = CommandType.StoredProcedure;
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable getallStudent()
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetAll_Student";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }
    public static StudentInfo getStudentByID(int id)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetStudent_ByID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@ID", id));
        cmd.CommandType = CommandType.StoredProcedure;
        try
        {
            SqlDataReader _Reader = cmd.ExecuteReader();
            _Reader.Read();

            StudentInfo _student = new StudentInfo();
             _student.StudentID = int.Parse(_Reader["StudentID"].ToString());
             _student.FirstName = _Reader["@Firstname"].ToString();
             _student.LastName = _Reader["@Lastname"].ToString();
             _student.FacultyID = int.Parse(_Reader["@@FacultyID"].ToString());
             _student.LocalAddress = _Reader["@Address"].ToString();
             _student.CollegeRoll = int.Parse(_Reader["@@CollegeRoll"].ToString());
             _student.AccountStatus =Convert.ToBoolean(_Reader["@status"]);
             _student.BatchID = int.Parse(_Reader["@BatchID"].ToString());
             _student.Email = _Reader["@Email"].ToString();
             return _student;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static void EditStudent(StudentInfo _students)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_Update_Student";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@studentID", _students.StudentID));
        cmd.Parameters.Add(new SqlParameter("@Firstname", _students.FirstName));
        cmd.Parameters.Add(new SqlParameter("@Lastname", _students.LastName));
        cmd.Parameters.Add(new SqlParameter("@FacultyID", _students.FacultyID));
        cmd.Parameters.Add(new SqlParameter("@CollegeRoll", _students.CollegeRoll));
        cmd.Parameters.Add(new SqlParameter("@Address",_students.LocalAddress));
        cmd.Parameters.Add(new SqlParameter("@ContactNo", _students.ContactNo));
        cmd.Parameters.Add(new SqlParameter("@Email", _students.Email));
        cmd.Parameters.Add(new SqlParameter("@BatchID", _students.BatchID));
        cmd.Parameters.Add(new SqlParameter("@status", _students.AccountStatus));

        cmd.CommandType = CommandType.StoredProcedure;

        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}