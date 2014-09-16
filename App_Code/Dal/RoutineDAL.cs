using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for RoutineDAL
/// </summary>
public class RoutineDAL
{
    public static void CreateRoutine(RoutineInfo _routine)
    {
        SqlConnection Con = ConnectionHelper.GetConnection();
        string Sp = "USP_Create_Routine";
        SqlCommand cmd = new SqlCommand(Sp, Con);
        cmd.Parameters.Add(new SqlParameter("@DayID", _routine.DayID));
        cmd.Parameters.Add(new SqlParameter("@FacultyID", _routine.FacultyID));
        cmd.Parameters.Add(new SqlParameter("@BatchID", _routine.BatchID));
        cmd.Parameters.Add(new SqlParameter("@First", _routine.First));
        cmd.Parameters.Add(new SqlParameter("@Second", _routine.Second));
        cmd.Parameters.Add(new SqlParameter("@Third", _routine.Third));
        cmd.Parameters.Add(new SqlParameter("@Fourth", _routine.Fourth));
        cmd.Parameters.Add(new SqlParameter("@Fifth", _routine.Fifth));
        cmd.Parameters.Add(new SqlParameter("@Sixth", _routine.Sixth));
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
    public static DataTable getallRoutine()
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetAll_Routine";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }
    public static RoutineInfo getRoutineByClassIDAndDayID(RoutineInfo _routine)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_Routine_ByClassIDAndDayID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@DayID", _routine.DayID));
        cmd.Parameters.Add(new SqlParameter("@ClassID", _routine.ClassID));
        cmd.CommandType = CommandType.StoredProcedure;
        try
        {
            SqlDataReader _Reader = cmd.ExecuteReader();
            _Reader.Read();

            RoutineInfo _routines = new RoutineInfo();
            _routines.ClassID = int.Parse(_Reader["ClassID"].ToString());
            _routines.DayID = int.Parse(_Reader["DayID"].ToString());
            _routines.First = _Reader["First"].ToString();
            _routines.Second = _Reader["Second"].ToString();
            _routines.Third = _Reader["Third"].ToString();
            _routines.Fourth = _Reader["Fourth"].ToString();
            _routines.Fifth = _Reader["Fifth"].ToString();
            _routines.Sixth = _Reader["Sixth"].ToString();
            return _routines;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static void EditRoutine(RoutineInfo _routine)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_Update_Routine";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@RoutineID", _routine.RoutineID));
        cmd.Parameters.Add(new SqlParameter("@First", _routine.First));
        cmd.Parameters.Add(new SqlParameter("@Second", _routine.Second));
        cmd.Parameters.Add(new SqlParameter("@Third", _routine.Third));
        cmd.Parameters.Add(new SqlParameter("@Fourth", _routine.Fourth));
        cmd.Parameters.Add(new SqlParameter("@Fifth", _routine.Fifth));
        cmd.Parameters.Add(new SqlParameter("@Sixth", _routine.Sixth));
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