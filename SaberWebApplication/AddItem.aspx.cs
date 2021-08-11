using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaberWebApplication
{
    public partial class AddItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SaberServiceReference.SaberWebServiceSoapClient obj = new SaberServiceReference.SaberWebServiceSoapClient();
            lblResult.Text = obj.AddItem(Convert.ToInt32(txtItemCode.Text), txtItemName.Text, txtUOM.Text, Convert.ToInt32(txtAvailableQty.Text));
            lblResult.Visible = true;
        }
    }
}