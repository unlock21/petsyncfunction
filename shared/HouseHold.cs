using System;
using System.Collections.Generic;
using System.Text;
using Company.Function;

namespace Company.Function
{
  class HouseHold
  {
    public HouseHold(string name, List<User> users)
    {
      this.name = name;
      this.users = users;
      this.householdId = Guid.NewGuid().ToString();
    }
    public string name { get; set; } // Cassidy
    public string householdId { get; set; } // GUID
    public List<Pet> pets { get; set; }
    public List<User> users { get; set; }
    public Pet addPet(string name, int maxNumFeedingsPerDay, int maxAmountPerFeeding, string feedingUM)
    {
      var pet = new Pet(name, maxNumFeedingsPerDay, maxAmountPerFeeding, feedingUM);
      pets.Add(pet);
      return pet;
    }
    public void removePet(string petId)
    {
      // pets.Remove(petId);
    }
    public void addUser(string name)
    {
      users.Add(new User(name));
    }
    public void removeUser(string userId)
    {
      // users.Remove(userId);
    }
  }
}
