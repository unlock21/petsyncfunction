using System;
using System.Collections.Generic;
using System.Text;
using Company.Function;

namespace Company.Function
{
  class Pet
  {
    public Pet(string name, int maxNumFeedingsPerDay, int maxAmountPerFeeding, string feedingUM)
    {
      this.name = name;
      this.maxNumFeedingsPerDay = maxNumFeedingsPerDay;
      this.maxAmountPerFeeding = maxAmountPerFeeding;
      this.feedingUM = feedingUM;
      this.petId = Guid.NewGuid().ToString();
    }
    public string name { get; set; } // Mira / Zoe / Maya / Myl
    public string petId { get; set; } // GUID
    public List<FeedEvent> today { get; set; }
    public List<FeedEvent> thisWeek { get; set; }
    public int maxNumFeedingsPerDay { get; set; } // 2 / 3
    public int maxAmountPerFeeding { get; set; } // 1 / 2 / 3
    public string feedingUM { get; set; } // Cup / Nugget / Pinch
    public DateTime lastEvent { get; set; }
    public void feed(string userId, string type, string amount)
    {
      today.Add(new FeedEvent(this.petId, userId, type, amount));
      lastEvent = DateTime.Now;
    }
  }
}
