using System;
using System.Collections.Generic;
using System.Text;
using Company.Function;

namespace Company.Function
{
  class TestRecords
  {
    public void createRecordsForOneDay()
    {
      var eric = new User("Eric");
      var brett = new User("Brett");
      var andrea = new User("AnDrea");
      var cassidy = new HouseHold("Cassidy", new List<User>() { eric, brett, andrea });
      var mira = cassidy.addPet("Mira", 3, 1, "Cup");
      var zoe = cassidy.addPet("Zoe", 3, 1, "Cup");
      var maya = cassidy.addPet("Maya", 2, 1, "Cup");
      var mylo = cassidy.addPet("Mylo", 2, 1, "Cup");
      var oliver = cassidy.addPet("Oliver", 2, 3, "Nuggets");
      var fish = cassidy.addPet("Fish", 2, 1, "Pinch");

      // FULL DAYS FEEDING SCHEDULE
      mira.feed(eric.userId, "M", "Full");
      zoe.feed(eric.userId, "M", "Full");
      fish.feed(eric.userId, "M", "Full");

      oliver.feed(brett.userId, "M", "Full");

      mira.feed(eric.userId, "A", "Half");
      zoe.feed(eric.userId, "A", "Full");
      maya.feed(eric.userId, "A", "Full");
      mylo.feed(eric.userId, "A", "Full");

      mira.feed(andrea.userId, "E", "Full");
      zoe.feed(andrea.userId, "E", "Full");
      maya.feed(andrea.userId, "E", "Full");
      mylo.feed(andrea.userId, "E", "Full");
      fish.feed(eric.userId, "E", "Full");
      oliver.feed(eric.userId, "E", "Full");
    }
  }
}
