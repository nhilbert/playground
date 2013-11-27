using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ninject;
using Playground.Presentation;
using System.Configuration;


namespace Playground.WebFront
{
    public partial class Default : System.Web.UI.Page, IMigratableView
    {
        [Inject] 
        public IMigratableObjectPresenter myPresentation{get; set;}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (myPresentation == null)
            {
                myPresentation = PresenterFactory.GetIMigratableObjectPresenter();
            }
            
            myPresentation.RegisterView(this);
        }

        protected void MigrationButtonClick(object sender, EventArgs e)
        {
            myPresentation.Migrate();
        }


        public bool Migrated
        {
            get
            {
                if (MigrationStatus.Text == ConfigurationManager.AppSettings["TextMigTrue"]) return true;
                return false;
            }
            set
            {
                if (value == false) MigrationStatus.Text = ConfigurationManager.AppSettings["TextMigFalse"];
                else MigrationStatus.Text = ConfigurationManager.AppSettings["TextMigTrue"];
            }
        }
    }
}