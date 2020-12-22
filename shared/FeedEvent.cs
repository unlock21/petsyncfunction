using System;
using System.Collections.Generic;
using System.Text;
using Company.Function;

namespace Company.Function
{
  class FeedEvent
  {
    public FeedEvent(string petId, string userId, string type, string amount)
    {
      this.petId = petId;
      this.userId = userId;
      this.type = type;
      this.amount = amount;
      this.eventId = Guid.NewGuid().ToString();
      this.timestamp = DateTime.Now;
    }
    public string petId { get; set; }
    public string userId { get; set; }
    public string eventId { get; set; }
    public string type { get; set; }
    public string amount { get; set; } // Quaurter / Half / Three-Quaurter / Full
    public DateTime timestamp { get; set; }
  }
}
