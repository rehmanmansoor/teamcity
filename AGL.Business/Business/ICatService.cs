using AGL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGL.Data;

namespace AGL.Business
{
 public interface ICatService
  {
    Dictionary<Gender, IEnumerable<Pet>> GetCatsByOwnerGender();

  }
}
