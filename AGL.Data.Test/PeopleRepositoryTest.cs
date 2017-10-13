using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Data.Test
{
  [TestClass()]
  public class PeopleRepositoryTest
  {
    [TestMethod]
    public void GetPeopleListTest()
    {

      var repo = new PeopleRepository();

      var peopleList = repo.GetPeopleList();

      Assert.IsTrue(peopleList.ToList().Count > 0);


    }

  }
}
