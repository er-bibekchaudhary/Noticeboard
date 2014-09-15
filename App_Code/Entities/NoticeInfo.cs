using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NoticeInfo
/// </summary>
public class NoticeInfo
{
    public int NoticeID { get; set; }
    public int FacutlyID { get; set; }
    public int BatchID{ get; set; }
    public string Reference { get; set; }
    public string Notice { get; set; }
    public DateTime PostedOn { get; set; }
    public int PostedBy { get; set; }
	public NoticeInfo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}