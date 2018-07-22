using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace RajSoniPricingAsh
{
    public partial class SelectedItemDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                GvDetails.DataSource = new List<Item>
                {
                     new Item {Product = "HCLLaptop", price=50,discount=5},
                     new Item { Product = "HPLaptop", price = 150, discount = 10 },
                     new Item {Product = "DellLaptop", price=170,discount=15},
                     new Item {Product = "MILaptop", price=70,discount=7},
                     

                };
                GvDetails.DataBind();
            }



        }

        protected void btnAmt_Click(object sender, EventArgs e)
        {
            decimal totalamt = 0;
            String Str="";
            foreach (GridViewRow row in GvDetails.Rows)
            {

                CheckBox chkSelect =(CheckBox) row.FindControl("ChkSelect");
                if (chkSelect.Checked)
                {
                    
                    totalamt = totalamt+(Convert.ToDecimal(row.Cells[2].Text) - Convert.ToDecimal(row.Cells[3].Text));

                    Str = Str + string.Format("Selected Product: {0}, Discounted Price:{1}  ", row.Cells[1].Text, (Convert.ToDecimal(row.Cells[2].Text) - Convert.ToDecimal(row.Cells[3].Text)));
                }

            }
            lblselected.Text = Str;
            lblpay.Text ="Total Pay :" + totalamt.ToString();
        }
    }
}