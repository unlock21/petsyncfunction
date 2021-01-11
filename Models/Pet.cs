using System;
using System.Collections.Generic;

namespace PetSync.Models
{
  public class Pet
  {
    public string id { get; set; } = Guid.NewGuid().ToString();
    public string name { get; set; }
    public List<Event> events = new List<Event>();
  }
}