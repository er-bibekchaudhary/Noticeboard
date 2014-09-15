using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageNotices : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PnlEditNotice.Visible = false;
        PnlAddNotice.Visible = false;
    }
    protected void DdlOperation_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (DdlOperation.SelectedItem.ToString() == "Add Notice")
        {
            PnlAddNotice.Visible = true;
            PnlEditNotice.Visible = false;
        }
        if (DdlOperation.SelectedItem.ToString() == "Edit Notice")
        {
            PnlAddNotice.Visible = false;
            PnlEditNotice.Visible = true;
        }

    }
}