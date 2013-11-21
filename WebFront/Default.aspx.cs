using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ninject;
using WebFront.presentation;
using WebFront.model;
using System.Configuration;


namespace WebFront
{
    public partial class Default : System.Web.UI.Page, IMigratableView
    {
        MigratableObjectPresenter myPresentation;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Setup everything on page load, i.e. create an object to migrate
            var kernel = new StandardKernel(new MigObjectModule());
            var mObjModel = kernel.Get<IMigratable>();

            //create a presentation for the object generated
            myPresentation = new MigratableObjectPresenter(this, mObjModel);
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