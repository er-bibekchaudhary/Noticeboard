using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Binddropdowns();
            BindRepeter();
        }
    }

    protected void BindRepeter()
    {
        rptrAll.DataSource = NoticeDAL.getallNotice();
        rptrAll.DataBind();
    }

    protected void Binddropdowns()
    {
        DDLFaculty.DataSource = FacultyDAL.getallFaculty();
        DDLFaculty.DataTextField = "FacultyName";
        DDLFaculty.DataValueField = "FacultyID";
        DDLFaculty.DataBind();
        DDLFaculty.Items.Insert(0, "--Choose Faculty--");

        DDLBatch.DataSource = BatchDAL.getallBatch();
        DDLBatch.DataTextField = "BatchYear";
        DDLBatch.DataValueField = "BatchID";
        DDLBatch.DataBind();
        DDLBatch.Items.Insert(0, "--Choose Batch--");
    }
    protected void BtnSignUp_Click(object sender, EventArgs e)
    {

    }
}