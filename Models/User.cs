using System;

namespace PetSync.Models
{
  public class User
  {
    public string id { get; set; } = Guid.NewGuid().ToString();
    public string name { get; set; }
  }
}