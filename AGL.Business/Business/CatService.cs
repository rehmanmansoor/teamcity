using AGL.Business;
using AGL.Data;
using AGL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Business
{
 public class CatService : ICatService
  {
    public IPeopleRepository _peopleRepository { get; set; }

    public CatService(IPeopleRepository peopleRepository)
    {
      this._peopleRepository = peopleRepository;
    }


    public Dictionary<Gender, IEnumerable<Pet>> GetCatsByOwnerGender()
    {
      Dictionary<Gender, IEnumerable<Pet>> catByGender = new Dictionary<Gender, IEnumerable<Pet>>();
      IEnumerable<People> Persons =  this._peopleRepository.GetPeopleList();

      catByGender.Add(Gender.Male, GetCatList(Persons, Gender.Male));
      catByGender.Add(Gender.Female, GetCatList(Persons, Gender.Female));

      return catByGender;

    }

    private List<Pet> GetCatList(IEnumerable<People> persons, Gender gender)
    {
      List<People> list = null;

      list = _peopleRepository.GetPeopleList();

      return (from people in list
              where people.gender==gender.ToString() && people.pets != null 
              from pet in people.pets
              where pet.type == "Cat"
              orderby pet.name
              select pet).ToList();



    }

  }

  public enum Gender
  {
    Male,
    Female
  }
}
