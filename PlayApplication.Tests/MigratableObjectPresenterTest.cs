using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ninject;
using Moq;
using WebFront.model;
using WebFront.presentation;
using WebFront;

namespace PlayApplication.Tests
{
    [TestFixture]
    class MigratableObjectPresenterTest
    {

        //Upon Build, isMigrated is false
        //After migration, it is true

        [Test]
        public void Not_Migrated_When_Created()
        {
            var migratableMock =new Mock<IMigratable>(); //a mock migratable object
            migratableMock.Setup(foo => foo.migrated).Returns(false); //it is not migrated
            IMigratable migObject = migratableMock.Object;

            var migratableViewMock =new Mock<IMigratableView>(); //a mock migratable object view
            migratableViewMock.Setup(foo => foo.Migrated).Returns(false); //it is showing "unmigrated"
            IMigratableView migObjectView = migratableViewMock.Object;

            MigratableObjectPresenter myMigObjPresenter = new MigratableObjectPresenter(migObjectView, migObject); //create the presenter to test
           
            Assert.AreEqual(false,myMigObjPresenter.isMigrated);

        }

        [Test]
        public void Migration_Updates_View()
        {
            var migratableMock = new Mock<IMigratable>(); //a mock migratable object
            migratableMock.Setup(foo => foo.migrated).Returns(false); //it is not migrated
            migratableMock.SetupProperty(f => f.migrated);
            IMigratable migObject = migratableMock.Object;

            var migratableViewMock = new Mock<IMigratableView>(); //a mock migratable object view
            migratableViewMock.Setup(foo => foo.Migrated).Returns(false); //it is showing "unmigrated"
            migratableViewMock.SetupProperty(f => f.Migrated);
            IMigratableView migObjectView = migratableViewMock.Object;

            MigratableObjectPresenter myMigObjPresenter = new MigratableObjectPresenter(migObjectView, migObject); //create the presenter to test

            myMigObjPresenter.Migrate();

            Assert.AreEqual(true, migObjectView.Migrated);
        }

                

        [Test]
        public void Migration_Migrates()
        {
            var migratableMock = new Mock<IMigratable>(); //a mock migratable object
            migratableMock.Setup(foo => foo.migrated).Returns(false); //it is not migrated
            migratableMock.SetupProperty(f => f.migrated);
            IMigratable migObject = migratableMock.Object;

            var migratableViewMock = new Mock<IMigratableView>(); //a mock migratable object view
            migratableViewMock.Setup(foo => foo.Migrated).Returns(false); //it is showing "unmigrated"
            migratableViewMock.SetupProperty(f => f.Migrated);
            IMigratableView migObjectView = migratableViewMock.Object;

            MigratableObjectPresenter myMigObjPresenter = new MigratableObjectPresenter(migObjectView, migObject); //create the presenter to test
            Console.WriteLine("Created Presenter, calling Migrate()");
            myMigObjPresenter.Migrate();

            Assert.AreEqual(true, myMigObjPresenter.isMigrated);
        }

        [Test]
        public void Load_Loads_From_Model()
        {
            var migratableMock = new Mock<IMigratable>(); //a mock migratable object
            migratableMock.Setup(foo => foo.migrated).Returns(false); //it is not migrated
            migratableMock.SetupProperty(f => f.migrated); 
            IMigratable migObject = migratableMock.Object;

            var migratableViewMock = new Mock<IMigratableView>(); //a mock migratable object view
            migratableViewMock.Setup(foo => foo.Migrated).Returns(false); //it is showing "unmigrated"
            migratableViewMock.SetupProperty(f => f.Migrated);
            IMigratableView migObjectView = migratableViewMock.Object;

            MigratableObjectPresenter myMigObjPresenter = new MigratableObjectPresenter(migObjectView, migObject); //create the presenter to test
            myMigObjPresenter.LoadFromModel();
            Assert.AreEqual(false, myMigObjPresenter.isMigrated);
            migObject.migrated = true;
            myMigObjPresenter.LoadFromModel();
            Assert.AreEqual(true, myMigObjPresenter.isMigrated);
            migObject.migrated = false;
            myMigObjPresenter.LoadFromModel();
            Assert.AreEqual(false, myMigObjPresenter.isMigrated);
        }

        [Test]
        public void Save_Saves_To_Model()
        {
            var migratableMock = new Mock<IMigratable>(); //a mock migratable object
            migratableMock.Setup(foo => foo.migrated).Returns(false); //it is not migrated
            migratableMock.SetupProperty(f => f.migrated);
            IMigratable migObject = migratableMock.Object;

            var migratableViewMock = new Mock<IMigratableView>(); //a mock migratable object view
            migratableViewMock.Setup(foo => foo.Migrated).Returns(false); //it is showing "unmigrated"
            migratableViewMock.SetupProperty(f => f.Migrated);
            IMigratableView migObjectView = migratableViewMock.Object;

            Console.WriteLine("Setting up");
            MigratableObjectPresenter myMigObjPresenter = new MigratableObjectPresenter(migObjectView, migObject); //create the presenter to test
            Assert.AreEqual(false, myMigObjPresenter.isMigrated, "Setup");
            Console.WriteLine("Set up done.");
            myMigObjPresenter.isMigrated = true;
            Console.WriteLine("Changed property isMigrated to true."); 
            Assert.AreEqual(true, myMigObjPresenter.isMigrated, "Step 1");
            myMigObjPresenter.SaveToModel();
            Assert.AreEqual(true, myMigObjPresenter.isMigrated, "Step 2");
            Assert.AreEqual(true, migObject.migrated, "Step 3");

        }

        [Test]
        public void Sync_Saves_To_Model()
        {
            var migratableMock = new Mock<IMigratable>(); //a mock migratable object
            migratableMock.Setup(foo => foo.migrated).Returns(false); //it is not migrated
            migratableMock.SetupProperty(f => f.migrated);
            IMigratable migObject = migratableMock.Object;

            var migratableViewMock = new Mock<IMigratableView>(); //a mock migratable object view
            migratableViewMock.Setup(foo => foo.Migrated).Returns(false); //it is showing "unmigrated"
            migratableViewMock.SetupProperty(f => f.Migrated);
            IMigratableView migObjectView = migratableViewMock.Object;

            Console.WriteLine("Setting up");
            MigratableObjectPresenter myMigObjPresenter = new MigratableObjectPresenter(migObjectView, migObject); //create the presenter to test
            Assert.AreEqual(false, myMigObjPresenter.isMigrated, "Setup");
            Console.WriteLine("Set up done.");
            myMigObjPresenter.isMigrated = true;
            Console.WriteLine("Changed property isMigrated to true.");
            Assert.AreEqual(true, myMigObjPresenter.isMigrated, "Step 1");
            myMigObjPresenter.Sync();
            Assert.AreEqual(true, myMigObjPresenter.isMigrated, "Step 2");
            Assert.AreEqual(true, migObject.migrated, "Step 3");

        }


    }
}
