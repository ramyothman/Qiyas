using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace SocioBuilderSite.Controls
{
    public partial class FormControl : System.Web.UI.UserControl
    {
        private string _text;
        [WebBrowsable()]
        [Personalizable()]
        public string Title
        {
            set { _text = value; Label1.Text = _text; }
            get { return _text; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Text = TextBox1.Text;
        }
    }
}