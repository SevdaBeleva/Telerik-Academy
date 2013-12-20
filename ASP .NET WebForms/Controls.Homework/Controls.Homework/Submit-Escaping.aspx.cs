using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls.Homework
{
    public partial class Submit_Escaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Display_Text(object sender, EventArgs e)
        {
            string enteredText = textValue.Text;
            submitedText.Text = enteredText;
        }
    }
}