using AGL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Data
{
 public interface IPeopleRepository
  {
    List<People> GetPeopleList();
    //List<PetListData> GetCatList();
  }
}
