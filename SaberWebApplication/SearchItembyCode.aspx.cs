using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaberWebApplication
{
    public partial class SearchItembyCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SaberServiceReference.SaberWebServiceSoapClient obj = new SaberServiceReference.SaberWebServiceSoapClient();

            dlProduct.DataSource = obj.SearchItembyCode(Convert.ToInt32(txtProductId.Text));
            dlProduct.DataBind();
        }
    }
}