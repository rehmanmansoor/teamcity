﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGL.Data
{
  

  public class People
  {
    public string name { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public List<Pet> pets { get; set; }
  }

  
}