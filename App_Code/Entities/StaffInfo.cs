using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StaffInfo
/// </summary>
public class StaffInfo
{
    public int StaffID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DepartmentID { get; set; }
    public string Address { get; set; }
    public string ContactNo { get; set; }
    public string Email { get; set; }
	public StaffInfo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}