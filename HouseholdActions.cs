using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using PetSync.Models;

namespace PetSync.Actions
{
  public static class HouseholdActions
  {
    private static Household household =
      new Household() {
        name = "Cassidy",
        users = new List<User> {
          new User() {
            name = "Brett"
          },
          new User() {
            name = "AnDrea"
          },
          new User() {
            name = "Eric"
          }
        },
        pets = new List<Pet> {
          new Pet() {
            name = "Mira"
          },
          new Pet() {
            name = "Zoe"
          },
          new Pet() {
            name = "Maya"
          },
          new Pet() {
            name = "Mylo"
          },
          new Pet() {
            name = "Oliver"
          },
          new Pet() {
            name = "Fish"
          }
        }
    };

    [FunctionName("FeedPet")]
    public static IActionResult FeedPet(
      [HttpTrigger(AuthorizationLevel.Function, "post", Route = "feed/{pet_id}")]HttpRequest req, ILogger log, string pet_id)
    {
      var feedEvent = new FeedEvent() {
        amount = 1,
        um = "cup"
      };
      if (household.pets.Count > 0)
      {
        var pet = household.pets.FirstOrDefault(x => x.id == Guid.Parse(pet_id));
        if (pet != null)
        {
          pet.events.Add(feedEvent);
        }
        else
        {
          return new NotFoundObjectResult("No pet with id = " + pet_id + " found!");
        }
      }
      return new OkObjectResult(feedEvent);
    }

    [FunctionName("GivePetSupplement")]
    public static IActionResult GivePetSupplement(
      [HttpTrigger(AuthorizationLevel.Function, "post", Route = "supplement/{pet_id}")]HttpRequest req, ILogger log, string pet_id)
    {
      var supplementEvent = new FeedEvent() {
        name = "Supplement",
        amount = 1,
        um = ""
      };
      if (household.pets.Count > 0)
      {
        var pet = household.pets.FirstOrDefault(x => x.id == Guid.Parse(pet_id));
        if (pet != null) {
          pet.events.Add(supplementEvent);
        }
        else
        {
          return new NotFoundObjectResult("No pet with id = " + pet_id + " found!");
        }
      }
      return new OkObjectResult(supplementEvent);
    }

    [FunctionName("GetHousehold")]
    public static IActionResult GetHousehold(
      [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]HttpRequest req, ILogger log)
    {
      return new OkObjectResult(household);
    }

    public static void ClearEvents()
    {
      foreach (Pet pet in household.pets)
      {
        pet.events = new List<Event>();
      }
    }
  }
}