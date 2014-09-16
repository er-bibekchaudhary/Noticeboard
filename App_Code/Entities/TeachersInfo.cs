using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TeachersInfo
/// </summary>
public class TeachersInfo
{
    public int TeachersID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DepartmentID { get; set; }
    public int EmpID { get; set; }
    public string Address { get; set; }
    public string ContactNo { get; set; }
    public string Email { get; set; }
	public TeachersInfo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}