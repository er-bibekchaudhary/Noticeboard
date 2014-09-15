using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for TeacherDAL
/// </summary>
public class TeacherDAL
{
    public static void CreateNotice(TeachersInfo _Teacher)
    {
        SqlConnection Con = ConnectionHelper.GetConnection();
        string Sp = "USP_Create_Teachers";
        SqlCommand cmd = new SqlCommand(Sp, Con);
        cmd.Parameters.Add(new SqlParameter("@FirstName", _Teacher.FirstName));
        cmd.Parameters.Add(new SqlParameter("@LastName", _Teacher.LastName));
        cmd.Parameters.Add(new SqlParameter("@DepartmentID", _Teacher.DepartmentID));
        cmd.Parameters.Add(new SqlParameter("@EmpID", _Teacher.EmpID));
        cmd.Parameters.Add(new SqlParameter("@Address", _Teacher.Address));
        cmd.Parameters.Add(new SqlParameter("@ContactNo", _Teacher.ContactNo));
        cmd.Parameters.Add(new SqlParameter("@ContactNo", _Teacher.Email));
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
    public static DataTable getallTeachers()
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetAll_Teachers";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public static TeachersInfo getTeacherByID(int id)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetTeacher_ByID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@ID", id));
        cmd.CommandType = CommandType.StoredProcedure;
        try
        {
            SqlDataReader _Reader = cmd.ExecuteReader();
            _Reader.Read();

            TeachersInfo _teacher = new TeachersInfo();
            _teacher.TeachersID = int.Parse(_Reader["TeachersID"].ToString());
            _teacher.EmpID =int.Parse( _Reader["EmpID"].ToString());
            _teacher.FirstName=   _Reader["FirstName"].ToString();
            _teacher.LastName=    _Reader["LastName"].ToString();
            _teacher.Address = _Reader["PAddress"].ToString();
            _teacher.ContactNo = int.Parse(_Reader["ContactNo"].ToString());
            _teacher.DepartmentID = int.Parse(_Reader["DepartmentID"].ToString());
            _teacher.Email = _Reader["Email"].ToString();
            _teacher.Address = _Reader["Notice"].ToString();
             return _teacher;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void EditTeachers(TeachersInfo _teacher)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_Update_Teachers";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@TeachersID", -_teacher.TeachersID));
        cmd.Parameters.Add(new SqlParameter("@Firstname", _teacher.FirstName));
        cmd.Parameters.Add(new SqlParameter("@Lastname", _teacher.LastName));
        cmd.Parameters.Add(new SqlParameter("@DepartmentID", _teacher.DepartmentID));
        cmd.Parameters.Add(new SqlParameter("@EmpID", _teacher.EmpID));
        cmd.Parameters.Add(new SqlParameter("@Address", _teacher.Address));
        cmd.Parameters.Add(new SqlParameter("@ContactNo", _teacher.ContactNo ));
        cmd.Parameters.Add(new SqlParameter("@Email", _teacher.Email));
   
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