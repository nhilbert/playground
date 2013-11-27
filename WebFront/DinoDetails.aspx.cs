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
        private ICardPresenter cardPresenter;

        public String Name {get; set;}
        public String ImageURL { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            


        }
    }
}