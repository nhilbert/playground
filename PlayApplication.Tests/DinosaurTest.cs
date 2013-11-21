using System;
using NUnit.Framework;
using WebFront.model;

namespace PlayApplication.Tests
{
    [TestFixture]
    public class DinosaurTest
    {

        //A dinosaur can be migrated
        //A dinosaur is "unmigrated" when created.

        [Test]
        public void A_Dinosaur_Can_Be_Migrated()
        {
            Dinosaur dinosaur = new Dinosaur(); 
            dinosaur.Migrate();
            Assert.AreEqual(true, dinosaur.migrated);
        }

        [Test]
        public void A_Dinosaur_Is_Not_Migrated_at_Beginning()
        {
            Dinosaur dinosaur = new Dinosaur(); 
            Assert.AreEqual(false, dinosaur.migrated);
        }

    }
}
