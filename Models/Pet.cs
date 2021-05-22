using System;
using System.Collections.Generic;

namespace PetSync.Models
{
  public class Pet
  {
    public Guid id { get; set; } = Guid.NewGuid();
    public string name { get; set; }
    public List<Event> events = new List<Event>();
  }
}