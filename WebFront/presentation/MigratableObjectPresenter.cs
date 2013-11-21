using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFront.model;
using Ninject;
using Moq;
using System.Diagnostics;

namespace WebFront.presentation
{
    /// <summary>
    /// A class to present a Dino to the VIEW (i.e. the ASPX)
    /// it provides functionality to the view and support synchronisation with the model
    /// that is the actual dinos
    /// </summary>
    public class MigratableObjectPresenter
    {
        /// <summary>
        /// the Migration-Object to present
        /// </summary>
        private IMigratable migratableObject;

        /// <summary>
        /// The View
        /// </summary>
        private IMigratableView _migView;

        //all relevant data for presentation

        /// <summary>
        /// Whether or not the presenter shows something migrated
        /// </summary>
        protected Boolean _migrated;


        /// <summary>
        /// Public Constructor
        /// </summary>
        [Inject]
        public MigratableObjectPresenter(IMigratableView migView, IMigratable migObject)
        {
            migratableObject = migObject;
            _migView = migView;
            this.Sync();
        }



        /// <summary>
        /// Query whether presented object is migrated
        /// </summary>
        public Boolean isMigrated{
            get
            {
                return _migrated;
            }

            set
            {
                Console.WriteLine("Setting _migrated to " + value.ToString());
                _migrated = value;
                Console.WriteLine("It is now " + _migrated.ToString());
            }
            
        }

        //actions the presenter supports
      
        /// <summary>
        /// The presented Object can be migrated
        /// </summary>
        public void Migrate(){
            Console.WriteLine("Setting migrated from " + isMigrated.ToString());
            isMigrated=true;  //change migration attribute
            Console.WriteLine("Set migrated to " + isMigrated.ToString());
            Sync(); //Sync with model
            Console.WriteLine("After Sync " + isMigrated.ToString());

        }

        public void LoadFromModel()
        {
            _migrated = migratableObject.migrated;
        }

        public void SaveToModel()
        {
            migratableObject.migrated = _migrated;
        }

        public void Sync()
        {
            SaveToModel();
            LoadFromModel();
            _migView.Migrated = _migrated; //set the view
        }
           
        
    }
}