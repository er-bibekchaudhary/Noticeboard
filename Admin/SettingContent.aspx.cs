using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_SettingContent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        loadReapeters();
    }
    protected void LbtEditBatch_Click(object sender, EventArgs e)
    {
        PnlFaculty.Visible = false;
        PnlBatch.Visible = true;
        LblResult.Text = " ";
        TxtBatch.Text = " ";
    }
    protected void LbtEditFaculty_Click(object sender, EventArgs e)
    {
        PnlFaculty.Visible = true;
        PnlBatch.Visible = false;
        LblResult.Text = " ";
        TxtFaculty.Text = " ";
    }
    protected void BtnAddBatch_Click(object sender, EventArgs e)
    {
        string Year = TxtBatch.Text;
        bool flag = true;
        if (Year.Length == 4)
        {
            char[] numb = (TxtBatch.Text).ToCharArray();
            int i = 0;
            foreach (char a in numb)
            {
                if (numb[i] != '0' && numb[i] != '1' && numb[i] != '2' && numb[i] != '3' && numb[i] != '4' && numb[i] != '5' && numb[i] != '6' && numb[i] != '7' && numb[i] != '8' && numb[i] != '9')
                {
                    LblResult.Text = "Please Enter only Numbers";
                    flag = false;
                }
                i = i + 1;
            }
            if (flag == true)
            {
                if (BatchDAL.CheckBatch(int.Parse(TxtBatch.Text)))
                {
                    try
                    {
                        BatchDAL.CreateBatch(int.Parse(TxtBatch.Text));
                        LblResult.Text = "Batch Successfully added ";
                        loadReapeters();
                    }
                    catch (Exception ex)
                    {
                        LblResult.Text = ex.Message;
                    }

                }
                else
                {
                    LblResult.Text = "Batch Already Exists";
                }
            }
        }
        else
        {
            LblResult.Text = "Enter a 4 digits of year";
        }


    }
    protected void BtnAddFaculty_Click(object sender, EventArgs e)
    {
        if (FacultyDAL.CheckFaculty(TxtFaculty.Text))
        {
            try
            {
                FacultyDAL.CreateFaculty(TxtFaculty.Text);
                LblResult.Text = "Batch Successfully added";
                loadReapeters();
            }
            catch (Exception ex)
            {
                LblResult.Text = ex.Message;
            }
        }
        else
        {
            LblResult.Text = "Faculty Already Exist";
        }

    }



    protected void BtnDeleteFaculty_Click(object sender, EventArgs e)
    {
        int id = int.Parse((sender as Button).CommandArgument.ToString());
        FacultyDAL.DeleteFaculty(id);
        loadReapeters();
    }
    protected void BtnDeleteBatch_Click(object sender, EventArgs e)
    {
       int id = int.Parse((sender as Button).CommandArgument.ToString());
       BatchDAL.Deletebatch(id);
       loadReapeters();
    }

    protected void loadReapeters()
    {
        RptrBatch.DataSource = BatchDAL.getallBatch();
        RptrBatch.DataBind();

        RptrFaculty.DataSource = FacultyDAL.getallFaculty();
        RptrFaculty.DataBind();
    }
}