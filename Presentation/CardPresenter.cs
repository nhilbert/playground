using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Playground.Model;

namespace Playground.Presentation
{
    public class CardPresenter:ICardPresenter
    {
        /// <summary>
        /// the Migration-Objects to present
        /// </summary>
        protected List<ICardable> _cardObjects;
        private List<ICardable>.Enumerator _cardEnumerator;

        /// <summary>
        /// The View
        /// </summary>
        private ICardView _view;

        //all relevant data for presentation

        /// <summary>
        /// The stuff the presenter currently shows
        /// </summary>
        protected String _name;
        protected String _imageURL;

        [Inject]
        public CardPresenter(List<ICardable> cardObjects)
        {
            _cardObjects = cardObjects;
            _cardEnumerator = _cardObjects.GetEnumerator();
            _cardEnumerator.MoveNext();
        }

        protected void ResetEnumerator(){
            _cardEnumerator = _cardObjects.GetEnumerator();
            _cardEnumerator.MoveNext();
        }


        public void RegisterView(ICardView view)
        {
            _view = view;
        }
 


        public void LoadFromModel()
        {
            _name = _cardEnumerator.Current.Name;
            _imageURL = _cardEnumerator.Current.ImageURL;
        }

        public void SaveToModel()
        {
            _cardEnumerator.Current.Name = _name;
            _cardEnumerator.Current.ImageURL = _imageURL;
        }

        public void Sync()
        {
            SaveToModel();
            LoadFromModel();
            _view.Name = _name; //set the view
            _view.ImageURL = _imageURL; //set the view
        }



        public void Next()
        {
            if (_cardEnumerator.MoveNext())
            {
                LoadFromModel();
                SaveToModel();
                _view.Name = _name; //set the view
                _view.ImageURL = _imageURL; //set the view
            }
        }

    }
}
