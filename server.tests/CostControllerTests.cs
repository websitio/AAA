using Microsoft.VisualStudio.TestTools.UnitTesting;
using server.Controllers;

namespace server.tests
{
    [TestClass]
    public class CostControllerTests
    {
       
        
        [TestMethod]
        public void GetAll()
        {
            var controller = new CostController();

            var result = controller.GetAll();

            Assert.IsNotNull(result);
      }

        /*

        [TestMethod]
        public void GetUsersl()
        {
            var controller = new CostController();
            var result = controller.GetAllUsers();
            Assert.IsNotNull(result);
        }
   
        
        
       [TestMethod]
    public void GetAllCosts()
    {
        var controller = new CostController();
        var result = controller.GetAllCosts();
        Assert.IsNotNull(result);
    }     
        
        */

    } //eoc
}  //eon