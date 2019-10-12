using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsDemo
{
    public partial class _Default : Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void OnBtnSumClick(object sender, EventArgs e)
        {
            var inputOne = int.Parse(this.InputOne.Text);
            var inputTwo = int.Parse(this.InputTwo.Text);
            this.LblResult.Text = (inputOne + inputTwo).ToString();
        }
    }
}