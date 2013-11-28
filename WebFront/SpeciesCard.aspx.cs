using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Playground.Presentation;

namespace Playground.WebFront
{
    public partial class DinoDetails : System.Web.UI.Page, ICardView
    {
        private ICardPresenter _presenter;

        public String Name {
            get { return Name;} 
            set {
                Name = value;
                SpeciesName.Text = Name;
            }
        }

        public String ImageURL {
            get { return ImageURL; } 
            set{
                ImageURL = value;
                SpeciesImage.ImageUrl = ImageURL;
            } }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (_presenter == null)
            {
                _presenter = PresenterFactory.GetICardPresenter();
            }

            _presenter.RegisterView(this);


        }

        protected void NextButton_Click(object sender, EventArgs e)
        {
            _presenter.Next();
        }
    }
}