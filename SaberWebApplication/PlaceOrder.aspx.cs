using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaberWebApplication
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SaberServiceReference.SaberWebServiceSoapClient obj = new SaberServiceReference.SaberWebServiceSoapClient();
            var result = obj.PlaceOrder(Convert.ToInt32(txtItemCode.Text), txtItemName.Text, txtUOM.Text, Convert.ToInt32(txtQty.Text), txtTransactionType.Text, txtDocNumber.Text, txtDate.Text);
            if (result)
                lblResult.Text = "Order added successfully";
            else
                lblResult.Text = "Failed to add Order";
            lblResult.Visible = true;
        }
    }
}