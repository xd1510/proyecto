using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class controls_ctrConstruccion : System.Web.UI.UserControl
{
    //private String texto = "";
    public string txt
    {
        get { return lbl.Text.Trim(); }
        set { lbl.Text = value; }
    }
    public string txt2
    {
        get { return Label1.Text.Trim(); }
        set { Label1.Text = value; }
    }

    public controls_ctrConstruccion()
    {
      
    }
}