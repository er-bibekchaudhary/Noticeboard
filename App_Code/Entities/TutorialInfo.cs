using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TutorialInfo
/// </summary>
public class TutorialInfo
{
    public int TutorialID { get; set; }
    public int FacultyID { get; set; }
    public int BatchID { get; set; }
    public string Reference { get; set; }
    public string FileName { get; set; }
    public DateTime PostedOn { get; set; }
    public string PostedBy { get; set; }
    public DateTime Deadline { get; set; }
	public TutorialInfo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}