using System;

namespace PetSync.Models
{
  public class Event
  {
    public string id { get; set; } = Guid.NewGuid().ToString();
    public string name { get; set; }
    public DateTime timestamp {get; set; } = DateTime.UtcNow;
  }
}