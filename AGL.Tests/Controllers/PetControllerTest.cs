using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGL;
using AGL.Controllers;
using AGL.Business;
using AGL.Data;

namespace AGL.Tests.Controllers
{
  [TestClass]
  public class PetControllerTest
  {
    [TestMethod]
    public void Index()
    {

      CatService catServices = new CatService(new PeopleRepository());

      // Arrange
      PetController controller = new PetController(catServices);

      // Act
      ViewResult result = controller.Index() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    
  }
}
