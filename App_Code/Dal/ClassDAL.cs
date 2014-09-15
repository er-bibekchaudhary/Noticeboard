using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for ClassDAL
/// </summary>
public class ClassDAL
{
	public static void CreateClass(ClassInfo _class)
    {
         SqlConnection Con = ConnectionHelper.GetConnection();
        string Sp = "USP_CreateClass";
        SqlCommand cmd = new SqlCommand(Sp, Con);
        cmd.Parameters.Add(new SqlParameter("@BatchID", _class.BatchID));
         cmd.Parameters.Add(new SqlParameter("@FacultyID", _class.Faculty));
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
	
    public static DataTable getAllClass()
    {
          SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetAll_Class";
        SqlCommand cmd = new SqlCommand(sp,con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;

    }

   
}

