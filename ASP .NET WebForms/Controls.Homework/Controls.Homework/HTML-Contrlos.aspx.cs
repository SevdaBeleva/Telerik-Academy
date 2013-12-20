using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls.Homework
{
    public partial class HTML_Contrlos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Generate_Numbers(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.textRandom1.Value);
            int num2 = int.Parse(this.textRandom2.Value);
          
            Random random = new Random();
             
            this.textRezult.Value = Convert.ToString(random.Next(num1, num2+1));
                                 
        }
    }
}