using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class defensa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 0; i < 10; i++)
        {
            ASP.construct construccion1;
            construccion1 = (ASP.construct)LoadControl("controls/construccion.ascx");
            construccion1.Titulo = "Titulo"+i;
            contenido.Controls.Add(construccion1);
            
        }
        contenido.Controls.Add(new LiteralControl(" <footer id='FooterConts'  style='clear:both'></footer>"));
        //for (int i = 0; i < 10; i++)
        //{
        //    controls_ctrConstruccion control = (controls_ctrConstruccion)Page.LoadControl(string.Format("~/controls/ctrConstruccion.ascx", "ctrConstruccion"));
        //    control.txt = i.ToString();
        //    Page.Controls.Add(control);
        //}


        //for (int i = 0; i < 10; i++)
        //{
        //    Controls_construccion control = (Controls_construccion)Page.LoadControl(string.Format("controls/construccion.ascx", "construccion"));
        //    control.txt = i.ToString();
        //    Page.Controls.Add(control);
        //}
        
    }
}