using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Notice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int Number1 = int.Parse(Request.QueryString["id"]);
        NoticeInfo _Notice = NoticeDAL.getNoticeByID(Number1);
        LblHeading.Text = _Notice.Reference;
        LblBody.Text = _Notice.Notice;
        Lbldate.Text = (_Notice.PostedOn.Date).ToString();
        string name= TeacherDAL.getTeacherByID(_Notice.PostedBy).FirstName + TeacherDAL.getTeacherByID(_Notice.PostedBy).LastName;
        LblName.Text = name;

    }
}