using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsDemo.Models;

namespace WebFormsDemo
{
    public partial class About : Page
    {
        public List<TeamMember> TeamMembers = new List<TeamMember>()
        {
            new TeamMember(){FirstName = "Gosho", LastName = "Petrov"},
            new TeamMember(){FirstName = "Pesho", LastName = "Goshev"},
            new TeamMember(){FirstName = "Bai", LastName = "Ivan", Email = "baiivan@abv.bg"},
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ListviewMembers.DataSource = TeamMembers;
            this.ListviewMembers.DataBind();
        }

    }
}