using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Playground.Model;

namespace Playground.Presentation
{
    class CardPresenter
    {
        /// <summary>
        /// the Migration-Object to present
        /// </summary>
        private IMigratable migratableObject;

        /// <summary>
        /// The View
        /// </summary>
        private ICardView _view;

        //all relevant data for presentation

        /// <summary>
        /// Whether or not the presenter shows something migrated
        /// </summary>
        protected String _name;
        protected String _imageURL;

        [Inject]
        public CardPresenter(IMigratable migObject){
            migratableObject = migObject;
        }


        public void RegisterView(ICardView view)
        {
            _view = view;
        }
 


        public void LoadFromModel()
        {
            _name = migratableObject.name;
            _imageURL = migratableObject.imageURL;
        }

        public void SaveToModel()
        {
            migratableObject.name = _name;
        }

        public void Sync()
        {
            SaveToModel();
            LoadFromModel();
            _view.Name = _name; //set the view
        }
           
    }
}
