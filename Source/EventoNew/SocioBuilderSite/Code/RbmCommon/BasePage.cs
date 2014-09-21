using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Globalization;
using SocioBuilderSite.Code.RbmSecurity;
using System.Configuration;

namespace SocioBuilderSite.Code.RbmCommon
{
    /// <summary>
    /// Summary description for BasePage
    /// </summary>
    public class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {

            //
            // TODO: Add constructor logic here
            //
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            //if (!SecurityManager.isLogged(this))
            //{
            //    string path = "~/" + this.Request.Url.AbsolutePath.Remove(0, 1);
            //    Response.Redirect("~/Administrator/Login/Default.aspx?ReturnUrl=" + path);
            //}
        }

        protected override void InitializeCulture()
        {
            try
            {
                base.InitializeCulture();
                string culture = "en-US";
                string uiculture = "en-US";
                if (!string.IsNullOrEmpty(Request["Culture"]))
                {
                    culture = Request["Culture"];
                }
                else if (Session["CurrentCulture"] != null)
                    culture = Session["CurrentCulture"].ToString();
                if (Session["CurrentCultureUI"] != null)
                    uiculture = Session["CurrentCultureUI"].ToString();
                BusinessLogicLayer.Entities.ContentManagement.Language language = BusinessLogicLayer.Common.LanguageLogic.GetByCode(culture);
                if(language != null)
                    Session["LanguageId"] = language.LanguageId;
                //retrieve culture information from user
                //set culture to current thread
                Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(uiculture);

                //call base class

            }
            catch
            {
            }
        }
        // int version
        public int intItemID
        {
            get { return (ViewState["intItemID"] != null) ? int.Parse(ViewState["intItemID"].ToString()) : 0; }
            set { ViewState["intItemID"] = value.ToString(); }
        }

        // the currently selected item id, where actions like view details, update, delete, etc take place.
        public string ItemID
        {
            get { return (ViewState["ItemID"] != null) ? ViewState["ItemID"] as string : string.Empty; }
            set { ViewState["ItemID"] = value; }
        }

        // redirect to home page
        protected void PageHome()
        {
            string homePage = "~/";
            if (ConfigurationManager.AppSettings["HomePage"] != null)
                homePage = ConfigurationManager.AppSettings["HomePage"];
            // transfer execution to it        
            Response.Redirect(ResolveUrl(homePage));
        }

        // redirect to login
        protected void PageLogin()
        {
            string LoginPage = "~/LoginForm.aspx";
            //if (ConfigurationManager.AppSettings["LoginPage"] != null)
            //    LoginPage = ConfigurationManager.AppSettings["LoginPage"];
            // transfer execution to it        
            Response.Redirect(ResolveUrl(LoginPage));
        }



        // onError, redirect the browser to the error page
        protected void PageError(string msg)
        {
            // store msg into session
            Session.Add("ErrorMsg", msg);
            // get error page
            string errorPage = "~/Error.aspx";
            if (ConfigurationManager.AppSettings["ErrorPage"] != null)
                errorPage = ConfigurationManager.AppSettings["ErrorPage"];
            // transfer execution to it        
            Response.Redirect(ResolveUrl(errorPage));
        }


    }
}