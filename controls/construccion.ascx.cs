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

public partial class Controls_construccion : System.Web.UI.UserControl
{
    public string Titulo
    {
        get { return lblTitulo.Text.Trim(); }
        set { lblTitulo.Text = value; }
    }
    public string Mejoras
    {
        get { return lblMejoras.Text.Trim(); }
        set { lblMejoras.Text = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }
}