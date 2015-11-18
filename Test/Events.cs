using DAL.Data.UnitofWork;
using DAL.Fake.Repo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class OwnersControllerTest
    {
     //   public OwnersController Controller;

        [TestInitialize]
        public void Initialize()
        {
            // Arrange
            var eventsRepo = new FakeEventsRepository();
            var uow = new UnitofWork { EventRepository = eventsRepo };
           // Controller = new OwnersController(uow);
        }

        [TestMethod]
        //public void IndexShouldListAllOwners()
        //{
        //    // Act
        //    var actual = Controller.Index();

        //    // Assert
        //    var viewResult = actual as ViewResult;
        //    if (viewResult == null) return;
        //    var data = viewResult.ViewData.Model as IList<Owner>;
        //    if (data != null) Assert.AreEqual(3, data.Count);
        //}

        [TestCleanup]
        public void CleanUp()
        {
          //  Controller.Dispose();
        }
    }
}
