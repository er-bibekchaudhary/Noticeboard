using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teachers_Settings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LbtPerDetails_Click(object sender, EventArgs e)
    {
        pnlPersonal.Visible = true;
        PnlPassword.Visible = false;
    }
    protected void LbtPassword_Click(object sender, EventArgs e)
    {

        pnlPersonal.Visible = false;
        PnlPassword.Visible = true;
    }
}