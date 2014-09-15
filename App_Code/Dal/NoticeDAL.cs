using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for NoticeDAL
/// </summary>
public class NoticeDAL
{
	 public static void CreateNotice( int FacultyID)
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
    public static DataTable getallNotice()
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetAll_Notice";
        SqlCommand cmd = new SqlCommand(sp,con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public static NoticeInfo getNoticeByID(int id)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_getNotice_ByNoticeID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@ID",id));
        cmd.CommandType=CommandType.StoredProcedure;
        try
        {
            SqlDataReader _Reader = cmd.ExecuteReader();
            _Reader.Read();

            NoticeInfo _batch = new NoticeInfo();
            _notice.FacultyID = int.Parse(_Reader["FacultyID"].ToString());
            _notice.BatchID = int.Parse(_Reader["BatchID"].ToString());
            _notice.Reference= _Reader["Reference"].ToString();
            _notice.Notice= _Reader["Notice"].ToString();
            _notice.PostedOn= _Reader["PostedOn"].ToString();
            _notice.PostedBy= _Reader["PostedBy"].ToString();
            return _faculty;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void Editnotice(NoticeInfo _notice)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_Update_Notice";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@FacultyID",_faculty.FacultyID));
        cmd.Parameters.Add(new SqlParameter("@BatchID",_faculty.FacultyName));
        cmd.Parameters.Add(new SqlParameter("@Reference",));
        cmd.Parameters.Add(new SqlParameter("@Notice",));
        cmd.Parameters.Add(new SqlParameter("@PostedOn",));
        cmd.Parameters.Add(new SqlParameter("@PostedBy",));
        cmd.CommandType=CommandType.StoredProcedure;

        try{
            cmd.ExecuteNonQuery();
        }
       catch(Exception ex)
        {
           throw ex;
       }
    }

    public static getNoticeIDandReferenceofNoticeByStaffID(int ID)
    {
         SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_getNotice_ByNoticeID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@ID",id));
        cmd.CommandType=CommandType.StoredProcedure;
        try
        {
            SqlDataReader _Reader = cmd.ExecuteReader();
            _Reader.Read();

            NoticeInfo _batch = new NoticeInfo();
            _notice.FacultyID = int.Parse(_Reader["FacultyID"].ToString());
            _notice.BatchID = int.Parse(_Reader["BatchID"].ToString());
            _notice.Reference= _Reader["Reference"].ToString();
            _notice.Notice= _Reader["Notice"].ToString();
            _notice.PostedOn= _Reader["PostedOn"].ToString();
            _notice.PostedBy= _Reader["PostedBy"].ToString();
            return _faculty;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
}
}