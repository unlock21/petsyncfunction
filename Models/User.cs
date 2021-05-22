using System;

namespace PetSync.Models
{
  public class User
  {
    public Guid id { get; set; } = Guid.NewGuid();
    public string name { get; set; }
  }
}