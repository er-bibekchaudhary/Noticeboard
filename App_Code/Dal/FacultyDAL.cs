using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for FacultyDAL
/// </summary>
public class FacultyDAL
{
	 public static void CreateFaculty( string FacultyName)
    {
        SqlConnection Con = ConnectionHelper.GetConnection();
        string Sp = "USP_Create_Faculty";
        SqlCommand cmd = new SqlCommand(Sp, Con);
        cmd.Parameters.Add(new SqlParameter("@FacultyName", FacultyName));
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
    public static DataTable getallFaculty()
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetAll_Faculty";
        SqlCommand cmd = new SqlCommand(sp,con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public static FacultyInfo getFacultyByID(int id)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetFaculty_ByID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@ID",id));
        cmd.CommandType=CommandType.StoredProcedure;
        try
        {
            SqlDataReader _Reader = cmd.ExecuteReader();
            _Reader.Read();

            FacultyInfo _batch = new FacultyInfo();
            _faculty.FacultyID = int.Parse(_Reader["FacultyID"].ToString());
            _faculty.FacultyName = _Reader["FacultyName"].ToString();
            return _faculty;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void Editfaculty(FacultyInfo _faculty)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_Update_Faculty";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@FacultyID",_faculty.FacultyID));
        cmd.Parameters.Add(new SqlParameter("@FacultyName",_faculty.FacultyName));
        cmd.CommandType=CommandType.StoredProcedure;

        try{
            cmd.ExecuteNonQuery();
        }
       catch(Exception ex)
        {
           throw ex;
       }
    }
}
}