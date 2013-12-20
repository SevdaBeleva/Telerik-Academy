using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal first = decimal.Parse(this.TextBoxFirstNumber.Text);
                decimal second = decimal.Parse(this.TextBoxSecondNumber.Text);
                decimal result = first + second;
                this.TextBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                this.TextBoxResult.Text = "invalid operation!";
            }
        }
    }
}