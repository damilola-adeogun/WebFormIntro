using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WFTest.Core.Entity;
using WFTest.Core.Factory;
using WFTest.Repository.Repository;

namespace WFTest.LevelMgt
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LevelFactory levelFactory = new LevelFactory();
            LevelRepository levelRepository = new LevelRepository();

            string error;
            if(!levelFactory.validate(txtName.Text, txtCode.Text, out error))
            {
                lbErrorMsg.Text = error;
                return;
            }

            Level theLevel = levelFactory.Create(txtName.Text, txtCode.Text, txtDescription.Text);

            if (theLevel != null)
            {
                levelRepository.CreatLevel(theLevel);

                Response.Redirect("View.aspx");
            }

        }
    }
}