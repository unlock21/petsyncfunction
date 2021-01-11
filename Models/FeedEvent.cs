using System;

namespace PetSync.Models
{
  public class FeedEvent : Event
  {
    new public string name { get; set; } = "Feed";
    public decimal amount { get; set; }
    public string um { get; set; }
  }
}