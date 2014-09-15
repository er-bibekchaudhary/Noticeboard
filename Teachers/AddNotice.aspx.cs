using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teachers_AddNotice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PnlEditNotice.Visible = false;
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
    protected void DdlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DdlType.SelectedItem.ToString() == "General Notice")
        {
            pnlDeadLine.Visible=false;
        }
        if (DdlType.SelectedItem.ToString() == "Tutorials")
        {
            pnlDeadLine.Visible = true;
        }
    }
}