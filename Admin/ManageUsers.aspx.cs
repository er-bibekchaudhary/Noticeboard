using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Admin_ManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
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


    protected void BtnCreate_Click(object sender, EventArgs e)
    {
    
    }

    protected void CreateMembership()
    {
        MembershipCreateStatus _status;

        string username = TxtUName.Text + TxtEmpID;

        var user = Membership.CreateUser(username, "Password!2", TxtEmail.Text, null, null, true, out _status);
        switch (_status)
        {
            case MembershipCreateStatus.Success:

                Roles.AddUserToRole(username, "Teachers");
                CreateTeachers();
                Session["UserName"] = username;
                break;
            case MembershipCreateStatus.DuplicateUserName:
                LblCreateMsg.Text = "The Mobile Number already Registered";
                break;
            case MembershipCreateStatus.InvalidEmail:
                LblCreateMsg.Text = "The email entered is invalid";
                break;
            case MembershipCreateStatus.DuplicateEmail:
                LblCreateMsg.Text = "The email is already in use";
                break;
            case MembershipCreateStatus.InvalidPassword:
                LblCreateMsg.Text = "The pasword must contain atleast 6 words, one Capital Letter and one Character";
                break;
            default:
                LblCreateMsg.Text = "Some error occured";
                break;
        }
    }

    protected void CreateTeachers()
    {
        TeachersInfo _teacher = new TeachersInfo();
        _teacher.FirstName = TxtUName.Text;
        _teacher.LastName = TxtLastName.Text;
        _teacher.EmpID = int.Parse(TxtEmpID.Text);
        _teacher.Email = TxtEmail.Text;
        _teacher.ContactNo = TxtContact.Text;
        _teacher.Address = TxtAddress.Text;
        _teacher.DepartmentID = int.Parse(DdlDept.SelectedValue);

        try
        {
            TeacherDAL.CreateTeachers(_teacher);
            LblCreateMsg.Text = "Successfully Created!!!";
        }
        catch (Exception ex)
        {
            LblCreateMsg.Text = ex.Message;
        }
    }
}
