using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PnlCreateUser.Visible = false;
        PnlEditUser.Visible = false;
    }

    protected void DdlTask_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DdlTask.SelectedItem.ToString() == "Create User")
        {
            PnlCreateUser.Visible = true;
            PnlEditUser.Visible = false;
        }
        if (DdlTask.SelectedItem.ToString() == "Edit User")
        {
            PnlCreateUser.Visible = false;
            PnlEditUser.Visible= true;
        }

    }
}
