using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for RoutineDAL
/// </summary>
public class RoutineDAL
{
	 public static void CreateNotice(RoutineInfo _routine)
    {
        SqlConnection Con = ConnectionHelper.GetConnection();
        string Sp = "USP_Create_Routine";
         SqlCommand cmd = new SqlCommand(Sp, Con);
        cmd.Parameters.Add(new SqlParameter("@DayID",_routine.DayID));
        cmd.Parameters.Add(new SqlParameter("@ClassID",_routine.ClassID));
        cmd.Parameters.Add(new SqlParameter("@First",_routine.First));
        cmd.Parameters.Add(new SqlParameter("@Second",_routine.Second));
        cmd.Parameters.Add(new SqlParameter("@Third",_routine.Third));
        cmd.Parameters.Add(new SqlParameter("@Fourth",_routine.Fourth));
         cmd.Parameters.Add(new SqlParameter("@Fifth",_routine.Fifth));
         cmd.Parameters.Add(new SqlParameter("@Sixth",_routine.Sixth));
        cmd.CommandType=CommandType.StoredProcedure;
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
}