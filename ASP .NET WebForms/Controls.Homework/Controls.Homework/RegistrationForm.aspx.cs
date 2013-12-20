using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controls.Homework
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_RegistrationForm(object sender, EventArgs e)
        {
            string fName = this.textFirstName.Text;
            string lName = this.textLastName.Text;
            string fNumber = this.textFacNumber.Text;
            string university = this.textUniversity.Text;
            var specialty = this.textSpecialty.Items;
            string specialties = "";

            for (int i = 0; i < specialty.Count; i++)
            {
                if (specialty[i].Selected)
                {
                    specialties += Server.HtmlEncode(specialty[i].Text) + ", ";
                }
            }

            this.displaySubmited.Text += "<h2>" + Server.HtmlEncode(fName) + Server.HtmlEncode(lName) + "</h2>";
            this.displaySubmited.Text += "<p>" + Server.HtmlEncode(fNumber) + "<br/>";
            this.displaySubmited.Text += Server.HtmlEncode(university) + "<br/>";
            this.displaySubmited.Text += Server.HtmlEncode(specialties) + "</p>";
        }
    }
}