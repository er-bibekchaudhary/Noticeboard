using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for TutorialDAL
/// </summary>
public class TutorialDAL
{
    public static void CreateTutorial(TutorialInfo _tutorial)
    {
        SqlConnection Con = ConnectionHelper.GetConnection();
        string Sp = "USP_Create_Tutorial";
        SqlCommand cmd = new SqlCommand(Sp, Con);
        cmd.Parameters.Add(new SqlParameter("@FacultyID", _tutorial.FacultyID));
        cmd.Parameters.Add(new SqlParameter("@BatchID", _tutorial.BatchID));
        cmd.Parameters.Add(new SqlParameter("@Reference", _tutorial.Reference));
        cmd.Parameters.Add(new SqlParameter("@FileName", _tutorial.FileName));
        cmd.Parameters.Add(new SqlParameter("@PostedOn", _tutorial.PostedOn));
        cmd.Parameters.Add(new SqlParameter("@PostedBy", _tutorial.PostedBy));
        cmd.Parameters.Add(new SqlParameter("@DeadLine", _tutorial.Deadline));
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
    public static DataTable getallTutorial()
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetAll_Tutorial";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public static DataTable getTutorialByBatchIDAndFacultyID(TutorialInfo _tutorial)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_getTutorial_ByBatchIDandFacultyID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public static TutorialInfo getTutorialByTutorialID(TutorialInfo _tutorial)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_getTutorial_ByTutorialID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@TutorialID", _tutorial.TutorialID));
        cmd.CommandType = CommandType.StoredProcedure;
        try
        {
            SqlDataReader _Reader = cmd.ExecuteReader();
            _Reader.Read();

            TutorialInfo _tutorials = new TutorialInfo();
            _tutorials.TutorialID = int.Parse(_Reader["TutorialID"].ToString());
            _tutorials.FacultyID = int.Parse(_Reader["FacultyID"].ToString());
            _tutorials.BatchID =   int.Parse(_Reader["BatchID"].ToString());
            _tutorials.Reference = _Reader["Reference"].ToString();
            _tutorials.FileName =  _Reader["FileName"].ToString();
            _tutorials.PostedOn = Convert.ToDateTime(_Reader["@PostedOn"].ToString());
            _tutorials.PostedBy = int.Parse(_Reader["@PostedBy"].ToString());
            _tutorials.Deadline = Convert.ToDateTime(_Reader["TutorialID"].ToString());

            return _tutorials;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable getTutorialIDandReferenceofTutorialByStaffID(int ID)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetTutorial_ByStuffID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@ID", ID));
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);
        return dt;
    }
}