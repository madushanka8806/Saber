
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaberWebApplication
{
    public partial class SearchIteambyName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SaberServiceReference.SaberWebServiceSoapClient obj = new SaberServiceReference.SaberWebServiceSoapClient();

            dlProduct.DataSource = obj.SearchItembyName(txtProductName.Text);
            dlProduct.DataBind();
        }
    }
}