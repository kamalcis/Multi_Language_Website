using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;


namespace MultiLanguageWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = GetLocalResourceObject("PageTitle").ToString();  // Greenlandinc Resources have been called. 
            Label2.Text = GetLocalResourceObject("lblMessage").ToString();

        }

        protected override void InitializeCulture()
        {
            string thisCulture = Session["site_culture"].ToString();
            if (!thisCulture.Equals(""))
            {
                String selectedLanguage = thisCulture; // "fi-FI"; //"en-US";

                UICulture = selectedLanguage;
                Thread.CurrentThread.CurrentUICulture = new
                    CultureInfo(selectedLanguage);
            }
            base.InitializeCulture();
        }

    }
}