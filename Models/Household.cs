using System;
using System.Collections.Generic;

namespace PetSync.Models
{
  public class Household
  {
    public string id { get; set; } = Guid.NewGuid().ToString();
    public string name { get; set; }
    public List<User> users { get; set; } = new List<User>();
    public List<Pet> pets { get; set; } = new List<Pet>();
  }
}