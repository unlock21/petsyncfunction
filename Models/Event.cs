using System;

namespace PetSync.Models
{
  public class Event
  {
    public Guid id { get; set; } = Guid.NewGuid();
    public string name { get; set; }
    public DateTime timestamp {get; set; } = DateTime.UtcNow;
  }
}