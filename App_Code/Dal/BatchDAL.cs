using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for BatchDAL
/// </summary>
public class BatchDAL
{
    public static void CreateBatch(int Year)
    {
        SqlConnection Con = ConnectionHelper.GetConnection();
        string Sp = "USP_Create_Batch";
        SqlCommand cmd = new SqlCommand(Sp, Con);
        cmd.Parameters.Add(new SqlParameter("@Year", Year));
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
    public static DataTable getallBatch()
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetAll_Batch";
        SqlCommand cmd = new SqlCommand(sp,con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public static BatchInfo getBatchByID(int id)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_GetBatch_ByID";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@ID",id));
        cmd.CommandType=CommandType.StoredProcedure;
        try
        {
            SqlDataReader _Reader = cmd.ExecuteReader();
            _Reader.Read();

            BatchInfo _batch = new BatchInfo();
            _batch.BatchID = int.Parse(_Reader["BatchID"].ToString());
            _batch.Year = int.Parse(_Reader["BatchYear"].ToString());
            return _batch;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void Editbatch(BatchInfo _batch)
    {
        SqlConnection con = ConnectionHelper.GetConnection();
        string sp = "USP_Update_Batch";
        SqlCommand cmd = new SqlCommand(sp, con);
        cmd.Parameters.Add(new SqlParameter("@BatchID",_batch.BatchID));
        cmd.Parameters.Add(new SqlParameter("@Year",_batch.Year));
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