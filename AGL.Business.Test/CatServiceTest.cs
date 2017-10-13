using AGL.Business;
using AGL.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Business.Test
{
  [TestClass()]
  public  class CatServiceTest
  {

    [TestMethod]
    public  void GetCatsByMaleOwner()
    {
      // Arrange
      CatService catBusiness = new CatService(new PeopleRepository());
      Dictionary<Gender, IEnumerable<Pet>> result =  catBusiness.GetCatsByOwnerGender();

      // Assert
      Assert.IsNotNull(result);
      Assert.IsNotNull(result[Gender.Male]);
      Assert.AreEqual("Garfield", result[Gender.Male].ToList()[0].name);
    }

    [TestMethod]
    public void GetCatsByFeMaleOwner()
    {
      // Arrange
      CatService catBusiness = new CatService(new PeopleRepository());
      Dictionary<Gender, IEnumerable<Pet>> result =  catBusiness.GetCatsByOwnerGender();

      // Assert
      Assert.IsNotNull(result);
      Assert.IsNotNull(result[Gender.Female]);
      Assert.AreEqual("Garfield", result[Gender.Female].ToList()[0].name);
    }

  }
}
